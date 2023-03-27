using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;

namespace PokerTable.Forms.Local.ViewModels
{
    public partial class PokerViewModel : ObservableBase, IViewLoadable
    {
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;

        public PokerViewModel(IContainerProvider containerProvider, IRegionManager regionManager) 
        {
            _containerProvider = containerProvider;
            _regionManager = regionManager;
        }

        public void OnLoaded(IViewable smartWindow)
        {
            IViewable cardContent = _containerProvider.Resolve<IViewable>("CardContent");
            IRegion mainRegion = _regionManager.Regions["MainRegion"];
            
            if (!mainRegion.Views.Contains(cardContent))
            {
                mainRegion.Add(cardContent);    
            }
            mainRegion.Activate(cardContent);
        }
    }
}
