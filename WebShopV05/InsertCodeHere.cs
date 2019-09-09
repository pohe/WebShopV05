using System;
#pragma warning disable 219

namespace WebShopV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;

            int noOfBooksInOrder = 8;
            int noOfDVDsInOrder = 3;
            int noOfGamesInOrder = 2;

            double netTax = 10;
            double shippingCost = 49;
            double creditCardFee = 2;
            double booksPrice = netPriceBook * noOfBooksInOrder ;
            double dvdPrice = netPriceDVD * noOfDVDsInOrder;
            double gamesPrice = netPriceGame * noOfGamesInOrder;


            double totalPrice = 0.0; // This variable should contain the total price for the order

            totalPrice = ((booksPrice + dvdPrice + gamesPrice) * (netTax + 100) / 100 + shippingCost) *((100 + creditCardFee)/100);
            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");

            // The LAST line of code should be ABOVE this line
        }
    }
}