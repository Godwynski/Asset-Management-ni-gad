using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Management_ni_gad
{
    internal class Session
    {
        public static string UserName { get; set; } = string.Empty;
        public static string UserRole { get; set; } = string.Empty;
        public static int UserId { get; set; } = 0;
        public static int UserStatus { get; set; } = 0;
        public static string UserEmail { get; set; } = string.Empty;
        public static string UserPhone { get; set; } = string.Empty;
    }
}
