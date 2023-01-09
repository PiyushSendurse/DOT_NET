using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;
using BusinessLogicLayer;
using BusinessObjectLayer;

namespace EStoreWebApp.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }
                         //action
    public IActionResult Index()
    {
        CatalogManager manager = new CatalogManager();
        List<Product> allProducts=manager.GetAllProduct(); 
        this.ViewData["products"]=allProducts;
        return View();
    }

}