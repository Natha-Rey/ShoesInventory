using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeClasses
{
    public class ShoeList
    {
        public List<Shoe> shoeCloset;

        public ShoeList()
        {
            shoeCloset = new List<Shoe>();
            shoeCloset.Add(new Shoe() { Style = ShoeStyle.Sneakers, Color = "Green", Price = 50.99, Image = "Sneakers.jpg" });
            shoeCloset.Add(new Shoe() { Style = ShoeStyle.Loafers, Color = "Blue", Price = 60.00, Image = "Loafers.jpg" });
            shoeCloset.Add(new Shoe() { Style = ShoeStyle.Clogs, Color = "Black", Price = 100.00, Image = "Clogs.jpg" });
            shoeCloset.Add(new Shoe() { Style = ShoeStyle.Loafers, Color = "Red", Price = 70.99, Image = "Loafers.jpg" });
            shoeCloset.Add(new Shoe() { Style = ShoeStyle.Wingtips, Color = "Black", Price = 55.50, Image = "WingTips.jpg" });
            shoeCloset.Add(new Shoe() { Style = ShoeStyle.Loafers, Color = "Grey", Price = 65.00, Image = "Loafers.jpg" });
            shoeCloset.Add(new Shoe() { Style = ShoeStyle.Sneakers, Color = "White", Price = 49.99, Image = "Sneakers.jpg" });
            shoeCloset.Add(new Shoe() { Style = ShoeStyle.Flipflops, Color = "Brown", Price = 20.00, Image = "Flipflops.jpg" });
            shoeCloset.Add(new Shoe() { Style = ShoeStyle.Sandals, Color = "Brown", Price = 29.15, Image = "Sandals.jpg" });
        }

        //To populate the comboBox
        public List<string> GetStyle()
        {
            List<string> styleList = new List<string>();
            foreach (string s in Enum.GetNames(typeof(ShoeStyle)))
            {
                styleList.Add(s);
            }
            return styleList;
        }

        /*It will return a string with the title of the image
         * depending on the style of the shoe*/
        public string GetImage(string style)
        {
            string imageTitle = "";

            foreach (Shoe shoe in shoeCloset)
            {
                if (shoe.Style.ToString() == style)
                    imageTitle = shoe.Image;
            }
            return imageTitle;
        }

        /*It will change and return the price of a shoe
         depending on its style.*/
        public double ChangeShoePrice(string style, double price)
        {
            foreach (Shoe shoe in shoeCloset)
            {
                if (shoe.Style.ToString() == style)
                    shoe.Price = price;
            }
            return price;
        }

        /*It will display the information of a shoe in the 
         list box depending on the style. */
        public List<Shoe> PopListBox(string style)
        {
            List<Shoe> shoeLst = new List<Shoe>();
            foreach (Shoe shoe in shoeCloset)
            {
                if (shoe.Style.ToString() == style)
                    shoeLst.Add(shoe);
            }
            return shoeLst;
        }
    }
}
