#region "IAddressBook"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-17 15:05:49
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Virtualizations
 * 
 * ####     Type Name : IAddressBook
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Virtualizations.IAddressBook
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.Virtualizations.IAddressBook</para>
    /// <para>
    /// 定义了通讯录接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IAddressBook
    {
        #region OfficePhone
        /// <summary>
        /// 设置或获取办公电话。
        /// </summary>
        IContactMethod OfficePhone { get; set; }
        #endregion

        #region OfficePostalAddress
        /// <summary>
        /// 设置或获取办公的通信地址。
        /// </summary>
        IContactMethod OfficePostalAddress { get; set; }
        #endregion

        #region MobilePhone
        /// <summary>
        /// 设置或获取移动电话号码。
        /// </summary>
        IContactMethod MobilePhone { get; set; }
        #endregion

        #region EmailAddress
        /// <summary>
        /// 设置或获取电子邮件地址。
        /// </summary>
        IContactMethod EmailAddress { get; set; }
        #endregion

        #region ResidentialPhone
        /// <summary>
        /// 设置或获取住宅电话号码。
        /// </summary>
        IContactMethod ResidentialPhone { get; set; }
        #endregion

        #region ResidentialAddress
        /// <summary>
        /// 设置或获取住宅地址。
        /// </summary>
        IContactMethod ResidentialAddress { get; set; }
        #endregion

        #region Others
        /// <summary>
        /// 获取其他的联系方式。
        /// </summary>
        ContactMethodCollection Others { get; }
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