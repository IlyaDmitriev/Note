using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Notes.Models;

namespace Notes.Controllers
{
	public class HomeController : Controller
	{
		private NotesContext db;
		public HomeController(NotesContext context)
		{
			db = context;
		}

		[HttpPost]
		public IActionResult Create(Note note)
		{
			note.CreationDate = DateTime.Now;
			var guid = Guid.NewGuid().ToString();
			note.GuidNote = guid;
			db.Notes.Add(note);
			db.SaveChanges();

			return View("Create", guid);
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult GetNotes(string noteGuid)
		{
			var note = db.Notes.FirstOrDefault(x => x.GuidNote == noteGuid);
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
