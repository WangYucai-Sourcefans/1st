#region "IAppDomainExtender"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-22 17:00:49
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : IAppDomainExtender
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.IAppDomainExtender
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
using System.IO;
using System.Reflection;

namespace SourcefansStudio.FoundationFramework.Commons
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.IAppDomainExtender</para>
    /// <para>
    /// Description
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IAppDomainExtender
    {
        #region Domain
        /// <summary>
        /// 获取<see cref="AppDomain"/>对象实例。
        /// </summary>
        AppDomain Domain { get; }
        #endregion

        #region Assemblies
        /// <summary>
        /// 获取当前应用程序域中的程序集。
        /// </summary>
        Assembly[] Assemblies { get; }
        #endregion

        #region FindAssembly
        /// <summary>
        /// 从当前的应用程序域中获取名称为<paramref name="assemblyName"/>的<see cref="Assembly"/>对象实例。
        /// </summary>
        /// <param name="assemblyName">程序集的完全限定名称。</param>
        /// <returns><see cref="Assembly"/>对象实例。</returns>
        Assembly FindAssembly(string assemblyName);
        #endregion

        #region FriendlyName
        /// <summary>
        /// 获取此应用程序域的友好名称。
        /// </summary>
        string FriendlyName { get; }
        #endregion

        #region SetData
        /// <summary>
        /// 将数据<paramref name="data"/>写入应用程序域。
        /// </summary>
        /// <typeparam name="T">数据类型。</typeparam>
        /// <param name="data">键值对数据。</param>
        void SetData<T>(IKeyValuePair<string, T> data);
        #endregion

        #region GetData
        /// <summary>
        /// 获取名称为<paramref name="name"/>的数据。
        /// </summary>
        /// <typeparam name="T">数据类型。</typeparam>
        /// <param name="name">名称。</param>
        /// <returns><typeparamref name="T"/>类型的数据。</returns>
        T GetData<T>(string name);
        #endregion

        #region BaseDirectory
        /// <summary>
        /// 获取当前应用程序域的基础目录。
        /// </summary>
        DirectoryInfo BaseDirectory { get; }
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