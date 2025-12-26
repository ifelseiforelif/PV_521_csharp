using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace Less9_records_extensions.MyExt;

internal static class MyExtension
{
    public static void WelcomeStudent(this Student obj)
    {
        Console.WriteLine($"Welcome {obj.Surname} {obj.Name}!");
    }

    public static void MyUp(ref this int n, int value)
    {
        n+=value;
    }
}
