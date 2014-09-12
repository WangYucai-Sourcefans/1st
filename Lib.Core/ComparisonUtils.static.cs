#region "ComparisonUtils"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-11 14:00:30
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : ComparisonUtils
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.ComparisonUtils
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.ComparisonUtils</para>
    /// <para>
    /// 提供了常用的比对方法。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public static class ComparisonUtils
    {
        #region IsNull
        /// <summary>
        /// 验证<paramref name="obj"/>是否为null值。
        /// </summary>
        /// <param name="obj">未知类型的对象实例。</param>
        /// <returns>true or false。</returns>
        static public bool IsNull(object obj)
        {
            return object.ReferenceEquals(obj, null);
        }
        #endregion

        #region NotNull
        /// <summary>
        /// 验证<paramref name="obj"/>是否不等于null值。
        /// </summary>
        /// <param name="obj">未知类型的对象实例。</param>
        /// <returns>true or false 。</returns>
        static public bool NotNull(object obj)
        {
            return !ComparisonUtils.IsNull(obj);
        }
        #endregion

        #region IsNullOrEmpty
        /// <summary>
        /// 验证字符串<paramref name="s"/>是否为null值、或<see cref="string"/>.Empty。
        /// </summary>
        /// <param name="s">需要验证的字符串。</param>
        /// <returns>true or false 。</returns>
        static public bool IsNullOrEmpty(string s)
        {
            return string.IsNullOrEmpty(s);
        }
        #endregion

        #region IsNullOrWhitespace
        /// <summary>
        /// 验证字符串<paramref name="s"/>是否等于null值、<see cref="string"/>.Empty、空白符。
        /// </summary>
        /// <param name="s">需要验证的字符串。</param>
        /// <returns>true or false 。</returns>
        static public bool IsNullOrWhitespace(string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }
        #endregion

        #region IsZero
        /// <summary>
        /// 验证<paramref name="value"/>是否等于0。
        /// </summary>
        /// <param name="value"><see cref="int"/>类型值。</param>
        /// <returns>true or false 。</returns>
        static public bool IsZero(int value)
        {
            return value.Equals(0);
        }
        #endregion

        #region IsGreaterThanZero
        /// <summary>
        /// 验证<paramref name="value"/>是否大于0。
        /// </summary>
        /// <param name="value"><see cref="int"/>类型值。</param>
        /// <returns>true or false。</returns>
        static public bool IsGreaterThanZero(int value)
        {
            return value > 0;
        }
        #endregion

        #region Is
        /// <summary>
        /// 验证<paramref name="obj"/>是否为<typeparamref name="T"/>类型。
        /// <para>
        /// 如果<paramref name="obj"/>为null值，则返回true。
        /// </para>
        /// </summary>
        /// <typeparam name="T">类型。</typeparam>
        /// <param name="obj">未知类型的对象实例。</param>
        /// <returns>true or false 。</returns>
        static public bool Is<T>(object obj)
        {
            return ComparisonUtils.IsNull(obj) ? true : (obj is T);
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