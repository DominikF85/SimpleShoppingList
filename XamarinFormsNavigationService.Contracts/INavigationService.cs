using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DF.XamarinFormsNavigationService.Contracts
{
  public interface INavigationService
  {
    INavigation Navigation { get; }

    Task NavigateTo(Type viewModelType, bool modal = false, bool closeSideMenu = true);

    Page GetPage(Type viewModelType);

    void Init(INavigation navigation, Action afterNavigateCloseMenuAction);

    void RegisterMapping(Type viewModelType, Page navigationTarget);
  }
}