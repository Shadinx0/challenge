using System;

public class Test
{
    enum ChestState
    {
        Locked,
        Closed,
        Open
    }

    public static void Main()
    {
        Console.WriteLine("Commands: lock, unlock, open, close, exit");

        ChestState current = ChestState.Locked;
        Console.WriteLine("The chest is Locked. What do you want to do?");

        while (true)
        {
            string S = Console.ReadLine();

            if (current == ChestState.Locked && S == "unlock")
            {
                Console.WriteLine("You unlocked the chest.");
                current = ChestState.Closed;
                Console.WriteLine("The chest is Closed. What do you want to do?");
            }
            else if (current == ChestState.Closed && S == "open")
            {
                Console.WriteLine("You opened the chest.");
                current = ChestState.Open;
                Console.WriteLine("The chest is Open. What do you want to do?");
            }
            else if (current == ChestState.Open && S == "close")
            {
                Console.WriteLine("You closed the chest.");
                current = ChestState.Closed;
                Console.WriteLine("The chest is Closed. What do you want to do?");
            }
            else if (current == ChestState.Closed && S == "lock")
            {
                Console.WriteLine("You locked the chest.");
                current = ChestState.Locked;
                Console.WriteLine("The chest is Locked. What do you want to do?");
            }
            else if (S == "exit")
            {
                Console.WriteLine("Exiting Chest program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid command. Please try again.");
            }
        }
    }
}
