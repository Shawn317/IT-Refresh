using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class LkupPortalUserApplicationRoles
    {
        public LkupPortalUserApplicationRoles()
        {
            LkupRolesRequire2Fa = new HashSet<LkupRolesRequire2Fa>();
            PortalUserApplicationRoles = new HashSet<PortalUserApplicationRoles>();
            SsoUserApplication = new HashSet<SsoUserApplication>();
        }

        public int Id { get; set; }
        public string UserRoleType { get; set; }
        public string UserRoleDesc { get; set; }
        public string UserRoleSite { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual ICollection<LkupRolesRequire2Fa> LkupRolesRequire2Fa { get; set; }
        public virtual ICollection<PortalUserApplicationRoles> PortalUserApplicationRoles { get; set; }
        public virtual ICollection<SsoUserApplication> SsoUserApplication { get; set; }
    }
}
