using Sale.Contract.Common;
using Sale.Contract.Invoices;
using Sale.Domain.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace Sale.ApplicationService.Invoices
{
    public class InvoiceApplicationService : IInvoiceApplicationService
    {
        private readonly IInvoiceDomainService _invoiceDomainService;
        private readonly IGenericRepository<Invoice> _invoiceRepository;
        private readonly IGenericRepository<Item> _itemRepository;
        public InvoiceApplicationService(IInvoiceDomainService  invoiceDomainService,IGenericRepository<Invoice> invoiceRepository, IGenericRepository<Item> itemReposiotiry)
        {
            _invoiceRepository = invoiceRepository;
            _invoiceDomainService = invoiceDomainService;
            _itemRepository = itemReposiotiry;
        }

        public void SubmitInvoice(Invoice invoice)
        {
        
                _invoiceRepository.Insert(invoice);
            
             
               
        }

        public void CreateItem(int invoiceId, Item item)
        {
            using (TransactionScope scope = new TransactionScope())
                {

                    // these operations are atomic since they below to same transactionscope
                    _itemRepository.Insert(item);
                    var items = _itemRepository.Get(i => i.InvoiceId == invoiceId);
                    Invoice invoice = _invoiceRepository.GetById(invoiceId);
                    int sum = _invoiceDomainService.CalculateTotalPrice(items.ToList());
                    invoice.TotalPrice = sum;
                    _invoiceRepository.Update(invoice);

                    scope.Complete();

                }
              

        }
        public void DeleteItem( int itemId)
        {
            using (TransactionScope scope = new TransactionScope())
            {

                // these operations are atomic since they below to same transactionscope
                Item item =_itemRepository.Get(i => i.Id == itemId).FirstOrDefault();
                Invoice invoice =this.GetInvoiceById(item.InvoiceId);
               _itemRepository.Delete(itemId);
                
                var items = _itemRepository.Get(i => i.InvoiceId == invoice.Id);
                int sum = _invoiceDomainService.CalculateTotalPrice(items.ToList());
                invoice.TotalPrice = sum;
                _invoiceRepository.Update(invoice);

                scope.Complete();
            }

        }
        public void DeleteInvoice(int id)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Invoice invoice =_invoiceRepository.Get(i => i.Id == id, i => i.Items).FirstOrDefault();
                var items = invoice.Items;

                foreach (var item in items.ToList())
                {
                    _itemRepository.Delete(item.Id);
                }
                _invoiceRepository.Delete(id);
                scope.Complete();

            }


        }
        public IEnumerable<Invoice> GetAllInvoices()
        {
            return _invoiceRepository.GetAll(x => x.Customer, x => x.Items).ToList();
        }

        public Item GetItemById(int id)
        {
            return _itemRepository.GetById(id);
        }
        public Invoice GetInvoiceById(int id)
        {
            Invoice invoice = _invoiceRepository.Get(x => x.Id == id, x => x.Customer, x => x.Items).FirstOrDefault();

            List<Item> items = new List<Item>();
            foreach (var item in invoice.Items)
            {

                items.Add(_itemRepository.Get(x => x.Id == item.Id, x => x.Product).FirstOrDefault());
            }
            invoice.Items = items;
            return invoice;
        }



    }

}
