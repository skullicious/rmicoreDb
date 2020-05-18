using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using rmicore.Entities;

namespace rmicore.Controllers
{
    public class AccountController : Controller


    {

        private readonly IMapper _mapper;
        private readonly UserManager<Client> _userManager;

        public AccountController(IMapper mapper, UserManager<Client> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;

        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegistrationModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userModel);
            }

            var client = _mapper.Map<Client>(userModel);

            var result = await _userManager.CreateAsync(client, userModel.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return View(userModel);

            }

            await _userManager.AddToRoleAsync(client, "Visitor");

            //NOT SURE WHAT TO DO HERE
            return null;
        }
    }
}