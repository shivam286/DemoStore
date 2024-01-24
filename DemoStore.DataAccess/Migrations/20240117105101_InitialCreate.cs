using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "sonusingh2");

            migrationBuilder.CreateTable(
                name: "active_admin_comments",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    @namespace = table.Column<string>(name: "namespace", type: "TEXT", nullable: true),
                    body = table.Column<string>(type: "TEXT", nullable: true),
                    resource_type = table.Column<string>(type: "TEXT", nullable: true),
                    resource_id = table.Column<int>(type: "INTEGER", nullable: true),
                    author_type = table.Column<string>(type: "TEXT", nullable: true),
                    author_id = table.Column<int>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("active_admin_comments_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "active_storage_blobs",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    key = table.Column<string>(type: "TEXT", nullable: false),
                    filename = table.Column<string>(type: "TEXT", nullable: false),
                    content_type = table.Column<string>(type: "TEXT", nullable: true),
                    metadata = table.Column<string>(type: "TEXT", nullable: true),
                    byte_size = table.Column<long>(type: "INTEGER", nullable: false),
                    checksum = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    service_name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("active_storage_blobs_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
    name: "admin_users",
    schema: "sonusingh2",
    columns: table => new
    {
        id = table.Column<long>(type: "INTEGER", nullable: false)
            .Annotation("Sqlite:Autoincrement", true),
        email = table.Column<string>(type: "TEXT", nullable: false, defaultValue: ""),
        encrypted_password = table.Column<string>(type: "TEXT", nullable: false, defaultValue: ""),
        reset_password_token = table.Column<string>(type: "TEXT", nullable: true),
        reset_password_sent_at = table.Column<DateTime>(type: "TEXT", nullable: true),
        remember_created_at = table.Column<DateTime>(type: "TEXT", nullable: true),
        created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
        updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
        role = table.Column<string>(type: "TEXT", nullable: true)
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_admin_users", x => x.id).Annotation("Sqlite:Autoincrement", true);
    });


            migrationBuilder.CreateTable(
                name: "ar_internal_metadata",
                schema: "sonusingh2",
                columns: table => new
                {
                    key = table.Column<string>(type: "TEXT", nullable: false),
                    value = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ar_internal_metadata_pkey", x => x.key);
                });

            migrationBuilder.CreateTable(
                name: "arask_jobs",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    job = table.Column<string>(type: "TEXT", nullable: true),
                    execute_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    interval = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("arask_jobs_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "banner_items",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    banner_id = table.Column<int>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("banner_items_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "banners",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    banner_type = table.Column<int>(type: "INTEGER", nullable: true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("banners_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "brands",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("brands_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cart_items",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cart_id = table.Column<int>(type: "INTEGER", nullable: true),
                    product_name = table.Column<string>(type: "TEXT", nullable: true),
                    unit_price = table.Column<decimal>(type: "TEXT", nullable: true),
                    quantity = table.Column<int>(type: "INTEGER", nullable: true),
                    total_price = table.Column<decimal>(type: "TEXT", nullable: true),
                    productable_id = table.Column<long>(type: "INTEGER", nullable: true),
                    productable_type = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    tax_amount = table.Column<decimal>(type: "TEXT", nullable: true, defaultValue: ""),
                    price_without_tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    total_without_discount = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("cart_items_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    parent_id = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("categories_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "categories_products",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category_id = table.Column<long>(type: "INTEGER", nullable: true),
                    product_id = table.Column<long>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("categories_products_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    state_id = table.Column<int>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("cities_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cms_pages",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(type: "TEXT", nullable: true),
                    slug = table.Column<string>(type: "TEXT", nullable: true),
                    content = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("cms_pages_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    full_phone_number = table.Column<string>(type: "TEXT", nullable: true),
                    message = table.Column<string>(type: "TEXT", nullable: true),
                    user_id = table.Column<int>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("contacts_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "coupons_users",
                schema: "sonusingh2",
                columns: table => new
                {
                    user_id = table.Column<long>(type: "INTEGER", nullable: true),
                    coupon_id = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "demo_requests",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    mobile_number = table.Column<string>(type: "TEXT", nullable: true),
                    buisness_name = table.Column<string>(type: "TEXT", nullable: true),
                    city = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("demo_requests_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "email_templates",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    subject = table.Column<string>(type: "TEXT", nullable: true),
                    body = table.Column<string>(type: "TEXT", nullable: true),
                    template_name = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("email_templates_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "faqs",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    question = table.Column<string>(type: "TEXT", nullable: true),
                    answer = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("faqs_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "import_products",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    status = table.Column<int>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("import_products_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "option_types",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    presentation = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("option_types_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "option_types_products",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    product_id = table.Column<int>(type: "INTEGER", nullable: true),
                    option_type_id = table.Column<int>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("option_types_products_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "option_values",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    option_type_id = table.Column<int>(type: "INTEGER", nullable: true),
                    display = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("option_values_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "option_values_variants",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    option_value_id = table.Column<int>(type: "INTEGER", nullable: true),
                    variant_id = table.Column<int>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("option_values_variants_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "order_addresses",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    order_id = table.Column<int>(type: "INTEGER", nullable: true),
                    full_name = table.Column<string>(type: "TEXT", nullable: true),
                    mobile_number = table.Column<string>(type: "TEXT", nullable: true),
                    pincode = table.Column<string>(type: "TEXT", nullable: true),
                    address_line_1 = table.Column<string>(type: "TEXT", nullable: true),
                    address_line_2 = table.Column<string>(type: "TEXT", nullable: true),
                    landmark = table.Column<string>(type: "TEXT", nullable: true),
                    city = table.Column<string>(type: "TEXT", nullable: true),
                    state = table.Column<string>(type: "TEXT", nullable: true),
                    country = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    state_id = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("order_addresses_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "order_items",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    order_id = table.Column<int>(type: "INTEGER", nullable: true),
                    product_name = table.Column<string>(type: "TEXT", nullable: true),
                    unit_price = table.Column<decimal>(type: "TEXT", nullable: true),
                    quantity = table.Column<int>(type: "INTEGER", nullable: true),
                    total_price = table.Column<decimal>(type: "TEXT", nullable: true),
                    productable_id = table.Column<long>(type: "INTEGER", nullable: true),
                    productable_type = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    tax_amount = table.Column<decimal>(type: "TEXT", nullable: true, defaultValue: ""),
                    price_without_tax = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("order_items_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "order_statuses",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    display_name = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("order_statuses_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "payment_methods",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<int>(type: "INTEGER", nullable: true),
                    api_key = table.Column<string>(type: "TEXT", nullable: true),
                    api_secret = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("payment_methods_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    order_id = table.Column<int>(type: "INTEGER", nullable: true),
                    amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    payment_method = table.Column<string>(type: "TEXT", nullable: true),
                    transaction_id = table.Column<string>(type: "TEXT", nullable: true),
                    status = table.Column<string>(type: "TEXT", nullable: true),
                    completed_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    payment_merchant = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("payments_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pos_users",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    email = table.Column<string>(type: "TEXT", nullable: true, defaultValue: "''::TEXT"),
                    username = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "''::TEXT"),
                    encrypted_password = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "''::TEXT"),
                    reset_password_token = table.Column<string>(type: "TEXT", nullable: true),
                    reset_password_sent_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    remember_created_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pos_users_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    sell_price = table.Column<decimal>(type: "TEXT", nullable: true),
                    compare_price = table.Column<decimal>(type: "TEXT", nullable: true),
                    cost_price = table.Column<decimal>(type: "TEXT", nullable: true),
                    description = table.Column<string>(type: "TEXT", nullable: true),
                    hsn_code = table.Column<string>(type: "TEXT", nullable: true),
                    sku = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    brand_id = table.Column<int>(type: "INTEGER", nullable: true),
                    stock_qty = table.Column<int>(type: "INTEGER", nullable: true),
                    tax_id = table.Column<int>(type: "INTEGER", nullable: true),
                    tax_type = table.Column<int>(type: "INTEGER", nullable: true),
                    tax_amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    price_with_tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    price_without_tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    average_rating = table.Column<decimal>(type: "TEXT", nullable: true),
                    bar_code = table.Column<string>(type: "TEXT", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("products_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "properties",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    value = table.Column<string>(type: "TEXT", nullable: true),
                    show_property = table.Column<bool>(type: "INTEGER", nullable: true, defaultValue: "true"),
                    product_id = table.Column<int>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("properties_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "public_contacts",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    phone = table.Column<string>(type: "TEXT", nullable: true),
                    message = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("public_contacts_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "reviews",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    user_id = table.Column<int>(type: "INTEGER", nullable: true),
                    product_id = table.Column<int>(type: "INTEGER", nullable: true),
                    rating = table.Column<decimal>(type: "TEXT", nullable: true),
                    comment = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    order_item_id = table.Column<int>(type: "INTEGER", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("reviews_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "schema_migrations",
                schema: "sonusingh2",
                columns: table => new
                {
                    version = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("schema_migrations_pkey", x => x.version);
                });

            migrationBuilder.CreateTable(
                name: "ship_rocket_raws",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    payload = table.Column<string>(type: "json", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ship_rocket_raws_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "shipping_charges",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    less_than = table.Column<int>(type: "INTEGER", nullable: true),
                    charge = table.Column<int>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("shipping_charges_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "shipping_methods",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    password = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("shipping_methods_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "states",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    code = table.Column<string>(type: "TEXT", nullable: true),
                    gst_code = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("states_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "store_details",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    store_name = table.Column<string>(type: "TEXT", nullable: true),
                    subdomain = table.Column<string>(type: "TEXT", nullable: true),
                    phone = table.Column<string>(type: "TEXT", nullable: true),
                    admin_user_id = table.Column<int>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    razorpay_cust_id = table.Column<string>(type: "TEXT", nullable: true),
                    order_balance = table.Column<int>(type: "INTEGER", nullable: true),
                    subscription_date = table.Column<DateOnly>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("store_details_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "store_settings",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    country = table.Column<string>(type: "TEXT", nullable: true),
                    currency_code = table.Column<string>(type: "TEXT", nullable: true),
                    address = table.Column<string>(type: "TEXT", nullable: true),
                    customer_care_number = table.Column<string>(type: "TEXT", nullable: true),
                    gst_number = table.Column<string>(type: "TEXT", nullable: true),
                    facebook_url = table.Column<string>(type: "TEXT", nullable: true),
                    instagram_url = table.Column<string>(type: "TEXT", nullable: true),
                    twitter_url = table.Column<string>(type: "TEXT", nullable: true),
                    youtube_url = table.Column<string>(type: "TEXT", nullable: true),
                    firebase_key = table.Column<string>(type: "TEXT", nullable: true),
                    mail_from_address = table.Column<string>(type: "TEXT", nullable: true),
                    customer_support_email = table.Column<string>(type: "TEXT", nullable: true),
                    new_order_notifications_email = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    background_color = table.Column<string>(type: "TEXT", nullable: true, defaultValue: "'#000000'::TEXT"),
                    text_color = table.Column<string>(type: "TEXT", nullable: true, defaultValue: "'#FFFFFF'::TEXT"),
                    border_color = table.Column<string>(type: "TEXT", nullable: true, defaultValue: "'#000000'::TEXT"),
                    hover_color = table.Column<string>(type: "TEXT", nullable: true, defaultValue: "'#CCCCCC'::TEXT"),
                    bulkgate_app_id = table.Column<string>(type: "TEXT", nullable: true),
                    bulkgate_app_token = table.Column<string>(type: "TEXT", nullable: true),
                    allow_cash_on_delivery = table.Column<bool>(type: "INTEGER", nullable: true, defaultValue: "true"),
                    country_code = table.Column<string>(type: "TEXT", nullable: true),
                    state_id = table.Column<int>(type: "INTEGER", nullable: true),
                    allow_due_payments = table.Column<bool>(type: "INTEGER", nullable: true, defaultValue: "false"),
                    print_a4_format = table.Column<bool>(type: "INTEGER", nullable: true, defaultValue: "false")
                },
                constraints: table =>
                {
                    table.PrimaryKey("store_settings_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    subdomain = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    phone = table.Column<long>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    subscription_plan_id = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("stores_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sub_categories",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    category_id = table.Column<int>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("sub_categories_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "subscribers",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("subscribers_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "subscription_plans",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    plan_name = table.Column<string>(type: "TEXT", nullable: true),
                    description = table.Column<string>(type: "TEXT", nullable: true),
                    period = table.Column<string>(type: "TEXT", nullable: true),
                    billing_cycle = table.Column<int>(type: "INTEGER", nullable: true),
                    amount = table.Column<double>(type: "REAL", nullable: true),
                    razorpay_plan_id = table.Column<string>(type: "TEXT", nullable: true),
                    active = table.Column<bool>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    orders_allowed = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("subscription_plans_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "subscriptions",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    subscription_plan_id = table.Column<long>(type: "INTEGER", nullable: true),
                    store_detail_id = table.Column<long>(type: "INTEGER", nullable: true),
                    razorpay_subs_id = table.Column<string>(type: "TEXT", nullable: true),
                    razorpay_payment_id = table.Column<string>(type: "TEXT", nullable: true),
                    start_at = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    expire_at = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    status = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("subscriptions_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "taxes",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    tax_percentage = table.Column<decimal>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("taxes_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    password_digest = table.Column<string>(type: "TEXT", nullable: true),
                    full_phone_number = table.Column<string>(type: "TEXT", nullable: true),
                    activated = table.Column<bool>(type: "INTEGER", nullable: true, defaultValue: "true"),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    pin = table.Column<string>(type: "TEXT", nullable: true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    stripe_id = table.Column<string>(type: "TEXT", nullable: true),
                    password_reset_sent_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("users_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "variants",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    sku = table.Column<string>(type: "TEXT", nullable: true),
                    hsn_code = table.Column<string>(type: "TEXT", nullable: true),
                    sell_price = table.Column<decimal>(type: "TEXT", nullable: true),
                    compare_price = table.Column<decimal>(type: "TEXT", nullable: true),
                    cost_price = table.Column<decimal>(type: "TEXT", nullable: true),
                    product_id = table.Column<int>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    stock_qty = table.Column<int>(type: "INTEGER", nullable: true),
                    tax_amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    price_with_tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    price_without_tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    bar_code = table.Column<string>(type: "TEXT", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("variants_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "wishlist_items",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    wishlist_id = table.Column<long>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    product_id = table.Column<int>(type: "INTEGER", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("wishlist_items_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "zip_codes",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    code = table.Column<string>(type: "TEXT", nullable: true),
                    charge = table.Column<int>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    price_less_than = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("zip_codes_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "active_storage_attachments",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    record_type = table.Column<string>(type: "TEXT", nullable: false),
                    record_id = table.Column<long>(type: "INTEGER", nullable: false),
                    blob_id = table.Column<long>(type: "INTEGER", nullable: false),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("active_storage_attachments_pkey", x => x.id);
                    table.ForeignKey(
                        name: "fk_rails_c3b3935057",
                        column: x => x.blob_id,
                        principalSchema: "sonusingh2",
                        principalTable: "active_storage_blobs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "active_storage_variant_records",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    blob_id = table.Column<long>(type: "INTEGER", nullable: false),
                    variation_digest = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("active_storage_variant_records_pkey", x => x.id);
                    table.ForeignKey(
                        name: "fk_rails_993965df05",
                        column: x => x.blob_id,
                        principalSchema: "sonusingh2",
                        principalTable: "active_storage_blobs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "addresses",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    user_id = table.Column<int>(type: "INTEGER", nullable: true),
                    full_name = table.Column<string>(type: "TEXT", nullable: true),
                    mobile_number = table.Column<string>(type: "TEXT", nullable: true),
                    pincode = table.Column<string>(type: "TEXT", nullable: true),
                    address_line_1 = table.Column<string>(type: "TEXT", nullable: true),
                    address_line_2 = table.Column<string>(type: "TEXT", nullable: true),
                    landmark = table.Column<string>(type: "TEXT", nullable: true),
                    city = table.Column<string>(type: "TEXT", nullable: true),
                    state = table.Column<string>(type: "TEXT", nullable: true),
                    country = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    pos_user_id = table.Column<long>(type: "INTEGER", nullable: true),
                    state_id = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("addresses_pkey", x => x.id);
                    table.ForeignKey(
                        name: "fk_rails_7c211ff7d1",
                        column: x => x.pos_user_id,
                        principalSchema: "sonusingh2",
                        principalTable: "pos_users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "coupons",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    code = table.Column<string>(type: "TEXT", nullable: true),
                    coupon_type = table.Column<int>(type: "INTEGER", nullable: true),
                    amount = table.Column<string>(type: "TEXT", nullable: true),
                    description = table.Column<string>(type: "TEXT", nullable: true),
                    usage_limit = table.Column<int>(type: "INTEGER", nullable: true),
                    usage_count = table.Column<int>(type: "INTEGER", nullable: true),
                    start_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    expire_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    per_user_usage = table.Column<int>(type: "INTEGER", nullable: true, defaultValue: "1"),
                    min_cart_value = table.Column<decimal>(type: "TEXT", nullable: true),
                    max_cart_value = table.Column<decimal>(type: "TEXT", nullable: true),
                    pos_user_id = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("coupons_pkey", x => x.id);
                    table.ForeignKey(
                        name: "fk_rails_73f7d018f8",
                        column: x => x.pos_user_id,
                        principalSchema: "sonusingh2",
                        principalTable: "pos_users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "orders",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    user_id = table.Column<int>(type: "INTEGER", nullable: true),
                    status = table.Column<string>(type: "TEXT", nullable: true),
                    total_tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    shipping_charge = table.Column<decimal>(type: "TEXT", nullable: true),
                    sub_total = table.Column<decimal>(type: "TEXT", nullable: true),
                    total = table.Column<decimal>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    applied_discount = table.Column<decimal>(type: "TEXT", nullable: true),
                    coupon_id = table.Column<int>(type: "INTEGER", nullable: true),
                    transaction_id = table.Column<string>(type: "TEXT", nullable: true),
                    cart_id = table.Column<string>(type: "TEXT", nullable: true),
                    payment_id = table.Column<string>(type: "TEXT", nullable: true),
                    payment_method = table.Column<string>(type: "TEXT", nullable: true),
                    total_with_tax = table.Column<decimal>(type: "TEXT", nullable: true, defaultValue: "0.0"),
                    shippment_id = table.Column<string>(type: "TEXT", nullable: true),
                    length = table.Column<int>(type: "INTEGER", nullable: true),
                    breadth = table.Column<int>(type: "INTEGER", nullable: true),
                    height = table.Column<int>(type: "INTEGER", nullable: true),
                    weight = table.Column<decimal>(type: "TEXT", nullable: true),
                    awb = table.Column<string>(type: "TEXT", nullable: true),
                    placed_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    confirmed_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    cancelled_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    shipped_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    out_for_delivery_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    delivered_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    returned_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    refunded_at = table.Column<DateTime>(type: "TEXT", nullable: true),
                    pos_user_id = table.Column<long>(type: "INTEGER", nullable: true),
                    pos_order = table.Column<bool>(type: "INTEGER", nullable: true, defaultValue: "false"),
                    admin_user_id = table.Column<long>(type: "INTEGER", nullable: true),
                    discount_percent = table.Column<decimal>(type: "TEXT", nullable: true),
                    payment_merchant = table.Column<string>(type: "TEXT", nullable: true),
                    due_amount = table.Column<decimal>(type: "TEXT", nullable: true, defaultValue: "0.0"),
                    discount_type = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("orders_pkey", x => x.id);
                    table.ForeignKey(
                        name: "fk_rails_1ec7454755",
                        column: x => x.admin_user_id,
                        principalSchema: "sonusingh2",
                        principalTable: "admin_users",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_rails_254aa60568",
                        column: x => x.pos_user_id,
                        principalSchema: "sonusingh2",
                        principalTable: "pos_users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "wishlists",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    user_id = table.Column<long>(type: "INTEGER", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    pos_user_id = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("wishlists_pkey", x => x.id);
                    table.ForeignKey(
                        name: "fk_rails_860b77682f",
                        column: x => x.pos_user_id,
                        principalSchema: "sonusingh2",
                        principalTable: "pos_users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "carts",
                schema: "sonusingh2",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    sub_total = table.Column<decimal>(type: "TEXT", nullable: true),
                    total = table.Column<decimal>(type: "TEXT", nullable: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    address_id = table.Column<int>(type: "INTEGER", nullable: true),
                    total_tax = table.Column<decimal>(type: "TEXT", nullable: true, defaultValue: "0.0"),
                    shipping_charge = table.Column<decimal>(type: "TEXT", nullable: true, defaultValue: "0.0"),
                    applied_discount = table.Column<decimal>(type: "TEXT", nullable: true, defaultValue: "0.0"),
                    coupon_id = table.Column<int>(type: "INTEGER", nullable: true),
                    cart_token = table.Column<string>(type: "TEXT", nullable: true),
                    transaction_id = table.Column<string>(type: "TEXT", nullable: true),
                    total_with_tax = table.Column<decimal>(type: "TEXT", nullable: true, defaultValue: "0.0"),
                    cartable_type = table.Column<string>(type: "TEXT", nullable: true),
                    cartable_id = table.Column<long>(type: "INTEGER", nullable: true),
                    user_id = table.Column<long>(type: "INTEGER", nullable: true),
                    discount_percent = table.Column<decimal>(type: "TEXT", nullable: true),
                    discount_type = table.Column<string>(type: "TEXT", nullable: true),
                    total_without_discount = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("carts_pkey", x => x.id);
                    table.ForeignKey(
                        name: "fk_rails_ea59a35211",
                        column: x => x.user_id,
                        principalSchema: "sonusingh2",
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "index_active_admin_comments_on_author_type_and_author_id",
                schema: "sonusingh2",
                table: "active_admin_comments",
                columns: new[] { "author_type", "author_id" });

            migrationBuilder.CreateIndex(
                name: "index_active_admin_comments_on_namespace",
                schema: "sonusingh2",
                table: "active_admin_comments",
                column: "namespace");

            migrationBuilder.CreateIndex(
                name: "index_active_admin_comments_on_resource_type_and_resource_id",
                schema: "sonusingh2",
                table: "active_admin_comments",
                columns: new[] { "resource_type", "resource_id" });

            migrationBuilder.CreateIndex(
                name: "index_active_storage_attachments_on_blob_id",
                schema: "sonusingh2",
                table: "active_storage_attachments",
                column: "blob_id");

            migrationBuilder.CreateIndex(
                name: "index_active_storage_attachments_uniqueness",
                schema: "sonusingh2",
                table: "active_storage_attachments",
                columns: new[] { "record_type", "record_id", "name", "blob_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "index_active_storage_blobs_on_key",
                schema: "sonusingh2",
                table: "active_storage_blobs",
                column: "key",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "index_active_storage_variant_records_uniqueness",
                schema: "sonusingh2",
                table: "active_storage_variant_records",
                columns: new[] { "blob_id", "variation_digest" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "index_addresses_on_pos_user_id",
                schema: "sonusingh2",
                table: "addresses",
                column: "pos_user_id");

            migrationBuilder.CreateIndex(
                name: "index_admin_users_on_email",
                schema: "sonusingh2",
                table: "admin_users",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "index_admin_users_on_reset_password_token",
                schema: "sonusingh2",
                table: "admin_users",
                column: "reset_password_token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "index_arask_jobs_on_execute_at",
                schema: "sonusingh2",
                table: "arask_jobs",
                column: "execute_at");

            migrationBuilder.CreateIndex(
                name: "index_cart_items_on_productable_id_and_productable_type",
                schema: "sonusingh2",
                table: "cart_items",
                columns: new[] { "productable_id", "productable_type" });

            migrationBuilder.CreateIndex(
                name: "index_carts_on_cartable",
                schema: "sonusingh2",
                table: "carts",
                columns: new[] { "cartable_type", "cartable_id" });

            migrationBuilder.CreateIndex(
                name: "index_carts_on_user_id",
                schema: "sonusingh2",
                table: "carts",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "index_categories_products_on_category_id",
                schema: "sonusingh2",
                table: "categories_products",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "index_categories_products_on_product_id",
                schema: "sonusingh2",
                table: "categories_products",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "index_coupons_on_pos_user_id",
                schema: "sonusingh2",
                table: "coupons",
                column: "pos_user_id");

            migrationBuilder.CreateIndex(
                name: "index_coupons_users_on_coupon_id",
                schema: "sonusingh2",
                table: "coupons_users",
                column: "coupon_id");

            migrationBuilder.CreateIndex(
                name: "index_coupons_users_on_user_id",
                schema: "sonusingh2",
                table: "coupons_users",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "index_orders_on_admin_user_id",
                schema: "sonusingh2",
                table: "orders",
                column: "admin_user_id");

            migrationBuilder.CreateIndex(
                name: "index_orders_on_pos_user_id",
                schema: "sonusingh2",
                table: "orders",
                column: "pos_user_id");

            migrationBuilder.CreateIndex(
                name: "index_pos_users_on_reset_password_token",
                schema: "sonusingh2",
                table: "pos_users",
                column: "reset_password_token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "index_pos_users_on_username",
                schema: "sonusingh2",
                table: "pos_users",
                column: "username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "index_products_on_deleted_at",
                schema: "sonusingh2",
                table: "products",
                column: "deleted_at");

            migrationBuilder.CreateIndex(
                name: "index_properties_on_deleted_at",
                schema: "sonusingh2",
                table: "properties",
                column: "deleted_at");

            migrationBuilder.CreateIndex(
                name: "index_reviews_on_deleted_at",
                schema: "sonusingh2",
                table: "reviews",
                column: "deleted_at");

            migrationBuilder.CreateIndex(
                name: "index_stores_on_subscription_plan_id",
                schema: "sonusingh2",
                table: "stores",
                column: "subscription_plan_id");

            migrationBuilder.CreateIndex(
                name: "index_subscriptions_on_store_detail_id",
                schema: "sonusingh2",
                table: "subscriptions",
                column: "store_detail_id");

            migrationBuilder.CreateIndex(
                name: "index_subscriptions_on_subscription_plan_id",
                schema: "sonusingh2",
                table: "subscriptions",
                column: "subscription_plan_id");

            migrationBuilder.CreateIndex(
                name: "index_variants_on_deleted_at",
                schema: "sonusingh2",
                table: "variants",
                column: "deleted_at");

            migrationBuilder.CreateIndex(
                name: "index_wishlist_items_on_deleted_at",
                schema: "sonusingh2",
                table: "wishlist_items",
                column: "deleted_at");

            migrationBuilder.CreateIndex(
                name: "index_wishlist_items_on_wishlist_id",
                schema: "sonusingh2",
                table: "wishlist_items",
                column: "wishlist_id");

            migrationBuilder.CreateIndex(
                name: "index_wishlists_on_pos_user_id",
                schema: "sonusingh2",
                table: "wishlists",
                column: "pos_user_id");

            migrationBuilder.CreateIndex(
                name: "index_wishlists_on_user_id",
                schema: "sonusingh2",
                table: "wishlists",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "active_admin_comments",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "active_storage_attachments",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "active_storage_variant_records",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "addresses",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "ar_internal_metadata",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "arask_jobs",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "banner_items",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "banners",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "brands",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "cart_items",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "carts",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "categories",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "categories_products",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "cities",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "cms_pages",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "contacts",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "coupons",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "coupons_users",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "demo_requests",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "email_templates",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "faqs",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "import_products",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "option_types",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "option_types_products",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "option_values",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "option_values_variants",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "order_addresses",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "order_items",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "order_statuses",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "orders",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "payment_methods",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "payments",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "products",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "properties",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "public_contacts",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "reviews",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "schema_migrations",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "ship_rocket_raws",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "shipping_charges",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "shipping_methods",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "states",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "store_details",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "store_settings",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "stores",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "sub_categories",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "subscribers",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "subscription_plans",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "subscriptions",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "taxes",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "variants",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "wishlist_items",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "wishlists",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "zip_codes",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "active_storage_blobs",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "users",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "admin_users",
                schema: "sonusingh2");

            migrationBuilder.DropTable(
                name: "pos_users",
                schema: "sonusingh2");
        }
    }
}
