using PokerTable.Settings;
using System;

namespace PokerTable
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App()
                .AddWireDataContext<WireDataContext>()
                .Run();
        }
    }
}
