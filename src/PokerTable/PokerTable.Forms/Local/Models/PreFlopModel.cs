namespace PokerTable.Forms.Local.Models
{
    internal class PreFlopModel : RoundModel
    {
        internal IRoundData DataGen()
        {
            Header = "Pre-Flop";

            Actions = new();
            Actions.Add(new BettingModel().DataGen("Dandy", "Raise", 4000));
            Actions.Add(new FoldModel().DataGen("Unknown", "Fold"));

            return this;
        }
    }
}
