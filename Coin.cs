using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    internal class Coin
    {
        public bool isHeads { get; set; }

        // constructor for new coin creation
        public Coin(bool h)
        {
           this.isHeads = h;
        }

        // asign the coin heads or tails randomly 
        public void flipCoin(Random rnd)
        {
            if (rnd.Next(10) > 5)
            {
                this.isHeads=true;
            }
            else
            {
                this.isHeads=false;
            }
        }
    }
}
