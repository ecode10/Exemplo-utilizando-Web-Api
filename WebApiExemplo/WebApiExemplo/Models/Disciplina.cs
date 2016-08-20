using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiExemplo.Models
{
    public class Disciplina
    {
        [Key]
        public System.Int64 idDisc { get; set; }

        public string DescricaoDisc { get; set; }
    }
}