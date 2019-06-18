using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Thread_.NET.DAL.Entities;
using Thread_.NET.DAL.Entities.Interfaces;

namespace Thread_.NET.DAL.Context
{
    public sealed class ThreadContext : DbContext
    {
        public ThreadContext(DbContextOptions<ThreadContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; private set; }
        public DbSet<CommentReaction> CommentReactions { get; private set; }
        public DbSet<Image> Images { get; private set; }
        public DbSet<Post> Posts { get; private set; }
        public DbSet<PostReaction> PostReactions { get; private set; }
        public DbSet<RefreshToken> RefreshTokens { get; private set; }
        public DbSet<User> Users { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setting up entities using extension method
            modelBuilder.Configure();

            // Seeding data using extension method
            // NOTE: this method will be called every time after adding a new migration, cuz we use Bogus for seed data
            modelBuilder.Seed();
        }

        public override int SaveChanges()
        {
            OnBeforeSaving();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            return base.SaveChangesAsync();
        }

        private void OnBeforeSaving()
        {
            ChangeTracker.DetectChanges();

            var markedAsDeleted = ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted);

            foreach (var item in markedAsDeleted)
            {
                if (item.Entity is ISoftDeletable entity)
                {
                    // Set the entity to unchanged (if we mark the whole entity as Modified, every field gets sent to Db as an update)
                    item.State = EntityState.Unchanged;
                    // Only update the IsDeleted flag - only this will get sent to the Db
                    entity.IsDeleted = true;
                }
            }
        }
    }
}
