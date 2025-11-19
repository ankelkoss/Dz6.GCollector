using Dz6.GCollector.Task1;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        StagePlay stagePlay = new StagePlay("Ревизор", "Николай Гоголь", "Комедия", 1836);

        stagePlay.ShowInfo();
        stagePlay.Show();
    }
}