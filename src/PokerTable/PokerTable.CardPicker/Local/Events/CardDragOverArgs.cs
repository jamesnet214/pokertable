﻿using PokerTable.CardPicker.Local.Models;

namespace PokerTable.CardPicker.Local.Events
{
        public class CardDragOverArgs : CardArgs
        {
                public SlotModel TargetObject { get; internal set; }
                public SlotModel DroppedObject { get; internal set; }
                public bool Cancel { get; set; }
        }
}
