using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTable.CardPicker.Local.Models
{
    public class SbModel : SlotModel
    {
				public SbModel(int seatNumber) : base (seatNumber) { }

				internal SlotModel DataGen()
        {
            Name = "SB";
            return this;
        }
    }
}
