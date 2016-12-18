using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorManagementSystem
{
    class Utils
    {
        private static string employeeId;
        private static string username;
        private static string type;

        public static void setEmployeeId(string id)
        {
            employeeId = id;
        }

        public static string getEmployeeId()
        {
            return employeeId;
        }

        public static void setUsername(string name)
        {
            username = name;
        }

        public static string getUsername()
        {
            return username;
        }

        public static void setType(string ty)
        {
            type = ty;
        }

        public static string getType()
        {
            return type;
        }


    }
}
