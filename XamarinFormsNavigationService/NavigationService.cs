using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DF.XamarinFormsNavigationService.Contracts;
using Xamarin.Forms;

namespace DF.XamarinFormsNavigationService
{
  public class NavigationService : INavigationService
  {
    private IDictionary<Type, Page> _viewModelMapping;

    #region Implementation of IViewModelNavigationHandler

    public void Init(INavigation navigation, IDictionary<Type, Page> viewModelMapping)
    {
      Navigation = navigation;
      _viewModelMapping = viewModelMapping;
    }

    public INavigation Navigation { get; private set; }

    public async Task NavigateTo(Type viewModelType, bool modal)
    {
      if (modal)
      {
        await Navigation.PushModalAsync(GetPage(viewModelType));
      }
      else
      {
        await Navigation.PushAsync(GetPage(viewModelType));
      }
    }

    public Page GetPage(Type viewModelType)
    {
      return _viewModelMapping[viewModelType];
    }

    #endregion
  }
}
