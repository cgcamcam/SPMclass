using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM
{
    class Program
    {
        static List<Project> listOfProjects = new List<Project>();
   
        static void Main(string[] args)
        {
            Project x = CreateNewProject();
            Project y = CreateNewProject();
            PrintListProjects(listOfProjects);
            
            Console.ReadLine();
           
            
        }

        static Project CreateNewProject()
        {

            Console.WriteLine("Create a new project");
            Console.WriteLine("Enter Project Name");
            string a = Console.ReadLine();
            Console.WriteLine("Enter Desc");
            string b = Console.ReadLine();
            Console.WriteLine("Enter owner name");
            string c = Console.ReadLine();

            Project newProj = new Project(a, b, c);
            listOfProjects.Add(newProj);
            return newProj;

        }

        static void PrintListProjects(List<Project> listOfProjects)

        {
            foreach (Project p in listOfProjects)
            {
                Console.WriteLine("{0} {1} {2}", );
            }
        }


        static void PrintMenu()
        {
            Console.WriteLine("Press f to make new project");
            Console.WriteLine("press h to view a project");
            //if they press a certain button, we'll activate a function

        }
    }
}
