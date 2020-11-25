using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kanban.Shared.Models
{
    [Table("LOGISTICA")]
	public class LOGISTICA
	{
		public int Id { get; set; }
		public int Pedido { get; set; }
		public int Presup { get; set; }
		public DateTime FechaPed { get; set; }
		public int CodCliente { get; set; }
		public string RazonSoc { get; set; }
		public string DES_CATEG { get; set; }
		public string CodArt { get; set; }
		public string DescripcionArt { get; set; }
		public decimal Cantped { get; set; }
		public decimal CantEnt { get; set; }
		public decimal PesosPresupuesto { get; set; }
		public decimal DolaresPresupuesto { get; set; }
		public decimal PesosPedido { get; set; }
		public decimal DolaresPedido { get; set; }
		public int OCInterna { get; set; }
		public DateTime FechaPrev { get; set; }
		public string Dirent { get; set; }
		public string OrdenCcompra { get; set; }
		public decimal TC { get; set; }
		public DateTime Fe_altaPT { get; set; }
		public string Obseritem { get; set; }
		public string Presion { get; set; }
		public string Resorte { get; set; }
		public string Fluido { get; set; }
		public string PresionenBanco { get; set; }
		public string Temperatura { get; set; }
		public string Contrapresion { get; set; }
		public DateTime FechaArmado { get; set; }
		public string RemitoVentas { get; set; }
		public int Semana { get; set; }
		public bool Confirmado { get; set; }
		public DateTime FechaConfirmacion { get; set; }
		public decimal TC_FechaPedido { get; set; }
		public decimal TC_FechaPresupuesto { get; set; }
		public string Factura { get; set; }
		public int MesFactura { get; set; }
		public DateTime FechaFac { get; set; }
		public string ConFactu { get; set; }
		public string ConPed { get; set; }
		public int MesPedido { get; set; }
		public decimal UnidEqui { get; set; }
		public int DiasAtraso { get; set; }
		public int DiasDemoraEntrega { get; set; }
		public int DiasParaFabricar { get; set; }
		public string ConRem { get; set; }
		public string Presup_des_obra { get; set; }
		public string Pedido_des_obra { get; set; }
		public DateTime ENTRREAL { get; set; }
		public DateTime Fe_ped { get; set; }
		public DateTime Fe_pres { get; set; }
		public int Cg_rub { get; set; }
		public string Rubro { get; set; }
		public decimal PesosFactura { get; set; }
		public decimal DolaresFactura { get; set; }
		public decimal TC_FechaFac { get; set; }
		public string Leyenda { get; set; }
		public string Localidad { get; set; }
		public decimal Descuento { get; set; }
		public decimal Bonificacion { get; set; }
		public string Unid { get; set; }
		public decimal anoPedido { get; set; }
		public decimal anoPresupuesto { get; set; }
		public decimal anoFactura { get; set; }
		public string MesAnoPedido { get; set; }
		public string MesAnoPresupuesto { get; set; }
		public string MesAnoFactura { get; set; }
	}
}
