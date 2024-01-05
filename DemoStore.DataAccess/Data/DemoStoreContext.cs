using System;
using System.Collections.Generic;
using DemoStore.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoStore.DataAccess.Data;

public partial class DemoStoreContext : DbContext
{
    public DemoStoreContext()
    {
    }

    public DemoStoreContext(DbContextOptions<DemoStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActiveAdminComment> ActiveAdminComments { get; set; }

    public virtual DbSet<ActiveStorageAttachment> ActiveStorageAttachments { get; set; }

    public virtual DbSet<ActiveStorageBlob> ActiveStorageBlobs { get; set; }

    public virtual DbSet<ActiveStorageVariantRecord> ActiveStorageVariantRecords { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AdminUser> AdminUsers { get; set; }

    public virtual DbSet<ArInternalMetadatum> ArInternalMetadata { get; set; }

    public virtual DbSet<AraskJob> AraskJobs { get; set; }

    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<BannerItem> BannerItems { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<CartItem> CartItems { get; set; }

    public virtual DbSet<CategoriesProduct> CategoriesProducts { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<CmsPage> CmsPages { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Coupon> Coupons { get; set; }

    public virtual DbSet<CouponsUser> CouponsUsers { get; set; }

    public virtual DbSet<DemoRequest> DemoRequests { get; set; }

    public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }

    public virtual DbSet<Faq> Faqs { get; set; }

    public virtual DbSet<ImportProduct> ImportProducts { get; set; }

    public virtual DbSet<OptionType> OptionTypes { get; set; }

    public virtual DbSet<OptionTypesProduct> OptionTypesProducts { get; set; }

    public virtual DbSet<OptionValue> OptionValues { get; set; }

    public virtual DbSet<OptionValuesVariant> OptionValuesVariants { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderAddress> OrderAddresses { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<PosUser> PosUsers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Property> Properties { get; set; }

    public virtual DbSet<PublicContact> PublicContacts { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<SchemaMigration> SchemaMigrations { get; set; }

    public virtual DbSet<ShipRocketRaw> ShipRocketRaws { get; set; }

    public virtual DbSet<ShippingCharge> ShippingCharges { get; set; }

    public virtual DbSet<ShippingMethod> ShippingMethods { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<StoreDetail> StoreDetails { get; set; }

    public virtual DbSet<StoreSetting> StoreSettings { get; set; }

    public virtual DbSet<SubCategory> SubCategories { get; set; }

    public virtual DbSet<Subscriber> Subscribers { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    public virtual DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }

    public virtual DbSet<Taxis> Taxes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Variant> Variants { get; set; }

    public virtual DbSet<Wishlist> Wishlists { get; set; }

    public virtual DbSet<WishlistItem> WishlistItems { get; set; }

    public virtual DbSet<ZipCode> ZipCodes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5000;Database=DemoStore;Username=postgres;Password=Nikita@123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActiveAdminComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("active_admin_comments_pkey");

            entity.ToTable("active_admin_comments", "sonusingh2");

            entity.HasIndex(e => new { e.AuthorType, e.AuthorId }, "index_active_admin_comments_on_author_type_and_author_id");

            entity.HasIndex(e => e.Namespace, "index_active_admin_comments_on_namespace");

            entity.HasIndex(e => new { e.ResourceType, e.ResourceId }, "index_active_admin_comments_on_resource_type_and_resource_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.AuthorType)
                .HasColumnType("character varying")
                .HasColumnName("author_type");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Namespace)
                .HasColumnType("character varying")
                .HasColumnName("namespace");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.ResourceType)
                .HasColumnType("character varying")
                .HasColumnName("resource_type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ActiveStorageAttachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("active_storage_attachments_pkey");

            entity.ToTable("active_storage_attachments", "sonusingh2");

            entity.HasIndex(e => e.BlobId, "index_active_storage_attachments_on_blob_id");

            entity.HasIndex(e => new { e.RecordType, e.RecordId, e.Name, e.BlobId }, "index_active_storage_attachments_uniqueness").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BlobId).HasColumnName("blob_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.RecordId).HasColumnName("record_id");
            entity.Property(e => e.RecordType)
                .HasColumnType("character varying")
                .HasColumnName("record_type");

            entity.HasOne(d => d.Blob).WithMany(p => p.ActiveStorageAttachments)
                .HasForeignKey(d => d.BlobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rails_c3b3935057");
        });

        modelBuilder.Entity<ActiveStorageBlob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("active_storage_blobs_pkey");

            entity.ToTable("active_storage_blobs", "sonusingh2");

            entity.HasIndex(e => e.Key, "index_active_storage_blobs_on_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ByteSize).HasColumnName("byte_size");
            entity.Property(e => e.Checksum)
                .HasColumnType("character varying")
                .HasColumnName("checksum");
            entity.Property(e => e.ContentType)
                .HasColumnType("character varying")
                .HasColumnName("content_type");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Filename)
                .HasColumnType("character varying")
                .HasColumnName("filename");
            entity.Property(e => e.Key)
                .HasColumnType("character varying")
                .HasColumnName("key");
            entity.Property(e => e.Metadata).HasColumnName("metadata");
            entity.Property(e => e.ServiceName)
                .HasColumnType("character varying")
                .HasColumnName("service_name");
        });

        modelBuilder.Entity<ActiveStorageVariantRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("active_storage_variant_records_pkey");

            entity.ToTable("active_storage_variant_records", "sonusingh2");

            entity.HasIndex(e => new { e.BlobId, e.VariationDigest }, "index_active_storage_variant_records_uniqueness").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BlobId).HasColumnName("blob_id");
            entity.Property(e => e.VariationDigest)
                .HasColumnType("character varying")
                .HasColumnName("variation_digest");

            entity.HasOne(d => d.Blob).WithMany(p => p.ActiveStorageVariantRecords)
                .HasForeignKey(d => d.BlobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rails_993965df05");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("addresses_pkey");

            entity.ToTable("addresses", "sonusingh2");

            entity.HasIndex(e => e.PosUserId, "index_addresses_on_pos_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressLine1)
                .HasColumnType("character varying")
                .HasColumnName("address_line_1");
            entity.Property(e => e.AddressLine2)
                .HasColumnType("character varying")
                .HasColumnName("address_line_2");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FullName)
                .HasColumnType("character varying")
                .HasColumnName("full_name");
            entity.Property(e => e.Landmark)
                .HasColumnType("character varying")
                .HasColumnName("landmark");
            entity.Property(e => e.MobileNumber)
                .HasColumnType("character varying")
                .HasColumnName("mobile_number");
            entity.Property(e => e.Pincode)
                .HasColumnType("character varying")
                .HasColumnName("pincode");
            entity.Property(e => e.PosUserId).HasColumnName("pos_user_id");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.PosUser).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.PosUserId)
                .HasConstraintName("fk_rails_7c211ff7d1");
        });

        modelBuilder.Entity<AdminUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("admin_users_pkey");

            entity.ToTable("admin_users", "sonusingh2");

            entity.HasIndex(e => e.Email, "index_admin_users_on_email").IsUnique();

            entity.HasIndex(e => e.ResetPasswordToken, "index_admin_users_on_reset_password_token").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasDefaultValueSql("''::character varying")
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.EncryptedPassword)
                .HasDefaultValueSql("''::character varying")
                .HasColumnType("character varying")
                .HasColumnName("encrypted_password");
            entity.Property(e => e.RememberCreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("remember_created_at");
            entity.Property(e => e.ResetPasswordSentAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("reset_password_sent_at");
            entity.Property(e => e.ResetPasswordToken)
                .HasColumnType("character varying")
                .HasColumnName("reset_password_token");
            entity.Property(e => e.Role)
                .HasColumnType("character varying")
                .HasColumnName("role");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ArInternalMetadatum>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("ar_internal_metadata_pkey");

            entity.ToTable("ar_internal_metadata", "sonusingh2");

            entity.Property(e => e.Key)
                .HasColumnType("character varying")
                .HasColumnName("key");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Value)
                .HasColumnType("character varying")
                .HasColumnName("value");
        });

        modelBuilder.Entity<AraskJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("arask_jobs_pkey");

            entity.ToTable("arask_jobs", "sonusingh2");

            entity.HasIndex(e => e.ExecuteAt, "index_arask_jobs_on_execute_at");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.ExecuteAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("execute_at");
            entity.Property(e => e.Interval)
                .HasColumnType("character varying")
                .HasColumnName("interval");
            entity.Property(e => e.Job)
                .HasColumnType("character varying")
                .HasColumnName("job");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Banner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("banners_pkey");

            entity.ToTable("banners", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BannerType).HasColumnName("banner_type");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<BannerItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("banner_items_pkey");

            entity.ToTable("banner_items", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BannerId).HasColumnName("banner_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("brands_pkey");

            entity.ToTable("brands", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("carts_pkey");

            entity.ToTable("carts", "sonusingh2");

            entity.HasIndex(e => new { e.CartableType, e.CartableId }, "index_carts_on_cartable");

            entity.HasIndex(e => e.UserId, "index_carts_on_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.AppliedDiscount)
                .HasDefaultValueSql("0.0")
                .HasColumnName("applied_discount");
            entity.Property(e => e.CartToken)
                .HasColumnType("character varying")
                .HasColumnName("cart_token");
            entity.Property(e => e.CartableId).HasColumnName("cartable_id");
            entity.Property(e => e.CartableType)
                .HasColumnType("character varying")
                .HasColumnName("cartable_type");
            entity.Property(e => e.CouponId).HasColumnName("coupon_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");
            entity.Property(e => e.DiscountType)
                .HasColumnType("character varying")
                .HasColumnName("discount_type");
            entity.Property(e => e.ShippingCharge)
                .HasDefaultValueSql("0.0")
                .HasColumnName("shipping_charge");
            entity.Property(e => e.SubTotal).HasColumnName("sub_total");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalTax)
                .HasDefaultValueSql("0.0")
                .HasColumnName("total_tax");
            entity.Property(e => e.TotalWithTax)
                .HasDefaultValueSql("0.0")
                .HasColumnName("total_with_tax");
            entity.Property(e => e.TotalWithoutDiscount).HasColumnName("total_without_discount");
            entity.Property(e => e.TransactionId)
                .HasColumnType("character varying")
                .HasColumnName("transaction_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Carts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_rails_ea59a35211");
        });

        modelBuilder.Entity<CartItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cart_items_pkey");

            entity.ToTable("cart_items", "sonusingh2");

            entity.HasIndex(e => new { e.ProductableId, e.ProductableType }, "index_cart_items_on_productable_id_and_productable_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CartId).HasColumnName("cart_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.PriceWithoutTax).HasColumnName("price_without_tax");
            entity.Property(e => e.ProductName)
                .HasColumnType("character varying")
                .HasColumnName("product_name");
            entity.Property(e => e.ProductableId).HasColumnName("productable_id");
            entity.Property(e => e.ProductableType)
                .HasColumnType("character varying")
                .HasColumnName("productable_type");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.TaxAmount)
                .HasDefaultValueSql("0.0")
                .HasColumnName("tax_amount");
            entity.Property(e => e.TotalPrice).HasColumnName("total_price");
            entity.Property(e => e.TotalWithoutDiscount).HasColumnName("total_without_discount");
            entity.Property(e => e.UnitPrice).HasColumnName("unit_price");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CategoriesProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categories_products_pkey");

            entity.ToTable("categories_products", "sonusingh2");

            entity.HasIndex(e => e.CategoryId, "index_categories_products_on_category_id");

            entity.HasIndex(e => e.ProductId, "index_categories_products_on_product_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categories_pkey");

            entity.ToTable("categories", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cities_pkey");

            entity.ToTable("cities", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CmsPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cms_pages_pkey");

            entity.ToTable("cms_pages", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Slug)
                .HasColumnType("character varying")
                .HasColumnName("slug");
            entity.Property(e => e.Title)
                .HasColumnType("character varying")
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("contacts_pkey");

            entity.ToTable("contacts", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.FullPhoneNumber)
                .HasColumnType("character varying")
                .HasColumnName("full_phone_number");
            entity.Property(e => e.Message)
                .HasColumnType("character varying")
                .HasColumnName("message");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Coupon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("coupons_pkey");

            entity.ToTable("coupons", "sonusingh2");

            entity.HasIndex(e => e.PosUserId, "index_coupons_on_pos_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("character varying")
                .HasColumnName("amount");
            entity.Property(e => e.Code)
                .HasColumnType("character varying")
                .HasColumnName("code");
            entity.Property(e => e.CouponType).HasColumnName("coupon_type");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.ExpireAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("expire_at");
            entity.Property(e => e.MaxCartValue).HasColumnName("max_cart_value");
            entity.Property(e => e.MinCartValue).HasColumnName("min_cart_value");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PerUserUsage)
                .HasDefaultValueSql("1")
                .HasColumnName("per_user_usage");
            entity.Property(e => e.PosUserId).HasColumnName("pos_user_id");
            entity.Property(e => e.StartAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("start_at");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsageCount).HasColumnName("usage_count");
            entity.Property(e => e.UsageLimit).HasColumnName("usage_limit");

            entity.HasOne(d => d.PosUser).WithMany(p => p.Coupons)
                .HasForeignKey(d => d.PosUserId)
                .HasConstraintName("fk_rails_73f7d018f8");
        });

        modelBuilder.Entity<CouponsUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("coupons_users", "sonusingh2");

            entity.HasIndex(e => e.CouponId, "index_coupons_users_on_coupon_id");

            entity.HasIndex(e => e.UserId, "index_coupons_users_on_user_id");

            entity.Property(e => e.CouponId).HasColumnName("coupon_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<DemoRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("demo_requests_pkey");

            entity.ToTable("demo_requests", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BuisnessName)
                .HasColumnType("character varying")
                .HasColumnName("buisness_name");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.MobileNumber)
                .HasColumnType("character varying")
                .HasColumnName("mobile_number");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<EmailTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("email_templates_pkey");

            entity.ToTable("email_templates", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Subject)
                .HasColumnType("character varying")
                .HasColumnName("subject");
            entity.Property(e => e.TemplateName)
                .HasColumnType("character varying")
                .HasColumnName("template_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Faq>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("faqs_pkey");

            entity.ToTable("faqs", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Question)
                .HasColumnType("character varying")
                .HasColumnName("question");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ImportProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("import_products_pkey");

            entity.ToTable("import_products", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<OptionType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("option_types_pkey");

            entity.ToTable("option_types", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Presentation)
                .HasColumnType("character varying")
                .HasColumnName("presentation");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<OptionTypesProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("option_types_products_pkey");

            entity.ToTable("option_types_products", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.OptionTypeId).HasColumnName("option_type_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<OptionValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("option_values_pkey");

            entity.ToTable("option_values", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Display)
                .HasColumnType("character varying")
                .HasColumnName("display");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.OptionTypeId).HasColumnName("option_type_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<OptionValuesVariant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("option_values_variants_pkey");

            entity.ToTable("option_values_variants", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.OptionValueId).HasColumnName("option_value_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.VariantId).HasColumnName("variant_id");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_pkey");

            entity.ToTable("orders", "sonusingh2");

            entity.HasIndex(e => e.AdminUserId, "index_orders_on_admin_user_id");

            entity.HasIndex(e => e.PosUserId, "index_orders_on_pos_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdminUserId).HasColumnName("admin_user_id");
            entity.Property(e => e.AppliedDiscount).HasColumnName("applied_discount");
            entity.Property(e => e.Awb)
                .HasColumnType("character varying")
                .HasColumnName("awb");
            entity.Property(e => e.Breadth).HasColumnName("breadth");
            entity.Property(e => e.CancelledAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("cancelled_at");
            entity.Property(e => e.CartId)
                .HasColumnType("character varying")
                .HasColumnName("cart_id");
            entity.Property(e => e.ConfirmedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("confirmed_at");
            entity.Property(e => e.CouponId).HasColumnName("coupon_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DeliveredAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("delivered_at");
            entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");
            entity.Property(e => e.DiscountType)
                .HasColumnType("character varying")
                .HasColumnName("discount_type");
            entity.Property(e => e.DueAmount)
                .HasDefaultValueSql("0.0")
                .HasColumnName("due_amount");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Length).HasColumnName("length");
            entity.Property(e => e.OutForDeliveryAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("out_for_delivery_at");
            entity.Property(e => e.PaymentId)
                .HasColumnType("character varying")
                .HasColumnName("payment_id");
            entity.Property(e => e.PaymentMerchant)
                .HasColumnType("character varying")
                .HasColumnName("payment_merchant");
            entity.Property(e => e.PaymentMethod)
                .HasColumnType("character varying")
                .HasColumnName("payment_method");
            entity.Property(e => e.PlacedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("placed_at");
            entity.Property(e => e.PosOrder)
                .HasDefaultValueSql("false")
                .HasColumnName("pos_order");
            entity.Property(e => e.PosUserId).HasColumnName("pos_user_id");
            entity.Property(e => e.RefundedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("refunded_at");
            entity.Property(e => e.ReturnedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("returned_at");
            entity.Property(e => e.ShippedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("shipped_at");
            entity.Property(e => e.ShippingCharge).HasColumnName("shipping_charge");
            entity.Property(e => e.ShippmentId)
                .HasColumnType("character varying")
                .HasColumnName("shippment_id");
            entity.Property(e => e.Status)
                .HasColumnType("character varying")
                .HasColumnName("status");
            entity.Property(e => e.SubTotal).HasColumnName("sub_total");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalTax).HasColumnName("total_tax");
            entity.Property(e => e.TotalWithTax)
                .HasDefaultValueSql("0.0")
                .HasColumnName("total_with_tax");
            entity.Property(e => e.TransactionId)
                .HasColumnType("character varying")
                .HasColumnName("transaction_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.AdminUser).WithMany(p => p.Orders)
                .HasForeignKey(d => d.AdminUserId)
                .HasConstraintName("fk_rails_1ec7454755");

            entity.HasOne(d => d.PosUser).WithMany(p => p.Orders)
                .HasForeignKey(d => d.PosUserId)
                .HasConstraintName("fk_rails_254aa60568");
        });

        modelBuilder.Entity<OrderAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_addresses_pkey");

            entity.ToTable("order_addresses", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressLine1)
                .HasColumnType("character varying")
                .HasColumnName("address_line_1");
            entity.Property(e => e.AddressLine2)
                .HasColumnType("character varying")
                .HasColumnName("address_line_2");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FullName)
                .HasColumnType("character varying")
                .HasColumnName("full_name");
            entity.Property(e => e.Landmark)
                .HasColumnType("character varying")
                .HasColumnName("landmark");
            entity.Property(e => e.MobileNumber)
                .HasColumnType("character varying")
                .HasColumnName("mobile_number");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Pincode)
                .HasColumnType("character varying")
                .HasColumnName("pincode");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_items_pkey");

            entity.ToTable("order_items", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.PriceWithoutTax).HasColumnName("price_without_tax");
            entity.Property(e => e.ProductName)
                .HasColumnType("character varying")
                .HasColumnName("product_name");
            entity.Property(e => e.ProductableId).HasColumnName("productable_id");
            entity.Property(e => e.ProductableType)
                .HasColumnType("character varying")
                .HasColumnName("productable_type");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.TaxAmount)
                .HasDefaultValueSql("0.0")
                .HasColumnName("tax_amount");
            entity.Property(e => e.TotalPrice).HasColumnName("total_price");
            entity.Property(e => e.UnitPrice).HasColumnName("unit_price");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_statuses_pkey");

            entity.ToTable("order_statuses", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DisplayName)
                .HasColumnType("character varying")
                .HasColumnName("display_name");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payments_pkey");

            entity.ToTable("payments", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CompletedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("completed_at");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.PaymentMerchant)
                .HasColumnType("character varying")
                .HasColumnName("payment_merchant");
            entity.Property(e => e.PaymentMethod)
                .HasColumnType("character varying")
                .HasColumnName("payment_method");
            entity.Property(e => e.Status)
                .HasColumnType("character varying")
                .HasColumnName("status");
            entity.Property(e => e.TransactionId)
                .HasColumnType("character varying")
                .HasColumnName("transaction_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payment_methods_pkey");

            entity.ToTable("payment_methods", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApiKey)
                .HasColumnType("character varying")
                .HasColumnName("api_key");
            entity.Property(e => e.ApiSecret)
                .HasColumnType("character varying")
                .HasColumnName("api_secret");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<PosUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pos_users_pkey");

            entity.ToTable("pos_users", "sonusingh2");

            entity.HasIndex(e => e.ResetPasswordToken, "index_pos_users_on_reset_password_token").IsUnique();

            entity.HasIndex(e => e.Username, "index_pos_users_on_username").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasDefaultValueSql("''::character varying")
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.EncryptedPassword)
                .HasDefaultValueSql("''::character varying")
                .HasColumnType("character varying")
                .HasColumnName("encrypted_password");
            entity.Property(e => e.RememberCreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("remember_created_at");
            entity.Property(e => e.ResetPasswordSentAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("reset_password_sent_at");
            entity.Property(e => e.ResetPasswordToken)
                .HasColumnType("character varying")
                .HasColumnName("reset_password_token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Username)
                .HasDefaultValueSql("''::character varying")
                .HasColumnType("character varying")
                .HasColumnName("username");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_pkey");

            entity.ToTable("products", "sonusingh2");

            entity.HasIndex(e => e.DeletedAt, "index_products_on_deleted_at");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AverageRating).HasColumnName("average_rating");
            entity.Property(e => e.BarCode)
                .HasColumnType("character varying")
                .HasColumnName("bar_code");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.ComparePrice).HasColumnName("compare_price");
            entity.Property(e => e.CostPrice).HasColumnName("cost_price");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("deleted_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.HsnCode)
                .HasColumnType("character varying")
                .HasColumnName("hsn_code");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PriceWithTax).HasColumnName("price_with_tax");
            entity.Property(e => e.PriceWithoutTax).HasColumnName("price_without_tax");
            entity.Property(e => e.SellPrice).HasColumnName("sell_price");
            entity.Property(e => e.Sku)
                .HasColumnType("character varying")
                .HasColumnName("sku");
            entity.Property(e => e.StockQty).HasColumnName("stock_qty");
            entity.Property(e => e.TaxAmount).HasColumnName("tax_amount");
            entity.Property(e => e.TaxId).HasColumnName("tax_id");
            entity.Property(e => e.TaxType).HasColumnName("tax_type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Property>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("properties_pkey");

            entity.ToTable("properties", "sonusingh2");

            entity.HasIndex(e => e.DeletedAt, "index_properties_on_deleted_at");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("deleted_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.ShowProperty)
                .HasDefaultValueSql("true")
                .HasColumnName("show_property");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Value)
                .HasColumnType("character varying")
                .HasColumnName("value");
        });

        modelBuilder.Entity<PublicContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("public_contacts_pkey");

            entity.ToTable("public_contacts", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasColumnType("character varying")
                .HasColumnName("phone");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("reviews_pkey");

            entity.ToTable("reviews", "sonusingh2");

            entity.HasIndex(e => e.DeletedAt, "index_reviews_on_deleted_at");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment).HasColumnName("comment");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("deleted_at");
            entity.Property(e => e.OrderItemId).HasColumnName("order_item_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<SchemaMigration>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("schema_migrations_pkey");

            entity.ToTable("schema_migrations", "sonusingh2");

            entity.Property(e => e.Version)
                .HasColumnType("character varying")
                .HasColumnName("version");
        });

        modelBuilder.Entity<ShipRocketRaw>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ship_rocket_raws_pkey");

            entity.ToTable("ship_rocket_raws", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Payload)
                .HasColumnType("json")
                .HasColumnName("payload");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ShippingCharge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("shipping_charges_pkey");

            entity.ToTable("shipping_charges", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Charge).HasColumnName("charge");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.LessThan).HasColumnName("less_than");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ShippingMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("shipping_methods_pkey");

            entity.ToTable("shipping_methods", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasColumnType("character varying")
                .HasColumnName("password");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("states_pkey");

            entity.ToTable("states", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasColumnType("character varying")
                .HasColumnName("code");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.GstCode)
                .HasColumnType("character varying")
                .HasColumnName("gst_code");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stores_pkey");

            entity.ToTable("stores", "sonusingh2");

            entity.HasIndex(e => e.SubscriptionPlanId, "index_stores_on_subscription_plan_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Subdomain)
                .HasColumnType("character varying")
                .HasColumnName("subdomain");
            entity.Property(e => e.SubscriptionPlanId).HasColumnName("subscription_plan_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<StoreDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("store_details_pkey");

            entity.ToTable("store_details", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdminUserId).HasColumnName("admin_user_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.OrderBalance).HasColumnName("order_balance");
            entity.Property(e => e.Phone)
                .HasColumnType("character varying")
                .HasColumnName("phone");
            entity.Property(e => e.RazorpayCustId)
                .HasColumnType("character varying")
                .HasColumnName("razorpay_cust_id");
            entity.Property(e => e.StoreName)
                .HasColumnType("character varying")
                .HasColumnName("store_name");
            entity.Property(e => e.Subdomain)
                .HasColumnType("character varying")
                .HasColumnName("subdomain");
            entity.Property(e => e.SubscriptionDate).HasColumnName("subscription_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<StoreSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("store_settings_pkey");

            entity.ToTable("store_settings", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasColumnType("character varying")
                .HasColumnName("address");
            entity.Property(e => e.AllowCashOnDelivery)
                .HasDefaultValueSql("true")
                .HasColumnName("allow_cash_on_delivery");
            entity.Property(e => e.AllowDuePayments)
                .HasDefaultValueSql("false")
                .HasColumnName("allow_due_payments");
            entity.Property(e => e.BackgroundColor)
                .HasDefaultValueSql("'#000000'::character varying")
                .HasColumnType("character varying")
                .HasColumnName("background_color");
            entity.Property(e => e.BorderColor)
                .HasDefaultValueSql("'#000000'::character varying")
                .HasColumnType("character varying")
                .HasColumnName("border_color");
            entity.Property(e => e.BulkgateAppId)
                .HasColumnType("character varying")
                .HasColumnName("bulkgate_app_id");
            entity.Property(e => e.BulkgateAppToken)
                .HasColumnType("character varying")
                .HasColumnName("bulkgate_app_token");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.CountryCode)
                .HasColumnType("character varying")
                .HasColumnName("country_code");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CurrencyCode)
                .HasColumnType("character varying")
                .HasColumnName("currency_code");
            entity.Property(e => e.CustomerCareNumber)
                .HasColumnType("character varying")
                .HasColumnName("customer_care_number");
            entity.Property(e => e.CustomerSupportEmail)
                .HasColumnType("character varying")
                .HasColumnName("customer_support_email");
            entity.Property(e => e.FacebookUrl)
                .HasColumnType("character varying")
                .HasColumnName("facebook_url");
            entity.Property(e => e.FirebaseKey).HasColumnName("firebase_key");
            entity.Property(e => e.GstNumber)
                .HasColumnType("character varying")
                .HasColumnName("gst_number");
            entity.Property(e => e.HoverColor)
                .HasDefaultValueSql("'#CCCCCC'::character varying")
                .HasColumnType("character varying")
                .HasColumnName("hover_color");
            entity.Property(e => e.InstagramUrl)
                .HasColumnType("character varying")
                .HasColumnName("instagram_url");
            entity.Property(e => e.MailFromAddress)
                .HasColumnType("character varying")
                .HasColumnName("mail_from_address");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.NewOrderNotificationsEmail)
                .HasColumnType("character varying")
                .HasColumnName("new_order_notifications_email");
            entity.Property(e => e.PrintA4Format)
                .HasDefaultValueSql("false")
                .HasColumnName("print_a4_format");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.TextColor)
                .HasDefaultValueSql("'#FFFFFF'::character varying")
                .HasColumnType("character varying")
                .HasColumnName("text_color");
            entity.Property(e => e.TwitterUrl)
                .HasColumnType("character varying")
                .HasColumnName("twitter_url");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.YoutubeUrl)
                .HasColumnType("character varying")
                .HasColumnName("youtube_url");
        });

        modelBuilder.Entity<SubCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sub_categories_pkey");

            entity.ToTable("sub_categories", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Subscriber>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("subscribers_pkey");

            entity.ToTable("subscribers", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("subscriptions_pkey");

            entity.ToTable("subscriptions", "sonusingh2");

            entity.HasIndex(e => e.StoreDetailId, "index_subscriptions_on_store_detail_id");

            entity.HasIndex(e => e.SubscriptionPlanId, "index_subscriptions_on_subscription_plan_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.ExpireAt).HasColumnName("expire_at");
            entity.Property(e => e.RazorpayPaymentId)
                .HasColumnType("character varying")
                .HasColumnName("razorpay_payment_id");
            entity.Property(e => e.RazorpaySubsId)
                .HasColumnType("character varying")
                .HasColumnName("razorpay_subs_id");
            entity.Property(e => e.StartAt).HasColumnName("start_at");
            entity.Property(e => e.Status)
                .HasColumnType("character varying")
                .HasColumnName("status");
            entity.Property(e => e.StoreDetailId).HasColumnName("store_detail_id");
            entity.Property(e => e.SubscriptionPlanId).HasColumnName("subscription_plan_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<SubscriptionPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("subscription_plans_pkey");

            entity.ToTable("subscription_plans", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.BillingCycle).HasColumnName("billing_cycle");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.OrdersAllowed).HasColumnName("orders_allowed");
            entity.Property(e => e.Period)
                .HasColumnType("character varying")
                .HasColumnName("period");
            entity.Property(e => e.PlanName)
                .HasColumnType("character varying")
                .HasColumnName("plan_name");
            entity.Property(e => e.RazorpayPlanId)
                .HasColumnType("character varying")
                .HasColumnName("razorpay_plan_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Taxis>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("taxes_pkey");

            entity.ToTable("taxes", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.TaxPercentage).HasColumnName("tax_percentage");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activated)
                .HasDefaultValueSql("true")
                .HasColumnName("activated");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.FullPhoneNumber)
                .HasColumnType("character varying")
                .HasColumnName("full_phone_number");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PasswordDigest)
                .HasColumnType("character varying")
                .HasColumnName("password_digest");
            entity.Property(e => e.PasswordResetSentAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("password_reset_sent_at");
            entity.Property(e => e.Pin)
                .HasColumnType("character varying")
                .HasColumnName("pin");
            entity.Property(e => e.StripeId)
                .HasColumnType("character varying")
                .HasColumnName("stripe_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Variant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("variants_pkey");

            entity.ToTable("variants", "sonusingh2");

            entity.HasIndex(e => e.DeletedAt, "index_variants_on_deleted_at");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BarCode)
                .HasColumnType("character varying")
                .HasColumnName("bar_code");
            entity.Property(e => e.ComparePrice).HasColumnName("compare_price");
            entity.Property(e => e.CostPrice).HasColumnName("cost_price");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("deleted_at");
            entity.Property(e => e.HsnCode)
                .HasColumnType("character varying")
                .HasColumnName("hsn_code");
            entity.Property(e => e.PriceWithTax).HasColumnName("price_with_tax");
            entity.Property(e => e.PriceWithoutTax).HasColumnName("price_without_tax");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.SellPrice).HasColumnName("sell_price");
            entity.Property(e => e.Sku)
                .HasColumnType("character varying")
                .HasColumnName("sku");
            entity.Property(e => e.StockQty).HasColumnName("stock_qty");
            entity.Property(e => e.TaxAmount).HasColumnName("tax_amount");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Wishlist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("wishlists_pkey");

            entity.ToTable("wishlists", "sonusingh2");

            entity.HasIndex(e => e.PosUserId, "index_wishlists_on_pos_user_id");

            entity.HasIndex(e => e.UserId, "index_wishlists_on_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.PosUserId).HasColumnName("pos_user_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.PosUser).WithMany(p => p.Wishlists)
                .HasForeignKey(d => d.PosUserId)
                .HasConstraintName("fk_rails_860b77682f");
        });

        modelBuilder.Entity<WishlistItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("wishlist_items_pkey");

            entity.ToTable("wishlist_items", "sonusingh2");

            entity.HasIndex(e => e.DeletedAt, "index_wishlist_items_on_deleted_at");

            entity.HasIndex(e => e.WishlistId, "index_wishlist_items_on_wishlist_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("deleted_at");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.WishlistId).HasColumnName("wishlist_id");
        });

        modelBuilder.Entity<ZipCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("zip_codes_pkey");

            entity.ToTable("zip_codes", "sonusingh2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Charge).HasColumnName("charge");
            entity.Property(e => e.Code)
                .HasColumnType("character varying")
                .HasColumnName("code");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.PriceLessThan).HasColumnName("price_less_than");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
