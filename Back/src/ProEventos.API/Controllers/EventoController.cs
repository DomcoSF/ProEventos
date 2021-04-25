using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                EventId = 1,
                Tema = "Angular",
                Local = "BH",
                Lote = "1 Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "Foto.pnj"
            },
            new Evento(){
                EventId = 2,
                Tema = "Teste 2",
                Local = "SP",
                Lote = "2 Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString(),
                ImagemURL = "Foto2.pnj"
            }
        };  
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()  
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }
        
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete id = {id} ";
        }
    }
}
