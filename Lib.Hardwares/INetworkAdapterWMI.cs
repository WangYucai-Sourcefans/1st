#region "INetworkAdapterWMI"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-26 11:32:14
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.HardwareInformation
 * 
 * ####     Type Name : INetworkAdapterWMI
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.HardwareInformation.INetworkAdapterWMI
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


namespace SourcefansStudio.FoundationFramework.Commons.HardwareInformation
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.HardwareInformation.INetworkAdapterWMI</para>
    /// <para>
    /// 访问网络适配器信息的WMI管理接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface INetworkAdapterWMI : IWMI
    {
        #region GetNetworkAdapters
        /// <summary>
        /// 获取所有的网络适配器信息。
        /// </summary>
        /// <returns><see cref="NetworkAdapterCollection"/>对象实例。</returns>
        NetworkAdapterCollection GetNetworkAdapters();
        #endregion

        #region GetIPEnabledNetworkAdapters
        /// <summary>
        /// 获取启用了IP的网络适配器信息。
        /// </summary>
        /// <returns><see cref="NetworkAdapterCollection"/>对象实例。</returns>
        NetworkAdapterCollection GetIPEnabledNetworkAdapters();
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