namespace app.Common
{
    public class Constants
    {
        private const string ClientCompanyDomain = "@company.com";
        private const string AgencyCompanyDomain = "@agency.com";
        public const string ADMIN_EMAIL = "portal-admin@admin.com";
        public const string CLIENT_ADMIN_EMAIL = "client-admin" +ClientCompanyDomain;
        public const string CLIENT_CREATOR_EMAIL = "client-creator" +ClientCompanyDomain;
        public const string CLIENT_ASSIGNER_EMAIL = "client-assigner" +ClientCompanyDomain;
        public const string CLIENT_ASSESSOR_EMAIL = "client-assessor" +ClientCompanyDomain;
        public const string AGENCY_ADMIN_EMAIL = "agency-admin"+ AgencyCompanyDomain;
        public const string AGENCY_SUPERVISOR_EMAIL = "agency-supervisor"+ AgencyCompanyDomain;
        public const string AGENCY_AGENT_EMAIL = "agency-agent"+ AgencyCompanyDomain;
        public const string ADMIN_ROLE = "POA";
        public const string CLIENT_ADMIN_ROLE = "CAM";
        public const string CLIENT_CREATOR_ROLE = "CCR";
        public const string CLIENT_ASSIGNER_ROLE = "CAS";
        public const string CLIENT_ASSESSOR_ROLE = "CSS";
        public const string AGENCY_ADMIN_ROLE = "AAM";
        public const string AGENCY_SUPERVISOR_ROLE = "AAS";
        public const string AGENCY_AGENT_ROLE = "AAA";
    }
}
