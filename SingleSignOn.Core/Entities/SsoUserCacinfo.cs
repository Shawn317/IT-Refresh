using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class SsoUserCacinfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string UserName { get; set; }
        public string Cacid { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual SsoUserMembership User { get; set; }
    }
}
