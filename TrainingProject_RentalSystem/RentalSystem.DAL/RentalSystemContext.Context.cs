﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalSystem.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RentalSystemContext : DbContext
    {
        private RentalSystemContext()
            : base("name=RentalSystemContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<RentProduct> RentProducts { get; set; }
    
        public virtual ObjectResult<spGetAllProducts_Result> spGetAllProducts(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllProducts_Result>("spGetAllProducts", idParameter);
        }
    
        public virtual ObjectResult<spGetAllProductsAdmin_Result> spGetAllProductsAdmin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllProductsAdmin_Result>("spGetAllProductsAdmin");
        }
    }
}