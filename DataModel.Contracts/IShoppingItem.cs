namespace DF.ShoppingList.DataModel.Contracts
{
  public interface IShoppingItem
  {
    string ItemName { get; set; }

    bool IsPurchased { get; set; }
  }
}
