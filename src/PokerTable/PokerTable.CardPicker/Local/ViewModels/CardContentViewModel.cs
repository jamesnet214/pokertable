using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using PokerTable.CardPicker.Local.Events;
using PokerTable.CardPicker.Local.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Documents;

namespace PokerTable.CardPicker.Local.ViewModels
{
        public partial class CardContentViewModel : ObservableBase, IViewLoadable
        {
                [ObservableProperty]
                private ObservableCollection<SlotModel> _slots;

                public CardContentViewModel()
                {
                }

                public void OnLoaded(IViewable smartWindow)
                {
                        Slots = GetSlots();
                }

                private ObservableCollection<SlotModel> GetSlots()
                {
                        ObservableCollection<SlotModel> source = new();
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
                        if (args.DroppedObject == null) return;

                        if(args.DroppedObject.Name == "BB")
                        {
                                if (args.TargetObject.Name == "SB" || args.TargetObject.Name == "Dealer")
                                        args.Cancel = true;
                        }
                        else if (args.DroppedObject.Name == "SB")
                        {
                                if(args.TargetObject.Name == "Dealer")
                                        args.Cancel = true;
                        }
                }

                [RelayCommand]
                private void DragEnter(CardDragEnterArgs args)
                {
                        var TargetObject = args.TargetObject;
                        var DroppedObject = args.DroppedObject;

                        if (DroppedObject == null)
                        {
                                return;
                        }

                        var index = this.Slots.IndexOf(DroppedObject);
                        var index2 = this.Slots.IndexOf(TargetObject);

                        if (DroppedObject.Name == "Dealer")
                        {
                                if (DroppedObject.SeatNumber == 1 && TargetObject.SeatNumber == 10) FirstSlotLast();
                                else if (DroppedObject.SeatNumber < TargetObject.SeatNumber) LastSlotFirst();
                                else FirstSlotLast();
                        }
                }

                private void LastSlotFirst()
                {
                        var lastSlot = this.Slots.Last();
                        this.Slots.Remove(lastSlot);
                        this.Slots.Insert(0, lastSlot);
                }

                private void FirstSlotLast()
                {
                        var firstSlot = this.Slots.First();
                        this.Slots.Remove(firstSlot);
                        this.Slots.Add(firstSlot);
                }
        }
}
