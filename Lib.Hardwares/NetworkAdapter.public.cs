#region "NetworkAdapter"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-26 11:21:35
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.HardwareInformation
 * 
 * ####     Type Name : NetworkAdapter
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.HardwareInformation.NetworkAdapter
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
using SourcefansStudio.FoundationFramework.Commons.Collections;

namespace SourcefansStudio.FoundationFramework.Commons.HardwareInformation
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.HardwareInformation.NetworkAdapter</para>
    /// <para>
    /// 网络适配器信息实体。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class NetworkAdapter : INetworkAdapter
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="NetworkAdapter" />对象实例。</para>
        /// </summary>
        public NetworkAdapter()
        {
        }

        #endregion

        #region IPEnabled
        private bool _ipEnabled = false;
        /// <summary>
        /// 设置或获取是否启用了IP。
        /// </summary>
        public virtual bool IPEnabled
        {
            get
            {
                return this._ipEnabled;
            }
            set
            {
                this._ipEnabled = value;
            }
        }
        #endregion

        #region IPAddresses
        private BaseList<string> _ipAddressList = new BaseList<string>();
        /// <summary>
        /// 获取描述此网络适配器的IP地址集合。
        /// </summary>
        public virtual IBaseList<string> IPAddresses
        {
            get { return this._ipAddressList; }
        }
        #endregion

        #region MacAddress
        private string _physicalAddr;
        /// <summary>
        /// 设置或获取此网络适配器的MAC地址。
        /// </summary>
        public virtual string MacAddress
        {
            get
            {
                return this._physicalAddr;
            }
            set
            {
                this._physicalAddr = value;
            }
        }
        #endregion

        #region Description
        private string _description;
        /// <summary>
        /// 设置或获取此网络适配器的描述信息。
        /// </summary>
        public virtual string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        #endregion

        #region IPv4
        private string _ipv4;
        /// <summary>
        /// 设置或获取此网络适配器的IP地址(v4)。
        /// </summary>
        public virtual string IPv4
        {
            get
            {
                return this._ipv4;
            }
            set
            {
                this._ipv4 = value;
            }
        }
        #endregion

        #region IPv6
        private string _ipv6;
        /// <summary>
        /// 设置或获取此网络适配器的IP地址(v6)。
        /// </summary>
        public virtual string IPv6
        {
            get
            {
                return this._ipv6;
            }
            set
            {
                this._ipv6 = value;
            }
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