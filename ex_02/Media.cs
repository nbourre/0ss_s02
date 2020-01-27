using System;
using System.Collections.Generic;
using System.Text;

namespace rappel_ex08
{
    class Media
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public string ID { get; private set; }

        private int _stock;

        public bool InStock() => _stock > 0;

        public void Sell(int qty)
        {
            _stock -= qty;
        }

        public virtual string Info() => $"{Title}, {Price}, In stock : {_stock}";
    }

    class Book : Media
    {
        public string ISBN { get; set; }

        public override string Info()
        {
            return base.Info() + $", ISBN : {ISBN}";
        }
    }

    class Movie : Media
    {
        public int Year { get; set; }
        public override string Info()
        {
            return base.Info() + $", Released : {Year}";
        }
    }

    class Magazine : Media
    {
        public string Issue { get; set; }

        public override string Info()
        {
            return base.Info() + $", Issue : {Issue}";
        }
    }
}
