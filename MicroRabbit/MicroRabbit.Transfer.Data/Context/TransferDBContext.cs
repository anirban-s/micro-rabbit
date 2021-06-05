using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDBContext : DbContext
    {
        public TransferDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
