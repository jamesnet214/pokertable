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
            source.Add(new DealerModel().DataGen());
            source.Add(new SbModel().DataGen());
            source.Add(new BbModel().DataGen());
            source.Add(new SlotModel().DataGen());
            source.Add(new SlotModel().DataGen());
            source.Add(new SlotModel().DataGen());
            source.Add(new SlotModel().DataGen());
            source.Add(new SlotModel().DataGen());
            source.Add(new SlotModel().DataGen());
            source.Add(new SlotModel().DataGen());

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
