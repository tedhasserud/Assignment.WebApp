using Assignment.WebApp.Models;
using Assignment.WebApp.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        #region Index

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeIndexViewModel();
            viewModel.Products = new List<ProductModel>();
            viewModel.ProductForm = new ProductModel();
            
            using (var client = new HttpClient())
            {
                viewModel.Products = await client.GetFromJsonAsync<IEnumerable<ProductModel>>("https://localhost:7123/api/products?key=IUYAGDgadauyAd");
            }

            return View(viewModel);
        }
        #endregion

        [HttpPost]
        public async Task<IActionResult> Index(HomeIndexViewModel viewModel)
        {
           
            using (var client = new HttpClient())
            {
                await client.PostAsJsonAsync("https://localhost:7123/api/products?key=IUYAGDgadauyAd", viewModel.ProductForm);
            }

            return RedirectToAction("Index", "Home");
        }
        #region Privacy
        public async Task<IActionResult> Privacy()
        {
            var viewModel = new HomeIndexViewModel();
            viewModel.Products = new List<ProductModel>();
            viewModel.ProductForm = new ProductModel();

            using (var client = new HttpClient())
            {
                viewModel.Products = await client.GetFromJsonAsync<IEnumerable<ProductModel>>("https://localhost:7123/api/products?key=IUYAGDgadauyAd");
            }

            return View(viewModel);
        }
        #endregion

        #region Tv
        public async Task<IActionResult> Tv()
        {
            var viewModel = new HomeIndexViewModel();
            viewModel.Products = new List<ProductModel>();
            viewModel.ProductForm = new ProductModel();

            using (var client = new HttpClient())
            {
                viewModel.Products = await client.GetFromJsonAsync<IEnumerable<ProductModel>>("https://localhost:7123/api/products?key=IUYAGDgadauyAd");
            }

            return View(viewModel);
        }

        #endregion

        #region Computer
        public async Task<IActionResult> Computer()
        {
            var viewModel = new HomeIndexViewModel();
            viewModel.Products = new List<ProductModel>();
            viewModel.ProductForm = new ProductModel();

            using (var client = new HttpClient())
            {
                viewModel.Products = await client.GetFromJsonAsync<IEnumerable<ProductModel>>("https://localhost:7123/api/products?key=IUYAGDgadauyAd");
            }

            return View(viewModel);
        }

        #endregion

        #region SoundAndImage
        public async Task<IActionResult> SoundAndImage()
        {
            var viewModel = new HomeIndexViewModel();
            viewModel.Products = new List<ProductModel>();
            viewModel.ProductForm = new ProductModel();

            using (var client = new HttpClient())
            {
                viewModel.Products = await client.GetFromJsonAsync<IEnumerable<ProductModel>>("https://localhost:7123/api/products?key=IUYAGDgadauyAd");
            }

            return View(viewModel);
        }

        #endregion

        #region Details
        public async Task<IActionResult> Details(int id)
        {
            var viewModel = new HomeIndexViewModel();
            viewModel.Products = new List<ProductModel>();
            viewModel.ProductForm = new ProductModel();
            if (id == null)
                return NotFound();

            using (var client = new HttpClient())
            {
                viewModel.ProductForm = await client.GetFromJsonAsync<ProductModel>($"https://localhost:7123/api/products/{id}?key=IUYAGDgadauyAd");
            }

            return View(viewModel);  
        }

        #endregion

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}