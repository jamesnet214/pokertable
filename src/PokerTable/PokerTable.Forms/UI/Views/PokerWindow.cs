using Jamesnet.Wpf.Controls;
using System.Windows;

namespace PokerTable.Forms.UI.Views
{
    public class PokerWindow : JamesWindow
    {
        static PokerWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PokerWindow), new FrameworkPropertyMetadata(typeof(PokerWindow)));
        }
    }
}
