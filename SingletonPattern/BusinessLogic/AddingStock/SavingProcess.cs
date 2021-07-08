using System;
using System.Collections.Generic;
using System.Text;
using StoreStock.Models;
using StoreStock.BusinessLogic;

namespace StoreStock.BusinessLogic {
  class SavingProcess {
    int currentID;
    internal List<Stock> currentStocks;
    Werehouse store;
    internal SavingProcess(Werehouse theStore) {
      currentStocks = theStore.WerehouseData;

      if (currentStocks.Count != 0) {
        currentID = theStore.WerehouseData[currentStocks.Count - 1].ID + 1;
      }
      else {
        currentID = 0;
      }

      store = theStore;
    }
    internal void SaveData(
      string type, int quantity, decimal price,
      string title, string genre_or_brand, string size) {
      if (type.ToLower() == "book") {
        Book newBook = new Book {
          genre = genre_or_brand,
          paperSize = size
        };
        newBook.SetGenericData(currentID, title, quantity, price, type);

        Stock newStock = newBook;

        Repository repo = new Repository(store);
        repo.AddMoreStock(newStock);
      }
      else if (type.ToLower() == "pencil") {
        Pencil newPensil = new Pencil {
          brand = genre_or_brand,
          pencilSize = size
        };
        newPensil.SetGenericData(currentID, title, quantity, price, type);


        Stock newStock = newPensil;

        Repository repo = new Repository(store);
        repo.AddMoreStock(newStock);
      }
      else {
        Console.WriteLine("Failed to save data.");
      }
    }

    internal void SaveData(
      string type, int quantity, decimal price,
      string title, string brand, string inkColor, string linesize) {
      Pen newPen = new Pen {
        brand = brand,
        inkColor = inkColor,
        lineSize = linesize
      };
      newPen.SetGenericData(currentID, title, quantity, price, type);

      Stock newStock = newPen;
      Repository repo = new Repository(store);
      repo.AddMoreStock(newStock);
    }
  }

}
