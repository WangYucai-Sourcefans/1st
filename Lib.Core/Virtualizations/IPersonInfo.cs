#region "IPersonInfo"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-12 16:49:47
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Virtualizations
 * 
 * ####     Type Name : IPersonInfo
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Virtualizations.IPersonInfo
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

namespace SourcefansStudio.FoundationFramework.Commons.Virtualizations
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.Virtualizations.IPersonInfo</para>
    /// <para>
    /// 定义了人类基本的信息。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IPersonInfo
    {
        #region LastName
        /// <summary>
        /// 设置或获取姓氏。
        /// </summary>
        string LastName { get; set; }
        #endregion

        #region FirstName
        /// <summary>
        /// 设置或获取名字。
        /// </summary>
        string FirstName { get; set; }
        #endregion

        #region Name
        /// <summary>
        /// 设置或获取姓名。
        /// </summary>
        string Name { get; set; }
        #endregion

        #region Age
        /// <summary>
        /// 设置或获取年龄。
        /// </summary>
        int Age { get; set; }
        #endregion

        #region BirthDate
        /// <summary>
        /// 设置或获取出生日期。
        /// </summary>
        DateTime BirthDate { get; set; }
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