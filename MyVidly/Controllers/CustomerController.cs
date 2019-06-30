using MyVidly.Models;
using MyVidly.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyVidly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult Index()
        {
            var movieList = _context.Customers.Include(c => c.Membership);
            return View(movieList);
        }

        public ActionResult New()
        {
            var newCustomerViewModel = new CustomerMembershipViewModel()
            {
                Customer = new Customer(),
                MembershipTypes = _context.MembershipTypes
            };
            return View("CustomerForm", newCustomerViewModel);
        }

        public ActionResult Edit(int id)
        {
            if (id == 0)
                return HttpNotFound();

            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            var viewModel = new CustomerMembershipViewModel()
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes
            };

            return View("CustomerForm", viewModel);
        }
        public ActionResult AddAndUpdate(Customer customer)
        {
            //if (!ModelState.IsValid)
            //{
            //    var viewModel = new CustomerMembershipViewModel()
            //    {
            //        Customer = customer,
            //        MembershipTypes = _context.MembershipTypes
            //    };
            //    return View("CustomerForm", viewModel);
            //}

            if (customer.Id == 0)
            {
                //customer.Id = _context.Customers.Count() + 1;

                //Console.WriteLine(customer);

                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.IsSubcribeToNewsletter = customer.IsSubcribeToNewsletter;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
            }

            try
            {
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return RedirectToAction("Index", "Customer");
        }
    }
}