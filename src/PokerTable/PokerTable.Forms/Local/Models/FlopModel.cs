using System;
using System.Reflection.PortableExecutable;

namespace PokerTable.Forms.Local.Models
{
    internal class FlopModel : RoundModel
    {
        internal IRoundData DataGen()
        {
            Header = "Flip";

            return this;
        }
    }
}
