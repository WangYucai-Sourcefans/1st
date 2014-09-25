#region "IEnvironmentVariable"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-25 16:38:39
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : IEnvironmentVariable
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.IEnvironmentVariable
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

namespace SourcefansStudio.FoundationFramework.Commons
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.IEnvironmentVariable</para>
    /// <para>
    /// 环境变量信息接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IEnvironmentVariable : IKeyValuePair<string, string>
    {
        #region Name
        /// <summary>
        /// 设置或获取环境变量名称。
        /// </summary>
        string Name { get; set; }
        #endregion

        #region Create
        /// <summary>
        /// 创建环境变量。
        /// </summary>
        /// <param name="target">
        /// <see cref="EnvironmentVariableTarget"/>中的一个值。
        /// <para>默认为<see cref="EnvironmentVariableTarget"/>.Machine。</para>
        /// </param>
        void Create(EnvironmentVariableTarget target = EnvironmentVariableTarget.Machine);
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