namespace PokerTable.Forms.Local.Models
{
    internal class BlindsModel : RoundModel
    {
        public int Value { get; set; }

        internal IRoundData DataGen()
        {
            Header = "Ante";
            Value = 2000;

            Actions = new();
            Actions.Add(new BettingModel().DataGen("홍진호", "SB", 1000));
            Actions.Add(new BettingModel().DataGen("루크", "BB", 2000));

            return this;
        }
    }
}
