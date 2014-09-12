#region "IExceptionPreCoding"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-09 16:50:52
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : IExceptionPreCoding
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.IExceptionPreCoding
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.IExceptionPreCoding</para>
    /// <para>
    /// 预定义的异常代码接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IExceptionPreCoding : IPreCoding<int>
    {
        #region GetExceptionPreCode
        /// <summary>
        /// 获取预定义的异常代码。
        /// </summary>
        /// <returns><see cref="int"/>型的异常代码值。</returns>
        int GetExceptionPreCode();
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