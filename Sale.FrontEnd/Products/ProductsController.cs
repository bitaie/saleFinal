using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UI.Helpers;

using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using Sale.Domain.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;


namespace Sale.FrontEnd.Products
{
    [Authorize]
    public class ProductsController : Controller
    {
  
        ApiInitializer _initializer = new ApiInitializer();
    

        // GET: Products

        //[AllowAnonymous]
        public async Task<ActionResult> Index()
        {
            var test=User.IsInRole("4");
            List <Product> Products = new List<Product>();
            HttpClient client = _initializer.initial();
            HttpResponseMessage response = await client.GetAsync("api/Products");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                Products = JsonConvert.DeserializeObject<List<Product>>(result);
                return View(Products);
            }

           
             else
            {
                TempData["State"] = "Fail";
            }

            return View();
        }

        // GET: Products/Details/5
        [Authorize(Roles ="admin")]
        public async Task<ActionResult> Details(int id)
        {
         
            Product Product = new Product();
            HttpClient client = _initializer.initial();
            HttpResponseMessage response = await client.GetAsync("api/Products/" + $" { id} ");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                Product = JsonConvert.DeserializeObject<Product>(result);
                return View(Product);
            }
            
             else
            {
                TempData["State"] = "Fail";
            }

            return View();
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        /*[ValidateAntiForgeryToken]*/
        public async Task<ActionResult> Create(Product body)
        {
            try
            {
                // TODO: Add insert logic here
                HttpClient client = _initializer.initial();
              
                string contents = JsonConvert.SerializeObject(body);

                HttpResponseMessage response = await client.PostAsJsonAsync("api/Products/", body);

                if (response.IsSuccessStatusCode)
                {
                    TempData["State"] = "Successfully created";

                    return RedirectToAction("Index");

                }

                var result = response.Content.ReadAsStringAsync().Result;

                List<string> errors = JsonConvert.DeserializeObject<List<string>>(result);
                // return Content(errors.ToString);
                TempData["errors"] = errors;
                if (errors.GetType() == typeof(List<string>))
                {
                    TempData["State"] = "Validation Error";
                }
                else
                {
                    TempData["State"] = "Fail";
                }

                return View();
            }
            catch (Exception ex)
            {
                TempData["State"] = "Fail";
                return View();
            }
        }

        // GET: Products/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            Product Product = new Product();
            HttpClient client = _initializer.initial();
            HttpResponseMessage response = await client.GetAsync("api/Products/" + $" { id} ");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                Product = JsonConvert.DeserializeObject<Product>(result);

                return View(Product);
            }
            else
            {
                TempData["State"] = "Fail";
            }

            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Product body)
        {
            try
            {
                // TODO: Add update logic here

                HttpClient client = _initializer.initial();
                //Convert body to Json Type
                //var test = body.ToDictionary();
                string contents = JsonConvert.SerializeObject(body);


                HttpResponseMessage response = await client.PutAsJsonAsync("api/Products/" + $" { id} ", body);




                if (response.IsSuccessStatusCode)
                {
                    TempData["State"] = "Successfully Edited";
                    return RedirectToAction(nameof(Index));
                }

                var result = response.Content.ReadAsStringAsync().Result;

                List<string> errors = JsonConvert.DeserializeObject<List<string>>(result);
                // return Content(errors.ToString);
                TempData["errors"] = errors;
                if (errors.GetType() == typeof(List<string>))
                {
                    TempData["State"] = "Validation Error";
                }
                else
                {
                    TempData["State"] = "Fail";
                }

                return View();

            }
            catch
            {
                TempData["State"] = "Fail";
                return View();
            }

        }

        //[HttpGet]
        //GET: Products/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        //POST: Products/Delete/5
        [HttpGet]
        /*[ValidateAntiForgeryToken]*/
        public async Task<ActionResult> Delete(int id)
        {
            try
            {

                // TODO: Add delete logic here
                HttpClient client = _initializer.initial();

                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await client.DeleteAsync("api/Products/" + $" { id} ");
                if (response.IsSuccessStatusCode)
                {
                    TempData["State"] = "Successfully Deleted";
                    return Json("");
                    //  return RedirectToAction(nameof(Index));
                }
                TempData["State"] = "Fail";
                return Json("");
               // return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["State"] = "Fail";
                return Json("");
                //return RedirectToAction(nameof(Index));
            }
        }
    }
}