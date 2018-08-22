using EntityFramework.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework.AcessoDados
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppContext _appContext;

        public ProdutoRepository(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public List<Produto> ListarProdutos()
        {
            return _appContext.Produtos.ToList();
        }
    }
}
