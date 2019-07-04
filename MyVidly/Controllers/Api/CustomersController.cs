using AutoMapper;
using MyVidly.Dtos;
using MyVidly.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyVidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //GET api/customers
        public IHttpActionResult GetCustomers(string query = null)
        {
            var customersQuery = _context.Customers.Include(c => c.Membership);

            if (!String.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(c => c.Name.Contains(query));

            var customerDtos = customersQuery.ToList().Select(Mapper.Map<Customer, CustomerDto>);

            return Ok(customerDtos);

        }

        //GET api/customers/1  get a single customer
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();
                //throw new HttpResponseException(HttpStatusCode.NotFound);

            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }

        //POST api/customers  create a new customer
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {

            //when we create a resource the status code should be 2 0 1 or create it.
            //So we need more control over the response return from our action and to make this happen instead of
            //returning customer DTO you're going to return an HTTP action result.

            if (!ModelState.IsValid)
                return BadRequest();
            //    throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            //return customerDto;
            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
        }

        //PUT api/customers/1  update a customer
        [HttpPut]
        public void UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(customerDto, customerInDb);

            // you can see the generic parameters are great out because the computer can infer from the objects
            //we have Pastor this method what are the source and target types so we can get rid of that.
            
            //Mapper.Map<CustomerDto, Customer>(customerDto, customerInDb);

            //customerInDb.Name = customerDto.Name;
            //customerInDb.IsSubcribeToNewsletter = customerDto.IsSubcribeToNewsletter;
            //customerInDb.MembershipTypeId = customerDto.MembershipTypeId;
            //customerInDb.Birthdate = customerDto.Birthdate;

            _context.SaveChanges();

        }

        //DELETE api/customers/1
        [HttpDelete]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public void DeleteCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

    }

}
