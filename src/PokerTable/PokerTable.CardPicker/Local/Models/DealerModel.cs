using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTable.CardPicker.Local.Models
{
    public class DealerModel : SlotModel
    {
        internal SlotModel DataGen()
        {
            Name = "Dealer";
            return this;    
        }
    }
}
