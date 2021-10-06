using System.Data.Entity;

namespace Projeto.ModelData.Logic.Northwind.Model
{
    public partial class NorthwindEntities : DbContext
    {
        public NorthwindEntities(string conn)
            : base(conn)
        {
        }
    }
}
