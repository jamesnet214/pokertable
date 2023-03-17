using System.Collections.Generic;

namespace PokerTable.Forms.Local.Models
{
    internal class RoundModel : IRoundData
    {
        public string Header { get; set; }
        public List<IActionData> Actions { get; set; }

        public RoundType DataType
        {
            get
            {
                return this.GetType().Name switch
                {
                    "BlindsModel" => RoundType.Blind,
                    "PreFlopModel" => RoundType.PreFlop,
                    "FlopModel" => RoundType.Flop,
                    "FlopTurnModel" => RoundType.FlopTurn,
                    "TurnRiverModel" => RoundType.TurnRiver,
                    _ => RoundType.None
                };
            }
        }
    }
}
