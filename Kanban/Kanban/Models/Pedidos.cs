using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kanban
{
    [Table("Pedidos")]
    public class Pedidos
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PEDIDO { get; set; } = 0;
        public string REMITO { get; set; } = "";
        public int FLAG { get; set; } = 0;
    }
}
