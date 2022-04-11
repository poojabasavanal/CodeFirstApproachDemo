using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleCFcoreMVC.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options): base(options)
        {

        }
        public DbSet<TodoItem> TodoItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem() { Id = 1, Name = "meeting with management", IsComplete = true, Description = "In meeting need to discuss some points." },
                new TodoItem() { Id = 2, Name = "Go for shopping", IsComplete = false, Description = "List of thisitem buy." },
                new TodoItem() { Id = 3, Name = "call to someone for do some task", IsComplete = true, Description = "here is task to ask to do on call" });
                }
        }

    }


