using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomStrategy;

namespace comportementFourmis
{
    public class XXXBlueQueen : QueenStrategy
    {
        public override StrategyColor GetColor()
        {
            return StrategyColor.Blue;
        }
        public override string GetId()
        {
            return "demo-blue-queen";
        }
        public override int GetVersion()
        {
            return 1;
        }
        public override string GetMessage()
        {
            return "Hello Demo";
        }
    }

}
