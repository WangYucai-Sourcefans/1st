#region "TUtils"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-11 14:37:18
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : TUtils
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.TUtils
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.TUtils</para>
    /// <para>
    /// 为泛型<typeparamref name="T"/>提供的方法。
    /// </para>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public static class TUtils<T>
    {
        #region Default
        /// <summary>
        /// 获取<typeparamref name="T"/>类型的默认值。
        /// </summary>
        static public T Default
        {
            get { return default(T); }
        }
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