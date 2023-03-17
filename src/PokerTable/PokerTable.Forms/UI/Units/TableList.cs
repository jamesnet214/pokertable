using System.Windows;
using System.Windows.Controls;

namespace PokerTable.Forms.UI.Units
{
    public class TableList : ListBox
    {
        static TableList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TableList), new FrameworkPropertyMetadata(typeof(TableList)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new TableListItem();
        }
    }
}
