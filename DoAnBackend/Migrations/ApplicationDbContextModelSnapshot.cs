﻿// <auto-generated />
using System;
using DoAnBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DoAnBackend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DoAnBackend.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Avatar")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("character varying(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("DoAnBackend.Data.Appointment", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly?>("AppointmentDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("DoctorFirstName")
                        .HasColumnType("text");

                    b.Property<string>("DoctorId")
                        .HasColumnType("text");

                    b.Property<string>("DoctorLastName")
                        .HasColumnType("text");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<string>("NurseFirstName")
                        .HasColumnType("text");

                    b.Property<string>("NurseId")
                        .HasColumnType("text");

                    b.Property<string>("NurseLastName")
                        .HasColumnType("text");

                    b.Property<string>("PatientEmail")
                        .HasColumnType("text");

                    b.Property<string>("PatientId")
                        .HasColumnType("text");

                    b.Property<string>("PatientName")
                        .HasColumnType("text");

                    b.Property<string>("Reason")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("updatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("NurseId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("DoAnBackend.Data.Invoice", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AppointmentId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("NurseId")
                        .HasColumnType("text");

                    b.Property<Guid>("PrescriptionId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("WalletType")
                        .HasColumnType("text");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("updatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId")
                        .IsUnique();

                    b.HasIndex("NurseId");

                    b.HasIndex("PrescriptionId")
                        .IsUnique();

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("DoAnBackend.Data.InvoiceMedicine", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<decimal>("Discount")
                        .HasColumnType("numeric");

                    b.Property<Guid>("InvoiceId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MedicineId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("updatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("MedicineId");

                    b.ToTable("InvoiceMedicines");
                });

            modelBuilder.Entity("DoAnBackend.Data.InvoiceService", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<decimal>("Discount")
                        .HasColumnType("numeric");

                    b.Property<Guid>("InvoicedId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("updatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("InvoicedId");

                    b.HasIndex("ServiceId");

                    b.ToTable("InvoicesServices");
                });

            modelBuilder.Entity("DoAnBackend.Data.Medicine", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("updatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("DoAnBackend.Data.Prescription", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AppointmentId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Diagnsis")
                        .HasColumnType("text");

                    b.Property<string>("DoctorId")
                        .HasColumnType("text");

                    b.Property<DateOnly?>("NextAppointment")
                        .HasColumnType("date");

                    b.Property<string>("PatientId")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("updatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId")
                        .IsUnique();

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("DoAnBackend.Data.PrescriptionDetail", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<Guid>("MedicineId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PrescriptionId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("updatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("MedicineId");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("PrescriptionDetails");
                });

            modelBuilder.Entity("DoAnBackend.Data.Service", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("updatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("character varying(21)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasDiscriminator().HasValue("IdentityRole");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DoAnBackend.Data.Doctor", b =>
                {
                    b.HasBaseType("DoAnBackend.Data.ApplicationUser");

                    b.Property<string>("LicenseNumber")
                        .HasColumnType("text");

                    b.Property<string>("Specialization")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("Doctor");
                });

            modelBuilder.Entity("DoAnBackend.Data.Nurse", b =>
                {
                    b.HasBaseType("DoAnBackend.Data.ApplicationUser");

                    b.HasDiscriminator().HasValue("Nurse");
                });

            modelBuilder.Entity("DoAnBackend.Data.Patient", b =>
                {
                    b.HasBaseType("DoAnBackend.Data.ApplicationUser");

                    b.HasDiscriminator().HasValue("Patient");
                });

            modelBuilder.Entity("DoAnBackend.Data.ApplicationRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("RoleName")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("ApplicationRole");
                });

            modelBuilder.Entity("DoAnBackend.Data.ApplicationUserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.HasDiscriminator().HasValue("ApplicationUserRole");
                });

            modelBuilder.Entity("DoAnBackend.Data.Appointment", b =>
                {
                    b.HasOne("DoAnBackend.Data.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId");

                    b.HasOne("DoAnBackend.Data.Nurse", "Nurse")
                        .WithMany("Appointments")
                        .HasForeignKey("NurseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DoAnBackend.Data.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Doctor");

                    b.Navigation("Nurse");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DoAnBackend.Data.Invoice", b =>
                {
                    b.HasOne("DoAnBackend.Data.Appointment", "Appointment")
                        .WithOne("Invoice")
                        .HasForeignKey("DoAnBackend.Data.Invoice", "AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoAnBackend.Data.Nurse", "Nurse")
                        .WithMany("Invoices")
                        .HasForeignKey("NurseId");

                    b.HasOne("DoAnBackend.Data.Prescription", "Prescription")
                        .WithOne("Invoice")
                        .HasForeignKey("DoAnBackend.Data.Invoice", "PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Appointment");

                    b.Navigation("Nurse");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("DoAnBackend.Data.InvoiceMedicine", b =>
                {
                    b.HasOne("DoAnBackend.Data.Invoice", "Invoice")
                        .WithMany("InvoiceMedicines")
                        .HasForeignKey("InvoiceId");

                    b.HasOne("DoAnBackend.Data.Medicine", "Medicine")
                        .WithMany("InvoiceMedicines")
                        .HasForeignKey("MedicineId");

                    b.Navigation("Invoice");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("DoAnBackend.Data.InvoiceService", b =>
                {
                    b.HasOne("DoAnBackend.Data.Invoice", "Invoice")
                        .WithMany("InvoiceServices")
                        .HasForeignKey("InvoicedId");

                    b.HasOne("DoAnBackend.Data.Service", "Service")
                        .WithMany("InvoiceServices")
                        .HasForeignKey("ServiceId");

                    b.Navigation("Invoice");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("DoAnBackend.Data.Prescription", b =>
                {
                    b.HasOne("DoAnBackend.Data.Appointment", "Appointment")
                        .WithOne("Prescription")
                        .HasForeignKey("DoAnBackend.Data.Prescription", "AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoAnBackend.Data.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DoAnBackend.Data.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Appointment");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DoAnBackend.Data.PrescriptionDetail", b =>
                {
                    b.HasOne("DoAnBackend.Data.Medicine", "Medicine")
                        .WithMany("PrescriptionDetails")
                        .HasForeignKey("MedicineId");

                    b.HasOne("DoAnBackend.Data.Prescription", "Prescription")
                        .WithMany("PrescriptionDetails")
                        .HasForeignKey("PrescriptionId");

                    b.Navigation("Medicine");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DoAnBackend.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DoAnBackend.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoAnBackend.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DoAnBackend.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoAnBackend.Data.ApplicationUserRole", b =>
                {
                    b.HasOne("DoAnBackend.Data.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId");

                    b.HasOne("DoAnBackend.Data.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DoAnBackend.Data.ApplicationUser", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("DoAnBackend.Data.Appointment", b =>
                {
                    b.Navigation("Invoice");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("DoAnBackend.Data.Invoice", b =>
                {
                    b.Navigation("InvoiceMedicines");

                    b.Navigation("InvoiceServices");
                });

            modelBuilder.Entity("DoAnBackend.Data.Medicine", b =>
                {
                    b.Navigation("InvoiceMedicines");

                    b.Navigation("PrescriptionDetails");
                });

            modelBuilder.Entity("DoAnBackend.Data.Prescription", b =>
                {
                    b.Navigation("Invoice");

                    b.Navigation("PrescriptionDetails");
                });

            modelBuilder.Entity("DoAnBackend.Data.Service", b =>
                {
                    b.Navigation("InvoiceServices");
                });

            modelBuilder.Entity("DoAnBackend.Data.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("DoAnBackend.Data.Nurse", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("DoAnBackend.Data.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("DoAnBackend.Data.ApplicationRole", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
