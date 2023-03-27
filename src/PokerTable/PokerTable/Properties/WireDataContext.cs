using Jamesnet.Wpf.Global.Location;
using PokerTable.CardPicker.Local.ViewModels;
using PokerTable.CardPicker.UI.Views;
using PokerTable.Forms.Local.ViewModels;
using PokerTable.Forms.UI.Views;

namespace PokerTable.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<PokerWindow, PokerViewModel>();
            items.Register<MainContent, MainContentViewModel>();
            items.Register<CardContent, CardContentViewModel>();
        }
    }
}
