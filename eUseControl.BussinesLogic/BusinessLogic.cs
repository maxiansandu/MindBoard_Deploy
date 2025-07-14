using System;
using eUseControl.BussinesLogic.Core;
using eUseControl.BussinesLogic.DBModel;
using eUseControl.BussinesLogic.Interfaces;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BussinesLogic;

public class BL
{


    public class uSessionBL : UserApi, IUserSession
    {

        public uSessionBL(UserContext context) : base(context)
        {
        }


        public RegisterResult RegistrUser(UDBTable uData)
        {

            return RegistrUser_action(uData);
        }

    }

}
//Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres