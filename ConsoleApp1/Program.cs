using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            user user1 = new user(); 
            user1.firstName = "Max";
            user1.lastName = "Cubero";
            user1.address = "SFS";
            user1.gender = "Male";
            user1.age = 24;

            user user2 = new user();
            user2.firstName = "Glezel";
            user2.lastName = "Cumla";
            user2.address = "SFS";
            user2.gender = "Female";
            user2.age = 23;
            
        }
    }
}
