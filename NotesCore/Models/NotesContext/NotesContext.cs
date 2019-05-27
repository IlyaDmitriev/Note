using Microsoft.EntityFrameworkCore;

namespace Notes.Models
{
	public class NotesContext : DbContext
	{
		public DbSet<Note> Notes { get; set; }
		public NotesContext(DbContextOptions<NotesContext> options) : base(options)
		{
			Database.EnsureCreated();
		}
	}
}
