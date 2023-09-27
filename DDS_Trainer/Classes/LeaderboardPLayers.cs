using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDS_Trainer.Classes
{
    internal class LeaderboardPLayers
    {
        public int score = 0;
        public string name = "";

        public LeaderboardPLayers(int PlayerScore, string PlayerName) 
        {
            score = PlayerScore;
            name = PlayerName;
        } 
    }
}
