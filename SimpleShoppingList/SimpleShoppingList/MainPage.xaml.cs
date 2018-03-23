﻿using ShoppingListVM;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DF.ShoppingList
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class MainPage : MasterDetailPage
  {
    public MainPage()
    {
      InitializeComponent();

      BindingContext = new ShoppingListAppMainVM();
    }
  }
}