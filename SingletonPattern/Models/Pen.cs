using System;
using System.Collections.Generic;
using System.Text;

namespace StoreStock.Models {
  class Pen : Stock {
    internal string brand;
    internal string inkColor;
    internal string lineSize;
    public string Brand { get { return brand; } }
    public string InkColor { get { return inkColor; } }
    public string LineSize { get { return lineSize; } }
  }
}
