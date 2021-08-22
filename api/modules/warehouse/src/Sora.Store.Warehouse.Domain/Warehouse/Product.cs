﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Sora.Store.Warehouse
{
    /// <summary>
    /// Bảng lưu thông tin của product
    /// </summary>
    public partial class Product
    {
        public Product()
        {
            Producttag = new HashSet<Producttag>();
        }

        /// <summary>
        /// Id của product
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Tên của product
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Slug của product
        /// </summary>
        public string Slug { get; set; }
        /// <summary>
        /// Giá nhập sản phẩm
        /// </summary>
        public float Cost { get; set; }
        /// <summary>
        /// Giá bán sản phẩm
        /// </summary>
        public float Price { get; set; }
        /// <summary>
        /// Giá tiền khuyến mại cho sản phẩm
        /// </summary>
        public float Discount { get; set; }
        /// <summary>
        /// Số lượng sản phẩm còn lại
        /// </summary>
        public short Quantity { get; set; }
        /// <summary>
        /// Thông số kỹ thuật của sản phẩm lưu dưới dạng string json
        /// </summary>
        public string Config { get; set; }
        /// <summary>
        /// Danh sách ảnh của sản phẩm lưu dưới dạng string json
        /// </summary>
        public string Images { get; set; }
        /// <summary>
        /// Sản phẩm có đang được bày bán không. 0: không, 1: có
        /// </summary>
        public sbyte? OnSale { get; set; }
        /// <summary>
        /// Thời gian bày bán
        /// </summary>
        public DateTime PublishedDate { get; set; }
        /// <summary>
        /// Nội dung sản phẩm (mô tả, giới thiệu,...)
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Thời gian tạo
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Thời gian cập nhật
        /// </summary>
        public DateTime? UpdatedDate { get; set; }
        /// <summary>
        /// Id của category
        /// </summary>
        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Producttag> Producttag { get; set; }
    }
}