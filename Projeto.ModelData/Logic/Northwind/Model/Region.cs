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
    [MetadataType(typeof(RegionMetaData))]
    
    /// <summary>
    /// Region class ModelData
    /// </summary>
    public partial class Region
    {
    
    	public Region()
        {
            this.Territories = new HashSet<Territories>();
        }
    
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
    
        public virtual ICollection<Territories> Territories { get; set; }
    }
}
