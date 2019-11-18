using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SingleSignOn.Core.Entities
{
    public partial class SSOContext : DbContext
    {
        public SSOContext()
        {
        }

        public SSOContext(DbContextOptions<SSOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HeadQuartersAdmins> HeadQuartersAdmins { get; set; }
        public virtual DbSet<HeadQuartersDirector> HeadQuartersDirector { get; set; }
        public virtual DbSet<HeadQuartersNc> HeadQuartersNc { get; set; }
        public virtual DbSet<HeadQuartersNop> HeadQuartersNop { get; set; }
        public virtual DbSet<HeadQuartersRdd> HeadQuartersRdd { get; set; }
        public virtual DbSet<HeadQuartersResper> HeadQuartersResper { get; set; }
        public virtual DbSet<HeadQuartersTng> HeadQuartersTng { get; set; }
        public virtual DbSet<HeadQuartersUsers> HeadQuartersUsers { get; set; }
        public virtual DbSet<LkupPortalUserApplicationRoles> LkupPortalUserApplicationRoles { get; set; }
        public virtual DbSet<LkupRolesRequire2Fa> LkupRolesRequire2Fa { get; set; }
        public virtual DbSet<LkupSsoaccountStatus> LkupSsoaccountStatus { get; set; }
        public virtual DbSet<LkupSsoapplicationList> LkupSsoapplicationList { get; set; }
        public virtual DbSet<LkupSsouserRoles> LkupSsouserRoles { get; set; }

        public static object GetSeedingMessages()
        {
            throw new NotImplementedException();
        }

        public virtual DbSet<PortalUserApplicationRoles> PortalUserApplicationRoles { get; set; }
        public virtual DbSet<SsoAuditTrail> SsoAuditTrail { get; set; }
        public virtual DbSet<SsoAuthyUser> SsoAuthyUser { get; set; }
        public virtual DbSet<SsoChangePasswordEmailLog> SsoChangePasswordEmailLog { get; set; }
        public virtual DbSet<SsoUserApplication> SsoUserApplication { get; set; }
        public virtual DbSet<SsoUserCacinfo> SsoUserCacinfo { get; set; }
        public virtual DbSet<SsoUserChallengeQuestionAns> SsoUserChallengeQuestionAns { get; set; }
        public virtual DbSet<SsoUserChallengeQuestionAns2> SsoUserChallengeQuestionAns2 { get; set; }
        public virtual DbSet<SsoUserChallengeQuestions> SsoUserChallengeQuestions { get; set; }
        public virtual DbSet<SsoUserMembership> SsoUserMembership { get; set; }
        public virtual DbSet<SsoUserMembership2> SsoUserMembership2 { get; set; }
        public virtual DbSet<SsoUserPreviousPasswords> SsoUserPreviousPasswords { get; set; }
        public virtual DbSet<StateCommitteeAdmins> StateCommitteeAdmins { get; set; }
        public virtual DbSet<StateCommitteeLeaders> StateCommitteeLeaders { get; set; }
        public virtual DbSet<StateCommitteeUsers> StateCommitteeUsers { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<UserLoginAuditTrail> UserLoginAuditTrail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server = SHAWN-XPS15 ; Database = SSO; Trusted_Connection = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeadQuartersAdmins>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HeadQuartersAdmins");

                entity.Property(e => e.AccountStatusId).HasColumnName("accountStatusID");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .HasColumnName("eMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPassword)
                    .HasColumnName("uPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleDesc)
                    .HasColumnName("userRoleDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleID");

                entity.Property(e => e.UserRoleSite)
                    .HasColumnName("userRoleSite")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleType)
                    .HasColumnName("userRoleType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeadQuartersDirector>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HeadQuartersDirector");

                entity.Property(e => e.AccountStatusId).HasColumnName("accountStatusID");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .HasColumnName("eMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPassword)
                    .HasColumnName("uPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleDesc)
                    .HasColumnName("userRoleDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleID");

                entity.Property(e => e.UserRoleSite)
                    .HasColumnName("userRoleSite")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleType)
                    .HasColumnName("userRoleType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeadQuartersNc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HeadQuartersNC");

                entity.Property(e => e.AccountStatusId).HasColumnName("accountStatusID");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .HasColumnName("eMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPassword)
                    .HasColumnName("uPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleDesc)
                    .HasColumnName("userRoleDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleID");

                entity.Property(e => e.UserRoleSite)
                    .HasColumnName("userRoleSite")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleType)
                    .HasColumnName("userRoleType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeadQuartersNop>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HeadQuartersNOP");

                entity.Property(e => e.AccountStatusId).HasColumnName("accountStatusID");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .HasColumnName("eMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPassword)
                    .HasColumnName("uPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleDesc)
                    .HasColumnName("userRoleDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleID");

                entity.Property(e => e.UserRoleSite)
                    .HasColumnName("userRoleSite")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleType)
                    .HasColumnName("userRoleType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeadQuartersRdd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HeadQuartersRDD");

                entity.Property(e => e.AccountStatusId).HasColumnName("accountStatusID");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .HasColumnName("eMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPassword)
                    .HasColumnName("uPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleDesc)
                    .HasColumnName("userRoleDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleID");

                entity.Property(e => e.UserRoleSite)
                    .HasColumnName("userRoleSite")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleType)
                    .HasColumnName("userRoleType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeadQuartersResper>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HeadQuartersRESPER");

                entity.Property(e => e.AccountStatusId).HasColumnName("accountStatusID");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .HasColumnName("eMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPassword)
                    .HasColumnName("uPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleDesc)
                    .HasColumnName("userRoleDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleID");

                entity.Property(e => e.UserRoleSite)
                    .HasColumnName("userRoleSite")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleType)
                    .HasColumnName("userRoleType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeadQuartersTng>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HeadQuartersTNG");

                entity.Property(e => e.AccountStatusId).HasColumnName("accountStatusID");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .HasColumnName("eMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPassword)
                    .HasColumnName("uPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleDesc)
                    .HasColumnName("userRoleDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleID");

                entity.Property(e => e.UserRoleSite)
                    .HasColumnName("userRoleSite")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleType)
                    .HasColumnName("userRoleType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeadQuartersUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HeadQuartersUsers");

                entity.Property(e => e.AccountStatusId).HasColumnName("accountStatusID");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .HasColumnName("eMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPassword)
                    .HasColumnName("uPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleDesc)
                    .HasColumnName("userRoleDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleID");

                entity.Property(e => e.UserRoleSite)
                    .HasColumnName("userRoleSite")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleType)
                    .HasColumnName("userRoleType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LkupPortalUserApplicationRoles>(entity =>
            {
                entity.ToTable("lkup_PortalUserApplicationRoles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("dateModified")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserRoleDesc)
                    .HasColumnName("userRoleDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleSite)
                    .HasColumnName("userRoleSite")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleType)
                    .HasColumnName("userRoleType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LkupRolesRequire2Fa>(entity =>
            {
                entity.ToTable("lkup_RolesRequire2FA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.Requires2Fa)
                    .HasColumnName("Requires2FA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.LkupRolesRequire2Fa)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_lkup_RolesRequireAnakam_lkup_SSOApplicationList");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.LkupRolesRequire2Fa)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_lkup_RolesRequireAnakam_lkup_PortalUserApplicationRoles");
            });

            modelBuilder.Entity<LkupSsoaccountStatus>(entity =>
            {
                entity.ToTable("lkup_SSOaccountStatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountType)
                    .HasColumnName("accountType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LkupSsoapplicationList>(entity =>
            {
                entity.HasKey(e => e.ApplicationId);

                entity.ToTable("lkup_SSOApplicationList");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.ApplicationDesc)
                    .HasColumnName("applicationDesc")
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationName)
                    .HasColumnName("applicationName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationUrl)
                    .HasColumnName("applicationURL")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LkupSsouserRoles>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lkup_SSOUserRoles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserRoleType)
                    .HasColumnName("userRoleType")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PortalUserApplicationRoles>(entity =>
            {
                entity.ToTable("Portal_UserApplicationRoles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("dateModified")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.PortalUserApplicationRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_Portal_UserApplicationRoles_lkup_SSOApplicationList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalUserApplicationRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Portal_UserApplicationRoles_SSO_UserMembership");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.PortalUserApplicationRoles)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_Portal_UserApplicationRoles_lkup_PortalUserApplicationRoles");
            });

            modelBuilder.Entity<SsoAuditTrail>(entity =>
            {
                entity.ToTable("SSO_AuditTrail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllHttp)
                    .HasColumnName("allHTTP")
                    .IsUnicode(false);

                entity.Property(e => e.AllRaw)
                    .HasColumnName("allRaw")
                    .IsUnicode(false);

                entity.Property(e => e.HttpHost)
                    .HasColumnName("httpHost")
                    .IsUnicode(false);

                entity.Property(e => e.HttpReferer)
                    .HasColumnName("httpReferer")
                    .IsUnicode(false);

                entity.Property(e => e.HttpUserAgent)
                    .HasColumnName("httpUserAgent")
                    .IsUnicode(false);

                entity.Property(e => e.Https)
                    .HasColumnName("https")
                    .IsUnicode(false);

                entity.Property(e => e.QueryStringData)
                    .HasColumnName("queryStringData")
                    .IsUnicode(false);

                entity.Property(e => e.RemoteAddr)
                    .HasColumnName("remoteAddr")
                    .IsUnicode(false);

                entity.Property(e => e.RemoteHost)
                    .HasColumnName("remoteHost")
                    .IsUnicode(false);

                entity.Property(e => e.RemoteUser)
                    .HasColumnName("remoteUser")
                    .IsUnicode(false);

                entity.Property(e => e.RequestMethod)
                    .HasColumnName("requestMethod")
                    .IsUnicode(false);

                entity.Property(e => e.ServerPort)
                    .HasColumnName("serverPort")
                    .IsUnicode(false);

                entity.Property(e => e.ServerPortSecure)
                    .HasColumnName("serverPortSecure")
                    .IsUnicode(false);

                entity.Property(e => e.ServerProtocol)
                    .HasColumnName("serverProtocol")
                    .IsUnicode(false);

                entity.Property(e => e.ServerSoftware)
                    .HasColumnName("serverSoftware")
                    .IsUnicode(false);

                entity.Property(e => e.TimeDateStamp)
                    .HasColumnName("timeDateStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.UrlBase)
                    .HasColumnName("urlBase")
                    .IsUnicode(false);

                entity.Property(e => e.UserAction)
                    .HasColumnName("userAction")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SsoAuthyUser>(entity =>
            {
                entity.ToTable("SSO_AuthyUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthyId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.PhoneNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ssoid).HasColumnName("SSOid");
            });

            modelBuilder.Entity<SsoChangePasswordEmailLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SSO_ChangePasswordEmailLog");

                entity.Property(e => e.Content)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recipients)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SsoUserApplication>(entity =>
            {
                entity.ToTable("SSO_UserApplication");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("dateModified")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsLockedOut)
                    .HasColumnName("isLockedOut")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserRoleTypeId).HasColumnName("userRoleTypeID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.SsoUserApplication)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_SSO_UserApplication_lkup_SSOApplicationList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SsoUserApplication)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SSO_UserApplication_SSO_UserMembership");

                entity.HasOne(d => d.UserRoleType)
                    .WithMany(p => p.SsoUserApplication)
                    .HasForeignKey(d => d.UserRoleTypeId)
                    .HasConstraintName("FK_SSO_UserApplication_lkup_PortalUserApplicationRoles");
            });

            modelBuilder.Entity<SsoUserCacinfo>(entity =>
            {
                entity.ToTable("SSO_UserCACInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cacid)
                    .IsRequired()
                    .HasColumnName("CACid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("dateModified")
                    .HasColumnType("datetime");

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SsoUserCacinfo)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SSO_UserCACInfo_SSO_UserMembership");
            });

            modelBuilder.Entity<SsoUserChallengeQuestionAns>(entity =>
            {
                entity.ToTable("SSO_UserChallengeQuestionAns");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("dateModified")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserChallengeQuestion).HasColumnName("userChallengeQuestion");

                entity.Property(e => e.UserCqanswer)
                    .HasColumnName("userCQAnswer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SsoUserChallengeQuestionAns)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SSO_UserChallengeQuestionAns_SSO_UserMembership");
            });

            modelBuilder.Entity<SsoUserChallengeQuestionAns2>(entity =>
            {
                entity.ToTable("SSO_UserChallengeQuestionAns2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("dateModified")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserChallengeQuestion).HasColumnName("userChallengeQuestion");

                entity.Property(e => e.UserCqanswer)
                    .HasColumnName("userCQAnswer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");
            });

            modelBuilder.Entity<SsoUserChallengeQuestions>(entity =>
            {
                entity.ToTable("SSO_UserChallengeQuestions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChallengeQuestion)
                    .HasColumnName("challengeQuestion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("dateModified")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SsoUserMembership>(entity =>
            {
                entity.ToTable("SSO_UserMembership");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountStatusId).HasColumnName("accountStatusID");

                entity.Property(e => e.AuthyId)
                    .HasColumnName("authyId")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("dateModified")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisableCacwarning)
                    .HasColumnName("DisableCACWarning")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.EMail)
                    .HasColumnName("eMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FailedAttemptCount)
                    .HasColumnName("failedAttemptCount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastLockOutDate)
                    .HasColumnName("lastLockOutDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate)
                    .HasColumnName("lastLoginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangeDate)
                    .HasColumnName("lastPasswordChangeDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.UPassword)
                    .HasColumnName("uPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.USalt)
                    .HasColumnName("uSalt")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccountStatus)
                    .WithMany(p => p.SsoUserMembership)
                    .HasForeignKey(d => d.AccountStatusId)
                    .HasConstraintName("FK_SSO_UserMembership_lkup_SSOaccountStatus");
            });

            modelBuilder.Entity<SsoUserMembership2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SSO_UserMembership2");

                entity.Property(e => e.AccountStatusId).HasColumnName("accountStatusID");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnName("dateModified")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .HasColumnName("eMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FailedAttemptCount)
                    .HasColumnName("failedAttemptCount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastLockOutDate)
                    .HasColumnName("lastLockOutDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate)
                    .HasColumnName("lastLoginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangeDate)
                    .HasColumnName("lastPasswordChangeDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UPassword)
                    .HasColumnName("uPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SsoUserPreviousPasswords>(entity =>
            {
                entity.ToTable("SSO_UserPreviousPasswords");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password1).IsUnicode(false);

                entity.Property(e => e.Password10).IsUnicode(false);

                entity.Property(e => e.Password2).IsUnicode(false);

                entity.Property(e => e.Password3).IsUnicode(false);

                entity.Property(e => e.Password4).IsUnicode(false);

                entity.Property(e => e.Password5).IsUnicode(false);

                entity.Property(e => e.Password6).IsUnicode(false);

                entity.Property(e => e.Password7).IsUnicode(false);

                entity.Property(e => e.Password8).IsUnicode(false);

                entity.Property(e => e.Password9).IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SsoUserPreviousPasswords)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SSO_UserPreviousPasswords_SSO_UserMembership");
            });

            modelBuilder.Entity<StateCommitteeAdmins>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StateCommitteeAdmins");

                entity.Property(e => e.AccountStatusId).HasColumnName("accountStatusID");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .HasColumnName("eMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPassword)
                    .HasColumnName("uPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleDesc)
                    .HasColumnName("userRoleDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleID");

                entity.Property(e => e.UserRoleSite)
                    .HasColumnName("userRoleSite")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleType)
                    .HasColumnName("userRoleType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StateCommitteeLeaders>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StateCommitteeLeaders");

                entity.Property(e => e.AccountStatusId).HasColumnName("accountStatusID");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .HasColumnName("eMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPassword)
                    .HasColumnName("uPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleDesc)
                    .HasColumnName("userRoleDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleID");

                entity.Property(e => e.UserRoleSite)
                    .HasColumnName("userRoleSite")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleType)
                    .HasColumnName("userRoleType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StateCommitteeUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StateCommitteeUsers");

                entity.Property(e => e.AccountStatusId).HasColumnName("accountStatusID");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .HasColumnName("eMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPassword)
                    .HasColumnName("uPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleDesc)
                    .HasColumnName("userRoleDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleID");

                entity.Property(e => e.UserRoleSite)
                    .HasColumnName("userRoleSite")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleType)
                    .HasColumnName("userRoleType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserLoginAuditTrail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentLoginDateTime)
                    .HasColumnName("currentLoginDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastLoginDateTime)
                    .HasColumnName("lastLoginDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.UMmsid).HasColumnName("uMMSID");

                entity.Property(e => e.USsoid).HasColumnName("uSSOID");

                entity.HasOne(d => d.USso)
                    .WithMany(p => p.UserLoginAuditTrail)
                    .HasForeignKey(d => d.USsoid)
                    .HasConstraintName("FK_UserLoginAuditTrail_SSO_UserMembership");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
