using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

public class Project
{
    public string description;
    public static List<string> teamMembers = new List<string>();

    public Project(string projectName, string ownerName ) //constructor , List<string> teamMembers
    {
        string projName = projectName;
        string owner = ownerName;
        string desc = description;
        List<string> members = teamMembers;

    }

    public string projName
    {
        get;
         set;
    }

    public string desc
    {
        get;
         set;
    }

    public string owner
    {
        get;
         set;
    }

    public List<string>members
    {
        get;
        set;
    }

    static void AddTeamMembers(List<string> teamMembers)
    {

        Console.WriteLine("Enter new members");
        string newMember = Console.ReadLine();
        teamMembers.Add(newMember);
    }

    static void ChangeDescription(string description)
    {
        Console.WriteLine("Enter description");
        string newDesc = Console.ReadLine();
        description = newDesc;
    }

    static void ChangeProjName(string projName)
    {
        string newProj = Console.ReadLine();
        projName = newProj;
    }

    static void ChangeOwnerName(string owner)
    {
        string newOwner = Console.ReadLine();
        owner = newOwner;
    }


    static void ViewTeamMembers()
    {
        foreach (string member in teamMembers)
        {
            Console.WriteLine(member);
        }
    }
}
