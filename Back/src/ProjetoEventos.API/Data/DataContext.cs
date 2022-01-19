using System;
using Microsoft.EntityFrameworkCore;
using ProjetoEventos.API.Models;

namespace ProjetoEventos.API.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
			
		}
		
		public DbSet<Evento> Eventos { get; set; }
	}
}