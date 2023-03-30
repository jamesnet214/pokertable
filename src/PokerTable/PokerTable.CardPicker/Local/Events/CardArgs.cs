using PokerTable.CardPicker.Local.Models;
using System.Windows.Input;

namespace PokerTable.CardPicker.Local.Events
{
        public class CardArgs
        {
                public MouseButtonState mouseButtonState { get; set; }
                public SlotModel DroppedObject { get; internal set; }
        }
}
