#region "AppDomainExtender"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-23 14:12:17
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : AppDomainExtender
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.AppDomainExtender
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.AppDomainExtender</para>
    /// <para>
    /// 定义了访问应用程序域的方法。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public class AppDomainExtender : IAppDomainExtender
    {
        #region InitAppDomainInstance
        /// <summary>
        /// 初始化应用程序域对象实例。
        /// </summary>
        /// <param name="domain"><see cref="AppDomain"/>对象实例。</param>
        protected virtual void InitAppDomainInstance(AppDomain domain)
        {
            this._appDomain = domain;
            this._friendlyName = domain.FriendlyName;
            this._baseDir = new DirectoryInfo(domain.BaseDirectory);
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="AppDomainExtender" />对象实例。</para>
        /// </summary>
        /// <param name="domain"><see cref="AppDomain"/>对象实例。</param>
        public AppDomainExtender(AppDomain domain)
        {
            this.InitAppDomainInstance(domain);
        }

        #endregion

        #region Domain
        private AppDomain _appDomain;
        /// <summary>
        /// 获取当前的<see cref="AppDomain"/>对象实例。
        /// </summary>
        public virtual AppDomain Domain
        {
            get { return this._appDomain; }
        }
        #endregion

        #region GetAssemblies
        /// <summary>
        /// 获取当前应用程序域中的所有程序集。
        /// </summary>
        /// <returns><see cref="Assembly"/>[]。</returns>
        protected virtual Assembly[] GetAssemblies()
        {
            return this.Domain.GetAssemblies();
        }
        #endregion

        #region Assemblies
        /// <summary>
        /// 获取当前的应用程序域中所有的程序集。
        /// </summary>
        public virtual Assembly[] Assemblies
        {
            get { return this.GetAssemblies(); }
        }
        #endregion

        #region FindAssembly
        /// <summary>
        /// 在当前的应用程序域中搜索名称为<paramref name="assemblyName"/>的<see cref="Assembly"/>对象实例。
        /// </summary>
        /// <param name="assemblyName">程序集的完全限定名称。</param>
        /// <returns><see cref="Assembly"/>对象实例。</returns>
        public virtual Assembly FindAssembly(string assemblyName)
        {
            Assembly[] assemblies = this.GetAssemblies();
            Assembly resultAss = null;
            foreach (Assembly item in assemblies)
            {
                if (item.FullName.Equals(assemblyName))
                {
                    resultAss = item; break;
                }
            }
            return resultAss;
        }
        #endregion

        #region FriendlyName
        private string _friendlyName;
        /// <summary>
        /// 获取当前应用程序域的友好名称。
        /// </summary>
        public virtual string FriendlyName
        {
            get { return this._friendlyName; }
        }
        #endregion

        #region SetData
        /// <summary>
        /// 将数据写入应用程序域中。
        /// </summary>
        /// <typeparam name="T">数据类型。</typeparam>
        /// <param name="data">键值对。</param>
        public virtual void SetData<T>(IKeyValuePair<string, T> data)
        {
            this.Domain.SetData(data.Key, data.Value);
        }
        #endregion

        #region GetData
        /// <summary>
        /// 从当前应用程序域中获取指定名称的数据。
        /// </summary>
        /// <typeparam name="T">数据类型。</typeparam>
        /// <param name="name">指定的名称。</param>
        /// <returns><typeparamref name="T"/>类型的数据。</returns>
        public virtual T GetData<T>(string name)
        {
            return CastUtils<T>.CastTo(this.Domain.GetData(name));
        }
        #endregion

        #region BaseDirectory
        private DirectoryInfo _baseDir;
        /// <summary>
        /// 获取当前应用程序域的基础目录。
        /// </summary>
        public virtual DirectoryInfo BaseDirectory
        {
            get { return this._baseDir; }
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