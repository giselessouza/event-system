using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEventos.DAL
{
		public class RepositorioComum<T> where T : EntidadeBancoBase, new()
		{
			public T Inserir(T modelo)
			{
				using (var db = new SistemaDeEventosContext())
				{
					db.ChangeTracker.AutoDetectChangesEnabled = false;

					db.Set<T>().Add(modelo);

					db.SaveChanges();

					return modelo;
				}
			}

			public List<T> Listar()
			{
				using (var db = new SistemaDeEventosContext())
				{
					return db.Set<T>().Where(x => !x.FlagExcluido).ToList();
				}
			}

			public void Excluir(T modelo)
			{
				using (var db = new SistemaDeEventosContext())
				{
					modelo.FlagExcluido = true;
					Atualizar(modelo);
				}
			}

			public T Atualizar(T modelo)
			{
				using (var db = new SistemaDeEventosContext())
				{
					db.ChangeTracker.AutoDetectChangesEnabled = false;

					db.Entry(modelo).State = EntityState.Modified;

					db.SaveChanges();

					return modelo;
				}
			}
	}
}
