using System;

namespace CoinFlip
{
    internal class Coin
    {
        public bool isHeads { get; set; }

        public Coin(bool h)
        {
            this.isHeads = h;
        }

        public void flipCoin(Random r)
        {
            if (r.Next(10) > 5)
            {
                this.isHeads = true;
            }
            else
            {
                this.isHeads = false;
            }
        }
    }
}