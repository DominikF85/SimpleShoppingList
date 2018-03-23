using System;
using System.Collections.Generic;

namespace DF.ShoppingList.DataModel.Contracts
{
    public interface IShoppingList
    {
        string Name { get; }

        DateTime ScheduledDate { get; }

        ICollection<IShoppingItem> Items { get; }
    }
}