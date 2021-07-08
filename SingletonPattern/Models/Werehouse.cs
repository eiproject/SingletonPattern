using System;
using System.Collections.Generic;
using System.Text;

namespace StoreStock.Models {
  public class Werehouse {
    private static Werehouse _store;
    private List<Stock> _werehouseData;
    private Werehouse() {
      _werehouseData = new List<Stock>();
    }

    internal bool IsRunning = true;
    public List<Stock> WerehouseData { get { return _werehouseData; } }
    public static Werehouse getDatabase() {
      if (_store == null) {
        _store = new Werehouse();
      }
      return _store;
    }
  }
}
