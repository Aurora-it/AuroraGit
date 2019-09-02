using System.Configuration;
namespace AU_ManageStockPredict.Models.Common
{
    public static class Constants
    {
        private static string aurJobsConnectionString = ConfigurationManager.ConnectionStrings["AurJobsConnectionString"].ConnectionString;
        private static string aurNewConnectionString = ConfigurationManager.ConnectionStrings["AurNewConnectionString"].ConnectionString;
        private static string aurCrmNewConnectionString = ConfigurationManager.ConnectionStrings["AurCrmNewConnectionString"].ConnectionString;

        public static string AurJobsConn
        {
            get
            {
                return aurJobsConnectionString;
            }
        }


        public static string AurNewConn
        {
            get
            {
                return aurNewConnectionString;
            }
        }


        public static string AurCrmNewConn
        {
            get
            {
                return aurCrmNewConnectionString;
            }
        }
    }




    //public static class PlanStatus
    //{
    //    public const string Draft = "Draft";
    //    public const string Planning = "Planning";
    //    public const string Planned = "Planned";
    //    public const string Preparing = "Preparing";
    //    public const string Prepared = "Prepared";
    //}
}
