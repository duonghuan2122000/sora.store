// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Sora.Store.Warehouse
{
    /// <summary>
    /// Bảng khóa ngoại lưu thông tin liên kết bảng product và bảng tag
    /// </summary>
    public partial class Producttag
    {
        /// <summary>
        /// Id của product
        /// </summary>
        public Guid ProductId { get; set; }
        /// <summary>
        /// Id của tag
        /// </summary>
        public Guid TagId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Tag Tag { get; set; }
    }
}