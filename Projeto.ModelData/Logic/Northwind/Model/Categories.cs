//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Projeto.ModelData.Logic.Northwind.MetaData;

namespace Projeto.ModelData.Logic.Northwind.Model
{
    using System; 
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using Projeto.ModelData.Logic.Northwind.MetaData;
    
    [Serializable]
    [MetadataType(typeof(CategoriesMetaData))]
    
    /// <summary>
    /// Categories class ModelData
    /// </summary>
    public partial class Categories
    {
    
    	public Categories()
        {
            this.Products = new HashSet<Products>();
        }
    
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    
        public virtual ICollection<Products> Products { get; set; }
    }
}
