using AutoMapper;
using MyVidly.Dtos;
using MyVidly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyVidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        //POST api/newrentals
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalsDto newRentalsDto)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRentalsDto.CustomerId);
            if (customer == null)
                return BadRequest("Invalid Customer Id.");

            //Tolist() changes movies from IQueryable to List
            var moviesInDb = _context.Movies.Where(m => newRentalsDto.MovieIds.Contains(m.Id)).ToList();

            foreach (var m in moviesInDb)
            {
                if (m.AvailableNumber <= 0)
                    return BadRequest("Movie is not available in the stock");
                m.AvailableNumber--;

                var rental = new Rental()
                {
                    Customer = customer,
                    Movies = m,
                    RentDate = DateTime.Now
                };

                _context.Rentals.Add(rental);

            }

            try { _context.SaveChanges(); }
            catch (Exception e) { Console.WriteLine(e); }

            return Ok();

        }
    }
}
