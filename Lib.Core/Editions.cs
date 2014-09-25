#region "Editions"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-25 16:13:50
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : Editions
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Editions
 * 
 * ####     Machine Name : GLCHQWYCWINW7
 * 
 * ####     UserName : GUOCOLAND/wangyucai
 * 
 * ####     CLR Version : 4.0.30319.18444
 * 
 * ####     Target Framework Version : 4.0
 */

#endregion

using System;

namespace SourcefansStudio.FoundationFramework.Commons
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.Editions</para>
    /// <para>
    /// 用来描述软件的常用版本信息的枚举类型。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable()]
    public enum Editions : int
    {
        /// <summary>
        /// 内测版。
        /// </summary>
        Alpha = 1,
        /// <summary>
        /// 公测版。
        /// </summary>
        Beta = 2,
        /// <summary>
        /// RC候选版。
        /// </summary>
        ReleaseCandidate = 3,
        /// <summary>
        /// RTM版。
        /// </summary>
        ReleaseToManufacture = 4,
        /// <summary>
        /// 试用版。
        /// </summary>
        Trial = 5,
        /// <summary>
        /// 未注册版。
        /// </summary>
        Unregistered = 6,
        /// <summary>
        /// 演示版。
        /// </summary>
        Demo = 7,
        /// <summary>
        /// 注册版。
        /// </summary>
        Registered = 8,
        /// <summary>
        /// 标准版。
        /// </summary>
        Standard = 9,
        /// <summary>
        /// 豪华版。
        /// </summary>
        Deluxe = 10,
        /// <summary>
        /// 专业版。
        /// </summary>
        Professional = 11,
        /// <summary>
        /// 企业版。
        /// </summary>
        Enterprise = 12,
        /// <summary>
        /// 开发人员版。
        /// </summary>
        Developer = 13,
        /// <summary>
        /// 旗舰版。
        /// </summary>
        Ultimate = 65535,
        /// <summary>
        /// OEM版。
        /// </summary>
        OEM = 14,
        /// <summary>
        /// 免费版。
        /// </summary>
        Free=15,
        /// <summary>
        /// 预览版。
        /// </summary>
        Preview=16,
        /// <summary>
        /// 特别版。
        /// </summary>
        Express=17,
    }
}

#region README

/*
 * ####     ©2014 Wang Yucai
 * 
 * ####     Contact me
 *                  
 *                  E-mail : Masterduner@Yeah.net
 *                  Mobile : 13621384677
 *                  QQ : 180261899
 */

#endregion