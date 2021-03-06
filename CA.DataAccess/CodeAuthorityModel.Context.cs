﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CA.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CodeAuthorityEntities : DbContext
    {
        public CodeAuthorityEntities()
            : base("name=CodeAuthorityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<string> InsertUpdateNewContact(string firstname, string lastname, string email, string telephone, string bestTimeToCall)
        {
            var firstnameParameter = firstname != null ?
                new ObjectParameter("Firstname", firstname) :
                new ObjectParameter("Firstname", typeof(string));
    
            var lastnameParameter = lastname != null ?
                new ObjectParameter("Lastname", lastname) :
                new ObjectParameter("Lastname", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telephoneParameter = telephone != null ?
                new ObjectParameter("Telephone", telephone) :
                new ObjectParameter("Telephone", typeof(string));
    
            var bestTimeToCallParameter = bestTimeToCall != null ?
                new ObjectParameter("BestTimeToCall", bestTimeToCall) :
                new ObjectParameter("BestTimeToCall", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("InsertUpdateNewContact", firstnameParameter, lastnameParameter, emailParameter, telephoneParameter, bestTimeToCallParameter);
        }
    }
}
