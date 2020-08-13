using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using WebAPINetCode27.Model;

namespace WebAPINetCode27.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration configuration;

        // Obtenemos datos de configuración (appsettings.json)
        public LoginController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // POST: api/Login
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(LoginDTO usuarioLogin)
        {
            var _userInfo = AutenticarUsuario(usuarioLogin.Usuario, usuarioLogin.Password);

            if (_userInfo != null)
            {
                return Ok(new { token = GenerarTokenJWT(_userInfo) });
            }
            else
            {
                return Unauthorized();
            }
        }

        //Verificar si existe el usuario
        private UsuarioDTO AutenticarUsuario(string usuario, string password)
        {
            // En esta sección podemos implementar nuestro mecanismo de autenticación //


            //Devolvemos los datos del usuario si la autenticación fue correcta
            return new UsuarioDTO()
            {
                // Id del Usuario en el Sistema de Información (BD)
                Id = new Guid("B5D233F0-6EC2-4950-8CD7-F44D16EC878F"),
                Nombre = "Marino",
                Apellidos = "Martinez",
                Email = "micorreo@correo.com",
                Rol = "Administrador"
            };

            //Si los datos fueran incorrectos devolveriamos null 
            //return null;
        }

        //Generar token con la info del usuario
        private string GenerarTokenJWT(UsuarioDTO usuarioInfo)
        {
            //Se crea el header
            var _symmetricSecurityKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(configuration["JWT:secret"])
                );
            var _signingCredentials = new SigningCredentials(
                    _symmetricSecurityKey, SecurityAlgorithms.HmacSha256
                );
            var _Header = new JwtHeader(_signingCredentials);

            //Se crean los claims
            var _Claims = new[] {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.NameId, usuarioInfo.Id.ToString()),
                new Claim("nombre", usuarioInfo.Nombre),
                new Claim("apellidos", usuarioInfo.Apellidos),
                new Claim(JwtRegisteredClaimNames.Email, usuarioInfo.Email),
                new Claim(ClaimTypes.Role, usuarioInfo.Rol)
            };

            //Se crea el payload
            var _Payload = new JwtPayload(
                    issuer: configuration["JWT:Issuer"],
                    audience: configuration["JWT:Audience"],
                    claims: _Claims,
                    notBefore: DateTime.UtcNow,
                    // Tiempo de expiración.
                    expires: DateTime.UtcNow.AddHours(24)
                );

            //Y finalmente el token
            var _Token = new JwtSecurityToken(
                    _Header,
                    _Payload
                );

            return new JwtSecurityTokenHandler().WriteToken(_Token);
        }
    }
}