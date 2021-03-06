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
    /// Employees class MetaData
    /// </summary>
    public partial class EmployeesMetaData
    {
        [DisplayName("Employee ID")]
        [Required(ErrorMessage = "Employee ID is required")]
        public int EmployeeID { get; set; }
    
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [MaxLength(20, ErrorMessage = "Last Name cannot be longer than 20 characters")]
        public string LastName { get; set; }
    
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [MaxLength(10, ErrorMessage = "First Name cannot be longer than 10 characters")]
        public string FirstName { get; set; }
    
        [DisplayName("Title")]
        [MaxLength(30, ErrorMessage = "Title cannot be longer than 30 characters")]
        public string Title { get; set; }
    
        [DisplayName("Title Of Courtesy")]
        [MaxLength(25, ErrorMessage = "Title Of Courtesy cannot be longer than 25 characters")]
        public string TitleOfCourtesy { get; set; }
    
        [DisplayName("Birth Date")]
        public Nullable<System.DateTime> BirthDate { get; set; }
    
        [DisplayName("Hire Date")]
        public Nullable<System.DateTime> HireDate { get; set; }
    
        [DisplayName("Address")]
        [MaxLength(60, ErrorMessage = "Address cannot be longer than 60 characters")]
        public string Address { get; set; }
    
        [DisplayName("City")]
        [MaxLength(15, ErrorMessage = "City cannot be longer than 15 characters")]
        public string City { get; set; }
    
        [DisplayName("Region")]
        [MaxLength(15, ErrorMessage = "Region cannot be longer than 15 characters")]
        public string Region { get; set; }
    
        [DisplayName("Postal Code")]
        [MaxLength(10, ErrorMessage = "Postal Code cannot be longer than 10 characters")]
        public string PostalCode { get; set; }
    
        [DisplayName("Country")]
        [MaxLength(15, ErrorMessage = "Country cannot be longer than 15 characters")]
        public string Country { get; set; }
    
        [DisplayName("Home Phone")]
        [MaxLength(24, ErrorMessage = "Home Phone cannot be longer than 24 characters")]
        public string HomePhone { get; set; }
    
        [DisplayName("Extension")]
        [MaxLength(4, ErrorMessage = "Extension cannot be longer than 4 characters")]
        public string Extension { get; set; }
    
        [DisplayName("Photo")]
        public byte[] Photo { get; set; }
    
        [DisplayName("Notes")]
        public string Notes { get; set; }
    
        [DisplayName("Reports To")]
        public Nullable<int> ReportsTo { get; set; }
    
        [DisplayName("Photo Path")]
        [MaxLength(255, ErrorMessage = "Photo Path cannot be longer than 255 characters")]
        public string PhotoPath { get; set; }
    
    }
}
