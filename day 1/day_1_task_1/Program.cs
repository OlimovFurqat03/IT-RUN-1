using System.Text;

string filePath = @"store.txt";
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.Unicode;

while (true)
{
    string[] products = File.ReadAllLines("store.txt");
    Console.WriteLine(@"Выберите действие:
a) Показать список продуктов
b) Добавить новый продукт
с) Продать продукт");

    string action = Console.ReadLine();
    if (action == "a")
    {
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
    else if (action == "b")
    {
        Console.WriteLine("Вводите имя");
        string name = Console.ReadLine();

        Console.WriteLine("Вводите кол-во");
        int count = int.Parse(Console.ReadLine());


        bool productExists = false;
        for (int i = 0; i < products.Length; i++)
        {
            string product = products[i];
            var split = product.Split(' ');
            string nom = split[0];
            int countOfExisting = int.Parse(split[1]);
            if (name == nom)
            {
                count += countOfExisting;
                products[i] = $"{name} {count}";
                File.WriteAllLines("store.txt", products);
                productExists = true;
                break;
            }
        }

        if (productExists)
        {
            string[] newProducts = new string[products.Length + 1];
            for (int i = 0; i < newProducts.Length - 1; i++)
            {
                newProducts[i] = products[i];
            }
            newProducts[newProducts.Length - 1] = $"{name} {count}";
            File.WriteAllLines("store.txt", newProducts);
        }
    }
    else if (action == "c")
    {
        Console.WriteLine("Вводите имя");
        string name = Console.ReadLine();

        Console.WriteLine("Вводите кол-во");
        int count = int.Parse(Console.ReadLine());


        for (int i = 0; i < products.Length; i++)
        {
            var product = products[i];
            var split = product.Split(' ');
            string nom = split[0];
            int countOfExisting = int.Parse(split[1]);
            if (name == nom)
            {
                countOfExisting -= count;
                products[i] = $"{name} {countOfExisting}";
                File.WriteAllLines("store.txt", products);
                break;
            }
        }
    }
}