using System;
using System.Collections.Generic;
using System.Linq;
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
