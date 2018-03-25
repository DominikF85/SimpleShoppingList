using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DF.XamarinFormsNavigationService.Contracts;
using Xamarin.Forms;

namespace DF.XamarinFormsNavigationService
{
  public class NavigationService : INavigationService
  {
    private Dictionary<Type, Page> _viewModelMapping = new Dictionary<Type, Page>();
    private Action _closeSideMenuAction;

    #region Implementation of IViewModelNavigationHandler

    public void Init(INavigation navigation, Action closeSideMenuAction)
    {
      Navigation = navigation;
      _closeSideMenuAction = closeSideMenuAction;
    }

    public void RegisterMapping(Type viewModelType, Page navigationTarget)
    {
      _viewModelMapping.Add(viewModelType, navigationTarget);
    }

    public INavigation Navigation { get; private set; }

    public async Task NavigateTo(Type viewModelType, bool modal = false, bool closeSideMenu = true)
    {
      if (closeSideMenu)
      {
        _closeSideMenuAction();
      }

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
