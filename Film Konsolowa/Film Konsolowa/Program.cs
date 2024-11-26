internal class Program
{
    class Film
    {
        protected string tytul;
        protected int liczbaWypozyczen;
        public Film()
        {
            tytul = "";
            liczbaWypozyczen = 0;
        }
        public void SetTytul(string nowyTytul)
        {
            if (nowyTytul.Length <= 20)
            {
                tytul = nowyTytul;
            }
            else
            {
                Console.WriteLine("Tytuł może mieć maksymalnie 20 znaków");
            }
        }
        public string GetTytul()
        {
            return tytul;
        }
        public void zwiekszLiczbeWypozyczen()
        {
            liczbaWypozyczen++;
        }
        public int getLiczbaWypozyczen()
        {
            return liczbaWypozyczen;
        }
    }
    private static void Main(string[] args)
    {
        Film film1 = new Film();
        Console.WriteLine("Tytuł: " + film1.GetTytul());
        Console.WriteLine("Liczba wypożyczeń: " + film1.getLiczbaWypozyczen());

        film1.SetTytul("Titanic");
        Console.WriteLine("Nowy tytul: " + film1.GetTytul());

        Console.WriteLine("Pobrany tytuł: " + film1.GetTytul());
        Console.WriteLine("Liczba wypożyczeń: " + film1.getLiczbaWypozyczen());
        film1.zwiekszLiczbeWypozyczen();
        Console.WriteLine("Liczba wypożyczeń: " + film1.getLiczbaWypozyczen());

        Console.ReadKey();
    }
}