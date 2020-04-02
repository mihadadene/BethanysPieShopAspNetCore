using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShopAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShopAspNetCore.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public PieController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        public ViewResult List()
        {
            return View(_pieRepository.Pies);
        }
    }
}
