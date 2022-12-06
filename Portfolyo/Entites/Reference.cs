using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolyo.Entites
{
	public class Reference
	{
		public int Id { get; set; }
		public string FullName { get; set; }
		public string Major { get; set; }
		public string Message { get; set; }
        public string ImgUrl { get; set; }
	}
}
