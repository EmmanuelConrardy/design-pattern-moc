using System.Linq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace OrderDesign.Test
{
    [TestClass]
    public class CheckoutValidationTest
    {
        //Validation des achats
        [TestMethod]
        public void checkAmountHandlerTest_should_valid()
        {
            //arrange
            var client = new Client();
            var purchase = new Purchase();
            var book = new Book("wow", 10);

            purchase.Products.Add(book);
            client.Purchase = purchase;

            var checkout = new Checkout(client);
            var checkAmountHandler = new CheckAmountHandler();
            //act
            var result = checkAmountHandler.ValidatePurchase(checkout);

            //assert
            Assert.AreEqual("valid", result.Message);

        }

        [TestMethod]
        public void checkAmountHandlerTest_shoul_failed_if_alcohol()
        {
            //arrange
            var client = new Client();
            var purchase = new Purchase();
            var vodka = new Vodka("alcohol", 600);

            purchase.Products.Add(vodka);
            client.Purchase = purchase;

            var checkout = new Checkout(client);
            var checkAmountHandler = new CheckAmountHandler();
            var checkAlcoholHandler = new CheckAlcoholHandler();

            checkAmountHandler.SetSuccessor(checkAlcoholHandler);

            //act
            var result = checkAmountHandler.ValidatePurchase(checkout);

            //assert
            Assert.AreEqual("has alcohol", result.Message);

        }
    }

    public class Client {
        public Purchase Purchase{get; set;}

    }

    public abstract class Product {
        public string Name {get; set;}
        public int Cost { get; set; } 

        public Product(string name, int cost) {
            Name = name;
            Cost = cost;
        }
    }

    public class Purchase {
        public List<Product> Products{get; set;}

        public Purchase() {
            Products = new List<Product>();
        }
    }

    public class Book: Product {
        public Book(string name, int cost): base(name, cost) {}
    }

    public class Vodka: Product {
        public Vodka(string name, int cost): base(name, cost) {}
    }

    public class Checkout {
        public Client Client { get; private set; }
        public CheckoutType CheckoutType {get; set;}
        public Checkout(Client client) {
            Client = client;
        }
    }

    public interface Handler {
       Validation ValidatePurchase(Checkout checkout);
    }

    public class CheckAmountHandler: CheckHandler {
        public override Validation ValidatePurchase(Checkout checkout) {
            int amount = checkout.Client.Purchase.Products.Sum(p => p.Cost);
            
            if (amount < 500) {
                return new Validation("valid");
            }else{
                return base.ValidatePurchase(checkout);
            }
        }
    }

    public class CheckAlcoholHandler: CheckHandler {
        public CheckAlcoholHandler() {
        }

        public override Validation ValidatePurchase(Checkout checkout) {
            var hasAlcohol = checkout.Client.Purchase.Products.Any(p => p.Name == "alcohol");
            
            if (hasAlcohol) {
                return new Validation("has alcohol");
            }else{
                return base.ValidatePurchase(checkout);
            }
        }
    }

    public abstract class CheckHandler: Handler {
        private Handler _successor;
        public void SetSuccessor(Handler successor) {
            _successor = successor;
        }
        public virtual Validation ValidatePurchase(Checkout checkout) {
            if (_successor == null) {
                return new Validation("no treatment");
            }
            return _successor.ValidatePurchase(checkout);
        }
    }

    public class Validation {
        public string Message {get; set;}

        public Validation(string message) {
            Message = message;
        }
    }
}
