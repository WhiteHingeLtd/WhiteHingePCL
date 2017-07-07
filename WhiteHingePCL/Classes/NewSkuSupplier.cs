using System.Collections.Generic;

namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// 
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class NewSkuSupplier
    {
        /// <summary>
        /// A dictionary containing all barcodes.
        /// </summary>
        public Dictionary<string, string> BarcodeDictionary = new Dictionary<string, string>();
        /// <summary>
        /// The Supplier's name
        /// </summary>
        public string SupplierName;
        /// <summary>
        /// The Supplier reorder code
        /// </summary>
        public string SupplierCode;
        /// <summary>
        /// The price per item from the supplier
        /// </summary>
        public float SupplierPrice;
        /// <summary>
        /// If the Supplier is the primary Supplier
        /// </summary>
        public bool SupplierIsPrimary = false;
        /// <summary>
        /// If the supplier has discontinued this item
        /// </summary>
        public bool SupplierIsDiscontinued = false;
        /// <summary>
        /// If the supplier is out of stock of this item
        /// </summary>
        public bool SupplierOutOfStock = false;
        /// <summary>
        /// 
        /// </summary>
        public NewSkuSupplier()
        {

        }
    }
}
