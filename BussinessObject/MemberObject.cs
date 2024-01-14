using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
	public class MemberObject
	{
		public int MemberId { get; set; }
		public string Email { get; set; } = string.Empty;
		public string CompanyName { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
		public string Country { get; set; } = string.Empty;
		public string? Password { get; set; } = string.Empty;
	}
}
