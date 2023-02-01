using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.ComponentModel;

namespace XiangXiang.Models
{
    public class TProductMetadata          //TProductMetadata
    {
        public TProductMetadata()
        {
            TCorders = new HashSet<TCorder>();
            TPsites = new HashSet<TPsite>();
        }

        public int ProductId { get; set; }
        public int? SupplierId { get; set; }
        [DisplayName("註冊商品名稱")]
        public string Name { get; set; } = null!;

        public virtual TSupplier? Supplier { get; set; }
        public virtual ICollection<TCorder> TCorders { get; set; }
        public virtual ICollection<TPsite> TPsites { get; set; }
    }
    [ModelMetadataType(typeof(TProductMetadata))]
    public partial class TProduct
    {
    }



    public class TPsiteRoomMetadata          //TPsiteRoomMetadata
    {
        public TPsiteRoomMetadata()
        {
            TCorderDetails = new HashSet<TCorderDetail>();
            TEvaluations = new HashSet<TEvaluation>();
        }

        public int RoomId { get; set; }
        public int? SiteId { get; set; }
        public int? CategoryId { get; set; }
        [DisplayName("以時計費")]
        public decimal? HourPrice { get; set; }
        [DisplayName("以日計費")]
        public decimal? DatePrice { get; set; }
        [DisplayName("坪數")]
        public int? Ping { get; set; }
        [DisplayName("圖片")]
        public string? Image { get; set; }
        [DisplayName("租借狀態")]
        public bool? Status { get; set; }
        [DisplayName("描述")]
        public string? Description { get; set; }
        public IFormFile photo { get; set; }

        public virtual TCategory? Category { get; set; }
        public virtual TPsite? Site { get; set; }
        public virtual ICollection<TCorderDetail> TCorderDetails { get; set; }
        public virtual ICollection<TEvaluation> TEvaluations { get; set; }
    }
    [ModelMetadataType(typeof(TPsiteRoomMetadata))]
    public partial class TPsiteRoom
    {
    }



    public class TPsiteMetadata          //TPsiteMetadata
    {
        public TPsiteMetadata()
        {
            TPsiteRooms = new HashSet<TPsiteRoom>();
        }

        public int SiteId { get; set; }
        public int? ProductId { get; set; }
        [DisplayName("站點名稱")]
        public string Name { get; set; } = null!;
        public string? Image { get; set; }
        public string? OpenTime { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public IFormFile photo { get; set; }

        public virtual TProduct? Product { get; set; }
        public virtual ICollection<TPsiteRoom> TPsiteRooms { get; set; }
    }
    [ModelMetadataType(typeof(TPsiteMetadata))]
    public partial class TPsite
    {
    }



    public class TAdvertiseMetadata
    {
        public TAdvertiseMetadata()
        {
            TAorders = new HashSet<TAorder>();
        }

        public int AdvertiseId { get; set; }
        [DisplayName("廣告類型")]
        public string Name { get; set; } = null!;
        public decimal? DatePrice { get; set; }

        public virtual ICollection<TAorder> TAorders { get; set; }
    }
    [ModelMetadataType(typeof(TAdvertiseMetadata))]
    public partial class TAdvertise
    {
    }



    public class TAorderMetadata
    {
        public int AorderId { get; set; }
        public int? SupplierId { get; set; }
        public int? AdvertiseId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Clicks { get; set; }
        public decimal? Price { get; set; }

        public virtual TAdvertise? Advertise { get; set; }
        public virtual TSupplier? Supplier { get; set; }
    }
    [ModelMetadataType(typeof(TAorderMetadata))]
    public partial class TAorder
    {
    }



    public class TCategoryMetadata
    {
        public TCategoryMetadata()
        {
            TPsiteRooms = new HashSet<TPsiteRoom>();
        }

        public int CategoryId { get; set; }
        [DisplayName("租借空間類型")]
        public string Name { get; set; } = null!;

