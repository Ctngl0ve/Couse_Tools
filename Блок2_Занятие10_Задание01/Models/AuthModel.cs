using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Блок2_Занятие10_Задание01.Models
{
    static class AuthModel
    {
        const string ValidUsername = "admin";
        const string ValidPassword = "12345";

        public static bool Authenticate(string username, string password) => username == ValidUsername && password == ValidPassword;
    }
}
