using System;
using lab4_JWT.Identity;
using lab4_JWT.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lab4_JWT
{
	public class StudentContext : IdentityDbContext<UserEntity, UserRole, int>
    {
        public StudentContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; } = null!;
    }
}

