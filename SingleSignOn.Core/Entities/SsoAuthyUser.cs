using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class SsoAuthyUser
    {
        public int Id { get; set; }
        public string AuthyId { get; set; }
        public string PhoneNum { get; set; }
        public int? Ssoid { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
