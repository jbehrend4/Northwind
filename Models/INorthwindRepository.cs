using System.Linq;

namespace Northwind.Models
{
    public interface INorthwindRepository
    {
        IQueryable<Category> Categories { get; }
        IQueryable<Product> Products { get; }
        IQueryable<Discount> Discounts { get; }
        IQueryable<Contact> Contacts { get; }
        IQueryable<Customers> Customers { get; }

        void AddContact(Contact contact);
        void AddCustomer(Customers customers);
        void EditCustomer(Customers customers);
    }
}
