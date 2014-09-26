#region "NetworkAdapterSearcher"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-26 11:36:00
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.HardwareInformation
 * 
 * ####     Type Name : NetworkAdapterSearcher
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.HardwareInformation.NetworkAdapterSearcher
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
using System.Management;

namespace SourcefansStudio.FoundationFramework.Commons.HardwareInformation
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.HardwareInformation.NetworkAdapterSearcher</para>
    /// <para>
    /// 搜索网络适配器信息的类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public class NetworkAdapterSearcher : INetworkAdapterWMI, IWMI
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="NetworkAdapterSearcher" />对象实例。</para>
        /// </summary>
        public NetworkAdapterSearcher()
        {
        }

        #endregion

        #region GetNetworkAdapters
        /// <summary>
        /// 获取所有的网络适配器信息。
        /// </summary>
        /// <returns><see cref="NetworkAdapterCollection"/>对象实例。</returns>
        public virtual NetworkAdapterCollection GetNetworkAdapters()
        {
            NetworkAdapterCollection collection = new NetworkAdapterCollection();
            using (ManagementObjectSearcher searcher = this.CreateWmiSearcher())
            {
                ManagementObjectCollection objects = searcher.Get();
                foreach (ManagementObject item in objects)
                {
                    NetworkAdapter adapter = new NetworkAdapter()
                    {
                        Description = ComparisonUtils.NotNull(item["Description"]) ? CastUtils<string>.CastTo(item["Description"]) : string.Empty,
                        IPEnabled = ComparisonUtils.NotNull(item["IPEnabled"]) ? CastUtils<bool>.CastTo(item["IPEnabled"]) : false,
                        MacAddress = ComparisonUtils.NotNull(item["MACAddress"]) ? CastUtils<string>.CastTo(item["MACAddress"]) : string.Empty
                    };
                    if (ComparisonUtils.NotNull(item["IPAddress"]))
                    {
                        string[] ipArray = (string[])item["IPAddress"];
                        foreach (string ipItem in ipArray)
                        {
                            adapter.IPAddresses.Add(ipItem);
                            if (ipItem.Contains("::")) adapter.IPv6 = ipItem;
                            if (ipItem.Contains(".")) adapter.IPv4 = ipItem;
                        }
                    }
                    collection.Add(adapter);
                }
            }
            return collection;
        }
        #endregion

        #region GetIPEnabledNetworkAdapters
        /// <summary>
        /// 获取启用IP的网络适配器信息。
        /// </summary>
        /// <returns><see cref="NetworkAdapterCollection"/>对象实例。</returns>
        public virtual NetworkAdapterCollection GetIPEnabledNetworkAdapters()
        {
            NetworkAdapterCollection all = this.GetNetworkAdapters();
            NetworkAdapterCollection collection = new NetworkAdapterCollection();
            foreach (NetworkAdapter item in all)
            {
                if (item.IPEnabled) collection.Add(item);
            }
            return collection;
        }
        #endregion

        #region Scope
        /// <summary>
        /// 获取了WMI的查询范围。
        /// </summary>
        public virtual string Scope
        {
            get { return @"root\CIMV2"; }
        }
        #endregion

        #region QueryString
        /// <summary>
        /// 获取WMI查询表达式。
        /// </summary>
        public virtual string QueryString
        {
            get { return "SELECT * FROM Win32_NetworkAdapterConfiguration"; }
        }
        #endregion

        #region CreateWmiSearcher
        /// <summary>
        /// 创建WMI搜索对象。
        /// </summary>
        /// <returns><see cref="ManagementObjectSearcher"/>对象实例。</returns>
        public virtual ManagementObjectSearcher CreateWmiSearcher()
        {
            return new ManagementObjectSearcher(this.Scope, this.QueryString);
        }
        #endregion

        #region DoSearch
        /// <summary>
        /// 尚未实现此方法。
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        [Obsolete]
        public virtual void DoSearch()
        {
            throw new NotImplementedException();
        }
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