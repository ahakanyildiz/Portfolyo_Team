using System.ComponentModel.DataAnnotations;

namespace Portfolyo.Entites
{
	public class About
	{
		//[Key] => Id dışında AboutId gibi bir prop tanımlarsak bu attribute sayesinde entity framework bunun primary key
		//ve identity specification özelliğini açar.
		public int Id { get; set; }
		public string AboutContent { get; set; }
		public string AboutTitle { get; set; }
		public string Details1 { get; set; }
		public string Details2 { get; set; }
		public DateTime BirthDate { get; set; }
		public string Website { get; set; }
		public string Phone { get; set; }
		public string City { get; set; }
		public string Graduation { get; set; }
		public string Email { get; set; }
		public bool Freelance { get; set; }
	}
}
