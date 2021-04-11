using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiChurrasTrinca.Data
{
    public class Churrasco
    {
        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string Observacao { get; set; }

        public DateTime Data { get; set; }

        public decimal ValorSugeridoPorParticipante { get; set; }

        public decimal ValorSugeridoPorParticipanteComBebida { get; set; }

        public virtual ICollection<Participante> Participantes { get; set; }

        public int TotalParticipantes { get { return this.Participantes.Count; } }

        public decimal ValorTotalArrecadado { get { return this.Participantes.Sum(p => p.ValorDeContribuicao); } }
    }
}
