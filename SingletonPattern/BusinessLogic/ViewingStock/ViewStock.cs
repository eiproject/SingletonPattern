using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using StoreStock.Models;
using StoreStock.BusinessLogic;

namespace StoreStock.BusinessLogic {
  class ViewStock {
    protected List<Stock> fetchedStock;
    public object FetchedStock { get { return fetchedStock; } }
  }
}
