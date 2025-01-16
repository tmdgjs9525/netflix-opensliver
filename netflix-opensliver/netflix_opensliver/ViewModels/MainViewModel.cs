using netflix_opensliver.Core;
using netflix_opensliver.Core.Navigate;
using netflix_opensliver.Names;

namespace netflix_opensliver.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        #region fields
        private readonly INavigationService _navigationService;
        #endregion

        #region properties

        #endregion
        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            _navigationService.NavigateTo(RegionNames.MainRegion,ViewNames.LoginView);
        }

        #region Commands

        #endregion
    }
}
