#region "IContactMethod"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-17 15:00:07
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Virtualizations
 * 
 * ####     Type Name : IContactMethod
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Virtualizations.IContactMethod
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.Virtualizations.IContactMethod</para>
    /// <para>
    /// 定义了访问联系方式的接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IContactMethod
    {
        #region Method
        /// <summary>
        /// 设置或获取常用的联系方式。
        /// </summary>
        ContactMethods Method { get; set; }
        #endregion

        #region Description
        /// <summary>
        /// 设置或获取联系方式的描述信息。
        /// </summary>
        string Description { get; set; }
        #endregion

        #region Value
        /// <summary>
        /// 设置或获取具体的联系方式。
        /// </summary>
        string Value { get; set; }
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