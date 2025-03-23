using System.Diagnostics;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.DTOs.SQLFunctions;
using MVC.Models;
using Npgsql;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
//using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetCustomerHistory(string customerId)
        {
            var sql = "select * from \"CustOrderHist\"({0})";
            var products = _context.Database.SqlQueryRaw<CustOrderHistoryDto>(sql, customerId).ToList();
            return Json(products); 
        }

        public JsonResult GetCustOrderDetail(int orderId)
        {
            var sql = "select * from \"CustOrdersDetail\"({0})";
            var products = _context.Database.SqlQueryRaw<CustOrderDetailDto>(sql, orderId).ToList();
            return Json(products); // Send the data as JSON
        }

        public JsonResult GetCustOrderOrders(string customerId)
        {
            var sql = "select * from \"CustOrdersOrders\"({0})";
            var orders = _context.Database.SqlQueryRaw<CustOrderOrdersDto>(sql, customerId).ToList();
            return Json(orders); // Send the data as JSON
        }

        public JsonResult GetEmployeeSalesByCountry(string beginningDate, string endingDate)
        {
            var sql = "select * from \"Employee Sales by Country\"({0}::Date,{1}::Date)";
            var sales = _context.Database.SqlQueryRaw<EmployeeSalesByCountryDto>(sql, beginningDate, endingDate).ToList();
            return Json(sales); // Send the data as JSON
        }

        public JsonResult GetSalesByYear(string beginningDate, string endingDate)
        {
            var sql = "select * from \"Sales by Year\"({0}::Date,{1}::Date)";
            var sales = _context.Database.SqlQueryRaw<SalesByYearDto>(sql, beginningDate, endingDate).ToList();
            return Json(sales); // Send the data as JSON
        }

        public JsonResult GetSalesByCategory(string categoryName, string Year)
        {
            var sql = "select * from \"Sales By Category\"({0}::varchar(15),{1}::varchar(4))";
            var sales = _context.Database.SqlQueryRaw<SalesByCategoryDto>(sql, categoryName, Year).ToList();
            return Json(sales); // Send the data as JSON
        }

        public JsonResult GetTenMostExpensiveProducts()
        {
            var sql = "select * from \"Ten Most Expensive Products\"()";
            var products = _context.Database.SqlQueryRaw<TenMostExpensiveProductsDto>(sql).ToList();
            return Json(products); // Send the data as JSON
        }
        public IActionResult Privacy()
        {
            return View();
        }

        

       // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
