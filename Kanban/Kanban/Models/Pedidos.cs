using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kanban.Shared.Models
{
    [Table("Pedidos")]
    public class Pedidos
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "PEDIDO")]
        public int PEDIDO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "REMITO")]
        public string REMITO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "FLAG ")]
        public int FLAG { get; set; } = 0;
    }
}
