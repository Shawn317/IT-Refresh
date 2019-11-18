using System;
using System.Collections.Generic;

namespace SingleSignOn.Core.Entities
{
    public partial class SsoAuditTrail
    {
        public int Id { get; set; }
        public string AllHttp { get; set; }
        public string AllRaw { get; set; }
        public string HttpHost { get; set; }
        public string HttpReferer { get; set; }
        public string HttpUserAgent { get; set; }
        public string Https { get; set; }
        public string QueryStringData { get; set; }
        public string RemoteAddr { get; set; }
        public string RemoteHost { get; set; }
        public string RemoteUser { get; set; }
        public string RequestMethod { get; set; }
        public string ServerPort { get; set; }
        public string ServerPortSecure { get; set; }
        public string ServerProtocol { get; set; }
        public string ServerSoftware { get; set; }
        public string UrlBase { get; set; }
        public DateTime? TimeDateStamp { get; set; }
        public string UserAction { get; set; }
    }
}
