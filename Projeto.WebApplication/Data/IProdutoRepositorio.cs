using ProjetoAPI.WebApplication.Models;
using System.Collections.Generic;

namespace ProjetoAPI.WebApplication.Data
{
    public interface IProdutoRepositorio
    {
        IEnumerable<Produto> GetAll();
        Produto Get(int id);
        Produto Add(Produto item);
        void Remove(int id);
        bool Update(Produto item);
    }
}