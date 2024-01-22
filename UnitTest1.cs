//Student name: Ma. Criselda Martirez
//Student no. C0881810
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;

namespace PizzaTest
{
    public class UnitTest1
    {
        [Fact]

        public void OrderList()
        {
            var controller = new PizzaController();       
            var order = new PizzaOrder { };

            var result = controller.OrderForm(order) as RedirectToActionResult;

            Assert.NotNull(result);
            Assert.Equal("Index", result.ActionName);
        }

        [Fact]
        public void ErrorOrder()
        {
            var controller = new PizzaController();
            controller.ModelState.AddModelError("CustomerName", "Required");
            var order = new PizzaOrder();

            var result = controller.OrderForm(order) as ViewResult;

            Assert.NotNull(result);
            Assert.Equal("OrderForm", result.ViewName);
        }
    }
}


