﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tecidolandia.Models.Entities
{
    [Table("STATUS")]
    public class Status
    {
        [Key]
        [Column("ID_STATUS")]
        public Int64 IdStatus { get; set; }

        [Column("NM_STATUS")]
        [Display(Name = "Nome do Status")]
        public string NmStatus { get; set; }

        [Column("STATUS_VENDA")]
        [Display(Name = "Status da Venda")]
        public bool StatusVenda { get; set; }

    }
}