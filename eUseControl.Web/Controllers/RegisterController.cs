using System.Reflection.Metadata;
using eUseControl.BussinesLogic;
using eUseControl.BussinesLogic.Interfaces;
using eUseControl.Domain.Entities.User;
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

        private readonly IUserSession _userSession;

        public RegisterController(IUserSession userSession)
    {
        _userSession = userSession;
    }

        public ActionResult register(string username, string password, string ConfirmPassword, string email)
        {
            if (password != ConfirmPassword)
            {
                ViewBag.Message = "parola nu coincide";
                return View();

            }
            var RegisterData = new uLoginData();

            RegisterData.Username = username;
            RegisterData.Password = password;
            RegisterData.ConfirmedPassword = ConfirmPassword;
            RegisterData.Email = email;

            var UserDataRegister = new UDBTable();

            UserDataRegister.Username = RegisterData.Username;
            UserDataRegister.Password = RegisterData.Password;
            UserDataRegister.Email = RegisterData.Email;

 
            RegisterResult response =_userSession.RegistrUser(UserDataRegister);

           bool status =  response.result;

            return View();
        }

    }
}
