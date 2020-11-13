using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Kanban.Shared.Models;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Kanban.Pages.Modelos
{
    public class ModeloPageBase : ComponentBase
    {
        [Inject] protected CustomHttpClient Http { get; set; }
        [Inject] protected IJSRuntime JsRuntime { get; set; }
        protected SfGrid<Estado> Grid;

        public bool Enabled = true;
        public bool Disabled = false;

        protected List<Estado> estados = new List<Estado>();
        protected override async Task OnInitializedAsync()
        {
            estados = await Http.GetFromJsonAsync<List<Estado>>("api/Estado");

            await base.OnInitializedAsync();
        }
    }
}
