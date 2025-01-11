using System;
using Microsoft.EntityFrameworkCore;
using RuGa.Models.Users_Models;

namespace RuGa.Data.DataBases;

public class ApiDbContext   :   DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options){

    }

    public  DbSet<User> User { get; set; }
}
