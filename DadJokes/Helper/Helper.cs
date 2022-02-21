using Microsoft.AspNetCore.Mvc.Rendering;

namespace DadJokes.Helper
{
    public class Helper
    {
        public static string Admin = "Admin";
        public static string User = "User"; 
        public static List<SelectListItem> GetRolesDropDown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Text = Admin, Value = Admin },
                new SelectListItem { Text = User, Value = User },
            };
        }
    }
}
