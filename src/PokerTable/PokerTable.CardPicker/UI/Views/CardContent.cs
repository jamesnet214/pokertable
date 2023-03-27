using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace PokerTable.CardPicker.UI.Views
{
    public class CardContent : JamesContent
    {
        static CardContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CardContent), new FrameworkPropertyMetadata(typeof(CardContent)));
        }
    }
}
