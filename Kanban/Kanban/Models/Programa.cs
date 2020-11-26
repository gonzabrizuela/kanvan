using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kanban
{
    public class Programa
    {
        [Key]
        public int REGISTRO { get; set; } = 0;
        public int PEDIDO { get; set; } = 0;
    }
}
