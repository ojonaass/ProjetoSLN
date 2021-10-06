using Projeto.DataApplicator.Logic.Northwind;
using Projeto.ModelData.Logic.Northwind.Model;
using SGI.Windows.Common;
using System;
using System.Linq;

namespace Projeto.Console.Logic
{
    public class CategoriesController : ControllerDataApplicator<CategoriesDataApplicator, NorthwindEntities>
    {
        public CategoriesController(NorthwindEntities contexto)
            : base(contexto)
        { }

        public void Listar()

        {
            try
            {
                var Funcionarios = this.DataApplicator.ConsultarTodos().Where(x => x.CategoryName == "Dairy Products");
                foreach (var item in Funcionarios)
                {
                    System.Console.WriteLine("Nome: {0} {1}", item.CategoryName, item.Description);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
        }
    }
}
