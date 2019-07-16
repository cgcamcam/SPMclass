//main class
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
            CreateNewProject();
            CreateNewProject();
            PrintListProjects(listOfProjects);

            Console.ReadLine();


        }

        static void CreateNewProject()
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
             

        }

        static void PrintListProjects(List<Project> listOfProjects)

        {
            foreach (Project p in listOfProjects)
            {
                Console.WriteLine( p.projName, p.desc, p.owner); //why are these null?
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