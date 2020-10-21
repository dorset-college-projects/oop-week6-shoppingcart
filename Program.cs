using System;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Product Apple = new Product("Apples");
            Product Orange = new Product("Oranges");
           
            ShoppingCart cart = new ShoppingCart();
            cart.ProductList.Add(Apple);
            cart.ProductList.Add(Orange);
            cart.ProductList.Add(Orange);
            cart.ProductList.Add(Apple);
          

            Console.WriteLine("Total price : " + cart.TotalPrice());



            return;















            try
            {
                int zero = 0;
                int error = 100 / zero;

            } catch
            {

                Console.WriteLine("Exception was thrown"); // testiong
            }



            try
            {
                int[] array1 = new int[] { 1, 3, 5, 7, 9 };
                Console.WriteLine("Valule is " + array1[6]); // testiong

                int zero = 0;
                int error = 100 / zero;

            }
            catch (System.IndexOutOfRangeException )
            {

                Console.WriteLine("Index Exception thrown"); // testiong
            }
            catch (System.DivideByZeroException)
            {

                Console.WriteLine("Divide by zero Exception thrown"); // testiong
            }
            finally
            {

                Console.WriteLine("Moving on to next code"); // testiong
            }







            Console.WriteLine("Goodbye  World!"); // testiong
            
        }
    }
}
