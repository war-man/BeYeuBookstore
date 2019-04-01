﻿// <auto-generated />
using System;
using BeYeuBookstore.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeYeuBookstore.Data.EF.Migrations
{
    [DbContext(typeof(ERPDbContext))]
    [Migration("20190401062551_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview1-35029")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.AdvertiseContract", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdvertisementContentFK");

                    b.Property<decimal>("ContractValue");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime>("DateFinish");

                    b.Property<DateTime?>("DateModified");

                    b.Property<DateTime>("DateStart");

                    b.Property<bool>("Paid");

                    b.Property<int>("Status");

                    b.HasKey("KeyId");

                    b.HasIndex("AdvertisementContentFK")
                        .IsUnique();

                    b.ToTable("AdvertiseContracts");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.AdvertisementContent", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdvertisementPositionFK");

                    b.Property<int>("AdvertiserFK");

                    b.Property<int?>("CensorStatus");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<decimal>("Deposite");

                    b.Property<string>("Description");

                    b.Property<string>("ImageLink");

                    b.Property<bool?>("PaidDeposite");

                    b.Property<string>("Title");

                    b.Property<string>("UrlToAdvertisement");

                    b.HasKey("KeyId");

                    b.HasIndex("AdvertisementPositionFK");

                    b.HasIndex("AdvertiserFK");

                    b.ToTable("AdvertisementContents");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.AdvertisementPosition", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdvertisePrice");

                    b.Property<int>("Height");

                    b.Property<string>("IdOfPosition");

                    b.Property<string>("PageUrl");

                    b.Property<int>("Status");

                    b.Property<int>("Width");

                    b.HasKey("KeyId");

                    b.ToTable("AdvertisementPositions");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Advertiser", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrandName");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<int>("Status");

                    b.Property<string>("UrlToBrand");

                    b.Property<Guid>("UserFK");

                    b.HasKey("KeyId");

                    b.HasIndex("UserFK")
                        .IsUnique();

                    b.ToTable("Advertisers");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.ArAccountsReceivable", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("ArNo");

                    b.Property<int?>("CustomerFk");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Department");

                    b.Property<string>("Description");

                    b.Property<int?>("PoNo");

                    b.Property<int?>("ProjectId");

                    b.Property<string>("RecordCode");

                    b.Property<int?>("TransactNo");

                    b.Property<DateTime?>("Transaction_Date");

                    b.Property<string>("Type")
                        .HasMaxLength(2);

                    b.Property<string>("WarehouseFk");

                    b.HasKey("KeyId");

                    b.ToTable("ArAccountsReceivable");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.ArAccountsReceivableAdjustments", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<Guid?>("AuthorizedBy");

                    b.Property<Guid?>("AuthorizedByNavigationId");

                    b.Property<string>("CreditAccount");

                    b.Property<string>("CustomerNo");

                    b.Property<string>("DebitAccount");

                    b.Property<DateTime?>("InvoiceDate");

                    b.Property<string>("InvoiceNo");

                    b.Property<int?>("TranType");

                    b.Property<DateTime?>("VoucherDate");

                    b.Property<string>("VoucherNo");

                    b.HasKey("KeyId");

                    b.HasIndex("AuthorizedByNavigationId");

                    b.ToTable("ArAccountsReceivableAdjustments");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Book", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<int>("BookCategoryFK");

                    b.Property<string>("BookTitle");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Description");

                    b.Property<int?>("Height");

                    b.Property<int>("Length");

                    b.Property<int>("MerchantFK");

                    b.Property<int>("PageNumber");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("UnitPrice");

                    b.Property<int>("Width");

                    b.Property<bool>("isPaperback");

                    b.HasKey("KeyId");

                    b.HasIndex("BookCategoryFK");

                    b.HasIndex("MerchantFK");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.BookCategory", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BookCategoryName");

                    b.HasKey("KeyId");

                    b.ToTable("BookCategorys");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Customer", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<DateTime?>("Dob");

                    b.Property<int>("Gender");

                    b.Property<Guid>("UserFK");

                    b.HasKey("KeyId");

                    b.HasIndex("UserFK")
                        .IsUnique();

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Delivery", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<int>("DeliveryStatus");

                    b.Property<int>("InvoiceFK");

                    b.HasKey("KeyId");

                    b.HasIndex("InvoiceFK")
                        .IsUnique();

                    b.ToTable("Deliverys");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Function", b =>
                {
                    b.Property<string>("KeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(128)");

                    b.Property<string>("IconCss");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("ParentId")
                        .HasMaxLength(128);

                    b.Property<int>("SortOrder");

                    b.Property<int>("Status");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("KeyId");

                    b.ToTable("Functions");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Invoice", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerFK");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<decimal>("TotalPrice");

                    b.HasKey("KeyId");

                    b.HasIndex("CustomerFK");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.InvoiceDetail", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookFK");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<int>("InvoiceFK");

                    b.Property<int>("Qty");

                    b.Property<decimal>("SubTotal");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("KeyId");

                    b.HasIndex("BookFK");

                    b.HasIndex("InvoiceFK");

                    b.ToTable("InvoiceDetails");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Merchant", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountNumber");

                    b.Property<string>("Address");

                    b.Property<string>("Bank");

                    b.Property<string>("BankAccountNotificationLinkImg");

                    b.Property<string>("BankBranch");

                    b.Property<string>("BussinessRegisterId");

                    b.Property<string>("BussinessRegisterLinkImg");

                    b.Property<string>("ContactAddress");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("DirectContactName");

                    b.Property<DateTime>("EstablishDate");

                    b.Property<string>("Hotline");

                    b.Property<string>("LegalRepresentative");

                    b.Property<string>("MerchantBankingName");

                    b.Property<string>("MerchantCompanyName");

                    b.Property<string>("MerchantName");

                    b.Property<int>("Scales");

                    b.Property<int>("Status");

                    b.Property<string>("TaxId");

                    b.Property<string>("TaxRegisterLinkImg");

                    b.Property<Guid>("UserFK");

                    b.Property<string>("Website");

                    b.HasKey("KeyId");

                    b.HasIndex("UserFK")
                        .IsUnique();

                    b.ToTable("Merchants");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.MerchantContract", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContractLink");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<int>("MerchantFK");

                    b.HasKey("KeyId");

                    b.HasIndex("MerchantFK");

                    b.ToTable("MerchantContracts");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Permission", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CanConfirm");

                    b.Property<bool>("CanCreate");

                    b.Property<bool>("CanDelete");

                    b.Property<bool>("CanRead");

                    b.Property<bool>("CanUpdate");

                    b.Property<string>("FunctionId")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<Guid>("RoleId");

                    b.HasKey("KeyId");

                    b.HasIndex("FunctionId");

                    b.HasIndex("RoleId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<string>("Avatar");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName")
                        .HasMaxLength(200);

                    b.Property<Guid?>("LastupdatedFk");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("UserTypeFK");

                    b.Property<int?>("UserTypeFKNavigationKeyId");

                    b.HasKey("Id");

                    b.HasIndex("UserTypeFKNavigationKeyId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.UserType", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("UserTypeTableName");

                    b.HasKey("KeyId");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.WebMaster", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<Guid>("UserFK");

                    b.Property<int>("WebMasterTypeFK");

                    b.HasKey("KeyId");

                    b.HasIndex("UserFK")
                        .IsUnique();

                    b.HasIndex("WebMasterTypeFK");

                    b.ToTable("WebMasters");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.WebMasterType", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("WebMasterTypeName");

                    b.HasKey("KeyId");

                    b.ToTable("WebMasterTypes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("ProviderKey");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("UserId");

                    b.HasKey("RoleId", "UserId");

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.AdvertiseContract", b =>
                {
                    b.HasOne("BeYeuBookstore.Data.Entities.AdvertisementContent", "AdvertisementContentFKNavigation")
                        .WithOne("AdvertiseContract")
                        .HasForeignKey("BeYeuBookstore.Data.Entities.AdvertiseContract", "AdvertisementContentFK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.AdvertisementContent", b =>
                {
                    b.HasOne("BeYeuBookstore.Data.Entities.AdvertisementPosition", "AdvertisementPositionFKNavigation")
                        .WithMany("AdvertisementContents")
                        .HasForeignKey("AdvertisementPositionFK")
                        .HasConstraintName("FK_dbo.AdvertisementContent.AdvertisementPosition")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BeYeuBookstore.Data.Entities.Advertiser", "AdvertiserFKNavigation")
                        .WithMany("AdvertisementContents")
                        .HasForeignKey("AdvertiserFK")
                        .HasConstraintName("FK_dbo.AdvertisementContent.Advertiser_AdvertiserFK_FK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Advertiser", b =>
                {
                    b.HasOne("BeYeuBookstore.Data.Entities.User", "UserBy")
                        .WithOne("AdvertiserFKNavigation")
                        .HasForeignKey("BeYeuBookstore.Data.Entities.Advertiser", "UserFK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.ArAccountsReceivableAdjustments", b =>
                {
                    b.HasOne("BeYeuBookstore.Data.Entities.User", "AuthorizedByNavigation")
                        .WithMany("ArAccountsReceivableAdjustments")
                        .HasForeignKey("AuthorizedByNavigationId");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Book", b =>
                {
                    b.HasOne("BeYeuBookstore.Data.Entities.BookCategory", "BookCategoryFKNavigation")
                        .WithMany("Books")
                        .HasForeignKey("BookCategoryFK")
                        .HasConstraintName("FK_dbo.Book.BookCategory_FK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BeYeuBookstore.Data.Entities.Merchant", "MerchantFKNavigation")
                        .WithMany("Books")
                        .HasForeignKey("MerchantFK")
                        .HasConstraintName("FK_dbo.Book.MerchantFK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Customer", b =>
                {
                    b.HasOne("BeYeuBookstore.Data.Entities.User", "UserBy")
                        .WithOne("CustomerFKNavigation")
                        .HasForeignKey("BeYeuBookstore.Data.Entities.Customer", "UserFK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Delivery", b =>
                {
                    b.HasOne("BeYeuBookstore.Data.Entities.Invoice", "InvoiceFKNavigation")
                        .WithOne("DeliveryFKNavigation")
                        .HasForeignKey("BeYeuBookstore.Data.Entities.Delivery", "InvoiceFK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Invoice", b =>
                {
                    b.HasOne("BeYeuBookstore.Data.Entities.Customer", "CustomerFKNavigation")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerFK")
                        .HasConstraintName("FK_dbo.Invoices.CustomerFK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.InvoiceDetail", b =>
                {
                    b.HasOne("BeYeuBookstore.Data.Entities.Book", "BookFKNavigation")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("BookFK")
                        .HasConstraintName("FK_dbo.InvoiceDetails.BookFK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BeYeuBookstore.Data.Entities.Invoice", "InvoiceFKNavigation")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("InvoiceFK")
                        .HasConstraintName("FK_dbo.InvoiceDetails.InvoiceFK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Merchant", b =>
                {
                    b.HasOne("BeYeuBookstore.Data.Entities.User", "UserBy")
                        .WithOne("MerchantFKNavigation")
                        .HasForeignKey("BeYeuBookstore.Data.Entities.Merchant", "UserFK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.MerchantContract", b =>
                {
                    b.HasOne("BeYeuBookstore.Data.Entities.Merchant", "MerchantFKNavigation")
                        .WithMany("MerchantContracts")
                        .HasForeignKey("MerchantFK")
                        .HasConstraintName("FK_dbo.MerchantContract.MerchantFK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.Permission", b =>
                {
                    b.HasOne("BeYeuBookstore.Data.Entities.Function", "Function")
                        .WithMany()
                        .HasForeignKey("FunctionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BeYeuBookstore.Data.Entities.Role", "AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.User", b =>
                {
                    b.HasOne("BeYeuBookstore.Data.Entities.UserType", "UserTypeFKNavigation")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeFKNavigationKeyId");
                });

            modelBuilder.Entity("BeYeuBookstore.Data.Entities.WebMaster", b =>
                {
                    b.HasOne("BeYeuBookstore.Data.Entities.User", "UserBy")
                        .WithOne("WebMasterFKNavigation")
                        .HasForeignKey("BeYeuBookstore.Data.Entities.WebMaster", "UserFK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BeYeuBookstore.Data.Entities.WebMasterType", "WebMasterTypeFKNavigation")
                        .WithMany("WebMasters")
                        .HasForeignKey("WebMasterTypeFK")
                        .HasConstraintName("FK_dbo.WebMasters.WebMasterTypeFK")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
