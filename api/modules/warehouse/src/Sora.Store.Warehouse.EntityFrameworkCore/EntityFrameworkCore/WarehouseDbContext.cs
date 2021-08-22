using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Sora.Store.Warehouse.EntityFrameworkCore
{
    [ConnectionStringName(WarehouseDbProperties.ConnectionStringName)]
    public class WarehouseDbContext : AbpDbContext<WarehouseDbContext>, IWarehouseDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) 
            : base(options)
        {

        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Producttag> Producttag { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.HasComment("Bảng lưu thông tin của category");

                entity.Property(e => e.Id).HasComment("Id của category");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasComment("Nội dung của category (mô tả, giới thiệu,...)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasComment("Thời gian tạo");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(75)
                    .HasComment("Slug của category");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(75)
                    .HasComment("Tên của category");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasComment("Thời gian cập nhật");
            });

            builder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.HasComment("Bảng lưu thông tin của product");

                entity.HasIndex(e => e.CategoryId, "CategoryId");

                entity.Property(e => e.Id).HasComment("Id của product");

                entity.Property(e => e.CategoryId).HasComment("Id của category");

                entity.Property(e => e.Config)
                    .HasMaxLength(1000)
                    .HasComment("Thông số kỹ thuật của sản phẩm lưu dưới dạng string json");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasComment("Nội dung sản phẩm (mô tả, giới thiệu,...)");

                entity.Property(e => e.Cost).HasComment("Giá nhập sản phẩm");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasComment("Thời gian tạo");

                entity.Property(e => e.Discount).HasComment("Giá tiền khuyến mại cho sản phẩm");

                entity.Property(e => e.Images)
                    .HasMaxLength(1000)
                    .HasComment("Danh sách ảnh của sản phẩm lưu dưới dạng string json");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("Tên của product");

                entity.Property(e => e.OnSale)
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Sản phẩm có đang được bày bán không. 0: không, 1: có");

                entity.Property(e => e.Price).HasComment("Giá bán sản phẩm");

                entity.Property(e => e.PublishedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("publishedDate")
                    .HasComment("Thời gian bày bán");

                entity.Property(e => e.Quantity)
                    .HasColumnType("smallint(6)")
                    .HasComment("Số lượng sản phẩm còn lại");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("Slug của product");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasComment("Thời gian cập nhật");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("product_ibfk_1");
            });

            builder.Entity<Producttag>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.TagId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("producttag");

                entity.HasComment("Bảng khóa ngoại lưu thông tin liên kết bảng product và bảng tag");

                entity.HasIndex(e => e.TagId, "producttag_ibfk_2");

                entity.Property(e => e.ProductId).HasComment("Id của product");

                entity.Property(e => e.TagId).HasComment("Id của tag");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Producttag)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("producttag_ibfk_1");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.Producttag)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("producttag_ibfk_2");
            });

            builder.Entity<Tag>(entity =>
            {
                entity.ToTable("tag");

                entity.HasComment("Bảng lưu thông tin của tag");

                entity.HasIndex(e => e.CategoryId, "CategoryId");

                entity.Property(e => e.Id).HasComment("Id của tag");

                entity.Property(e => e.CategoryId).HasComment("Id của category");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasComment("Nội dung của slug (mô tả, giới thiệu,...)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasComment("Thời gian tạo");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(75)
                    .HasComment("Slug của tag");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(75)
                    .HasComment("Tên của tag");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasComment("Thời gian cập nhật");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Tag)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("tag_ibfk_1");
            });

            builder.ConfigureWarehouse();
        }
    }
}