
namespace AB5_12_PRO
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var context = new Context())
			{
				var lieferkosten = new Lieferkosten
				{
					NameZone = "Bern",
					Preis = 10
				};

				var kunde = new Kunde
				{
					Name = "marco",
					Vorname = "pasa",
					Telefon = "123456789",
					Lieferkosten = lieferkosten
				};

				context.Lieferkosten.Add(lieferkosten);
				context.Kunden.Add(kunde);

				context.SaveChanges();
			}
		}
	}
}