
using Sale.Contract.Invoices;
using System.Transactions;
using Sale.Infrastructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sale.Domain.Invoices;
using Sale.Contract.Common;

namespace Sale.DomainService.Invoices
{
    public class InvoiceDomainService : IInvoiceDomainService
    {
        //@To Do: remove all linses till calculate total price if they are not necessary after test
        private readonly AppDbContext _context = null;
        private readonly IGenericRepository<Invoice> _invoiceRepository;
        private readonly IGenericRepository<Item> _itemRepository;
        public InvoiceDomainService(AppDbContext context, IGenericRepository<Invoice> invoiceRepository,
            IGenericRepository<Item> itemRepository)
        {
            _context = context;
            _invoiceRepository = invoiceRepository;
            _itemRepository = itemRepository;
        }
       
    
        public int CalculateTotalPrice(List<Item> items)
        {
            var sum = 0;
            foreach (var item in items)
            {
                var price = item.Price;
                var quantity = item.Quantity;
                sum = sum + price * quantity;

            }
            return sum;
        }
       



    }




    
}
