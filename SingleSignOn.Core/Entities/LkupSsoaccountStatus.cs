using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class LkupSsoaccountStatus
    {
        public LkupSsoaccountStatus()
        {
            SsoUserMembership = new HashSet<SsoUserMembership>();
        }

        public int Id { get; set; }
        public string AccountType { get; set; }

        public virtual ICollection<SsoUserMembership> SsoUserMembership { get; set; }
    }
}
