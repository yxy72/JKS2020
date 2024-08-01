using System;

namespace JKS_HIGH
{
    class PTInfo
    {
        public const int PTnum = 25;//0号位空
        private static int[] status = new int[PTnum];
        private static string[] data = new string[PTnum];
        private static string[][] his10Data = new string[PTnum][];
       
        private const int maxRecordNum = 300;
        private const int layoutPTNum = 6 + 1;//0号位空
        private static string[][] hisMaxData = new string[layoutPTNum][];


        private enum SORT
        {
            PT7, PT1, PT4, PT19,
            PT8, PT2, PT5, PT20,
            PT9, PT3, PT6, PT21,
            PT10, PT13, PT16, PT22,
            PT11, PT14, PT17, PT23,
            PT12, PT15, PT18, PT24
        };

        /*
            PT7, PT13, PT1, PT4,
            PT8, PT14, PT2, PT5,
            PT9, PT15, PT3, PT6,
            PT10, PT16, PT19, PT22,
            PT11, PT17, PT20, PT23,
            PT12, PT18, PT21, PT24

            PT7, PT1, PT4, PT19,
            PT8, PT2, PT5, PT20,
            PT9, PT3, PT6, PT21,
            PT10, PT13, PT16, PT22,
            PT11, PT14, PT17, PT23,
            PT12, PT15, PT18, PT24

         */



        private static Type enumType = SORT.PT1.GetType();
        private static int[] realSort = new int[PTInfo.PTnum - 1];



        public static int[] Status { get => status; set => status = value; }
        public static string[] Data { get => data; set => data = value; }
        public static string[][] His10Data { get => his10Data; set => his10Data = value; }

        public static int MaxRecordNum => maxRecordNum;

        public static int LayoutPTNum => layoutPTNum;

        public static string[][] HisMaxData { get => hisMaxData; set => hisMaxData = value; }
        public static int[] RealSort { get => realSort; set => realSort = value; }

        public static void Init()
        {
            for (int i = 1; i < PTnum; i++)
            {
                status[i] = 0;
                data[i] = "none";
            }
            for (int i = 1; i < layoutPTNum; i++)
                hisMaxData[i] = new string[maxRecordNum];
            
            for (int i = 0; i < PTInfo.PTnum - 1; i++)
                realSort[i] = Int32.Parse(Enum.GetName(enumType, i).Substring(2));

            if (realSort[1] == 1)
                v.LAYOUTMODEL = 0;
            else
                v.LAYOUTMODEL = 1;


        }
    }
}
