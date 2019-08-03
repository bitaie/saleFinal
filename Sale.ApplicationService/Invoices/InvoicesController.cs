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
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoiceApplicationService _invoiceApplicationService;
  

        public InvoicesController(IInvoiceApplicationService invoiceApplicationService)
        {
            _invoiceApplicationService = invoiceApplicationService;
           
        }

        // GET: api/Invoices
        [HttpGet]
        public IEnumerable<Invoice> GetInvoice()
        {
            return _invoiceApplicationService.GetAllInvoices();
        }
        // GET: api/Invoices/5
        [HttpGet("{id}")]
        public ActionResult GetInvoice([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Invoice = _invoiceApplicationService.GetInvoiceById(id);

            if (Invoice == null)
            {
                return NotFound();
            }

            return Ok(Invoice);
        }

        //@To Do: Maybe in the future there is a need to make this API
        // PUT: api/Invoices/5
        [HttpPut]
        public IActionResult PutInvoice(Invoice invoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

          

            try
            {
                

                _invoiceApplicationService.UpdateInvoice(invoice.Id);
            }
            catch (DbUpdateConcurrencyException)
            {
                return Conflict();
            }

            return NoContent();
        }

        // POST: api/Invoices

        [HttpPost]
        public IActionResult PostInvoice(Invoice invoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           

            

            _invoiceApplicationService.SubmitInvoice(invoice);


            return CreatedAtAction("GetInvoice", new { id = invoice.Id }, invoice);
        }

        // DELETE: api/Invoices/5
        [HttpDelete("{id}")]
        public IActionResult DeleteInvoice([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Invoice = _invoiceApplicationService.GetInvoiceById(id);
            if (Invoice == null)
            {
                return NotFound();
            }
            _invoiceApplicationService.DeleteInvoice(id);

            return Ok(Invoice);
        }



    }
}