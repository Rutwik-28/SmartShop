using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartShop.Models
{
    public class Offers
    {
        public int OfferId { get; set; }

        public string OfferName { get; set; }

        public int DiscountRate { get; set; }

        public DateTime OfferDate { get; set; }

        public int ShelfRate { get; set; }

        public string Status { get; set; }
    }
}
