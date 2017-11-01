using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

//ref: http://www.cnblogs.com/Anna2Serena/archive/2011/10/13/2210235.html
namespace Pickup.Text
{
    public class VBChineseConverter
    {

        /// <summary>
        /// 繁体转简体
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToSimplified(string s)
        {
            return Strings.StrConv(s, VbStrConv.SimplifiedChinese, 0);
        }

        /// <summary>
        /// 简体转繁体
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToTraditional(string s)
        {
            return Strings.StrConv(s, VbStrConv.TraditionalChinese, 0);
        }

        /// <summary>
        /// 半角转全角
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToWideChar(string s)
        {
            return Strings.StrConv(s, VbStrConv.Wide, 0);
        }

        /// <summary>
        /// 全角转半角
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToNarrow(string s)
        {
            return Strings.StrConv(s, VbStrConv.Narrow,0 );
        }
    }
}
