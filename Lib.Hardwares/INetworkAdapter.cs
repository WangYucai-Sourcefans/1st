#region "INetworkAdapter"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-26 10:59:16
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.HardwareInformation
 * 
 * ####     Type Name : INetworkAdapter
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.HardwareInformation.INetworkAdapter
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

using SourcefansStudio.FoundationFramework.Commons.Collections;

namespace SourcefansStudio.FoundationFramework.Commons.HardwareInformation
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.HardwareInformation.INetworkAdapter</para>
    /// <para>
    /// 定义了网络适配器信息接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface INetworkAdapter
    {
        #region IPEnabled
        /// <summary>
        /// 设置或获取是否启用IP。
        /// </summary>
        bool IPEnabled { get; set; }
        #endregion

        #region IPAddresses
        /// <summary>
        /// 获取描述此网络适配器的IP地址集合。
        /// </summary>
        IBaseList<string> IPAddresses { get; }
        #endregion

        #region MacAddress
        /// <summary>
        /// 设置或获取MAC地址。
        /// </summary>
        string MacAddress { get; set; }
        #endregion

        #region Description
        /// <summary>
        /// 设置或获取此网络适配器的描述信息。
        /// </summary>
        string Description { get; set; }
        #endregion

        #region IPv4
        /// <summary>
        /// 设置或获取此网络适配器的IP地址(v4)。
        /// </summary>
        string IPv4 { get; set; }
        #endregion

        #region IPv6
        /// <summary>
        /// 设置或获取此网络适配器的IP地址(v6)。
        /// </summary>
        string IPv6 { get; set; }
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