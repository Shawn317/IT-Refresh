using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class SsoUserPreviousPasswords
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
        public string Password3 { get; set; }
        public string Password4 { get; set; }
        public string Password5 { get; set; }
        public string Password6 { get; set; }
        public string Password7 { get; set; }
        public string Password8 { get; set; }
        public string Password9 { get; set; }
        public string Password10 { get; set; }
        public int? CurrentPassword { get; set; }

        public virtual SsoUserMembership User { get; set; }
    }
}
