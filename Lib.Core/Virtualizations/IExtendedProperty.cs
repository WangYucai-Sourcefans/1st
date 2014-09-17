#region "IExtendedProperty"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-17 14:50:44
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Virtualizations
 * 
 * ####     Type Name : IExtendedProperty
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Virtualizations.IExtendedProperty
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


namespace SourcefansStudio.FoundationFramework.Commons.Virtualizations
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.Virtualizations.IExtendedProperty</para>
    /// <para>
    /// 定义了与人相关的扩展属性的接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IExtendedProperty
    {
        #region Certificates
        /// <summary>
        /// 获取所持有的证件信息。
        /// </summary>
        CertificateCollection Certificates { get; }
        #endregion

        #region ContactMethods
        /// <summary>
        /// 设置或获取此人的联系方式。
        /// </summary>
        IAddressBook ContactMethods { get; set; }
        #endregion

        #region Organization
        /// <summary>
        /// 设置或获取所属的组织。
        /// </summary>
        IOrganization Organization { get; set; }
        #endregion

        #region JobTitle
        /// <summary>
        /// 设置或获取职位信息。
        /// </summary>
        IJobTitle JobTitle { get; set; }
        #endregion

        #region FamilyMembers
        /// <summary>
        /// 设置或获取相关人的家庭成员。
        /// </summary>
        PersonCollection FamilyMembers { get; set; }
        #endregion

        #region GetEducationExperiences
        /// <summary>
        /// 获取相关人的教育经历信息。
        /// </summary>
        /// <returns><see cref="EducationExperienceCollection"/>对象实例。</returns>
        EducationExperienceCollection GetEducationExperiences();
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