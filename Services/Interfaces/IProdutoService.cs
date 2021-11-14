using CrudProdutoBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudProdutoBlazor.Services.Interfaces
{
    public interface IProdutoService : IGeneric<ProdutoModel>
    {
        Task<List<ProdutoModel>> ListarProdutosMaisComprados();
        Task<List<ProdutoModel>> ListarProdutosMaisRecentes();
        Task<List<ProdutoModel>> ListarProdutosInativos();
        Task<List<ProdutoModel>> ListarProdutosAtivos();
        Task VenderProduto(int idProduto, int quantidade);
    }
}
