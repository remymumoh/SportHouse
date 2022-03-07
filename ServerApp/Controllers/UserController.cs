using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;
namespace ServerApp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private UserManager<UserModel> _userManager;
        private SignInManager<UserModel> _singInManager;

        public ApplicationUserController(UserManager<UserModel> userManager, SignInManager<UserModel> signInManager)
        {
            _userManager = userManager;
            _singInManager = signInManager;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<Object> PostApplicationUser(UserModel model)
        {
            var applicationUser = new UserModel() {
                Email = model.Email,
            };

            try
            {
                var result = await _userManager.CreateAsync(applicationUser, model.Password);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}