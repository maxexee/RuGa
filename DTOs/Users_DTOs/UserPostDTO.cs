using System;

namespace RuGa.DTOs.Users_DTOs;

public class UserPostDTO
{
    public string userName { get; set;}
    public string   userMasterPassword { get; set; }
    public  string  userEmail_fk { get; set; }
}
