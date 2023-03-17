namespace PokerTable.Forms.Local.Models
{
    public class ActionModel : IActionData
    {
        public string PlayerName { get; set; }
        public string PlayType { get; set; }
        public int Value { get; private set; }

        internal ActionModel DataGen(string playerName, string playType, int value)
        {
            PlayerName = playerName;
            PlayType = playType;
            Value = value;

            return this;
        }

        public ActionType DataType
        {
            get
            {
                return this.GetType().Name switch
                {
                    "BettingModel" => ActionType.Betting,
                    "FoldModel" => ActionType.Fold,
                    _ => ActionType.None
                };
            }
        }
    }
}
