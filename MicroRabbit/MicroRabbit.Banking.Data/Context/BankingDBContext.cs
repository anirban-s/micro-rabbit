using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDBContext : DbContext
    {
        public BankingDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
