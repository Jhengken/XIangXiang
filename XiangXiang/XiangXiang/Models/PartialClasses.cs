using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace XiangXiang.Models
{
    public class PartialClasses
    {
        //[ModelMetadataType(typeof(TProductMetadata))]
        //public partial class TProduct
        //{
        //}
        [ModelMetadataTypeAttribute(typeof(TAdvertiseMetaData))]
        public partial class TAdvertise
        {
        }
    }
}
