namespace FinalProject
{
    public static class SessionManager
    {
        public static bool IsLoggedIn { get; set; } = false;

        public static string CurrentUserEmail { get; set; }
    }
}