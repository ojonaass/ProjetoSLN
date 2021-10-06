using Projeto.Console.Logic;
using Projeto.ModelData.Logic.Northwind.Model;

namespace Projeto.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //NorthwindEntities contexto = new NorthwindEntities();

            ////CategoriesController controle = new CategoriesController(contexto);
            //EmployeesController employees = new EmployeesController(contexto);
            ////controle.Listar();
            //employees.Listar();
            //System.Console.ReadKey();

            localhost.WebServiceNorthWind webServiceNorthWind = new localhost.WebServiceNorthWind();
            var employeer = webServiceNorthWind.ObeterEmployeerporId(4);
            System.Console.WriteLine(employeer);
        }
    }
}
