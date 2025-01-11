using System;

namespace RuGa.DTOs.Users_DTOs;

public class UserDTO
{
    public int id_User { get; set; }
    public string   userName { get; set; }
    public string   userMasterPassword { get; set; }
    public  string  userEmail_fk { get; set; }
}
