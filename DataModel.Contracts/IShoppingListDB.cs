using System.Collections.Generic;

namespace DF.ShoppingList.DataModel.Contracts
{
    public interface IShoppingListDB
    {
        ICollection<IShoppingList> ShoppingLists { get; }
        
        ICollection<IStore> KnownStores { get; }
    }
}