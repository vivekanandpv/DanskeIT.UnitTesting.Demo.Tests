using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DanskeIT.UnitTesting.Demo.Controllers;
using DanskeIT.UnitTesting.Demo.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace DanskeIT.UnitTesting.Demo.Tests
{
    public class CustomersControllerShould
    {
        [Test]
        public void ReturnListOfCustomers()
        {
            //  arrange
            var controller = new CustomersController();

            //  act
            var result = controller.Get();
            var customers = result.Result;

            Assert.NotNull(customers);
        }

        
        [Test]
        public void ReturnCustomerById()
        {
            //  arrange
            var controller = new CustomersController();

            //  act
            var result = controller.Get(123);
            var customer = result.Result;

            Assert.NotNull(customer);
        }

        [Test]
        public void CreateCustomer()
        {
            //  arrange
            var controller = new CustomersController();

            //  act
            var customer = new Customer();
            var result = controller.Create(customer) as OkObjectResult;
            

            Assert.NotNull(result);
        }

        [Test]
        public void UpdateCustomer()
        {
            //  arrange
            var controller = new CustomersController();

            //  act
            var customer = new Customer();
            var result = controller.Update(customer, 123) as OkObjectResult;
            

            Assert.NotNull(result);
        }

        [Test]
        public void SuccessfullyDeleteCustomerWithIdLessThan100()
        {
            //  arrange
            var controller = new CustomersController();

            //  act
            var result = controller.Delete(98) as OkObjectResult;
            

            Assert.NotNull(result);
        }

        [Test]
        public void PreventDeletionOfCustomerWithIdGreaterThanOrEqualTo100()
        {
            //  arrange
            var controller = new CustomersController();

            //  act
            var result = controller.Delete(123) as NotFoundResult;
            

            Assert.NotNull(result);
        }
    }
}
