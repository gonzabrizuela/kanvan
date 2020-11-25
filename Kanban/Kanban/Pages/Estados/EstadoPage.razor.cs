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
        protected SfGrid<LOGISTICA> Grid;

        public bool Enabled = true;
        public bool Disabled = false;

        protected List<PedCli> Pedclis = new List<PedCli>();
        protected List<LOGISTICA> Logisticas = new List<LOGISTICA>();
        protected override async Task OnInitializedAsync()
        {
            Pedclis = await Http.GetFromJsonAsync<List<PedCli>>("api/Pedcli");
            Logisticas = await Http.GetFromJsonAsync<List<LOGISTICA>>("api/LOGISTICA");

            await base.OnInitializedAsync();
        }
    }
}
