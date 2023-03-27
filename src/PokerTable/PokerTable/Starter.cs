using PokerTable.Properties;
using System;

namespace PokerTable
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App()
                .AddInversionModule<ViewModules>()
                .AddWireDataContext<WireDataContext>()
                .Run();
        }
    }
}
