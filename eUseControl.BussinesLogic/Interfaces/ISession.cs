using System;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BussinesLogic.Interfaces;

public interface IUserSession
{
    RegisterResult RegistrUser(UDBTable udata);

}
