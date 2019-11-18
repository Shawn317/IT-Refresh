using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class PortalUserApplicationRoles
    {
        public int Id { get; set; }
        public int? ApplicationId { get; set; }
        public int? UserRoleId { get; set; }
        public int? UserId { get; set; }
        public string IsApproved { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual LkupSsoapplicationList Application { get; set; }
        public virtual SsoUserMembership User { get; set; }
        public virtual LkupPortalUserApplicationRoles UserRole { get; set; }
    }
}
