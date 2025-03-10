namespace Inventory_Management_System
{
    internal class Program
    {
        const int MAX_SIZE = 50;
        static string[,] inventory = new string[MAX_SIZE, 3];
        static int size = 0;
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to The inventory system (^_^)");
            Console.WriteLine("------------------------------");

            while (true)
            {
                Console.WriteLine("1 . Add product");
                Console.WriteLine("2 . Update product");
                Console.WriteLine("3 . View product");
                Console.WriteLine("4 . Exit\n");
                Console.WriteLine("Enter Your Choice");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Enter Valid Option");
                    continue;
                }

                switch (choice)
                {
                    case 1:// Add Product
                        AddProduct();
                        break;
                    case 2: // Update Product
                        UpdateProduct();
                        break;
                    case 3: //view Prouduct(Id,quantity,Price)
                        ViewProducts();
                        break;
                    case 4:// Exit
                        return;
                    default:
                        Console.WriteLine("Value between 1 to 4");
                        break;

                }
            }
        }
        private static void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter Product Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Product Quantity");
            string quantity = Console.ReadLine();

            Console.WriteLine("Enter Product price");
            string price = Console.ReadLine();
            inventory[size, 0] = name;
            inventory[size, 1] = quantity;
            inventory[size, 2] = price;
            size++;
            Console.WriteLine("Product Added");
        }

        private static void ViewProducts()
        {
            Console.Clear();
            Console.WriteLine("Name   quantity   price");
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    
                    Console.Write(inventory[i,j]+"       ");
                }
                Console.WriteLine();
            }
        }

        private static void UpdateProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter Id Of product");
            if(!int.TryParse(Console.ReadLine(),out int id))
            {
                Console.WriteLine("Invalid Id");
                return;
            }
            if(id<0 || id >= size)
            {
                Console.WriteLine("Id Not Found");
                return;
            }

            Console.WriteLine("Enter Product Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Product Quantity");
            string quantity = Console.ReadLine();

            Console.WriteLine("Enter Product price");
            string price = Console.ReadLine();
            inventory[id, 0] = name;
            inventory[id, 1] = quantity;
            inventory[id, 2] = price;
            Console.WriteLine("Product Updated");
        }
    }
}
