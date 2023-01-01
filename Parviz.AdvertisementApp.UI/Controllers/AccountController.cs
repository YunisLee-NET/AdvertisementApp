using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Parviz.AdvertisementApp.Business.Interfaces;
using Parviz.AdvertisementApp.Common.Enums;
using Parviz.AdvertisementApp.Dtos;
using Parviz.AdvertisementApp.UI.Extensions;
using Parviz.AdvertisementApp.UI.Models;
using System.Threading.Tasks;

namespace Parviz.AdvertisementApp.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IGenderService _genderService;
        private readonly IValidator<UserCreateModel> _userValidator;
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;

        public AccountController(IGenderService genderService, IValidator<UserCreateModel> userValidator, IMapper mapper, IAppUserService appUserService)
        {
            _genderService = genderService;
            _userValidator = userValidator;
            _mapper = mapper;
            _appUserService = appUserService;
        }
        [HttpGet]
        public async Task<IActionResult> SignUp()
        {
            var genderData = await _genderService.GetAllAsync();
            var model = new UserCreateModel();
            model.Gender = new SelectList(genderData.Data,"Id","Definition");            
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserCreateModel model)
        {
            var validationresult = _userValidator.Validate(model);
            if (validationresult.IsValid)
            {
                var convertToDto = _mapper.Map<AppUserCreateDto>(model);
                var response = await _appUserService.CreateWithRoleAsync(convertToDto, (int)RoleType.Member);
                return this.ResponseRedirectAction(response, "Index", "Home");
            }
            else
            {
                foreach (var error in validationresult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                    var genderdata = await _genderService.GetAllAsync();
                    model.Gender = new SelectList(genderdata.Data, "Id", "Definition");

                }
                return View(model);
            }
        }

        public IActionResult SignIn()
        {
            return View();
        }
    }
}
