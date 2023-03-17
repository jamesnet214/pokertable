using System.Windows;
using System.Windows.Controls;

namespace PokerTable.Forms.UI.Units
{
    public class ActionList : ListBox
    {
        static ActionList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ActionList), new FrameworkPropertyMetadata(typeof(ActionList)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new ActionListItem();
        }
    }
}
