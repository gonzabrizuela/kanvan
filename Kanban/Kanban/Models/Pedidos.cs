﻿using System;
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
        public int REGISTRO { get; set; } = 0;//
        public int PEDIDO { get; set; } = 0;//
        public string REMITO { get; set; } = "";//
        public int FLAG { get; set; } = 0;//

        public int CG_ORDF { get; set; } = 0;

        public int TIPOO { get; set; } = 0;//

        public int CG_TIRE { get; set; } = 0;//





    }
}
