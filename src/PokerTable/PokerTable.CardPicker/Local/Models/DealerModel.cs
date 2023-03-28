using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTable.CardPicker.Local.Models
{
    public class DealerModel : SlotModel
		{
				public DealerModel(int seatNumber) : base (seatNumber) { }
        internal SlotModel DataGen()
        {
            Name = "Dealer";
            return this;    
        }
    }
}
