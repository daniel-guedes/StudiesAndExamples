using Microsoft.EntityFrameworkCore;

namespace MiniToDo.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<ToDo> Todos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options) 
			=> options.UseSqlite("DataSource=app.db;Cache=Shared");
	}
}
