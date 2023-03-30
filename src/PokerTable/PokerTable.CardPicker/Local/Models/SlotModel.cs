using CommunityToolkit.Mvvm.ComponentModel;

namespace PokerTable.CardPicker.Local.Models
{
        public partial class SlotModel : ObservableObject
        {
                [ObservableProperty]
                private bool isSelected;
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
