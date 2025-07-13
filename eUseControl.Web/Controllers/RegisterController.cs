using eUseControl.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace eUseControl.Web.Controllers
{
    public class RegisterController : Controller
    {
        // GET: RegisterController
        public ActionResult reg()
        {
            return View();
        }


        public ActionResult register(string username, string password, string ConfirmPassword,string email)
        {
            var RegisterData = new uLoginData();

            RegisterData.Username = username;
            RegisterData.Password = password;
            RegisterData.ConfirmedPassword = ConfirmPassword;
            RegisterData.Email = email;

            return View();
        }

    }
}
