using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using ApiOrderServico.Domain.Entities;
using ApiOrderServico.Domain.Enum;

namespace TestOrderServico
{
    public class OrderService
    {
        [Fact]
        public void Deveria_Criar_Uma_Order_Service_Com_Status_Aberto()
        {
            var operadorAberturaId = Guid.NewGuid();
            var equipamentoId = Guid.NewGuid();

            var newOrderService = new OrdemServico(operadorAberturaId, equipamentoId);

            Assert.True(newOrderService.Status == OrdermStatusEnum.Aberto);            
        }
    }
}