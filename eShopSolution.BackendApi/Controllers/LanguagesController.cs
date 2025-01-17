﻿using eShopSolution.Application.System.Languages;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly ILanguageService _languageService;

        public LanguagesController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        //*********PUBLIC*******
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _languageService.GetAll();
            return Ok(products);
        }
    }
}