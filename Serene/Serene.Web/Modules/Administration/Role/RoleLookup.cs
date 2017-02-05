using Serene.Administration.Entities;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Serene.Administration
{
    [LookupScript("Administration.Role")]
    public class RoleLookup : MultiTenantRowLookupScript<RoleRow>
    {
    }
}