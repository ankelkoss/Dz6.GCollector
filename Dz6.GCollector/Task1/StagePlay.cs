using Dz6.GCollector.Task2;

namespace Dz6.GCollector.Task1
{
    public class StagePlay(string name, string author, string genre, int year) : IDisposable
    {
        public string Name { get; } = name;
        public string Author { get; } = author;
        public string Genre { get; } = genre;
        public int Year { get; } =
            year > DateTime.Now.Year
                ? throw new ArgumentOutOfRangeException(nameof(year), "Год не может быть из будущего.")
                : year;

        private bool disposed = false;

        public void Show()
        {
            if (disposed)
                throw new ObjectDisposedException(nameof(StagePlay));

            Console.WriteLine("Начался показ пьесы");

            Thread.Sleep(Random.Shared.Next(1_000, 5_000));

            Console.WriteLine("Закончился показ пьесы");
        }

        public void ShowInfo()
        {
            if (disposed)
                throw new ObjectDisposedException(nameof(StagePlay));

            string item = string.Format("Пеьсса: {0}, Автор: {1}, Жанр: {2}, Год: {3}", Name, Author, Genre, Year);
            Console.WriteLine(item);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
                Console.WriteLine($"Class StagePlay: {Name} has been disposed");

            disposed = true;
        }

        ~StagePlay()
        {
            Console.WriteLine($"Class StagePlay has deleted");
            Dispose(false);
        }
    }
}
