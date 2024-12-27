using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RuGa.Data.DataBases;
using RuGa.DTOs.Users_DTOs;
using RuGa.Models.Users_Models;

namespace RuGa.Controllers.Users_Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly ApiDbContext   _context;
        public UserController(ILogger<UserController> logger,    ApiDbContext    context)
        {
            _logger     = logger;
            _context    = context;
        }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> Post(UserPostDTO   userPostDTO){
            // CREACION DEL NUEVO USUARIO EN BASE A *userPostDTO*.
            var user    =   new User(){
                userName            =   userPostDTO.userName,
                userMasterPassword  =   userPostDTO.userMasterPassword,
                userEmail_fk        =   userPostDTO.userEmail_fk,
            };

            // GUARDADO DEL NUEVO USUARIO EN LA BASE DE DATOS.
            await   _context.User.AddAsync(user);
            await   _context.SaveChangesAsync();

            // RETORNO QUE MUESTRA AL NUEVO USUARIO.
            var userDto =   new UserDTO(){
                id_User =   user.id_User,
                userName=   user.userName,
                userMasterPassword  =   user.userMasterPassword,
                userEmail_fk    =   user.userEmail_fk
            };

            return Ok();
        }
    }
}
