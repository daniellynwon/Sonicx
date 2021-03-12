using System.Configuration;

namespace SmartMES_Sonicx
{
    public static class G
    {
        public static string Pos;
        public static string ComName;
        public static string PosName;

        public static string UserID;
        public static string UserName;
        public static string Authority;

        public static string conStr = ConfigurationManager.ConnectionStrings["SmartMES_Sonicx.Properties.Settings.snworld_mesConnectionString"].ConnectionString;
    }
}
