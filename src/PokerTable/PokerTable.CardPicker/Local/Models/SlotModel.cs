using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTable.CardPicker.Local.Models
{
    public class SlotModel
    {
        public string Name { get; set; }
        public bool IsSlot => !(this.GetType().Name == "SlotModel");
        public int SeatNumber { get; set; }
				public SlotModel(int seatNumber)
				{
						this.SeatNumber = seatNumber;
				}

				internal SlotModel DataGen()
        {
            Name = "Empty";
            return this;
        }
    }
}
