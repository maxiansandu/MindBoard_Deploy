using System;
using Microsoft.EntityFrameworkCore;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BussinesLogic.DBModel;

public class UserContext : DbContext
{
    
    public UserContext(DbContextOptions<UserContext> options)
            : base(options) { }

        public DbSet<UDBTable> Users { get; set; }


}
