﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Umbiad.App.DataAccess.Meyesos
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class MeyesosDBContainer : DbContext
    {
        public MeyesosDBContainer()
            : base("name=MeyesosDBContainer")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<MYS_USER> Table_User { get; set; }
        public virtual DbSet<MYS_MESSAGE> Table_Message { get; set; }
        public virtual DbSet<MYS_FOLLOWINFO> Table_FollowInfo { get; set; }
    }
}