using System;
using System.Runtime.InteropServices;

namespace Pickup.Text
{
    public class ChineseConverter
    {

        private const int LocaleSystemDefault = 0x0800;
        private const int LcmapSimplifiedChinese = 0x02000000;
        private const int LcmapTraditionalChinese = 0x04000000;

        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int LCMapString(int locale, int dwMapFlags, string lpSrcStr, int cchSrc,
                                      [Out] string lpDestStr, int cchDest);

        /// <summary>
        /// 繁体转简体。符號可能被轉成全型
        /// </summary>
        /// <param name="argSource"></param>
        /// <returns></returns>
        public static string ToSimplified(string argSource)
        {
            var t = new String(' ', argSource.Length);
            LCMapString(LocaleSystemDefault, LcmapSimplifiedChinese, argSource, argSource.Length, t, argSource.Length);
            return t;
        }

        /// <summary>
        /// 简体转繁体 。符號可能被轉成全型
        /// </summary>
        /// <param name="argSource"></param>
        /// <returns></returns>
        public static string ToTraditional(string argSource)
        {
            var t = new String(' ', argSource.Length);
            LCMapString(LocaleSystemDefault, LcmapTraditionalChinese, argSource, argSource.Length, t, argSource.Length);
            return t;
        }
    }
}
