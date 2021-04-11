using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiChurrasTrinca.Data
{
    public class Participante
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal ValorDeContribuicao { get; set; }

        [ForeignKey("IdChurrasco")]

        public int IdChurrasco { get; set; }
        [JsonIgnore]
        public virtual Churrasco Churrasco { get; set; }
    }
}
