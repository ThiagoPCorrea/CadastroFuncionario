using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadastroFuncionario.Models
{
    public class Base
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public DateTime DataInsert { get; set; }

        public DateTime? DataUpdate { get; set; }

        public Base()
        {
            this.DataInsert = DateTime.Now;
        }
    }
}