using System;

namespace Domain
{
    public class Wine : BaseDbClass
    {
        public Wine()
        {
            this.CreationDate = DateTime.Now;
            this.LastUpdateDate = DateTime.Now;
        }
        public string Name{ get; set; }

        public DateTime Vintage { get; set; }

        public decimal Price { get; set; }
    }
}