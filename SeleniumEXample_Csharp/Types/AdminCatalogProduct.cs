using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumEXample_Csharp.Resources;
using System.IO;

namespace SeleniumEXample_Csharp.Types
{
    public class AdminCatalogProduct
    {
        public bool _SatusEnabled { get; set; }
        public string _ProductName { get; set; }
        public string _ProductCode { get; set; }
        public string _ProductCategory { get; set; }
        private string _ProductDefaultCategory { get; set; }
        public string _ProductGroupGender { get; set; }
        public string _ProductQuantity { get; set; }
        public string _ProductImagePath { get; set; }
        public string _ProductManufacturer { get; set; }
        public string _ProductInformationDescription { get; set; }
        public string _ProductKeyWords { get; set; }
        public string _ProductShortDescription { get; set; }
        public string _ProductHeadTitle { get; set; }
        public string _ProductPurchasePrice { get; set; }
        public string _ProductPurchasePriceCurrency { get; set; }
        private readonly Utils.Utils _utils;

        public AdminCatalogProduct()
        {
            _utils = new Utils.Utils();
            
        }

        public AdminCatalogProduct CreateRandomProductData()
        {
            this._SatusEnabled = true;
            this._ProductName = _utils.RandomAlpabetString(3) + " DUCK";
            this._ProductCode = _utils.RandomNumericString(5);
            this._ProductCategory = "Rubber Ducks";
            this._ProductDefaultCategory = "Rubber Ducks";
            this._ProductGroupGender = Gender.Unisex;
            this._ProductQuantity = _utils.RandomNumericString(2);
            this._ProductImagePath = GetImageAbsolutePath();
            this._ProductManufacturer = "ACME Corp.";
            this._ProductInformationDescription = GetProductInformationDescription();
            this._ProductKeyWords = this._ProductName;
            this._ProductShortDescription = GetProductShortDescription();
            this._ProductHeadTitle = this._ProductName;
            this._ProductPurchasePrice = _utils.RandomNumericString(2);
            this._ProductPurchasePriceCurrency = "USD";

            return this;
        }

        private string GetProductShortDescription()
        {
            return "Product Short Description for " + this._ProductName;
        }

        private string GetProductInformationDescription()
        {
            return @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sollicitudin ante massa, eget ornare libero porta congue.Cras scelerisque dui non consequat sollicitudin. Sed pretium tortor ac auctor molestie. Nulla facilisi. Maecenas pulvinar nibh vitae lectus vehicula semper. Donec et aliquet velit. Curabitur non ullamcorper mauris. In hac habitasse platea dictumst. Phasellus ut pretium justo, sit amet bibendum urna. Maecenas sit amet arcu pulvinar, facilisis quam at, viverra nisi. Morbi sit amet adipiscing ante. Integer imperdiet volutpat ante, sed venenatis urna volutpat a. Proin justo massa, convallis vitae consectetur sit amet, facilisis id libero. ";
        }

        private string GetImageAbsolutePath()
        {
            string ImageRelativeDirectoryPath = @"..\..\";
            string ImageName = @"Images\policeduck.jpg";
            var ImageAbsoluteDirectoryPath = new Uri(new Uri(Directory.GetCurrentDirectory().ToString()), ImageRelativeDirectoryPath).AbsolutePath;
            var ImageAbsolutePath = new Uri(new Uri(ImageAbsoluteDirectoryPath), ImageName).AbsolutePath;

            string[] FileList = Directory.GetFiles(new FileInfo(ImageAbsolutePath).Directory.FullName);
            foreach ( var fileName in FileList)
            {
                if (File.Exists(fileName))
                {
                    return fileName;
                }
            }
            
            return ImageAbsolutePath;
        }

    }
}
