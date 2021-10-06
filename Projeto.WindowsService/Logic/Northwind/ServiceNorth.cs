using Projeto.DataApplicator.Logic.Northwind;
using Projeto.ModelData.Logic.Northwind.Model;
using SGI.Windows.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.WindowsService.Logic.NorthWind
{
    public class ServiceNorth : ControllerDataApplicator<EmployeesDataApplicator, NorthwindEntities>
    {
       
        public ServiceNorth(NorthwindEntities contexto)
            : base(contexto)
        { }

        public void ProcessarServico()
        {
            try
            {
                var Employees = this.DataApplicator.ConsultarTodos().ToList();

                foreach (var item in Employees)
                {
                    AlterarEmployeer(item);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
        }
        public void AlterarEmployeer(Employees employees)
        {
            Employees employee = new Employees();
            employee = this.DataApplicator.ObterUnico(x => x.EmployeeID == employees.EmployeeID); 
            employee.HireDate = DateTime.Now;
            this.DataApplicator.Atualizar(employee);
            this.DataApplicator.Salvar();

        }
    }
}
