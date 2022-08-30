using VidGameLibDAL3;

namespace FinalProject
{
    public static class Globals
    {
        static public bool IsLoggedIn { get; set; } = false;
        static public UserPOCO CurrentUser { get; set; } = null;
    }
}