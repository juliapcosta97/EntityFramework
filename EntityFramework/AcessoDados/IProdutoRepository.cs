using System.Collections.Generic;
using EntityFramework.Entidades;

namespace EntityFramework.AcessoDados
{
    public interface IProdutoRepository
    {
        List<Produto> ListarProdutos();
    }
}