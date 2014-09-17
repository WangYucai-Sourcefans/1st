#region "WorkStatus"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-17 16:28:12
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Virtualizations
 * 
 * ####     Type Name : WorkStatus
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Virtualizations.WorkStatus
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

namespace SourcefansStudio.FoundationFramework.Commons.Virtualizations
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.Virtualizations.WorkStatus</para>
    /// <para>
    /// 定义了重用的工作状态枚举。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable()]
    public enum WorkStatus
    {
        /// <summary>
        /// 在职的。
        /// </summary>
        InOffice = 1,
        /// <summary>
        /// 已离职的。
        /// </summary>
        Resigned = 2,
        /// <summary>
        /// 正在办理离职手续。
        /// </summary>
        Resigning = 3,
        /// <summary>
        /// 无业的。
        /// </summary>
        None = 4,
        /// <summary>
        /// 未知的。
        /// </summary>
        Unknown = 5
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