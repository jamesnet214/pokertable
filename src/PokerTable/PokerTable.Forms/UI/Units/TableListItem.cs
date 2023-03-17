using System.Windows;
using System.Windows.Controls;

namespace PokerTable.Forms.UI.Units
{
    public class TableListItem : ListBoxItem
    {
        static TableListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TableListItem), new FrameworkPropertyMetadata(typeof(TableListItem)));
        }
    }
}
