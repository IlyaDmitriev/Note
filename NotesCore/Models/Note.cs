using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.Models
{
	public class Note
	{
		public int Id { get; set; }
		public string NoteText { get; set; }
		public DateTime CreationDate { get; set; }
		public bool DeleteAfterRead { get; set; }

		public string UserName { get; set; }

		public int? HoursDeleting { get; set; }

		public int? MinutesDeleting { get; set; }

		public int? DaysDeleting { get; set; }

		public string GuidNote { get; set; }
		public string Weee { get; set; }
	}
}
