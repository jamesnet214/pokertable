using Jamesnet.Wpf.Controls;
using PokerTable.Forms.UI.Views;
using System.Windows;

namespace PokerTable
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new MainWindow();
        }
    }
}
