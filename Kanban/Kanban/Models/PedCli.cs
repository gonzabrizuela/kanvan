using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kanban.Shared.Models
{
    [Table("PedCli")]
    public class PedCli
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "PEDIDO")]
        public int PEDIDO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "DES_CLI")]
        public string DES_CLI { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "ORCO")]
        public string ORCO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "CG_ART")]
        public string CG_ART { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "DES_ART")]
        public string DES_ART { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "OBSERVITEM")]
        public string OBSERVITEM { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "DIRENT")]
        public string DIRENT { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "CG_ESTADO")]
        public string CG_ESTADO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "CG_ESTADPEDCLI")]
        public int CG_ESTADPEDCLI { get; set; } = 0;
    }
}
