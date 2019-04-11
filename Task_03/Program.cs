using System;
using System.Collections.Generic;

namespace TaskThree
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> ActionType = new List<string>
            {
                "Create",
                "Read",
                "Update",
                "Delete"
            };
            string Search = ActionType.Find((x) => x == "Create");
            Console.WriteLine(Search);
            Console.ReadKey();
        }
    }
}


/*using System;
namespace TaskThree
{

    /// Задача - перепишите данный код так, чтобы он работал через коллекции C#, вместо конструкции switch


    public enum ActionType
    {
        Create,

        Read,

        Update,

        Delete

    }

    class Program
    {
        static void Main(string[] args)
        {
            var type = ActionType.Read;
            if (type == ActionType.Create)
                CreateMethod(type);
            else if (type == ActionType.Read)
                ReadMethod(type);
            else if (type == ActionType.Update)
                UpdateMethod(type);
            else if (type == ActionType.Delete)
                DeleteMethod(type);
        }
        private static void CreateMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
            Console.ReadKey();
        }

        private static void ReadMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
            Console.ReadKey();
        }

        private static void UpdateMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
            Console.ReadKey();
        }

        private static void DeleteMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
            Console.ReadKey();
        }
    }
} */
