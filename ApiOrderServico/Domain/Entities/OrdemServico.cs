using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiOrderServico.Domain.Enum;

namespace ApiOrderServico.Domain.Entities
{
    public class OrdemServico
    {
        //public bool Ativo { get; set; }
        public Guid Id { get; private set; }
        public DateTime DataCadatro { get; private set; }
        public DateTime DataAtualizacao { get; private set; }
        public Guid OperadorAberturaId { get; private set; }
        public Guid OperadorFechamentoId { get; private set; }
         public Guid OperadorAnaliseId { get; private set; }
        public Guid EquipamentoId { get; private set; }
        public DateTime? DataFinalizacao { get; private set; }
        public OrdermStatusEnum Status { get; private set; }

        public OrdemServico( Guid operadorAberturaId, Guid equipamentoId)
        {
            Id = Guid.NewGuid();
            DataCadatro = DateTime.Now;
            DataAtualizacao = DateTime.Now;
            OperadorAberturaId = operadorAberturaId;
            EquipamentoId = equipamentoId;
            Status = OrdermStatusEnum.Aberto;
        }

        public void FinalizarOrdem(Guid operadorFechamentoId)
        {
            DataFinalizacao = DateTime.Now;
            OperadorFechamentoId = operadorFechamentoId;
            Status = OrdermStatusEnum.Fechado;
        }

        public void AnalisarOrdem(Guid operadorAnaliseId)
        {
            DataAtualizacao = DateTime.Now;
            OperadorAnaliseId = operadorAnaliseId;
            Status = OrdermStatusEnum.EmAnalise;
        }

        public OrdermStatusEnum ObterAndamentoOrderService(Guid ordemServicoId) => Status;
    }
}