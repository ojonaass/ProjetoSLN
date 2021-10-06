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
    /// Territories class MetaData
    /// </summary>
    public partial class TerritoriesMetaData
    {
        [DisplayName("Territory ID")]
        [Required(ErrorMessage = "Territory ID is required")]
        [MaxLength(20, ErrorMessage = "Territory ID cannot be longer than 20 characters")]
        public string TerritoryID { get; set; }
    
        [DisplayName("Territory Description")]
        [Required(ErrorMessage = "Territory Description is required")]
        [MaxLength(50, ErrorMessage = "Territory Description cannot be longer than 50 characters")]
        public string TerritoryDescription { get; set; }
    
        [DisplayName("Region ID")]
        [Required(ErrorMessage = "Region ID is required")]
        public int RegionID { get; set; }
    
    }
}
