﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace jobway.DAL.Context;
public class JobwayDbContext : IdentityDbContext
{
    public JobwayDbContext(DbContextOptions<JobwayDbContext> options): base(options) { }
}
