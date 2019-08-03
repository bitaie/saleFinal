using Sale.Domain.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sale.Contract.Invoices
{
    public interface IInvoiceApplicationService
    {
        void SubmitInvoice(Invoice invoice);
        void CreateItem(int invoiceId, Item item);
        void DeleteItem(int itemId);
        void DeleteInvoice(int id);
        IEnumerable<Invoice> GetAllInvoices();
        Invoice GetInvoiceById(int id);
        Item GetItemById(int id);
        object UpdateInvoice(int invoiceId);
    }
}
