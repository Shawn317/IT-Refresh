using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class SsoUserChallengeQuestions
    {
        public int Id { get; set; }
        public string ChallengeQuestion { get; set; }
        public string IsActive { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
