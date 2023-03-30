using PokerTable.CardPicker.Local.Events;
using PokerTable.CardPicker.Local.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace PokerTable.CardPicker.UI.Units
{
        public class CardListItem : ListBoxItem
        {
                public static readonly DependencyProperty DragOverCheckCommandProperty =
                    DependencyProperty.Register(
                        "DragOverCheckCommand",
                        typeof(ICommand),
                        typeof(CardListItem),
                        new PropertyMetadata(null));

                public ICommand DragOverCheckCommand
                {
                        get { return (ICommand)GetValue(DragOverCheckCommandProperty); }
                        set { SetValue(DragOverCheckCommandProperty, value); }
                }

                public static readonly DependencyProperty DragEnterCommandProperty =
                    DependencyProperty.Register(
                        "DragEnterCommand",
                        typeof(ICommand),
                        typeof(CardListItem),
                        new PropertyMetadata(null));

                public ICommand DragEnterCommand
                {
                        get { return (ICommand)GetValue(DragEnterCommandProperty); }
                        set { SetValue(DragEnterCommandProperty, value); }
                }
                private bool _isDragItem;

                static CardListItem()
                {
                        DefaultStyleKeyProperty.OverrideMetadata(typeof(CardListItem), new FrameworkPropertyMetadata(typeof(CardListItem)));
                }

                public CardListItem()
                {
                        AllowDrop = true;
                        DataContextChanged += CardListItem_DataContextChanged;
                        DragOver += CardListItem_DragOver;
                        DragEnter += CardListItem_DragEnter;
                }

                private void CardListItem_DragEnter(object sender, DragEventArgs e)
                {
                        var droppedObject = e.Data.GetData("MyCustomFormat") as CardListItem;

                        if (!droppedObject.Equals(this))
                        {
                                CardDragEnterArgs args = new();
                                args.DroppedObject = droppedObject.DataContext as SlotModel;
                                args.TargetObject = this.DataContext as SlotModel;
                                DragEnterCommand?.Execute(args);

                                if (args.Cancel)
                                {
                                        e.Effects = DragDropEffects.None;
                                        e.Handled = true;
                                }
                        }
                }

                private void CardListItem_DragOver(object sender, DragEventArgs e)
                {
                        var droppedObject = e.Data.GetData("MyCustomFormat") as CardListItem;

                        if (!droppedObject.Equals(this))
                        {
                                CardDragOverArgs args = new();
                                args.DroppedObject = droppedObject.DataContext as SlotModel;
                                args.TargetObject = this.DataContext as SlotModel;
                                DragOverCheckCommand?.Execute(args);

                                if (args.Cancel)
                                {
                                        e.Effects = DragDropEffects.None;
                                        e.Handled = true;
                                }
                        }
                }

                private void CardListItem_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
                {
                        if (DataContext is SlotModel data)
                        {
                                _isDragItem = data.IsSlot;
                        }
                }

                protected override void OnMouseMove(MouseEventArgs e)
                {
                        base.OnMouseMove(e);

                        if (_isDragItem && e.LeftButton == MouseButtonState.Pressed)
                        {
                                var data = new DataObject();
                                data.SetData("MyCustomFormat", this);
                                DragDrop.DoDragDrop((DependencyObject)this, data, DragDropEffects.Move);
                        }
                }

                protected override void OnDrop(DragEventArgs e)
                {
                        base.OnDrop(e);

                        if (!e.Source.Equals(this))
                        {

                        }
                }
        }
}
