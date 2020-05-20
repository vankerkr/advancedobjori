using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQExAss7
{
    class QueryTest
    {
        IList<Item> itemList;

        public QueryTest()
        {
            setSeedVals();
            displayAllOver(8.99);
            Console.ReadLine();
            displayAllUnder(99.99);
            Console.ReadLine();

        }

        public void setSeedVals()
        {
            itemList = new List<Item>()
            {
                new Item() { ProductName="Louisville Slugger", ProductDesc= "Baseball Bat", ProductPrice = 179.99, ProductID = 1 },
                new Item() { ProductName="Nike Glove", ProductDesc= "Baseball Glove", ProductPrice = 59.99, ProductID = 2 },
                new Item() { ProductName="Adidas Glove", ProductDesc= "Baseball Glove", ProductPrice = 49.99, ProductID = 3 },
                new Item() { ProductName="Wilson Baseball 1 Pack", ProductDesc= "Baseball 1ct", ProductPrice = 9.99, ProductID = 4 },
                new Item() { ProductName="Louisville Baseball 1 Pack", ProductDesc= "Baseball 1ct", ProductPrice = 7.99, ProductID = 5 }
            };

        }


        //displays products over a certain price.
        public void displayAllOver(double price)
        {
            var selection = itemList.Where(p => p.ProductPrice > price)
                                    .Select(p => p.ProductName);

            foreach(var name in selection)
            {
                Console.WriteLine(name);
            }
        }

        //displays products under a certain price
        public void displayAllUnder(double price)
        {
            var selection = itemList.Where(p => p.ProductPrice < price)
                                    .Select(p => p.ProductName);

            foreach (var name in selection)
            {
                Console.WriteLine(name);
            }
        }


    }
}
