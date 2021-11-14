using CrudProdutoBlazor.Models;
using CrudProdutoBlazor.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudProdutoBlazor.Pages
{
    public partial class ProdutoDetail
    {
        [Parameter]
        public string Id { get; set; }

        public ProdutoModel Produto { get; set; } = new ProdutoModel();
        [Inject]
        public IProdutoService ProdutoService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Produto = await ProdutoService.GetById(Convert.ToInt32(Id));
        }
    }
}
