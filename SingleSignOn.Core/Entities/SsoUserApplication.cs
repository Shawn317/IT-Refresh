using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class SsoUserApplication
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ApplicationId { get; set; }
        public int? UserRoleTypeId { get; set; }
        public string IsApproved { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string IsLockedOut { get; set; }

        public virtual LkupSsoapplicationList Application { get; set; }
        public virtual SsoUserMembership User { get; set; }
        public virtual LkupPortalUserApplicationRoles UserRoleType { get; set; }
    }
}
