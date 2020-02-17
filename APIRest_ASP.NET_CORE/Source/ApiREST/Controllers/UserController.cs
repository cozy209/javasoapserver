using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace ApiREST.Controllers
{
    [Authorize]
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        #region Fields
        private IConfiguration _configuration = null;
        #endregion

        #region Constructors
        public UserController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        #endregion

        #region Public methods
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel model)
        {
            IActionResult result = this.Unauthorized();

            if (model != null)
            {
                UserModel resultModel = new UserModel
                {
                    Token = this.CreateToken(model)
                };

                result = this.Ok(resultModel);
            }

            return result;
        }
        #endregion

        #region Internal methods
        private string CreateToken(LoginModel model)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._configuration["jwt:key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(this._configuration["jwt:issuer"],
                                             this._configuration["jwt:issuer"],
                                             expires: DateTime.Now.AddMinutes(30),
                                             signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        #endregion
    }

    internal class UserModel
    {
        public string Token { get; set; }
    }
}