namespace XDlol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            Console.WriteLine(model.car.Count);
            model.Afteryer(2016).ForEach(x => Console.WriteLine(x));
            model.StHp(200).ForEach(x => Console.WriteLine(x));
            if (model.IsBrand("Tesla"))
            {
                Console.WriteLine("Van benne");
            }
            else
            {
                Console.WriteLine("Nincs Benne");
            }
            if (model.loero(100))
            {
                Console.WriteLine("van");
            }
            else
            {
                Console.WriteLine("nincs");
            }

        }
    }
}
