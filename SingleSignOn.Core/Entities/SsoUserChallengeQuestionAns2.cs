using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class SsoUserChallengeQuestionAns2
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? UserChallengeQuestion { get; set; }
        public string UserCqanswer { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
