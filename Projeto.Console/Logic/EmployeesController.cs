using Projeto.DataApplicator.Logic.Northwind;
using Projeto.ModelData.Logic.Northwind.Model;
using SGI.Windows.Common;
using System;
using System.Linq;

namespace Projeto.Console.Logic
{
    public class EmployeesController : ControllerDataApplicator<EmployeesDataApplicator, NorthwindEntities>
    {
        public EmployeesController(NorthwindEntities contexto)
            : base(contexto)
        { }


        public void Listar()
        {
            try
            {
                var Funcionarios = this.DataApplicator.ConsultarTodos().Take(10);
                foreach (var item in Funcionarios)
                {
                    System.Console.WriteLine("Nome: {0} {1}", item.FirstName, item.LastName);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
        }
    }
}
