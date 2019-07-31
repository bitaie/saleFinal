using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sale.Contract.Invoices;
using Sale.Domain.Dto;
using Sale.Domain.Invoices;

namespace Sale.ApplicationService.Invoices
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IInvoiceApplicationService _invoiceApplicationService;
  

        public ItemsController(IInvoiceApplicationService invoiceApplicationService)
        {
            _invoiceApplicationService = invoiceApplicationService;
           
        }

        

        //@To Do: Maybe in the future there is a need to make this API
        //// PUT: api/Invoices/5
        //[HttpPut("{id}")]
        //public IActionResult PutInvoice([FromRoute] int id, InsertInvoiceDto insertInvoiceDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != insertInvoiceDto.invoice.Id)
        //    {
        //        return BadRequest();
        //    }

        //    try
        //    {
        //        List<Item> items = insertInvoiceDto.items;
        //        Invoice invoice = insertInvoiceDto.invoice;

        //        _invoiceApplicationService.UpdateInvoice(insertInvoiceDto.invoice, insertInvoiceDto.items);
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        return Conflict();
        //    }

        //    return NoContent();
        //}

        // POST: api/Invoices

        [HttpPost]
        public IActionResult PostItem(InsertItemDto insertItemDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            Item item = insertItemDto.item;

           int invoiceId = insertItemDto.invoiceId;

            _invoiceApplicationService.CreateItem(invoiceId, item);


            return Created("", item);
        }

        // DELETE: api/Invoices/5
        [HttpDelete("{id}")]
        public IActionResult DeleteItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = _invoiceApplicationService.GetItemById(id);
            if (item == null)
            {
                return NotFound();
            }
            _invoiceApplicationService.DeleteItem(id);

            return Ok(item);
        }



    }
}