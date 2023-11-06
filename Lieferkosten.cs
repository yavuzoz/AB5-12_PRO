using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AB5_12_PRO
{
	class Lieferkosten
	{
		public Lieferkosten() { }
		
			public int ID { get; set; }
			public string NameZone { get; set; }
			public float Preis { get; set; }
			public ICollection<Kunde> Kunden { get; set; }
	}
}