        public virtual ICollection<TPsiteRoom> TPsiteRooms { get; set; }
    }
    [ModelMetadataType(typeof(TCategoryMetadata))]
    public partial class TCategory
    {
    }



    public class TCorderMetadata
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? CancelDate { get; set; }
        public DateTime? TakeDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual TCustomer? Customer { get; set; }
        public virtual TProduct? Product { get; set; }
    }
    [ModelMetadataType(typeof(TCorderMetadata))]
    public partial class TCorder
    {
    }



    public class TCorderDetailMetadata
    {
        public int OrderId { get; set; }
        public int? CouponId { get; set; }
        public int? RoomId { get; set; }
        public decimal? Price { get; set; }

        public virtual TCoupon? Coupon { get; set; }
        public virtual TPsiteRoom? Room { get; set; }
    }
    [ModelMetadataType(typeof(TCorderDetailMetadata))]
    public partial class TCorderDetail
    {
    }



    public class TCouponMetadata
    {
        public TCouponMetadata()
        {
            TCorderDetails = new HashSet<TCorderDetail>();
        }

        public int CouponId { get; set; }
        [DisplayName("優惠卷代碼")]
        public string? Code { get; set; }
        [DisplayName("折扣(輸入整數，ex：85折輸入85)")]
        public decimal? Discount { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? Quantity { get; set; }
        public bool? Available { get; set; }

        public virtual ICollection<TCorderDetail> TCorderDetails { get; set; }
    }
    [ModelMetadataType(typeof(TCouponMetadata))]
    public partial class TCoupon
    {
    }



    public class TCustomerMetadata
    {
        public TCustomerMetadata()
        {
            TCorders = new HashSet<TCorder>();
            TEvaluations = new HashSet<TEvaluation>();
        }

        public int CustomerId { get; set; }
        [DisplayName("顧客名稱")]
        public string Name { get; set; } = null!;
        public bool? Sex { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public DateTime? Birth { get; set; }
        public string? CreditCard { get; set; }
        public int? CreditPoints { get; set; }
        public bool? BlackListed { get; set; }

        public virtual ICollection<TCorder> TCorders { get; set; }
        public virtual ICollection<TEvaluation> TEvaluations { get; set; }
    }
    [ModelMetadataType(typeof(TCustomerMetadata))]
    public partial class TCustomer
    {
    }



    public class TEvaluationMetadata
    {
        public int EvaluationId { get; set; }
        public int? CustomerId { get; set; }
        public int? RoomId { get; set; }
        public DateTime? Date { get; set; }
        [DisplayName("主題")]
        public string? Title { get; set; }
        [DisplayName("概述")]
        public string? Description { get; set; }
        public string? Response { get; set; }
        public int? Star { get; set; }

        public virtual TCustomer? Customer { get; set; }
        public virtual TPsiteRoom? Room { get; set; }
    }
    [ModelMetadataType(typeof(TEvaluationMetadata))]
    public partial class TEvaluation
    {
    }



    public class TManagerMetadata
    {
        public int ManagerId { get; set; }
        [DisplayName("管理者名稱")]
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
    }
    [ModelMetadataType(typeof(TManagerMetadata))]
    public partial class TManager
    {
    }



    public class TSupplierMetadata
    {
        public TSupplierMetadata()
        {
            TAorders = new HashSet<TAorder>();
            TProducts = new HashSet<TProduct>();
        }

        public int SupplierId { get; set; }
        [DisplayName("供應商名稱")]
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        [DisplayName("電話號碼")]
        public string? Phone { get; set; }
        [DisplayName("密碼")]
        public string? Password { get; set; }
        [DisplayName("地址")]
        public string? Address { get; set; }
        [DisplayName("信用積分")]
        public int? CreditPoints { get; set; }
        [DisplayName("黑名單")]
        public bool? BlackListed { get; set; }

        public virtual ICollection<TAorder> TAorders { get; set; }
        public virtual ICollection<TProduct> TProducts { get; set; }
    }

    [ModelMetadataType(typeof(TSupplierMetadata))]
    public partial class TSupplier
    {
    }

}
