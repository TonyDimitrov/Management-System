namespace ManagementSystem.Data
{
    using ManagementSytem.Models.EntityModels;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MngSysContext : IdentityDbContext<ApplicationUser>
    {

        public MngSysContext()
            : base("MngSystemContext", throwIfV1Schema: false)
        {
        }


        public static MngSysContext Create()
        {
            return new MngSysContext();
        }
    }
}