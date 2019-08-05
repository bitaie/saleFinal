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
using Sale.FrontEnd.ViewModels;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Sale.Domain.Invoices;
using Sale.Domain.Products;
using Sale.Domain.Customers;
using Sale.Domain.Dto;
using Microsoft.AspNetCore.Authorization;

namespace Sale.FrontEnd.Invoices
{
    [Authorize(Roles = "InvoiceManager")]
    public class InvoicesController : Controller
    {
        ApiInitializer _initializer = new ApiInitializer();
        // GET: Invoices
        
        public async Task<ActionResult> Index()
        {

            List<Invoice> Invoices = new List<Invoice>();
            HttpClient client = _initializer.initial();
            HttpResponseMessage response = await client.GetAsync("api/Invoices");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                Invoices = JsonConvert.DeserializeObject<List<Invoice>>(result);
                return View(Invoices);
            }

            
             else
            {
                TempData["State"] = "Fail";
            }

            return View();
        }

        // GET: Invoices/Details/5
        public async Task<ActionResult> Details(int id)

        {
            try { 
            Invoice invoice = new Invoice();
            HttpClient client = _initializer.initial();
            HttpResponseMessage response = await client.GetAsync("api/Invoices/" + $" { id} ");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                invoice = JsonConvert.DeserializeObject<Invoice>(result);
                    return View(invoice);
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

        
        [HttpGet]

        public async Task<ActionResult> Create(int id)
        {
          
       
            HttpClient client = _initializer.initial();
            HttpResponseMessage customerResponse = await client.GetAsync("api/Customers/" + $" { id} ");
            Invoice invoice = new Invoice();
            invoice.CustomerId = id;
            HttpResponseMessage invoiceResponse = await client.PostAsJsonAsync("api/Invoices/", invoice);
            HttpResponseMessage productsResponse = await client.GetAsync("api/ProductsList/");
          
          
            if (customerResponse.IsSuccessStatusCode && productsResponse.IsSuccessStatusCode && invoiceResponse.IsSuccessStatusCode)
            {

                var customerResult = customerResponse.Content.ReadAsStringAsync().Result;
                var productsResult = productsResponse.Content.ReadAsStringAsync().Result;
                var invoiceResult = invoiceResponse.Content.ReadAsStringAsync().Result;
              
                    CreateInvoiceViewModel vm = new CreateInvoiceViewModel();
                vm.invoice = JsonConvert.DeserializeObject<Invoice>(invoiceResult);
                vm.invoice.Customer = JsonConvert.DeserializeObject<Customer>(customerResult);
                vm.productsList = JsonConvert.DeserializeObject<Dictionary<int,string>>(productsResult);
              // vm.invoice.Items = new List<Item>();

                return View(vm);

            }
            else
            {
                TempData["State"] = "Fail";
                return (RedirectToAction(nameof(Index)));
            }
            

        }
     
        [HttpPost]
        public async Task<ActionResult> AddItem(int productID, int itemQuantity,int invoiceId)
        {
            try
            {

                CreateInvoiceViewModel vm = new CreateInvoiceViewModel();
                vm.invoice = new Invoice();
                vm.invoice.Items = new List<Item>();

                if (itemQuantity > 0 )
                {



                    HttpClient client = _initializer.initial();

                    HttpResponseMessage response = await client.GetAsync("api/Products/" + $" { productID} ");
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        Product product = JsonConvert.DeserializeObject<Product>(result);
                        Item item = new Item();
                        item.Price = product.Price;
                        //vm.item.Product = Product;
                        item.ProductId = productID;
                        item.InvoiceId = invoiceId;
                        
                        item.Quantity = itemQuantity;
                      
                        InsertItemDto insertItemDto = new InsertItemDto() { item = item, invoiceId = invoiceId };
                        HttpResponseMessage itemResponse = await client.PostAsJsonAsync("api/Items/", insertItemDto);
                        if (itemResponse.IsSuccessStatusCode)
                        {
                            var itemResult = itemResponse.Content.ReadAsStringAsync().Result;
                            Item itemJson = JsonConvert.DeserializeObject<Item>(itemResult);
                            item.Id = itemJson.Id;
                            item.Product = product;
                            item.Product.Brand = product.Brand;
                            item.Product.Name = product.Name;
                            vm.invoice.Items.Add(item);
                            

                            return Json(vm);
                        }
                    }
                    
                

                    else
                    {
                        TempData["State"] = "Fail";
                        return Json("");
                    }





                }
                return Json(vm);
            }

            //var JSONresult = JsonConvert.SerializeObject(vm);


            catch (Exception ex)
            {
                TempData["State"] = "Fail";
                return Json("");
            }


           // return View(nameof(Create));


        }

        [HttpPost]
        public async Task<ActionResult> removeItem(int itemId)
        {



            // TODO: Add delete logic here
            HttpClient client = _initializer.initial();

            client.DefaultRequestHeaders.Accept.Clear();
            HttpResponseMessage response = await client.DeleteAsync("api/Items/" + $" { itemId} ");
            if (response.IsSuccessStatusCode)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }


        // POST: Invoices/Create
        //[HttpPost]
        /*[ValidateAntiForgeryToken]*/
        public ActionResult Create()
        {
            TempData["State"] = "Successfully created";
            return RedirectToAction(nameof(Index));
           

        }
        public async Task<ActionResult> Edit(Invoice invoice)
        {
            HttpClient client = _initializer.initial();
            //Convert body to Json Type
            //var test = body.ToDictionary();

           // HttpResponseMessage response = await client.PostAsJsonAsync("api/Invoices/", invoice);
           HttpResponseMessage response = await client.PutAsJsonAsync("api/Invoices/", invoice);



            //content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //HttpResponseMessage response = await client.PostAsync("api/Customers", content);
            if (response.IsSuccessStatusCode)
            {
                TempData["State"] = "Successfully Edited";
                return RedirectToAction(nameof(Index));
            }


            else
            {
                TempData["State"] = "Fail";
            }

          
            return View();


        }
        [HttpGet]
        // GET: Invoices/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            CreateInvoiceViewModel vm = new CreateInvoiceViewModel();

            HttpClient client = _initializer.initial();
            HttpResponseMessage invoiceResponse = await client.GetAsync("api/Invoices/" + $" { id} ");
           // HttpResponseMessage customerResponse = await client.GetAsync("api/Customers/" + $" { customerId} ");
            HttpResponseMessage productsResponse = await client.GetAsync("api/ProductsList/");


            if (invoiceResponse.IsSuccessStatusCode && productsResponse.IsSuccessStatusCode)
            {
               // var customerResult = customerResponse.Content.ReadAsStringAsync().Result;
                var invoiceResult = invoiceResponse.Content.ReadAsStringAsync().Result;
                var productsResult = productsResponse.Content.ReadAsStringAsync().Result;

               // vm.customer = JsonConvert.DeserializeObject<Customer>(customerResult);
                vm.invoice = JsonConvert.DeserializeObject<Invoice>(invoiceResult);
                vm.productsList = JsonConvert.DeserializeObject<Dictionary<int, string>>(productsResult);





            }
            else
            {
                TempData["State"] = "Fail";
                return (RedirectToAction(nameof(Index)));
            }


            return View("Edit",vm);
           
   
        }
        //[HttpPost]
        //public async Task<ActionResult> Edit(List<Item> items, int invoiceId)
        //{
        //    try
        //    {
        //        HttpClient client = _initializer.initial();

