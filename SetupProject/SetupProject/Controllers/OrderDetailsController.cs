using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SetupProject.DAL;
using SetupProject.Models;

namespace SetupProject.Controllers
{
    public class OrderDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public OrderDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: OrderDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrderDetails.ToListAsync());
        }

        // GET: OrderDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = await _context.OrderDetails
                .FirstOrDefaultAsync(m => m.OrderDetailID == id);
            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // GET: OrderDetails/Create
        public IActionResult Create(int id)
        {
           
            return View();
        }

        // POST: OrderDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderDetailID,BookQuantity,BookPrice,SumPrice")] OrderDetail orderDetail, int SelectedBook)
        {

            //Need to make this selectedbook in the view
            //Find the book associated with this order
            Book dbBook = _context.Books.Find(SelectedBook);

            orderDetail.Book = dbBook;

            _context.Add(orderDetail);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Orders", new { id = orderDetail.Order.OrderID });
        }

        // GET: OrderDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = _context.OrderDetails
                                        .Include(c => c.Book)
                                        .FirstOrDefault(c => c.OrderDetailID == id);
            if (orderDetail == null)
            {
                return NotFound();
            }
            return View(orderDetail);
        }

        // POST: OrderDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderDetailID,BookQuantity,BookPrice,SumPrice")] OrderDetail orderDetail)
        {
            if (id != orderDetail.OrderDetailID)
            {
                return NotFound();
            }

            OrderDetail DbOrdDet = _context.OrderDetails
                                            .Include(r => r.Book)
                                            .Include(r => r.Order)
                                            .FirstOrDefault(r => r.OrderDetailID == orderDetail.OrderDetailID);

            ShippingCosts currentShipCosts = _context.ShippingCosts.FirstOrDefault();


            if (ModelState.IsValid)
            {
                try
                {
                    //if the quantity the user orders is higher than the inventory
                    if (orderDetail.BookQuantity > DbOrdDet.Book.Inventory)
                    {
                        //figure out how to return an error message
                        ViewBag.QuantityError = "The quantity you entered exceeds our stock.";
                        orderDetail.BookPrice = DbOrdDet.BookPrice;
                        return View(orderDetail);
                    }
                    else 
                    {
                        //fix shipping costs for the order
                        Order order = _context.Orders.Include(c => c.OrderDetails).ThenInclude(c => c.Book).FirstOrDefault(c => c.OrderID == DbOrdDet.Order.OrderID);

                        int orderDetailCount = order.OrderDetails.Count();

                        //check if there's another book in the order already
                        if (orderDetailCount > 1) 
                        {
                            //if there is already other book(s) in the order
                            decimal oldShippingCost = order.ShippingCost;

                            //decimal additionalShippingCost = oldShippingCost - (DbOrdDet.Quantity * 1.50m);
                            decimal additionalShippingCost = oldShippingCost - (DbOrdDet.BookQuantity * currentShipCosts.AddBookShipCost);
                            //use the old quantity and subtract that old cost


                            //order.ShippingCost = orderDetail.Quantity * 1.50m + additionalShippingCost;
                            order.ShippingCost = orderDetail.BookQuantity * currentShipCosts.AddBookShipCost + additionalShippingCost;
                        }
                        else
                        {
                            //if this is the only book in the order
                            //order.ShippingCost = 3.50m + ((orderDetail.Quantity - 1) * 1.50m);
                            order.ShippingCost = currentShipCosts.FirstBookShipCost + ((orderDetail.BookQuantity - 1) * currentShipCosts.AddBookShipCost);
                        }
                    
                        DbOrdDet.BookQuantity = orderDetail.BookQuantity;
                        DbOrdDet.BookPrice = DbOrdDet.BookPrice; //price should not change
                        _context.OrderDetails.Update(DbOrdDet);
                     
                        _context.SaveChanges();
                    }

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderDetailExists(orderDetail.OrderDetailID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Cart", "Orders");
            }
            return View(DbOrdDet);
        }

        // GET: OrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = await _context.OrderDetails
                .FirstOrDefaultAsync(m => m.OrderDetailID == id);
            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // POST: OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderDetail = await _context.OrderDetails.FindAsync(id);

            OrderDetail od = _context.OrderDetails
                                     .Include(c => c.Order)
                                     .FirstOrDefault(c => c.OrderDetailID == id);

            Order order = _context.Orders
                                  .Include(c => c.OrderDetails)
                                  .ThenInclude(c => c.Book)
                                  .FirstOrDefault(c => c.OrderID == od.Order.OrderID);


            ShippingCosts currentShipCosts = _context.ShippingCosts.FirstOrDefault();

            int orderDetailCount = order.OrderDetails.Count();

    
            if (orderDetailCount > 1) 
            {
                decimal oldShippingCost = order.ShippingCost;

                decimal leftoverShippingCost = oldShippingCost - (od.BookQuantity * currentShipCosts.AddBookShipCost);
               
                order.ShippingCost = leftoverShippingCost;
            }
            else
            {
                //if this is the only book in the order
                order.ShippingCost = 0m; //3.50m + ((orderDetail.Quantity - 1) * 1.50m);
            }


            //remove orderDetail from the database and save
            _context.OrderDetails.Remove(orderDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction("Cart", "Orders");
        }


        private bool OrderDetailExists(int id)
        {
            return _context.OrderDetails.Any(e => e.OrderDetailID == id);
        }
    }
}
