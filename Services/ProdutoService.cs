using CrudProdutoBlazor.Models;
using CrudProdutoBlazor.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CrudProdutoBlazor.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly HttpClient _httpClient;
        public ProdutoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task Add(ProdutoModel produtoModel)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(ProdutoModel Object)
        {
            throw new NotImplementedException();
        }

        public async Task<ProdutoModel> GetById(int Id)
        {
            var apiResponse = await _httpClient.GetStreamAsync($"api/Produto/BuscarProdutoPorId?id={Id}");
            return await JsonSerializer.DeserializeAsync<ProdutoModel>(apiResponse, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<List<ProdutoModel>> List()
        {
            var apiResponse = await _httpClient.GetStreamAsync("api/Produto/ListarTodosProdutos");
            return await JsonSerializer.DeserializeAsync<List<ProdutoModel>>(apiResponse, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<List<ProdutoModel>> ListarProdutosAtivos()
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProdutoModel>> ListarProdutosInativos()
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProdutoModel>> ListarProdutosMaisComprados()
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProdutoModel>> ListarProdutosMaisRecentes()
        {
            throw new NotImplementedException();
        }

        public async Task Update(ProdutoModel Object)
        {
            throw new NotImplementedException();
        }

        public async Task VenderProduto(int idProduto, int quantidade)
        {
            throw new NotImplementedException();
        }
    }
}
