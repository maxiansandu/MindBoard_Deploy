using System;
using System.Data.Common;
using eUseControl.BussinesLogic.DBModel;
using eUseControl.Domain.Entities.User;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic;

namespace eUseControl.BussinesLogic.Core;

public class UserApi
{
    private readonly UserContext _context;

    // Constructor corect cu injectare de dependință
    public UserApi(UserContext context)
    {
        _context = context;
    }



    public RegisterResult RegistrUser_action(UDBTable uData)
    {


        var result = new RegisterResult();


        var userExists = _context.Users.Any(u => u.Username == uData.Username || u.Email == uData.Email);

        if (userExists)
        {
            result.notification = "An user with this username allready exists";
            result.result = false;

            return result;

        }

        _context.Users.Add(uData);
        _context.SaveChanges();



        result.notification = "Register with succes";
        result.result = true;

        return result;
    }

}
