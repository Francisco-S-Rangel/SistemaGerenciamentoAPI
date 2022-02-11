using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Provedor2.WebAPI.Models
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Nome { get; set; }
        public string Foto { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string RG { get; set; } 
        public int DepartamentoId { get; set; }
    }
}
