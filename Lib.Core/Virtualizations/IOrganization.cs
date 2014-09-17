#region "IOrganization"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-17 15:19:13
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Virtualizations
 * 
 * ####     Type Name : IOrganization
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Virtualizations.IOrganization
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.Virtualizations.IOrganization</para>
    /// <para>
    /// 定义了组织信息的接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IOrganization
    {
        #region Name
        /// <summary>
        /// 设置或获取组织的名称。
        /// </summary>
        string Name { get; set; }
        #endregion

        #region GetSuperior
        /// <summary>
        /// 获取上级组织的信息。
        /// </summary>
        /// <returns>实现了<see cref="IOrganization"/>接口的对象实例。</returns>
        IOrganization GetSuperior();
        #endregion

        #region GetSubs
        /// <summary>
        /// 获取下属的组织。
        /// </summary>
        /// <returns><see cref="OrganizationCollection"/>对象实例。</returns>
        OrganizationCollection GetSubs();
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