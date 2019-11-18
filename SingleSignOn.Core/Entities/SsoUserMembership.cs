using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class SsoUserMembership
    {
        public SsoUserMembership()
        {
            PortalUserApplicationRoles = new HashSet<PortalUserApplicationRoles>();
            SsoUserApplication = new HashSet<SsoUserApplication>();
            SsoUserCacinfo = new HashSet<SsoUserCacinfo>();
            SsoUserChallengeQuestionAns = new HashSet<SsoUserChallengeQuestionAns>();
            SsoUserPreviousPasswords = new HashSet<SsoUserPreviousPasswords>();
            UserLoginAuditTrail = new HashSet<UserLoginAuditTrail>();
        }

        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string UPassword { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? LastPasswordChangeDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? LastLockOutDate { get; set; }
        public int? FailedAttemptCount { get; set; }
        public int? AccountStatusId { get; set; }
        public string DisableCacwarning { get; set; }
        public int? MemberId { get; set; }
        public string USalt { get; set; }
        public bool? IsImported { get; set; }
        public string AuthyId { get; set; }

        public virtual LkupSsoaccountStatus AccountStatus { get; set; }
        public virtual ICollection<PortalUserApplicationRoles> PortalUserApplicationRoles { get; set; }
        public virtual ICollection<SsoUserApplication> SsoUserApplication { get; set; }
        public virtual ICollection<SsoUserCacinfo> SsoUserCacinfo { get; set; }
        public virtual ICollection<SsoUserChallengeQuestionAns> SsoUserChallengeQuestionAns { get; set; }
        public virtual ICollection<SsoUserPreviousPasswords> SsoUserPreviousPasswords { get; set; }
        public virtual ICollection<UserLoginAuditTrail> UserLoginAuditTrail { get; set; }
    }
}
