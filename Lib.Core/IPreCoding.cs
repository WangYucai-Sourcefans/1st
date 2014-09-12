#region "IPreCoding"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-09 16:47:00
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : IPreCoding
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.IPreCoding
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


namespace SourcefansStudio.FoundationFramework.Commons
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.IPreCoding&lt;TCode&gt;</para>
    /// <para>
    /// 预定义的代码接口。
    /// </para>
    /// </summary>
    /// <typeparam name="TCode">预定义的代码类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IPreCoding<TCode>
    {
        #region Code
        /// <summary>
        /// 获取预定义的代码。
        /// </summary>
        TCode Code { get; }
        #endregion

        #region GetCode
        /// <summary>
        /// 获取预定义的代码值。
        /// </summary>
        /// <returns><typeparamref name="TCode"/>类型的代码值。</returns>
        TCode GetCode();
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