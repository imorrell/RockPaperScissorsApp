using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsApp
{
    abstract class Player 
    {
        #region properties
        public string Name { get; set; }
        public Roshambo Selection { get; set; }

        #endregion

        #region methods
        public abstract Roshambo GetRoshambo();
        #endregion

    }
}
