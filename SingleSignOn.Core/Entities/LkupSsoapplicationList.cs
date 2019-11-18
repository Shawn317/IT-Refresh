using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class LkupSsoapplicationList
    {
        public LkupSsoapplicationList()
        {
            LkupRolesRequire2Fa = new HashSet<LkupRolesRequire2Fa>();
            PortalUserApplicationRoles = new HashSet<PortalUserApplicationRoles>();
            SsoUserApplication = new HashSet<SsoUserApplication>();
        }

        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationUrl { get; set; }
        public string ApplicationDesc { get; set; }

        public virtual ICollection<LkupRolesRequire2Fa> LkupRolesRequire2Fa { get; set; }
        public virtual ICollection<PortalUserApplicationRoles> PortalUserApplicationRoles { get; set; }
        public virtual ICollection<SsoUserApplication> SsoUserApplication { get; set; }
    }
}
