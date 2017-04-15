using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using travis_resume.Data;

namespace travis_resume.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170415063629_Seventh")]
    partial class Seventh
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("travis_resume.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("travis_resume.Models.Education", b =>
                {
                    b.Property<int>("EducationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressCity")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 30);

                    b.Property<int>("AddressId");

                    b.Property<string>("AddressLineOne")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 60);

                    b.Property<string>("AddressLineTwo")
                        .HasAnnotation("MaxLength", 60);

                    b.Property<string>("AddressState")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 2);

                    b.Property<string>("AddressZip")
                        .IsRequired();

                    b.Property<string>("EducationDescription");

                    b.Property<string>("EducationLevel")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 30);

                    b.Property<string>("EducationName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 30);

                    b.Property<int?>("PersonId");

                    b.Property<int?>("ResumeViewModelId");

                    b.HasKey("EducationId");

                    b.HasIndex("PersonId");

                    b.HasIndex("ResumeViewModelId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("travis_resume.Models.Jobs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressCity")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 30);

                    b.Property<int>("AddressId");

                    b.Property<string>("AddressLineOne")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 60);

                    b.Property<string>("AddressLineTwo")
                        .HasAnnotation("MaxLength", 60);

                    b.Property<string>("AddressState")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 2);

                    b.Property<string>("AddressZip")
                        .IsRequired();

                    b.Property<int>("PersonId");

                    b.Property<int?>("ResumeViewModelId");

                    b.Property<DateTime>("jobDateHired");

                    b.Property<DateTime>("jobDateOver");

                    b.Property<string>("jobDescription")
                        .IsRequired();

                    b.Property<string>("jobName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 30);

                    b.Property<string>("jobTitle")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 30);

                    b.HasKey("ID");

                    b.HasIndex("PersonId");

                    b.HasIndex("ResumeViewModelId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("travis_resume.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PersonEmail");

                    b.Property<string>("PersonFirstName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 60);

                    b.Property<string>("PersonLastName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 30);

                    b.Property<string>("PersonPhone");

                    b.HasKey("PersonId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("travis_resume.Models.ResumeViewModels.ResumeViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContactPersonId");

                    b.HasKey("Id");

                    b.HasIndex("ContactPersonId");

                    b.ToTable("ResumeViewModel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("travis_resume.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("travis_resume.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travis_resume.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("travis_resume.Models.Education", b =>
                {
                    b.HasOne("travis_resume.Models.Person", "People")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("travis_resume.Models.ResumeViewModels.ResumeViewModel")
                        .WithMany("Schools")
                        .HasForeignKey("ResumeViewModelId");
                });

            modelBuilder.Entity("travis_resume.Models.Jobs", b =>
                {
                    b.HasOne("travis_resume.Models.Person", "People")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travis_resume.Models.ResumeViewModels.ResumeViewModel")
                        .WithMany("Job")
                        .HasForeignKey("ResumeViewModelId");
                });

            modelBuilder.Entity("travis_resume.Models.ResumeViewModels.ResumeViewModel", b =>
                {
                    b.HasOne("travis_resume.Models.Person", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactPersonId");
                });
        }
    }
}
