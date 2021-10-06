using Projeto.ModelData.Logic.Northwind.Model;
using SGI.Common.DataApplicator;

namespace Projeto.DataApplicator.Logic.Northwind
{
    public class CategoriesDataApplicator : WinDataApplicatorEF<NorthwindEntities, Categories>
    {
        public CategoriesDataApplicator(NorthwindEntities contexto)
            : base(contexto)
        {

        }

    }
}
