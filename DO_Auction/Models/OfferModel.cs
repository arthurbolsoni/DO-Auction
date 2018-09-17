using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DO_Login.Models
{
    public class OfferModel
    {
        HtmlElement Offers { get; set; }

        public String img { get; set; }
        public String name { get; set; }
        public String itemKey { get; set; }
        public String highest { get; set; }
        public Int64 currentBid { get; set; }
        public Int64 youBid { get; set; }
        public String lootId { get; set; }
    }
}