#region "NetworkAdapterCollection"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-26 11:20:06
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.HardwareInformation
 * 
 * ####     Type Name : NetworkAdapterCollection
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.HardwareInformation.NetworkAdapterCollection
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.HardwareInformation.NetworkAdapterCollection</para>
    /// <para>
    /// 网络适配器信息集合。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    [Serializable]
    public sealed class NetworkAdapterCollection : BaseList<INetworkAdapter>
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="NetworkAdapterCollection" />对象实例。</para>
        /// </summary>
        public NetworkAdapterCollection()
        {
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