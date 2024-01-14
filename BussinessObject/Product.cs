using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
	public class Product
	{
		public int ProductId { get; set; }
		public int CategoryId { get; set; }
		public string ProductName { get; set; } = string.Empty;
		public string Weight { get; set; } = string.Empty;
		public SqlMoney UnitPrice { get; set; }
		public int UnitsIsStock { get; set; }

	}
}
