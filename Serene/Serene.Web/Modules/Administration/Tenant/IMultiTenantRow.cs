using Serenity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Serene
{
    public interface IMultiTenantRow
    {
        Int32Field TenantIdField { get; }
    }
}