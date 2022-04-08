namespace tpmodul7_1302204047
{
    public class Program
    {
        public static void Main()
        {
            CovidConfig config = new CovidConfig();
            config.ReadJSON();
            config.WriteJSON();

            Console.WriteLine("Berapa suhu badan anda?");
            Console.ReadLine();
            Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam");
        }
    }
}