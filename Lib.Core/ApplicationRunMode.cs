#region "ApplicationRunMode"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-12 11:41:10
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : ApplicationRunMode
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.ApplicationRunMode
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.ApplicationRunMode</para>
    /// <para>
    /// 定义了应用运行模式。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable()]
    public enum ApplicationRunMode
    {
        /// <summary>
        /// 可执行的应用程序。
        /// </summary>
        ExecutableApplication = 'E',
        /// <summary>
        /// WEB应用程序。
        /// </summary>
        WebApplication = 'W',
        /// <summary>
        /// 移动应用程序。
        /// </summary>
        MobileApplication = 'M'
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