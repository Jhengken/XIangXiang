using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace XiangXiang.Models
{
    public class TProductMetadata
    {
        public TProductMetadata()
        {
            TCorders = new HashSet<TCorder>();
            TPsites = new HashSet<TPsite>();
        }

        public int ProductId { get; set; }
        public int? SupplierId { get; set; }
        [DisplayName("產品名稱")]
        public string Name { get; set; } = null!;

        public virtual TSupplier? Supplier { get; set; }
        public virtual ICollection<TCorder> TCorders { get; set; }
        public virtual ICollection<TPsite> TPsites { get; set; }
    }
    [ModelMetadataType(typeof(TProductMetadata))]
    public partial class TProduct
    {
    }
    
    public class TAdvertiseMetaData 
    {
        public TAdvertiseMetaData()
        {
            TAorders = new HashSet<TAorder>();
        }
        public int AdvertiseId { get; set; }
        [DisplayName("廣告類型")]
        public string Name { get; set; } = null!;
        [DisplayName("每日租金")]
        public decimal? DatePrice { get; set; }

        public virtual ICollection<TAorder> TAorders { get; set; }
    }
    //[ModelMetadataType(typeof(TAdvertiseMetaData))]
    //public partial class TAdvertise { }
}
