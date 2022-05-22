using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeClasses
{
    public enum ShoeStyle
    {
        Clogs,
        Flipflops,
        Sneakers,
        Loafers,
        Sandals,
        Wingtips,
    }
    public class Shoe
    {
        public ShoeStyle Style { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        //Default Constructor
        public Shoe()
        {
            Style = ShoeStyle.Clogs;
            Color = " ";
            Price = 0;
        }

        public Shoe(string style, double price)
        {
            Style = (ShoeStyle)Enum.Parse(typeof(ShoeStyle), style);
            Price = price;
        }

        public Shoe(string style, string color, double price, string image)
        {
            Style = (ShoeStyle) Enum.Parse(typeof(ShoeStyle),style);
            Color = color;
            Price = price;
            Image = image;
        }

        public override string ToString()
        {
            return Color + " coloured " + Style + " at price: " + Price.ToString("C");
        }
    }
}
