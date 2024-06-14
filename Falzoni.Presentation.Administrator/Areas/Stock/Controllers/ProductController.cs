using Falzoni.Presentation.Administrator.Clients.Interfaces.Stock;
using Falzoni.Presentation.Administrator.Models.Common;
using Falzoni.Presentation.Administrator.Models.Stock;
using Falzoni.Presentation.Administrator.Models.Tables.Stock;
using Falzoni.Utils.Helpers;
using NLog;
using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Falzoni.Presentation.Administrator.Areas.Stock.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductClient _productClient;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public ProductController(IProductClient productClient)
        {
            _productClient = productClient;
        }

        // GET: Stock/Product
        public ActionResult Index()
        {
            return View();
        }

        //GET: Stock/Product/LoadTable
        [HttpGet]
        public async Task<JsonResult> LoadTable()
        {
            var table = new ProductTableModel();

            try
            {
                table = await _productClient.GetTableAsync(UrlConfigurationHelper.ProductGetAll);
            }
            catch (Exception ex)
            {
                _logger.Fatal("Ocorreu um erro: " + ex);
            }

            return Json(table, JsonRequestBehavior.AllowGet);
        }

        //GET: Stock/Product/Create
        [HttpGet]
        public ActionResult Create()
        {
            var model = new ProductModel();

            try
            {
                return View(model);
            }
            catch (ApplicationException ex)
            {
                _logger.Error("Ocorreu um erro: " + ex);

                TempData["Return"] = new ReturnModel
                {
                    Type = "Error",
                    Message = ex.Message
                };

                return View("Index");
            }
            catch (Exception ex)
            {
                _logger.Fatal("Ocorreu um erro: " + ex);
                throw;
            }
        }

        // POST: Stock/Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                string result = _productClient.Add(UrlConfigurationHelper.ProductCreate, model);

                TempData["Return"] = new ReturnModel
                {
                    Type = "Success",
                    Message = result
                };

                return View("Index");
            }
            catch (ApplicationException ex)
            {
                _logger.Error("Ocorreu um erro: " + ex);

                ModelState.AddModelError(string.Empty, ex.Message);

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.Fatal("Ocorreu um erro: " + ex);
                throw;
            }
        }

        // GET: Stock/Product/Edit
        [HttpGet]
        public async Task<ActionResult> Edit(string id)
        {
            try
            {
                var model = await _productClient.GetAsync(UrlConfigurationHelper.ProductGet, id);

                return View(model);
            }
            catch (ApplicationException ex)
            {
                _logger.Error("Ocorreu um erro: " + ex);

                TempData["Return"] = new ReturnModel
                {
                    Type = "Error",
                    Message = ex.Message
                };

                return View("Index");
            }
            catch (Exception ex)
            {
                _logger.Fatal("Ocorreu um erro: " + ex);
                throw;
            }

        }

        // POST: Stock/Product/Edit
        [HttpPost]
        public ActionResult Edit(ProductModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                string result = _productClient.Update(UrlConfigurationHelper.ProductEdit, model);

                TempData["Return"] = new ReturnModel
                {
                    Type = "Success",
                    Message = result
                };

                return View("Index");
            }
            catch (ApplicationException ex)
            {
                _logger.Error("Ocorreu um erro: " + ex);

                ModelState.AddModelError(string.Empty, ex.Message);

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.Fatal("Ocorreu um erro: " + ex);
                throw;
            }
        }

        //POST: Stock/Product/Delete
        [HttpPost]
        public async Task<ActionResult> Delete(ProductModel model)
        {
            //List<string> errorsList = new List<string>();

            try
            {
                string result = await _productClient.DeleteAsync(UrlConfigurationHelper.ProductDelete, model);

                return Json(new { success = true, message = result });
            }
            catch (ApplicationException ex)
            {
                _logger.Error("Ocorreu um erro: " + ex);
                Response.StatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);

                //errorsList.Add(ex.Message);

                //return Json(new { success = false, errors = errorsList });
                return Json(new { success = false, error = ex.Message });
            }

            catch (Exception ex)
            {
                _logger.Fatal("Ocorreu um erro: " + ex);

                //errorsList.Add(ex.Message);

                if (Debugger.IsAttached)
                {
                    //errorsList.Add("Ocorreu um erro, verifique o arquivo de log e tente novamente!");
                    return Json(new { success = false, error = "Ocorreu um erro, verifique o arquivo de log e tente novamente!" });
                }

                //return Json(new { success = false, errors = errorsList });
                return Json(new { success = false, error = ex.Message });
            }
        }
    }
}