#region "IAssemblyFileInfo"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-22 16:27:34
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Reflection
 * 
 * ####     Type Name : IAssemblyFileInfo
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Reflection.IAssemblyFileInfo
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
using System.Diagnostics;
using System.Reflection;

namespace SourcefansStudio.FoundationFramework.Commons.Reflection
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.Reflection.IAssemblyFileInfo</para>
    /// <para>
    /// 程序集文件信息接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IAssemblyFileInfo
    {
        #region Name
        /// <summary>
        /// 获取程序集文件名称。
        /// </summary>
        string Name { get; }
        #endregion

        #region FullName
        /// <summary>
        /// 获取程序集文件完整名称。
        /// </summary>
        string FullName { get; }
        #endregion

        #region Exists
        /// <summary>
        /// 获取程序集文件是否存在。
        /// </summary>
        bool Exists { get; }
        #endregion

        #region AssemblyName
        /// <summary>
        /// 获取与程序集相关的名称信息。
        /// </summary>
        AssemblyName AssemblyName { get; }
        #endregion

        #region AssemblyFileVersion
        /// <summary>
        /// 获取程序集文件版本信息。
        /// </summary>
        FileVersionInfo AssemblyFileVersion { get; }
        #endregion

        #region AssemblyVersion
        /// <summary>
        /// 获取程序集版本信息。
        /// </summary>
        Version AssemblyVersion { get; }
        #endregion

        #region Load
        /// <summary>
        /// 将此程序集文件加载到当前的应用程序域中。
        /// </summary>
        /// <param name="loadDependencies">是否同时加载依赖项。</param>
        /// <returns><see cref="Assembly"/>对象实例。</returns>
        Assembly Load(bool loadDependencies);
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