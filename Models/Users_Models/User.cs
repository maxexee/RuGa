using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RuGa.Models.Users_Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id_User { get; set; }
    public string   userName { get; set; }
    public string   userMasterPassword { get; set; }
    public  string  userEmail_fk { get; set; }
}
