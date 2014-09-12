#region "IOnlyGetUniqueIdentity"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-12 10:04:04
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : IOnlyGetUniqueIdentity
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.IOnlyGetUniqueIdentity
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.IOnlyGetUniqueIdentity</para>
    /// <para>
    /// 唯一标识接口（只能获取）。
    /// </para>
    /// </summary>
    /// <typeparam name="T">唯一标识类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IOnlyGetUniqueIdentity<T>
    {
        #region UniqueId
        /// <summary>
        /// 获取唯一标识。
        /// </summary>
        T UniqueId { get; }
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