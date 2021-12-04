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
        public IEnumerable<evento> _evento = new evento[] {
                new evento() {
                    EventoID = 1,
                    Tema = "Angular 11 e .NET 5",
                    Local =  "Belo Horizonte",
                    Lote = "1° Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
                },
                new evento() {
                    EventoID = 2,
                    Tema = "Angular e Suas Novidades",
                    Local =  "São Paulo",
                    Lote = "2° Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto1.png"
                },
            };

        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<evento> Get()
        {
            return _evento;
        }
        [HttpGet("{id}")]
        public IEnumerable<evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoID == id);
        }

        [HttpPost]
        public string Post()
        {
            return "exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"exemplo de put {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"exemplo de Delete com id = {id}";
        }
    }
}
