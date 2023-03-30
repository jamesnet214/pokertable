using System.Windows;
using System.Windows.Controls;

namespace PokerTable.CardPicker.UI.Units
{
        public class CardList : ListBox
    {
        static CardList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CardList), new FrameworkPropertyMetadata(typeof(CardList)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new CardListItem();
        }
    }
}
