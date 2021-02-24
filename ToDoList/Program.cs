using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("MAIN MENU");
      Console.WriteLine("Enter 'A' to add a task, 'V' to view all tasks, or 'Q' to quit");
      string userInput = Console.ReadLine().ToUpper();
      switch (userInput)
      {
        case "A":
          Console.WriteLine("Enter task to add");
          string task = Console.ReadLine();
          Item newItem = new Item(task);
          Main();
          break;

        case "V":
          List<Item> allItems = Item.GetAll();
          foreach (Item thisItem in allItems)
          {
            Console.WriteLine(thisItem.Description);
          }
          Main();
          break;

        case "Q":
          Console.WriteLine("Good Bye!");
          break;

        default:
          Console.WriteLine("Please enter a valid input");
          Main();
          break;
      }
    }
  }
}
