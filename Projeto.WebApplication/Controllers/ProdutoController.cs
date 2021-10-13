using ProjetoAPI.WebApplication.Data;
using ProjetoAPI.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ProjetoAPI.WebApplication.Controllers
{
    public class ProdutoController : ApiController
    {
        static readonly IProdutoRepositorio repositorio = new ProdutoRepositorio();

        /// <summary>
        /// Método GET, destinado a busca de registro
        /// </summary>
        /// <returns>Envelope JSON Correspondente ao resultado da pesquisa.</returns>

        // GET: api/Produto
        [ResponseType(typeof(Produto))]
        public IEnumerable<Produto> Get()
        {
            return repositorio.GetAll();
        }

        /// <summary>
        /// Método GET, destinado a busca de registros por ID.
        /// </summary>
        /// <param name="id">Chave primaria da tabela.</param>
        /// <returns>Envelope JSON correspondente ao resultado da pesquisa.</returns>

        [ResponseType(typeof(Produto))]
        public Produto Get(int id)
        {
            Produto item = repositorio.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }


        [Route("PorCategoria")]
        [ResponseType(typeof(Produto))]
        public IEnumerable<Produto> GetPorCategoria(string categoria)
        {
            return repositorio.GetAll().Where(
                p => string.Equals(p.Categoria, categoria, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Método POST, destinado a criação de registros.
        /// </summary>
        /// <param name="Produtos">Instância em JSON do registro para inclusão</param>
        /// <returns>O envelope JSON do registro incluso com Chave Primária</returns>
        [ResponseType(typeof(Produto))]
        public HttpResponseMessage Post(Produto item)
        {
            item = repositorio.Add(item);
            var response = Request.CreateResponse<Produto>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        /// <summary>
        /// Método PUT
        /// </summary>
        /// <param name="id"></param>
        /// <param name="produto"></param>
        /// <returns>O envelope JSON com registo alterado.</returns>
        [ResponseType(typeof(Produto))]
        public void Put(int id, Produto produto)
        {
            produto.Id = id;
            if (!repositorio.Update(produto))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        /// Método DELETE, destinado a remover um registro.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>O envelope JSON com registro excluido.</returns>
        [ResponseType(typeof(Produto))]
        public void Delete(int id)
        {
            Produto item = repositorio.Get(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            repositorio.Remove(id);
        }
    }
}
