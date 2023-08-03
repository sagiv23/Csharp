using System;
class HelloWorld {
  static void Main() {
    bool True_False;
    bool True_False_While = true;

    while(True_False_While)
    {
      Console.WriteLine("Hello! Welcome to our company! Write:");
      Console.WriteLine("1 - customer service.");
      Console.WriteLine("2 - cancel order.");
      Console.WriteLine("3 - problem with product.");
      Console.WriteLine("4 - talk directly to the manager.\n");
      int number = int.Parse(Console.ReadLine());

      switch (number)
      {
        case 1:
          Console.Write("Are you sure you want to speak to customer service? Write true/false: ");
          True_False = bool.Parse(Console.ReadLine());

          switch (True_False)
          {
            case true:
              Console.WriteLine("Ok, connecting to customer service.");
              True_False_While = false;
              break;

            case false:
              Console.WriteLine("");
              break;
          }

          break;
        
        case 2:
          Console.Write("Are you sure you want to cancel the order? Write true/false: ");
          True_False = bool.Parse(Console.ReadLine());

          switch (True_False)
          {
            case true:
              Console.WriteLine("OK, canceling the order.");
              True_False_While = false;
              break;

            case false:
              Console.WriteLine("");
              break;
          }

          break;

        case 3:
          Console.Write("Are you sure you want to report a product problem? Write true/false: ");
          True_False = bool.Parse(Console.ReadLine());
          
          switch (True_False)
          {
            case true:
              Console.WriteLine("Ok, reporting the product.");
              True_False_While = false;
              break;

            case false:
              Console.WriteLine("");
              break;
          }

          break;

        case 4:
          Console.Write("Are you sure you want to speak directly to the manager? Write true/false: ");
          True_False = bool.Parse(Console.ReadLine());
          
          switch (True_False)
          {
            case true:
              Console.WriteLine("OK, waiting for the manager.");
              True_False_While = false;
              break;

            case false:
              Console.WriteLine("");
              break;
          }

          break;
        
        default:
          Console.WriteLine("Pls Write a number between 1 - 4");
          Console.WriteLine("");
          break;
      }
    }
    
  }
}
