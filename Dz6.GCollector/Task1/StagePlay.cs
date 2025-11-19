namespace Dz6.GCollector.Task1
{
    public class StagePlay(string name, string author, string genre, int year)
    {
        public string Name { get; } = name;
        public string Author { get; } = author;
        public string Genre { get; } = genre;
        public int Year { get; } =
            year > DateTime.Now.Year
                ? throw new ArgumentOutOfRangeException(nameof(year), "Год не может быть из будущего.")
                : year;

        public void Show()
        {
            Console.WriteLine("Начался показ пьесы");

            Thread.Sleep(Random.Shared.Next(1_000, 5_000));

            Console.WriteLine("Закончился показ пьесы");
        }

        public void ShowInfo()
        {
            string item = string.Format("Пеьсса: {0}, Автор: {1}, Жанр: {2}, Год: {3}", Name, Author, Genre, Year);
            Console.WriteLine(item);
        }

        ~StagePlay()
        {
            Console.WriteLine($"Class StagePlay has deleted");
        }
    }
}
