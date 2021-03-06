//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Projeto.ModelData.Logic.Northwind.MetaData
{
    using System; 
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    /// <summary>
    /// Order_Details class MetaData
    /// </summary>
    public partial class Order_DetailsMetaData
    {
        [DisplayName("Order ID")]
        [Required(ErrorMessage = "Order ID is required")]
        public int OrderID { get; set; }
    
        [DisplayName("Product ID")]
        [Required(ErrorMessage = "Product ID is required")]
        public int ProductID { get; set; }
    
        [DisplayName("Unit Price")]
        [Required(ErrorMessage = "Unit Price is required")]
        public decimal UnitPrice { get; set; }
    
        [DisplayName("Quantity")]
        [Required(ErrorMessage = "Quantity is required")]
        public short Quantity { get; set; }
    
        [DisplayName("Discount")]
        [Required(ErrorMessage = "Discount is required")]
        public float Discount { get; set; }
    
    }
}
