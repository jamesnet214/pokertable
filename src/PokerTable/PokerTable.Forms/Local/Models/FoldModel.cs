namespace PokerTable.Forms.Local.Models
{
    public class FoldModel : ActionModel
    {
        internal IActionData DataGen(string playerName, string playType)
        {
            PlayerName = playerName;
            PlayType = playType;

            return this;
        }
    }
}
