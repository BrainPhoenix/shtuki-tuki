using System.Web;

namespace shtuki_tuki.web.Infrastructure
{
    public static class SessionPersister
    {
        private static string usernameSessionvar = "username";

        public static string Username
        {
            get
            {
                if (HttpContext.Current == null)
                    return string.Empty;

                var sessionVar = HttpContext.Current.Session[usernameSessionvar];

                if (sessionVar != null)
                    return sessionVar as string;
                return null;
            }
            set { HttpContext.Current.Session[usernameSessionvar] = value; }
        }
    }
}