using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class SsoChangePasswordEmailLog
    {
        public string Username { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Recipients { get; set; }
        public string Content { get; set; }
        public DateTime? DateSent { get; set; }
        public bool? IsSuccessful { get; set; }
    }
}
