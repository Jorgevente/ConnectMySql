using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ConnectMySql.Models
{
	//public class DataContext : IdentityDbContext<UserEntity>
	//{
	//	public DataContext(DbContextOptions<DataContext> options) : base(options)
	//	{

	//	}


	//	//protected override void OnModelCreating(ModelBuilder builder)
	//	//{
	//	//	base.OnModelCreating(builder);
	//	//	builder.Entity<UserEntity>(entity => entity.Property(m => m.NormalizedEmail).HasMaxLength(3072));
	//	//	builder.Entity<UserEntity>(entity => entity.Property(m => m.NormalizedUserName).HasMaxLength(3072));
	//	//	builder.Entity<IdentityRole>(entity => entity.Property(m => m.NormalizedName).HasMaxLength(3072));
	//	//	builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(760));
	//	//	builder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(3072));
	//	//	builder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(3072));
	//	//	builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(3072));
	//	//	builder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(3072));
	//	//	builder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(3072));
	//	//}


		
	//}


	public class DataContext : IdentityDbContext<UserEntity>
	{

		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}



		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}



			//	modelBuilder.Entity<IdentityUser>().ToTable("Users").Property(p => p.Id).HasColumnName("UserId");
			//	modelBuilder.Entity<ApplicationUser>().ToTable("Users").Property(p => p.Id).HasColumnName("UserId");
			//	modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
			//	modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
			//	modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims");
			//	modelBuilder.Entity<IdentityRole>().ToTable("Roles");
			//	modelBuilder.Entity<ApplicationRole>().ToTable("Roles");
			//	modelBuilder.Entity<UserRoleAccess>().ToTable("UserRoleAccess");

			//	modelBuilder.Entity<ApplicationUser>().HasRequired(p => p.Person)
			//		.WithMany(b => b.Users);

			//	modelBuilder.Entity<ApplicationUser>().HasRequired(p => p.Person)
			//		.WithMany(b => b.Users)
			//		.HasForeignKey(p => p.PersonId);

			//	modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
			//	modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
			//	modelBuilder.Entity<ApplicationRole>().HasKey<string>(r => r.Id);
			//	modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });


			//}

			//... default code for ApplicationDbContext

			//protected override void OnModelCreating(ModelBuilder modelBuilder)
			//{
			//	if (modelBuilder == null)
			//	{
			//		throw new ArgumentNullException("modelBuilder");
			//	}

			//	base.OnModelCreating(modelBuilder);

			//	modelBuilder.Entity<UserEntity>().Property(u => u.UserName).HasMaxLength(128);

			//	//Uncomment this to have Email length 128 too (not neccessary)
			//	//modelBuilder.Entity<ApplicationUser>().Property(u => u.Email).HasMaxLength(128);

			//	modelBuilder.Entity<IdentityRole>().Property(r => r.Id).HasMaxLength(128);

			//	//modelBuilder.Entity<IdentityUserLogin>().Property(iul => iul.UserId).HasColumnName("UserId");
			//	//modelBuilder.Entity<IdentityUserLogin>().Property(iul => iul.LoginProvider).HasColumnName("LoginProvider");
			//	//modelBuilder.Entity<IdentityUserLogin>().Property(iul => iul.ProviderKey).HasColumnName("ProviderKey");


			//	//modelBuilder.Entity<AspNetUserLogins>().Property(r => r.key).HasMaxLength(128);

			//}
		}
}