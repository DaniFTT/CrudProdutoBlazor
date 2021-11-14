using CrudProdutoBlazor.Models;
using CrudProdutoBlazor.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudProdutoBlazor.Pages
{
    public partial class ProdutoOverview
    {
        public IEnumerable<ProdutoModel> ProdutosList { get; set; }

        [Inject]
        public IProdutoService ProdutoService {get; set;}

        protected override async Task OnInitializedAsync()
        {
            ProdutosList = (await ProdutoService.List());
        }
    }
}
