#region "ICertificate"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-17 14:43:48
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Virtualizations
 * 
 * ####     Type Name : ICertificate
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Virtualizations.ICertificate
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.Virtualizations.ICertificate</para>
    /// <para>
    /// 定义了证件信息的接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface ICertificate
    {
        #region Type
        /// <summary>
        /// 设置或获取证件类型。
        /// </summary>
        CertificateTypes Type { get; set; }
        #endregion

        #region Name
        /// <summary>
        /// 设置或获取证件类型。
        /// </summary>
        string Name { get; set; }
        #endregion

        #region Number
        /// <summary>
        /// 设置或获取证件编号。
        /// </summary>
        string Number { get; set; }
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