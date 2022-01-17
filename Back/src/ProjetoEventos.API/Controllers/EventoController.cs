using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoEventos.API.Models;

namespace ProjetoEventos.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class EventoController : ControllerBase
	{
		public EventoController()
		{
			
		}
		
		public IEnumerable<Evento> _evento = new Evento[]
		{
			new Evento()
			{
				EventoId = 1,
				Tema = "Angular 11 e .Net 5",
				Local = "Belo Horizonte",
				Lote = "1º Lote",
				QtdPessoas = 250,
				DataEvento = DateTime.Now.AddDays(2).ToString(),
				ImagemURL = "foto.png"
			},
			new Evento()
			{
				EventoId = 2,
				Tema = "Angular 11 e .Net 5",
				Local = "Goiânia",
				Lote = "1º Lote",
				QtdPessoas = 250,
				DataEvento = DateTime.Now.AddDays(3).ToString(),
				ImagemURL = "foto.png"
			}
		};
		
		[HttpGet]
		public IEnumerable<Evento> Get()
		{
			return _evento;
		}
		
		[HttpGet("{id}")]
		public IEnumerable<Evento> Get(int id)
		{
			return _evento.Where(evento => evento.EventoId == id);
		}
		
		[HttpPost]
		public string Post()
		{
			return "Exemplo de POST";
		}
		
		[HttpPut("{id}")]
		public string Put(int id)
		{
			return $"Exemplo de Put id é: {id}";
		}
		
		[HttpDelete("{id}")]
		public string Delete(int id)
		{
			return $"Exemplo de Delete id é: {id}";
		}
	}
}
