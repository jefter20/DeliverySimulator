using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliverySimulator.API.Models
{
    public class Pedido
    {
    public int PedidoId { get; set; }

    public string NomeProduto { get; set; }

    public int QtdProduto { get; set; }

    public bool Prioridade { get; set; }

    public DateTime DataHorario { get; set; }
    }
}