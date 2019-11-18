using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class UserLoginAuditTrail
    {
        public int Id { get; set; }
        public int? USsoid { get; set; }
        public int? UMmsid { get; set; }
        public DateTime? CurrentLoginDateTime { get; set; }
        public DateTime? LastLoginDateTime { get; set; }

        public virtual SsoUserMembership USso { get; set; }
    }
}
