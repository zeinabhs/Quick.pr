using Microsoft.AspNetCore.Mvc;
using Quick.DataAccess.Repository.IRepository;
using Quick.Models;
using QuickBites.Utility;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBites.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DashboardController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(int? categoryId)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            //var isAdmin = await _unitOfWork.IsUserInRoleAsync(userId, SD.Role_Admin);

            //if (!isAdmin)
            //{
            //    return Unauthorized();
            //}

            var viewModel = new ProductDashboardViewModel
            {
                Categories = _unitOfWork.Category.GetAll().ToList(),
                Products = categoryId == null
                    ? _unitOfWork.Product.GetAll().ToList()
                    : _unitOfWork.Product.GetAll(p => p.CategoryId == categoryId).ToList(),
                SelectedCategoryId = categoryId, // Ensure this line sets the selected category ID
                ProductsMoreThan6 = _unitOfWork.Product.GetAll(x => x.Price > 6).ToList(),
                ProductsLessThan6 = _unitOfWork.Product.GetAll(x => x.Price < 6).ToList()
            };

            return View(viewModel);
        }

        public IActionResult FilterByCategory(int categoryId)
        {
            var products = _unitOfWork.Product.GetAll(d => d.CategoryId == categoryId).ToList();
            var viewModel = new ProductDashboardViewModel
            {
                Categories = _unitOfWork.Category.GetAll().ToList(),
                Products = products,
                SelectedCategoryId = categoryId
            };
            return View("Index", viewModel);
        }
    }
}
