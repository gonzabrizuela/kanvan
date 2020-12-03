using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kanban
{
    public class KanbanLOG
    {
        public string ESTADO_PEDIDO { get; set; } = ""; //Pedcli CG_ESTADO
        public int CG_ESTADPEDCLI { get; set; } = 0; //Pedcli CG_ESTADPEDCLI
        public int PEDIDO { get; set; } = 0; //Pedcli PEDIDO
        public int CG_ESTADO { get; set; } = 0; //Programa CG_ESTADO
        public string REMITO { get; set; } = ""; //Pedidos REMITO
        public int CG_ESTADOCARGA { get; set; } = 0; //Programa CG_ESTADOCARGA
        public decimal FLAG { get; set; } = 0; //Pedidos FLAG
        public int CG_ORDF { get; set; } = 0; //Pedidos CG_ORDF
        public DateTime FE_CIERRE { get; set; } //Programa FE_CIERRE
        public int TIPOO { get; set; } = 0; //Pedidos TIPOO
        public int CG_TIRE { get; set; } = 0; //Pedidos CG_TIRE
        public string DES_CLI { get; set; } = ""; //Pedcli DES_CLI
        public string ORCO { get; set; } = ""; //Pedcli ORCO
        public string CG_ART { get; set; } = ""; //Pedcli CG_ART
        public string DES_ART { get; set; } = ""; //Pedcli DES_ART
        public string OBSERITEM { get; set; } = ""; //Pedcli OBSERITEM
        public string DIRENT { get; set; } = ""; //Pedcli DIRENT
    }
}
