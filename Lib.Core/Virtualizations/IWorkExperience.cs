#region "IWorkExperience"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-17 16:16:41
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Virtualizations
 * 
 * ####     Type Name : IWorkExperience
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Virtualizations.IWorkExperience
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.Virtualizations.IWorkExperience</para>
    /// <para>
    /// 定义了工作经历信息接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IWorkExperience
    {
        #region CorporationNature
        /// <summary>
        /// 设置或获取企业性质。
        /// </summary>
        EnterpriseNature CorporationNature { get; set; }
        #endregion

        #region CorporationName
        /// <summary>
        /// 设置或获取企业名称。
        /// </summary>
        string CorporationName { get; set; }
        #endregion

        #region ProbableHeadCount
        /// <summary>
        /// 设置或获取大概的员工数。
        /// </summary>
        int ProbableHeadCount { get; set; }
        #endregion

        #region WorkStatus
        /// <summary>
        /// 设置或获取此时的工作状态。
        /// </summary>
        WorkStatus WorkStatus { get; set; }
        #endregion

        #region JobTitle
        /// <summary>
        /// 设置或获取职位名称。
        /// </summary>
        string JobTitle { get; set; }
        #endregion

        #region InductionDate
        /// <summary>
        /// 设置或获取入职日期。
        /// </summary>
        DateTime InductionDate { get; set; }
        #endregion

        #region ResignedDate
        /// <summary>
        /// 设置或获取离职日期。
        /// </summary>
        DateTime ResignedDate { get; set; }
        #endregion

        #region Description
        /// <summary>
        /// 设置或获取工作描述信息。
        /// </summary>
        string Description { get; set; }
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