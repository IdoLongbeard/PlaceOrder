using System;
using PlaceOrder.Entities;
using PlaceOrder.Enums;

namespace PlaceOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrar com dados do cliente:

            Console.WriteLine("Enter client data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birthdate: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            //Instanciar o objeto cliente com os dados fornecidos;
            Client client = new Client(name, email, birthDate);
            

            //entrar com dados do pedido;

            Console.WriteLine("Enter order data: ");

            Console.WriteLine("Status: ");

            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many items to this order?");
            int quantityItems = int.Parse(Console.ReadLine());


            for(var i = 0; i <= quantityItems; i++)
            {
                Console.WriteLine("Enter item #" + i + " data:");
                Console.WriteLine("Product Name: ");

                string productName = Console.ReadLine();

                Console.WriteLine("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice, productQuantity);

                OrderItem orderItem = new OrderItem(quantityItems, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.Write( "ORDER SUMMARY: ");
            Console.WriteLine(order);
            
            
        }
    }
}
