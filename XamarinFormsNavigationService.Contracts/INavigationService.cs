using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DF.XamarinFormsNavigationService.Contracts
{
  public interface INavigationService
  {
    INavigation Navigation { get; }

    Task NavigateTo(Type viewModelType, bool modal);

    Page GetPage(Type viewModelType);

    void Init(INavigation navigation, IDictionary<Type, Page> viewModelMapping);
  }
}