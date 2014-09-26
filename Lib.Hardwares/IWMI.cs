#region "IWMI"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-26 10:53:53
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.HardwareInformation
 * 
 * ####     Type Name : IWMI
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.HardwareInformation.IWMI
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

using System.Management;

namespace SourcefansStudio.FoundationFramework.Commons.HardwareInformation
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.HardwareInformation.IWMI</para>
    /// <para>
    /// Windows Management Instrumentation 查询接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IWMI
    {
        #region Scope
        /// <summary>
        /// 获取查询范围。
        /// </summary>
        string Scope { get; }
        #endregion

        #region QueryString
        /// <summary>
        /// 获取查询表达式。
        /// </summary>
        string QueryString { get; }
        #endregion

        #region CreateWmiSearcher
        /// <summary>
        /// 创建一个<see cref="ManagementObjectSearcher"/>查询对象实例。
        /// </summary>
        /// <returns><see cref="ManagementObjectSearcher"/>对象实例。</returns>
        ManagementObjectSearcher CreateWmiSearcher();
        #endregion

        #region DoSearch
        /// <summary>
        /// 执行查询。
        /// </summary>
        void DoSearch();
        #endregion
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