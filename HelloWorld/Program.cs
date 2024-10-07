namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
           {
            // Pyydetään käyttäjää syöttämään merkkijono
            Console.WriteLine("Anna merkkijono, jossa on kirjaimia ja numeroita: ");
            string syote = Console.ReadLine();

            // Lasketaan kuinka monta lukua ja kirjainta syötteessä on
            int kirjainMaara = 0;
            int numeroMaara = 0;

            foreach (char merkki in syote)
            {
                if (char.IsLetter(merkki))
                {
                    kirjainMaara++;
                }
                else if (char.IsDigit(merkki))
                {
                    numeroMaara++;
                }
            }

            // Tulostetaan tulokset
            Console.WriteLine($"Kirjainten määrä: {kirjainMaara}");
            Console.WriteLine($"Numeroiden määrä: {numeroMaara}");
        }


    }
}
