using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliverySimulator.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DeliverySimulator.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        public IEnumerable<Pedido> _pedido = new Pedido[]{
                new Pedido(){
                    PedidoId = 1,
                    NomeProduto = "Esfiha de Carne",
                    QtdProduto = 10,
                    Prioridade = false,
                    DataHorario = DateTime.Now 
                },

                new Pedido(){
                    PedidoId = 2,
                    NomeProduto = "Esfiha de Queijo",
                    QtdProduto = 5,
                    Prioridade = false,
                    DataHorario = DateTime.Now
                }
            };
        
        public PedidoController()
        {
         
        }

        [HttpGet]
        public IEnumerable<Pedido> Get()
        {
            return _pedido;
        }

        [HttpGet("{id}")]
        public IEnumerable<Pedido> GetById(int id)
        {
            return _pedido.Where(x => x.PedidoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Post da controller";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Put da controllher = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Delete da controller = {id}";
        }
    }
}
