using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography.X509Certificates;
using XiangXiang.Models;

namespace XiangXiang.VIewModels
{
    public class TSupplierViewModel
    {
        private TSupplier _supplier;

        public TSupplier supplier
        {
            get { return _supplier; }
            set { _supplier = value; }
        }

        public TSupplierViewModel()
        {
            _supplier = new TSupplier();
        }

        public int SupplierId { get { return _supplier.SupplierId; } set { _supplier.SupplierId = value; } }
        public string Name { get { return _supplier.Name; } set { _supplier.Name = value; } }
        public string? Email { get { return _supplier.Email; } set { _supplier.Email = value; } }
        public string? Phone { get { return _supplier.Phone; } set { _supplier.Phone = value; } }
        public string? Password { get { return _supplier.Password; } set { _supplier.Password = value; } }
        public string? Address { get { return _supplier.Address; } set { _supplier.Address = value; } }
        public int? CreditPoints { get { return _supplier.CreditPoints; } set { _supplier.CreditPoints = value; } }
        public bool? BlackListed { get { return _supplier.BlackListed; } set { _supplier.BlackListed = value; } }

        public virtual ICollection<TAorder> TAorders { get { return _supplier.TAorders; } set { _supplier.TAorders = value; } }
        public virtual ICollection<TProduct> TProducts { get { return _supplier.TProducts; } set { _supplier.TProducts = value; } }


    }
}
