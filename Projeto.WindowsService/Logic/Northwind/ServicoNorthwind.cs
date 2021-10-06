using Projeto.DataApplicator.Logic.Northwind;
using Projeto.ModelData.Logic.Northwind.Model;
using SGI.Windows.Common;
using System;
using System.Linq;

namespace Projeto.WindowsService.Logic.Northwind
{
    public class ServicoNorthwind : ControllerDataApplicator<EmployeesDataApplicator, NorthwindEntities>
    {
        public ServicoNorthwind(NorthwindEntities contexto)
    : base(contexto)
        { }


        public void ProcessarServico()
        {
            try
            {
                var funcionarios = this.DataApplicator.ConsultarTodos().ToList();
                foreach (var item in funcionarios)
                {
                    AlterarEmployees(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        private void AlterarEmployees(Employees employees)
        {
            Employees employee = new Employees();
            employee = this.DataApplicator.ObterUnico(x => x.EmployeeID == employees.EmployeeID);
            employee.HireDate = DateTime.Now;
            this.DataApplicator.Atualizar(employee);
            this.DataApplicator.Salvar();
        }
    }
}
