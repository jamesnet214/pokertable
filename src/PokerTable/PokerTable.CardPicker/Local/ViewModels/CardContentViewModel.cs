using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using PokerTable.CardPicker.Local.Events;
using PokerTable.CardPicker.Local.Models;
using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace PokerTable.CardPicker.Local.ViewModels
{
    public partial class CardContentViewModel : ObservableBase, IViewLoadable
    {
        [ObservableProperty]
        private List<SlotModel> _slots;

        public CardContentViewModel()
        {
        }

        public void OnLoaded(IViewable smartWindow)
        {
            Slots = GetSlots();
        }

        private List<SlotModel> GetSlots()
        {
            List<SlotModel> source = new();
            source.Add(new DealerModel(1).DataGen());
            source.Add(new SbModel(2).DataGen());
            source.Add(new BbModel(3).DataGen());
            source.Add(new SlotModel(4).DataGen());
            source.Add(new SlotModel(5).DataGen());
            source.Add(new SlotModel(6).DataGen());
            source.Add(new SlotModel(7).DataGen());
            source.Add(new SlotModel(8).DataGen());
            source.Add(new SlotModel(9).DataGen());
            source.Add(new SlotModel(10).DataGen());

            return source;
        }

        [RelayCommand]
        private void DragOverCheck(CardDragOverArgs args)
        {
            if (args.TargetObject.Name == "SB" && args.DroppedObject.Name == "BB")
            {
                args.Cancel = true;
            }
        }
    }
}
