using System.Linq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace OrderDesign.Test
{
    [TestClass]
    public class CheckoutChoicesTest
    {
        
        //Validation des achats avec choix du traitement;
        [TestMethod]
        public void StrategyShippingBookValid()
        {
            //arrange
            var client = new Client();
            var purchase = new Purchase();
            var book = new Book("wow", 10);

            purchase.Products.Add(book);
            client.Purchase = purchase;

            var checkout = new Checkout(client);

            checkout.CheckoutType = CheckoutType.Shipping;

            var checkoutStrategy = new CheckoutStrategy();

            var checkoutHandler = checkoutStrategy.GetHandler(checkout);
            
            //act
            var result = checkoutHandler.ValidatePurchase(checkout);

            //assert
            Assert.AreEqual("valid", result.Message);

        }

        [TestMethod]
        public void StrategyCashRegisterWhithAlcohol()
        {
            //arrange
            var client = new Client();
            var purchase = new Purchase();
            var vodka = new Vodka("alcohol", 600);

            purchase.Products.Add(vodka);
            client.Purchase = purchase;

            var checkout = new Checkout(client);

            checkout.CheckoutType = CheckoutType.CashRegister;

            var checkoutStrategy = new CheckoutStrategy();

            var checkoutHandler = checkoutStrategy.GetHandler(checkout);
            
            //act
            var result = checkoutHandler.ValidatePurchase(checkout);

            //assert
            Assert.AreEqual("has alcohol", result.Message);

        }
    }

    public interface ICheckoutHandler {
        Handler GetHandler(Checkout checkout);
    }

    public class CheckoutStrategy: ICheckoutHandler {
        public Handler GetHandler(Checkout checkout){
            switch(checkout.CheckoutType){
                case CheckoutType.Shipping:
                    return ShippingHandler(checkout);
                case CheckoutType.CashRegister:
                    return CashRegisterHandler(checkout);
                default:
                    throw new ArgumentException();
            }
        }

        private Handler ShippingHandler(Checkout checkout){
            var checkAmountHandler = new CheckAmountHandler();
            var checkAlcoholHandler = new CheckAlcoholHandler();
            checkAmountHandler.SetSuccessor(checkAlcoholHandler);
            return checkAmountHandler;
        }

        private Handler CashRegisterHandler(Checkout checkout){
             var checkAmountHandler = new CheckAmountHandler();
            var checkAlcoholHandler = new CheckAlcoholHandler();
            checkAlcoholHandler.SetSuccessor(checkAmountHandler); 
            return checkAlcoholHandler;
        }
    }
}
