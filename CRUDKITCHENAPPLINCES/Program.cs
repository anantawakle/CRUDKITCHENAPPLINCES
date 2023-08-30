using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDKITCHENAPPLINCES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            KitchenapplincesCRUD crud=new KitchenapplincesCRUD();
            do
            {
                Console.WriteLine("__________________________________");
                Console.WriteLine("1.Kitchenapplinces List");
                Console.WriteLine("2.Get Kichenapplinces by id");
                Console.WriteLine("3.Add kichenapplinces");
                Console.WriteLine("4.Update kitchenapplinces");
                Console.WriteLine("5.Delet kitchenapplinces");
                Console.WriteLine("Select your option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        List<Kitchenapplinces> list = crud.GetKitchenapplinces();
                        Console.WriteLine("Id\t Name\t Price\t Company");
                        foreach (Kitchenapplinces kichenapplinces in list)
                        {
                            Console.WriteLine($"{kichenapplinces.Id} \t {kichenapplinces.Name} \t {kichenapplinces.Price}\t {kichenapplinces.Company} ");

                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the kitchenapplinces id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Kitchenapplinces k = crud.GetKitchenapplincesById(id);
                        Console.WriteLine("Id\t Name\t price\t company");
                        Console.WriteLine($" {k.Id} {k.Name} {k.Price} {k.Company} ");
                        break;
                    case 3:
                        Kitchenapplinces k1 = new Kitchenapplinces();
                        Console.WriteLine("Enter the id");
                        k1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the name");
                        k1.Name = Console.ReadLine();
                        Console.WriteLine("Enter the price");
                        k1.Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the company");
                        k1.Company = Console.ReadLine();
                        crud.AddKitchenapplinces(k1);
                        Console.WriteLine("Kitchenapplinces save");
                        break;
                    case 4:
                        Kitchenapplinces k2 = new Kitchenapplinces();
                        Console.WriteLine("Enter theid");
                        k2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the name ");
                        k2.Name = Console.ReadLine();
                        Console.WriteLine("Enter the price");
                        k2.Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the company");
                        k2.Company = Console.ReadLine();
                        crud.UpdateKitchenapplinces(k2);
                        Console.WriteLine("Kitchenapplinces update");
                        break;
                    case 5:
                        Console.WriteLine("Enter the id");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        crud.DeletKichenapllinces(id2);
                        Console.WriteLine($"{id2} kitchenapplinces delet");
                        break;
                }
                Console.WriteLine("Press 1 for continue");
                no = Convert.ToInt32(Console.ReadLine());
            }
            while (no == 1);
        }
    }
}
