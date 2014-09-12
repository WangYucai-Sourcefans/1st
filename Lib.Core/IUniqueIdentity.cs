#region "IUniqueIdentity"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-12 10:02:01
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : IUniqueIdentity
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.IUniqueIdentity
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.IUniqueIdentity</para>
    /// <para>
    /// 唯一标识接口。
    /// </para>
    /// </summary>
    /// <typeparam name="T">标识类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IUniqueIdentity<T> : IOnlyGetUniqueIdentity<T>
    {
        #region UniqueId
        /// <summary>
        /// 设置或获取唯一标识。
        /// </summary>
        new T UniqueId { get; set; }
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