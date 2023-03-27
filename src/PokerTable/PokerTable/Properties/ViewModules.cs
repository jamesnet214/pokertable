using Jamesnet.Wpf.Controls;
using PokerTable.CardPicker.UI.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace PokerTable.Properties
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, CardContent>("CardContent");
        }
    }
}
