#region "IAppearanceProperty"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-12 16:55:35
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Virtualizations
 * 
 * ####     Type Name : IAppearanceProperty
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Virtualizations.IAppearanceProperty
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.Virtualizations.IAppearanceProperty</para>
    /// <para>
    /// 定义了与人类外表属性相关的接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IAppearanceProperty
    {
        #region Height
        /// <summary>
        /// 设置或获取身高值。
        /// </summary>
        ILength Height { get; set; }
        #endregion

        #region Weight
        /// <summary>
        /// 设置或获取重量值。
        /// </summary>
        IWeight Weight { get; set; }
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