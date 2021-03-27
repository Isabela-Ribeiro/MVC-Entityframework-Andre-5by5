using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProjMVCdois.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        [DisplayName("Sabor")]
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}