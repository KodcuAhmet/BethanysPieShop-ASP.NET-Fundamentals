﻿using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository) // constructor
        {
            // we will get concrete instances when the constructor is run, the instances will be placed above

            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            PieListViewModel piesListViewModel = new PieListViewModel
                (_pieRepository.AllPies, "Cheese cakes");
            return View(piesListViewModel);
        }
    }
}
