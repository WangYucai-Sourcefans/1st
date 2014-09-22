#region "AssemblyFileInfo"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-22 16:37:43
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Reflection
 * 
 * ####     Type Name : AssemblyFileInfo
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Reflection.AssemblyFileInfo
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
using System.Diagnostics;

namespace SourcefansStudio.FoundationFramework.Commons.Reflection
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.Reflection.AssemblyFileInfo</para>
    /// <para>
    /// 定义了访问程序集文件信息的方法。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    /// <exception cref="FileNotFoundException">当程序集文件不存在时，抛出此异常。</exception>
    public class AssemblyFileInfo : IAssemblyFileInfo
    {
        private FileInfo _assemblyFileInfo;

        #region Name
        private string _name;
        /// <summary>
        /// 获取程序集文件名称。
        /// </summary>
        public virtual string Name
        {
            get
            {
                this.RaiseException();
                return this._name;
            }
        }
        #endregion

        #region FullName
        private string _fullName;
        /// <summary>
        /// 获取程序集文件的完整名称。
        /// </summary>
        public virtual string FullName
        {
            get
            {
                this.RaiseException();
                return this._fullName;
            }
        }
        #endregion

        #region Exists
        private bool _exists;
        /// <summary>
        /// 获取此程序集文件是否存在。
        /// </summary>
        public virtual bool Exists
        {
            get
            {
                return this._exists;
            }
        }
        #endregion

        #region AssemblyName
        private AssemblyName _assemblyName;
        /// <summary>
        /// 获取与程序集名称相关的信息。
        /// </summary>
        public virtual AssemblyName AssemblyName
        {
            get
            {
                this.RaiseException();
                return this._assemblyName;
            }
        }
        #endregion

        #region AssemblyFileVersion
        private FileVersionInfo _assemblyFileVersion;
        /// <summary>
        /// 获取程序集文件版本信息。
        /// </summary>
        public virtual FileVersionInfo AssemblyFileVersion
        {
            get
            {
                this.RaiseException();
                return this._assemblyFileVersion;
            }
        }
        #endregion

        #region AssemblyVersion
        private Version _assemblyVersion;
        /// <summary>
        /// 获取程序集版本信息。
        /// </summary>
        public virtual Version AssemblyVersion
        {
            get
            {
                this.RaiseException();
                return this._assemblyVersion;
            }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="AssemblyFileInfo" />对象实例。</para>
        /// </summary>
        /// <param name="fileName">程序集文件名称。</param>
        public AssemblyFileInfo(string fileName)
        {
            this._assemblyFileInfo = new FileInfo(fileName);
            this._exists = this._assemblyFileInfo.Exists;
            if (this._exists)
            {
                this._name = _assemblyFileInfo.Name;
                this._fullName = _assemblyFileInfo.FullName;
                this._assemblyName = AssemblyName.GetAssemblyName(_assemblyFileInfo.FullName);
                this._assemblyVersion = this._assemblyName.Version;
                this._assemblyFileVersion = FileVersionInfo.GetVersionInfo(_assemblyFileInfo.FullName);
            }
        }

        #endregion

        #region RaiseException
        /// <summary>
        /// 验证程序集文件是否存在，如果不存在则抛出<see cref="FileNotFoundException"/>异常。
        /// </summary>
        protected virtual void RaiseException()
        {
            if (!this.Exists) throw new FileNotFoundException();
        }
        #endregion

        #region Load
        /// <summary>
        /// 加载程序集到当前的应用程序域中。
        /// </summary>
        /// <param name="loadDependencies">是否同时加载此程序集的依赖项。</param>
        /// <returns><see cref="Assembly"/>的对象实例。</returns>
        public virtual Assembly Load(bool loadDependencies)
        {
            this.RaiseException();
            
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