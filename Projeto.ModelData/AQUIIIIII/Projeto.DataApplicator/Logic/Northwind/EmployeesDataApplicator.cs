using Projeto.ModelData.Logic.Northwind.Model;
using SGI.Common.DataApplicator;
using System.Linq;

namespace Projeto.DataApplicator.Logic.Northwind
{
    public class EmployeesDataApplicator : WebDataApplicatorEF<NorthwindEntities, Employees>
    {
        public IQueryable<Employees> BuscarPorNome(string nome)
        {
            try
            {
                return this.Contexto.Employees.Where(est => est.FirstName.Contains(nome));
            }
            catch
            {
                throw;
            }
        }
    }

}
