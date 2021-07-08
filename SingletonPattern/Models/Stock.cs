using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreStock.BusinessLogic;

namespace StoreStock.Models {
  class Stock : Werehouse {
    const decimal maxDiscount = 0.3m; // max discount
    const decimal maxDiscountStock = 1000m; // max stock that get discount

    // internal static data
    /*internal static int countID;*/
    /*internal static List<Stock> allStock = new List<Stock>();*/

    // internal data
    internal int id;
    internal string title;
    internal int quantity;
    internal decimal price;
    internal string type;
    internal decimal discount {
      get {
        int _counter = quantity;
        decimal percentage;
        percentage = Math.Min(decimal.Multiply(maxDiscount, _counter / maxDiscountStock), maxDiscount);
        return decimal.Multiply(percentage, price);
      }
    }

    // All public data
    public int ID { get { return id; } }
    public string Type { get { return type; } }
    public int Quantity { get { return quantity; } }
    public decimal Discount { get { return discount; } }
    public decimal Price {
      get {
        return price - discount;
      }
    }
    public string Title { get { return title; } }
    
    internal Stock() {
    }
  }
}
