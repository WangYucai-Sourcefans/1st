#region "EducationStatus"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-17 15:59:35
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Virtualizations
 * 
 * ####     Type Name : EducationStatus
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Virtualizations.EducationStatus
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.Virtualizations.EducationStatus</para>
    /// <para>
    /// 定义了教育状态枚举。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable()]
    public enum EducationStatus
    {
        /// <summary>
        /// 在读。
        /// </summary>
        Inprogress = 1,
        /// <summary>
        /// 毕业。
        /// </summary>
        Graduate = 2,
        /// <summary>
        /// 肄业。
        /// </summary>
        NotGraduate = 3,
        /// <summary>
        /// 退学。
        /// </summary>
        DropOut = 4,
        /// <summary>
        /// 休学。
        /// </summary>
        Suspended = 5,
        /// <summary>
        /// 实习中。
        /// </summary>
        Internship = 6,
        /// <summary>
        /// 无。
        /// </summary>
        None = 7,
        /// <summary>
        /// 未知的。
        /// </summary>
        Unknown = 8
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