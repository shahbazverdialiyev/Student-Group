using Student_Group.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Contents.Groups=new List<Group>();
        Console.WriteLine("1. Group Menu\r\n2. Student Menu\r\n0. Exit");
        Console.WriteLine(">>>  ");
        string command = Console.ReadLine();
        while (command != "0")
        {
            if (command == "1")
            {
                Console.WriteLine("---- Group Menu ----");
                Console.WriteLine("1. Create Group\r\n 2. Delete Group\r\n 3. Update Group\r\n4. showallGroup \r\n0. Back");
                while (command != "0")
                {
                    Console.Write(">>>  ");
                    command = Console.ReadLine();
                    switch (command)
                    {
                        case "1":
                            Console.Write("Name: ");
                            Contents.Groups.Add(new Group(Console.ReadLine()));
                            Console.WriteLine("created group");
                            break;
                        case "2":
                            Contents.Groups.Remove(FindGroupById(Contents.Groups));
                            Console.WriteLine("deleted group");
                            break;
                        case "3":
                            Group group=FindGroupById(Contents.Groups);
                            Console.WriteLine("Name: ");
                            group.Name = Console.ReadLine();
                            Console.WriteLine("updated group");
                            break;
                        case "4":
                            Console.WriteLine("GROUPS: ");
                            Contents.Groups.ForEach(g => Console.WriteLine(g.Name));
                            break;
                        default:
                            Console.WriteLine("Yuxardaki komandalardan birini yazin");
                            break;
                    }
                }
            }
            
        }
    }
    private static Group FindGroupById(List<Group> groups)
    {
        int id;
        while (true)
        {
            Console.Write("Id: ");
            if (!(Int32.TryParse(Console.ReadLine(), out id)))
            {
                Console.WriteLine("Eded daxil edin!");
                continue;
            }
            Group group = Contents.Groups.Find(g => g.Id == id);
            if (group == null)
            {
                Console.WriteLine("Group tapilmadi!");
            }
            return group;
            break;
        }
    }
}
