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
        public void CreateOrdemServico_StatusEhAberto()
        {
            // Arange
            var operadorAberturaId = Guid.NewGuid();
            var equipamentoId = Guid.NewGuid();

            //Act
            var newOrderService = new OrdemServico(operadorAberturaId, equipamentoId);

            //Assert
            Assert.True(newOrderService.Status == OrdermStatusEnum.Aberto);            
        }
        [Fact]
        public void FinalizarOrdem_StatusEhFechado()
        {
            // Arange
            var operadorAberturaId = Guid.NewGuid();
            var operadorFechamentoId = Guid.NewGuid();
            var equipamentoId = Guid.NewGuid();
            var newOrderService = new OrdemServico(operadorAberturaId, equipamentoId);

            //Act
            newOrderService.FinalizarOrdem(operadorFechamentoId);

            //Assert
            Assert.True(newOrderService.Status == OrdermStatusEnum.Fechado);            
        }
    }
}