using Dz6.GCollector.Task1;
using Dz6.GCollector.Task2;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Task1();

        Task2();
    }

    static void Task1()
    {
        using (StagePlay stagePlay = new StagePlay("Ревизор", "Николай Гоголь", "Комедия", 1836))
        {
            stagePlay.ShowInfo();
            stagePlay.Show();
        }

        Console.WriteLine();
        Console.WriteLine("Нажмите любую клавишу, чтобы протестировать using Dispose");
        Console.ReadKey(true);
        Console.WriteLine();

        StagePlay stagePlay2 = new StagePlay("Наталка Полтавка", "Іван Котляревський", "Комедія", 1819);
        stagePlay2.ShowInfo();

        stagePlay2.Dispose();

        try
        {
            stagePlay2.Show();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine();
        Console.WriteLine("Нажмите любую клавишу для завершения...");
        Console.ReadKey(true);
    }

    static void Task2()
    {
        using (var groceryStore = new Store("АТБ", "м. Київ, вул. Хрещатик, 10", StoreTypeEnum.Grocery))
        {
            groceryStore.PrintInfo();
            groceryStore.ChangeAddress("м. Київ, вул. Хрещатик, 12");
            groceryStore.PrintInfo();
        }

        Console.WriteLine();
        Console.WriteLine("Нажмите любую клавишу, чтобы протестировать using Dispose");
        Console.ReadKey(true);
        Console.WriteLine();

        var clothingStore = new Store("ZARA", "м. Львів, пл. Ринок, 3", StoreTypeEnum.Clothing);
        clothingStore.PrintInfo();

        clothingStore.Dispose();

        try
        {
            clothingStore.PrintInfo();
        }
        catch (ObjectDisposedException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine();
        Console.WriteLine("Нажмите любую клавишу для завершения...");
        Console.ReadKey(true);
    }
}