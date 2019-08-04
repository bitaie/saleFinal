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
using Sale.Domain.Customers;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Sale.FrontEnd.Customers
{
    [Authorize(Roles ="CustomerManager")]
    public class CustomersController : Controller
    {
        ApiInitializer _initializer = new ApiInitializer();
        private RoleManager<IdentityRole> roleManager;
        public CustomersController(RoleManager<IdentityRole> _roleManager)
        {
            roleManager = _roleManager;
        }
        // GET: Customers
        [AllowAnonymous]
        public async Task<ActionResult> Index()
        {
         
            List<Customer> customers = new List<Customer>();
            HttpClient client = _initializer.initial();
            HttpResponseMessage response = await client.GetAsync("api/Customers");
            if (response.IsSuccessStatusCode) {
                var result = response.Content.ReadAsStringAsync().Result;
                customers = JsonConvert.DeserializeObject<List<Customer>>(result);
                return View(customers);
            }

          
             else
            {
                TempData["State"] = "Fail";
                return View();
            }
        }

        // GET: Customers/Details/5
        public async Task<ActionResult> Details(int id)
        {
            Customer customer = new Customer();
            HttpClient client = _initializer.initial();
            HttpResponseMessage response = await client.GetAsync("api/Customers/" + $" { id} ");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                customer = JsonConvert.DeserializeObject<Customer>(result);
                return View(customer);
            }
            
            else
            {
                TempData["State"] = "Fail";
                return View();
            }
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        /*[ValidateAntiForgeryToken]*/
        public async Task<ActionResult> Create(Customer body)
        {
            try
            {
                // TODO: Add insert logic here
                HttpClient client = _initializer.initial();
                //Convert body to Json Type
                //var test = body.ToDictionary();
                string contents = JsonConvert.SerializeObject(body);


                HttpResponseMessage response = await client.PostAsJsonAsync("api/Customers/", body);


               

                //content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                //HttpResponseMessage response = await client.PostAsync("api/Customers", content);
                if (response.IsSuccessStatusCode)
                {
                    TempData["State"] = "Successfully created";
                    return RedirectToAction("Index");
                 
                }

                var result = response.Content.ReadAsStringAsync().Result;
              
                List<string> errors= JsonConvert.DeserializeObject<List<string>>(result);
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
            catch(Exception ex)
            {
                TempData["State"] = "Fail";
                return View();
            }
        }

        // GET: Customers/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            Customer customer = new Customer();
            HttpClient client = _initializer.initial();
            HttpResponseMessage response = await client.GetAsync("api/Customers/" + $" { id} ");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                customer = JsonConvert.DeserializeObject<Customer>(result);
                return View(customer);
            }
         
             else
            {
                TempData["State"] = "Fail";
            }

            return View();

        }

        // POST: Customers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Customer body)
        {
            try
            {
                // TODO: Add update logic here

                HttpClient client = _initializer.initial();
                //Convert body to Json Type
                //var test = body.ToDictionary();
                string contents = JsonConvert.SerializeObject(body);


                HttpResponseMessage response = await client.PutAsJsonAsync("api/Customers/" + $" { id} ", body);




                //content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                //HttpResponseMessage response = await client.PostAsync("api/Customers", content);
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
            catch(Exception ex)
            {
                TempData["State"] = "Fail";
                return View();
            }
         
        }

        //[HttpGet]
        //GET: Customers/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        //POST: Customers/Delete/5
        [HttpGet]
        /*[ValidateAntiForgeryToken]*/
        public async Task<ActionResult> Delete(int id)
        {
            try
            {

                // TODO: Add delete logic here
                HttpClient client = _initializer.initial();

                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await client.DeleteAsync("api/Customers/" + $" { id} ");
                if (response.IsSuccessStatusCode)
                {
                    TempData["State"] = "Successfully Deleted";
                    return Json("");
                   // return RedirectToAction(nameof(Index));
                }
                TempData["State"] = "Fail";
                // return RedirectToAction(nameof(Index));
                return Json("");
            }
            catch
            {
                TempData["State"] = "Fail";
                // return RedirectToAction(nameof(Index));
                return Json("");
            }
        }
    }
}