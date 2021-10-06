using Projeto.DataApplicator.Logic.Northwind;
using Projeto.ModelData.Logic.Northwind.Model;
using SGI.Windows.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.WebService.Logic.NorthWind
{
    public class WebServicoNorthWind : ControllerDataApplicator<EmployeesDataApplicator, NorthwindEntities>
    {
        public WebServicoNorthWind(NorthwindEntities contexto)
            : base(contexto)
        { }
        
        public Employees ObterEmployeerPorId(int Id)
        {
            {
                var Employees = new Employees();
                try
                {
                    Employees = DataApplicator.ObterUnico(x => x.EmployeeID == Id);
                }
                catch(Exception ex)
                {
                    System.Console.WriteLine(ex.ToString());
                }
                return Employees;
            }
        }

        public List<Employees> ListarTodosEmployees()
        {
            try
            {
                var Employees = DataApplicator.ConsultarTodos().ToList();
                return Employees;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}