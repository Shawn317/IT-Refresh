using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class LkupRolesRequire2Fa
    {
        public int Id { get; set; }
        public int? ApplicationId { get; set; }
        public int? RoleId { get; set; }
        public string Requires2Fa { get; set; }

        public virtual LkupSsoapplicationList Application { get; set; }
        public virtual LkupPortalUserApplicationRoles Role { get; set; }
    }
}
