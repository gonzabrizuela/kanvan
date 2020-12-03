﻿using Microsoft.AspNetCore.Components;
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
        protected SfGrid<PedCli> Grid;
        public bool Enabled = true;
        public bool Disabled = false;

        public string mensaje = "Hola";
        public string mensaje2 = "Hola";
        public string mensaje3 = "Hola";

        //protected List<KanbanLOG> KB = new List<KanbanLOG>();
        protected List<PedCli> Pedclis = new List<PedCli>();
        protected List<Pedidos> Pedidoss = new List<Pedidos>();
        protected List<Programa> Programas = new List<Programa>();
        protected override async Task OnInitializedAsync()
        {
            
            Pedclis = await Http.GetFromJsonAsync<List<PedCli>>("api/PedCli");
            Pedidoss = await Http.GetFromJsonAsync<List<Pedidos>>("api/Pedidos");
            Programas = await Http.GetFromJsonAsync<List<Programa>>("api/Programa");
            //KB = await Http.GetFromJsonAsync<List<KanbanLOG>>("api/KanbanLOG");

            await base.OnInitializedAsync();
        }
    }
}
