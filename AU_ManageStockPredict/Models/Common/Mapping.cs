using System.Collections.Generic;

namespace AU_ManageStockPredict.Models
{
    public class Mapping
    {
        private static Dictionary<string, string> toHumanizeTh = new Dictionary<string, string>
                {
                    { "ago", "ก่อน" },
                    { "seconds", "วินาที" },
                    { "second", "วินาที" },
                    { "minutes", "นาที" },
                    { "minute", "นาที" },
                    { "hours", "ชั่วโมง" },
                    { "hour", "ชั่วโมง" },
                    { "days", "วัน" },
                    { "day", "วัน" },
                    { "weeks", "สัปดาห์" },
                    { "week", "สัปดาห์" },
                    { "months", "เดือน" },
                    { "month", "เดือน" },
                    { "years", "ปี" },
                    { "year", "ปี" },
                    { "yesterday", "เมื่อวาน" },
                    { "now", "" },
                };
        public static Dictionary<string, string> ToHumanizeTh
        {
            get
            {
                return toHumanizeTh;
            }
        }
    }
}
