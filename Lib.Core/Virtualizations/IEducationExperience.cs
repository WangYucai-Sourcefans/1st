#region "IEducationExperience"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-17 15:55:42
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Virtualizations
 * 
 * ####     Type Name : IEducationExperience
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Virtualizations.IEducationExperience
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.Virtualizations.IEducationExperience</para>
    /// <para>
    /// 定义了教育经历的信息接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IEducationExperience
    {
        #region Education
        /// <summary>
        /// 设置或获取所获得的学历信息。
        /// </summary>
        Education Education { get; set; }
        #endregion

        #region Status
        /// <summary>
        /// 设置或获取教育状态。
        /// </summary>
        EducationStatus Status { get; set; }
        #endregion

        #region SchoolName
        /// <summary>
        /// 设置或获取学校名称。
        /// </summary>
        string SchoolName { get; set; }
        #endregion

        #region EnrolDate
        /// <summary>
        /// 设置或获取入学日期。
        /// </summary>
        DateTime EnrolDate { get; set; }
        #endregion

        #region LeftDate
        /// <summary>
        /// 设置或获取离校日期。
        /// </summary>
        DateTime LeftDate { get; set; }
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