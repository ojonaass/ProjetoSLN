using Projeto.ModelData.Logic.Northwind.Model;
using Projeto.WebService.Logic.NorthWind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Projeto.WebService
{
    /// <summary>
    /// Summary description for WebServiceNorthWind
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceNorthWind : System.Web.Services.WebService
    {

        [WebMethod]
        public EmployeesDto ObeterEmployeerporId(int Id)
        {
            NorthwindEntities contexto = new NorthwindEntities();
            WebServicoNorthWind employees = new WebServicoNorthWind(contexto);
            var result = employees.ObterEmployeerPorId(Id);

            return new EmployeesDto()
            {
                EmployeeID = result.EmployeeID,
                LastName = result.LastName,
                FirstName = result.FirstName,
                Title = result.Title,
                TitleOfCourtesy = result.TitleOfCourtesy,
                BirthDate = result.BirthDate,
                HireDate = result.HireDate,
                Address = result.Address,
                City = result.City,
                Region = result.Region,
                PostalCode = result.PostalCode,
                Country = result.Country,
                HomePhone = result.HomePhone,
                Extension = result.Extension,
                Photo = result.Photo,
                Notes = result.Notes,
                ReportsTo = result.ReportsTo,
                PhotoPath = result.PhotoPath
            };

        }

        [WebMethod]
        public List<EmployeesDto> ObeterTodosEmployeer()
        {
            NorthwindEntities contexto = new NorthwindEntities();
            WebServicoNorthWind employees = new WebServicoNorthWind(contexto);
            var result = employees.ListarTodosEmployees();
            var lst = new List<EmployeesDto>();

            foreach (var item in result)
            {

                var employeesDto = new EmployeesDto()
                {
                    EmployeeID = item.EmployeeID,
                    LastName = item.LastName,
                    FirstName = item.FirstName,
                    Title = item.Title,
                    TitleOfCourtesy = item.TitleOfCourtesy,
                    BirthDate = item.BirthDate,
                    HireDate = item.HireDate,
                    Address = item.Address,
                    City = item.City,
                    Region = item.Region,
                    PostalCode = item.PostalCode,
                    Country = item.Country,
                    HomePhone = item.HomePhone,
                    Extension = item.Extension,
                    Photo = item.Photo,
                    Notes = item.Notes,
                    ReportsTo = item.ReportsTo,
                    PhotoPath = item.PhotoPath
                };

                lst.Add(employeesDto);
            }


            return lst;
        }

        public partial class EmployeesDto
        {
            public EmployeesDto()
            {

            }

            public int EmployeeID { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string Title { get; set; }
            public string TitleOfCourtesy { get; set; }
            public Nullable<System.DateTime> BirthDate { get; set; }
            public Nullable<System.DateTime> HireDate { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Region { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
            public string HomePhone { get; set; }
            public string Extension { get; set; }
            public byte[] Photo { get; set; }
            public string Notes { get; set; }
            public Nullable<int> ReportsTo { get; set; }
            public string PhotoPath { get; set; }


        }
    }
}
