using System.Windows;
using System.Windows.Controls;

namespace PokerTable.Forms.UI.Units
{
    public class ActionListItem : ListBoxItem
    {
        static ActionListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ActionListItem), new FrameworkPropertyMetadata(typeof(ActionListItem)));
        }
    }
}
