using PokerTable.CardPicker.Local.Models;
using PokerTable.CardPicker.UI.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTable.CardPicker.Local.Events
{
    public class CardDragEnterArgs
        {
        public SlotModel TargetObject { get; internal set; }
        public SlotModel DroppedObject { get; internal set; }
        public bool Cancel { get; set; }
    }
}
