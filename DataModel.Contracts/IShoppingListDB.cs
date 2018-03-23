using System.Linq;

namespace DF.ShoppingList.DataModel.Contracts
{
  public interface IShoppingListDB
  {
    IQueryable<IShoppingList> ShoppingLists { get; }

    void Load();

    void Save();
  }
}