        //        HttpResponseMessage invoiceResponse = await client.GetAsync("api/Invoices/" + $" { invoiceId} ");
        //        if (invoiceResponse.IsSuccessStatusCode)
        //        {
        //            var result = invoiceResponse.Content.ReadAsStringAsync().Result;
        //            Invoice invoice = JsonConvert.DeserializeObject<Invoice>(result);
        //            InsertInvoiceDto insertInvoiceDto = new InsertInvoiceDto();
        //            insertInvoiceDto.items = items;
        //            insertInvoiceDto.invoice = invoice;
               
                 

        //            HttpResponseMessage updateInvoiceResponse = await client.PutAsJsonAsync("api/Invoices/" + $" { invoiceId} ", insertInvoiceDto);
        //            if (updateInvoiceResponse.IsSuccessStatusCode)
        //            {

        //                TempData["State"] = "Successfully Edited";

        //                return Json(Url.Action("Index", "Invoices"));
        //            }
        //        }
        //        return Json("failed");
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json("failed");
        //    }


        //}

        // POST: Invoices/Edit/5

        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Update(List<Item> items, int invoiceId)
        //{
           
        //}

        //[HttpGet]
        //GET: Invoices/Delete/5
        //public ActionResult Delete()
        //{
        //    return View();
        //}

        //POST: Invoices/Delete/5
        [HttpGet]
        /*[ValidateAntiForgeryToken]*/
        public async Task<ActionResult> Delete(int id)
        {
            try
            {

                // TODO: Add delete logic here
                HttpClient client = _initializer.initial();

                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await client.DeleteAsync("api/Invoices/" + $" { id} ");
                if (response.IsSuccessStatusCode)
                {
                    TempData["State"] = "Successfully Deleted";
                    return Json("");
                    // return RedirectToAction(nameof(Index));
                }
                TempData["State"] = "Fail";
                return Json("");
                //  return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["State"] = "Fail";
                return Json("");
                // return RedirectToAction(nameof(Index));
            }
        }
    }
}