using System.Collections.Generic;
using static Robotname.Program;
namespace Robotname
{
    internal class Program
    {
   
        public class Robot
            {
                private static HashSet<string> usedNames = new HashSet<string>();
                private static Random random = new Random();
                private string name;
                public string Name
                {
                    get
                    {
                        if (name == null)
                        {
                            do
                            {
                                name = $"{(char)('A' + random.Next(26))}{(char)('A' + random.Next(26))}{random.Next(1000):D3}";
                            }
                            while (usedNames.Contains(name));
                            usedNames.Add(name);
                        }
                        return name;
                    }
                }
                public void Reset()
                {
                    usedNames.Remove(name);
                    name = null;
                }
            }
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            Console.WriteLine(robot.Name); 
            robot.Reset();
            Console.WriteLine(robot.Name);
            
        }
    }
}
