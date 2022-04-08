using System.Text.Json;
using System.Diagnostics;

namespace class CovidConfig
{
	public CovidConfig()
	{
		public string CONFIG1 { get; set; } = "celcius";
        public int CONFIG2 { get; set; } = 14;
        public string CONFIG3 { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
        public string CONFIG4 { get; set; } = "Anda dipersilahkan untuk masuk ke dalam gedung ini";

        public string satuan_suhu { get; set; }
        public int batas_hari_demam { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

		public void ReadJSON()
		{
			string jsonString = File.ReadAllText("covid_config.json");
			CovidConfig jsonData = JsonSerializer.Deserialize<CovidConfig>(jsonString);

			this.satuan_suhu = jsonData.satuan_suhu;
			this.batas_hari_demam = jsonData.batas_hari_demam;
			this.pesan_ditolak = jsonData.pesan_ditolak;
			this.pesan_diterima = jsonData.pesan_diterima;
		}

		public void UbahSatuan() 
		{
		if (CONFIG1 == "Celcius") ;
			else if (CONFIG1 == "fahrenheit");
			
		}
	}
}