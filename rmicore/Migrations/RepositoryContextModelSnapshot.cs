﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rmicore;

namespace rmicore.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("rmicore.Entities.EmploymentType", b =>
                {
                    b.Property<int>("EmploymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmploymentTypeId");

                    b.ToTable("EmploymentTypes");

                    b.HasData(
                        new
                        {
                            EmploymentTypeId = 1,
                            Name = "Insurance"
                        },
                        new
                        {
                            EmploymentTypeId = 2,
                            Name = "Retail"
                        },
                        new
                        {
                            EmploymentTypeId = 3,
                            Name = "Technology"
                        },
                        new
                        {
                            EmploymentTypeId = 4,
                            Name = "Construction"
                        },
                        new
                        {
                            EmploymentTypeId = 5,
                            Name = "Finance"
                        },
                        new
                        {
                            EmploymentTypeId = 6,
                            Name = "Local Government"
                        });
                });

            modelBuilder.Entity("rmicore.Entities.Occupation", b =>
                {
                    b.Property<int>("OccupationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OccupationId");

                    b.ToTable("Occupations");

                    b.HasData(
                        new
                        {
                            OccupationId = 1,
                            Name = "Abbatoir Worker"
                        },
                        new
                        {
                            OccupationId = 2,
                            Name = "Bartender"
                        },
                        new
                        {
                            OccupationId = 3,
                            Name = "Chef"
                        },
                        new
                        {
                            OccupationId = 4,
                            Name = "Lawyer"
                        },
                        new
                        {
                            OccupationId = 5,
                            Name = "Mechanic"
                        },
                        new
                        {
                            OccupationId = 6,
                            Name = "Occupational Therapist"
                        },
                        new
                        {
                            OccupationId = 7,
                            Name = "Police Officer"
                        },
                        new
                        {
                            OccupationId = 8,
                            Name = "Train Driver"
                        },
                        new
                        {
                            OccupationId = 9,
                            Name = "Soldier"
                        });
                });

            modelBuilder.Entity("rmicore.Entities.OccupationStatus", b =>
                {
                    b.Property<int>("OccupationStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OccupationStatusId");

                    b.ToTable("OccupationStatus");

                    b.HasData(
                        new
                        {
                            OccupationStatusId = 1,
                            Name = "Full Time"
                        },
                        new
                        {
                            OccupationStatusId = 2,
                            Name = "Part Time"
                        },
                        new
                        {
                            OccupationStatusId = 3,
                            Name = "Unemployed"
                        },
                        new
                        {
                            OccupationStatusId = 4,
                            Name = "Contractor"
                        });
                });

            modelBuilder.Entity("rmicore.Entities.Test", b =>
                {
                    b.Property<Guid>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.HasKey("TestId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("rmicore.Entities.Title", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TitleId");

                    b.ToTable("Titles");

                    b.HasData(
                        new
                        {
                            TitleId = 1,
                            Name = "Mr"
                        },
                        new
                        {
                            TitleId = 2,
                            Name = "Mrs"
                        },
                        new
                        {
                            TitleId = 3,
                            Name = "Miss"
                        },
                        new
                        {
                            TitleId = 4,
                            Name = "Doctor"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
