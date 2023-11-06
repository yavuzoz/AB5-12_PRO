using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB5_12_PRO
{
	internal class Kunde
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Vorname { get; set; }
		public string Telefon { get; set; }
		public int LieferkostenID { get; set; }
		public Lieferkosten Lieferkosten { get; set; }
	}
}
