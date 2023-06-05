using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_2
{
    public class product
    {
        public string id { get; set; }
        public string img1 { get; set; }
        public string img2 { get; set; }
        public string content { get; set; }
        public string priceCurrent { get; set; }
        public string priceOld { get; set; }
        public string[] type { get; set; }
        public string color { get; set; }

        public product()
        {

        }
        public product(string id, string img1, string img2, string content, string priceCurrent, string priceOld, string[] type, string color)
        {
            this.id = id;
            this.img1 = img1;
            this.img2 = img2;
            this.content = content;
            this.priceCurrent = priceCurrent;
            this.priceOld = priceOld;
            this.type = type;
            this.color = color;
        }
    }
}