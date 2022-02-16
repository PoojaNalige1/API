﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMgmtSys.Models
{
    public class EFDBhandle:DbContext
    {
        public string conn = "Server=DESKTOP-MSP08OQ;Database= CustomerMgmt_DB; Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsB)
        {
            optionsB.UseSqlServer(conn);
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
