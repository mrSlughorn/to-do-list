namespace to_do_list
{
    // My first To-Do list (for practice)
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            List<string> Tasks = new List<string>();

            while (input != "4")
            {

                listMenu(); // The menu for the list
                input = Console.ReadLine();


                if (input == "1")
                {
                    while (true)
                    {

                        Console.Write("Add new task or type 'done' to get back to the menu: ");
                        input = Console.ReadLine();

                        if (input.ToLower() == "done") // if input is "done" with upper or lowercase
                        {
                            break;
                        }
                        else
                        {
                            Tasks.Add(input);
                        }

                    }
                }
                else if (input == "2")
                {
                    if (Tasks.Count == 0) // if there is no element in the list
                    {
                        Console.WriteLine("There are no tasks yet.");
                    }

                    else
                    {

                        Console.WriteLine("\n");
                        getListItems();

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("\n" + "Type 'done' to get back to the menu");
                                Console.Write("Enter number to delete task: ");
                                input = Console.ReadLine();
                                if (input.ToLower() == "done")
                                {

                                    break;
                                }

                                int answer = int.Parse(input);
                                Tasks.RemoveAt(answer);

                                Console.WriteLine("\n");
                                getListItems();
                            }
                            catch (FormatException ex) // this happens if the user writes something that isn't a integer
                            {
                                Console.WriteLine($"Error: Enter a valid number. {ex.Message}");
                            }
                            catch (ArgumentOutOfRangeException ex) // this happens if the user writes a number(task) that isn't in the list, for instance if the user writes 4 and there's only 2 tasks.
                            {
                                Console.WriteLine($"Error: There is no task to that number. {ex.Message}");
                            }


                        }

                    }


                }

                else if (input == "3")
                {
                    if (Tasks.Count == 0)
                    {
                        Console.WriteLine("There are no tasks yet.");
                    }
                    else
                    {
                        Console.WriteLine("\n");
                        getListItems();
                    }

                }


                void listMenu() // Function that writes out the To-Do list menu
                {
                    Console.WriteLine("\n" + "To-Do List" + "\n" + new string('-', 31));
                    Console.WriteLine("1. Add tasks" + "\n" + "2. Delete tasks" + "\n" + "3. Show all tasks" + "\n" + "4. Exit the list" + "\n" + new string('-', 31));
                    Console.Write("Enter number: ");
                }

                void getListItems() // Function that shows all the tasks that are currently in the list
                {
                    int taskNmb = 0;

                    foreach (string Task in Tasks)
                    {
                        Console.WriteLine(taskNmb + ". " + Task);
                        taskNmb++;
                    }

                }
            }

        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
}
