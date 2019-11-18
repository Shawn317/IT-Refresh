using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class HeadQuartersNc
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string UPassword { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? AccountStatusId { get; set; }
        public int? ApplicationId { get; set; }
        public int? UserRoleId { get; set; }
        public int? UserId { get; set; }
        public string IsApproved { get; set; }
        public string UserRoleType { get; set; }
        public string UserRoleDesc { get; set; }
        public string UserRoleSite { get; set; }
    }
}
