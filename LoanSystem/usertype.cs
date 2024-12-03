using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem
{
    public enum UserType
    {
        LoanOfficer,
        BranchManager,
        Accountant,
        SystemAdministrator,
        Unknown
    }

    public static class CurrentUser
    {
        public static string Email { get; set; }
        public static UserType Usertype { get; set; }
    }
}
