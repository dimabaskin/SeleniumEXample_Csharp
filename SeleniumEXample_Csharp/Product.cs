using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SeleniumEXample_Csharp
{
    public class Product : IEquatable<Product>
    {
        public string ProductName { get; set; }
        public StrPrice RegularPrice;
        public StrPrice CampaignPrice;
        public bool IsOnSaile { get; set; }


        public bool Equals(Product other)
        {
            if (other == null) return false;

            //if both are new product
            if (this.IsOnSaile && other.IsOnSaile)
            {
                return (this.ProductName.Equals(other.ProductName) &&
                   this.RegularPrice.price.Equals(other.RegularPrice.price) &&
                   this.CampaignPrice.price.Equals(other.CampaignPrice.price) &&
                   this.RegularPrice.GetColor().Equals(other.RegularPrice.GetColor()) &&
                   this.CampaignPrice.GetColor().Equals(other.CampaignPrice.GetColor())
                   );
            }
            else
            {
                return (this.ProductName.Equals(other.ProductName) &&
                   this.RegularPrice.price.Equals(other.RegularPrice.price) &&
                   this.RegularPrice.GetColor().Equals(other.RegularPrice.GetColor()) &&
                   this.IsOnSaile.Equals(other.IsOnSaile)
                   );
            }

            
        }

        public bool HaveRightProperties()
        {

            //if product on sail
            //check regular prise is isStrikethrough
            //check regular prise color is "grey"
            //check sail price is not isStrikethrough
            //check sail price color is RED
            // check sail price is bigger than regular price

            if (this.IsOnSaile)
            {
                return (this.RegularPrice.isStrikethrough &&
                    this.RegularPrice.GetColor() == "Grey" &&
                    !this.CampaignPrice.isStrikethrough &&
                    this.CampaignPrice.GetColor() == "Red" &&
                    this.RegularPrice.GetTextSize() < this.CampaignPrice.GetTextSize()
                    );
             }
            

            //if product is new 
            //check regular prise is not isStrikethrough
            // check regulkar prise is "GRAY"
            else 
            {
                return (!this.RegularPrice.isStrikethrough &&
                        this.RegularPrice.GetColor() == "Grey"
                        );
            }
            
            
        }

    /*    public bool IsTheSameProductAs(Product product)
        {
            if (this.ProductName == product.ProductName &&
                this.RegularPrice.price == product.RegularPrice.price &&
                this.CampaignPrice.price == product.CampaignPrice.price &&
                //this.RegularPrice.getColor() == product.RegularPrice.getColor &&
                //this.CampaignPrice.textColor == product.CampaignPrice.textColor &&
                this.RegularPrice.isStrikethrough == product.RegularPrice.isStrikethrough)
            {
                return true;
            }
            return false;
        }*/

     /*   public bool isTheSameProduct(Product homePageProduct, Product productPageProduct)
        {
            if (homePageProduct.ProductName == productPageProduct.ProductName &&
                homePageProduct.RegularPrice.price == productPageProduct.RegularPrice.price &&
                homePageProduct.CampaignPrice.price == productPageProduct.CampaignPrice.price &&
                //homePageProduct.RegularPrice.textColor == productPageProduct.RegularPrice.textColor &&
                //homePageProduct.CampaignPrice.textColor == productPageProduct.CampaignPrice.textColor &&
                homePageProduct.RegularPrice.isStrikethrough == productPageProduct.RegularPrice.isStrikethrough)
            {
                return true;
            }
            return false;
        }*/

    }

    public struct StrPrice
    {
        public string price { get; set; }
        public bool isStrikethrough { get; set; }
        private string textColor;
        public string textStyle { get; set; }
        private int textSize;

        public string GetColor ()
        {
            return this.textColor;
        }

        public void SetColor(string color)
        {
            string[] strArray = color.Split('(');
            string RGBcolor = strArray[1];
            RGBcolor = RGBcolor.Substring(0, RGBcolor.Length - 1);
            string[] RGBstrArray = RGBcolor.Split(',');

            if ( RGBstrArray.Count() == 3)
            {
                int Red;
                int Green;
                int Blue;
                int.TryParse(RGBstrArray[0], out Red);
                int.TryParse(RGBstrArray[1], out Green);
                int.TryParse(RGBstrArray[2], out Blue);

                if (Red == Green && Red == Blue)
                {
                    this.textColor = "Grey";
                }
                else if(Red > 0 && Green  == 0 && Blue == 0)
                {
                    this.textColor = "Red";
                }
                else
                {
                    this.textColor = "N/A";
                }
            }

        }
        
        public int GetTextSize()
        {
            return textSize;
        }

        public void SetTextSize(string size)
        {
            int.TryParse(size.Substring(0,size.Length - 2), out this.textSize);
        }
    }

    


}
