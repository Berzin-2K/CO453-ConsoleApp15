using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.entityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace WebApps.data

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(dbContextoptions<ApplicationDbContext> options)
        : base(options)
}
}


