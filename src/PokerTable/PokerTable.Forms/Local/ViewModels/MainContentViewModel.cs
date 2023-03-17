using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using PokerTable.Forms.Local.Models;
using System.Collections.Generic;

namespace PokerTable.Forms.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase, IViewLoadable
    {
        [ObservableProperty]
        private List<IRoundData> _rounds;

        public MainContentViewModel() 
        {
                
        }

        public void OnLoaded(IViewable smartWindow)
        {
            Rounds = GetRounds();
        }

        private List<IRoundData> GetRounds()
        {
            List<IRoundData> source = new();
            source.Add(new BlindsModel().DataGen());
            source.Add(new PreFlopModel().DataGen());
            source.Add(new FlopModel().DataGen());

            return source;
        }
    }
}
