using Microsoft.EntityFrameworkCore;
using Pagination.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pagination.DataConnection
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
            //
        }

        public DbSet<UserInfo> UserInfos { get; set; }
    }
}
