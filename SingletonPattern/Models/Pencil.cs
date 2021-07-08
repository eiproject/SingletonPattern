using System;
using System.Collections.Generic;
using System.Text;

namespace StoreStock.Models {
  class Pencil : Stock {
    internal string brand;
    internal string pencilSize;
    public string Brand { get { return brand; } }
    public string PencilSize { get { return pencilSize; } }
  }
}
