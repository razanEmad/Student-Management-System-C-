using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hciProject.Data
{
    internal class ProgramSession
    {

        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; } 
        public static int StudentId { get; set; } 
        public static string StudentName { get; set; } // <-- Add this property
    }
}
