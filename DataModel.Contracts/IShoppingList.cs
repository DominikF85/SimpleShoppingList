using System;
using System.Collections.Generic;

namespace DF.ShoppingList.DataModel.Contracts
{
    public interface IShoppingList
    {
        string Name { get; }

        DateTime ScheduledDate { get; }

        IStore Store { get; }

        ICollection<IShoppingItem> Items { get; }
    }
}