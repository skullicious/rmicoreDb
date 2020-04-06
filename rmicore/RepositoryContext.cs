﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rmicore.Entities;
using Microsoft.EntityFrameworkCore;

namespace rmicore
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<OccupationStatus> OccupationStatus { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Title>().HasData(new Title
            {
                TitleId = 1,
                Name = "Mr"
            }, new Title
            {
                TitleId = 2,
                Name = "Mrs"
            },
            new Title
            {
                TitleId = 3,
                Name = "Miss"
            },
            new Title
            {
                TitleId = 4,
                Name = "Doctor"
            });

            modelBuilder.Entity<Occupation>().HasData(new Occupation
            {
                OccupationId = 1,
                Name = "Abbatoir Worker"
            }, new Occupation
            {
                OccupationId = 2,
                Name = "Bartender"
            },
           new Occupation
           {
               OccupationId = 3,
               Name = "Chef"
           },
           new Occupation
           {
               OccupationId = 4,
               Name = "Lawyer"
           },
            new Occupation
            {
                OccupationId = 5,
                Name = "Mechanic"
            },
            new Occupation
            {
                OccupationId = 6,
                Name = "Occupational Therapist"
            },
            new Occupation
            {
                OccupationId = 7,
                Name = "Police Officer"
            },
            new Occupation
            {
                OccupationId = 8,
                Name = "Train Driver"
            },
            new Occupation
            {
                OccupationId = 9,
                Name = "Soldier"
            });



            modelBuilder.Entity<OccupationStatus>().HasData(new OccupationStatus
            {
                OccupationStatusId = 1,
                Name = "Full Time"
            }, new OccupationStatus
            {
                OccupationStatusId = 2,
                Name = "Part Time"
            },
           new OccupationStatus
           {
               OccupationStatusId = 3,
               Name = "Unemployed"
           },
           new OccupationStatus
           {
               OccupationStatusId = 4,
               Name = "Contractor"
           });


            modelBuilder.Entity<EmploymentType>().HasData(new EmploymentType
            {
                EmploymentTypeId = 1,
                Name = "Insurance"
            }, new EmploymentType
            {
                EmploymentTypeId = 2,
                Name = "Retail"
            },
          new EmploymentType
          {
              EmploymentTypeId = 3,
              Name = "Technology"
          },
          new EmploymentType
          {
              EmploymentTypeId = 4,
              Name = "Construction"
          },
            new EmploymentType
            {
                EmploymentTypeId = 5,
                Name = "Finance"
            },
            new EmploymentType
            {
                EmploymentTypeId = 6,
                Name = "Local Government"
            });



        }

    }
}