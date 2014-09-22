#region "StringParser"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-22 15:53:30
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : StringParser
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.StringParser
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

using System;
using System.Reflection;

namespace SourcefansStudio.FoundationFramework.Commons
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.StringParser</para>
    /// <para>
    /// 定义了解析字符串的方法。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public static class StringParser
    {
        #region ParseTo
        /// <summary>
        /// 将字符串<paramref name="s"/>解析成等效的C#类型。
        /// </summary>
        /// <typeparam name="TCsharp">
        /// <typeparamref name="TCsharp"/>类型必须包含Parse静态方法，且此方法必须提供一个以字符串类型的参数。
        /// </typeparam>
        /// <param name="s">字符串。</param>
        /// <returns><see cref="TCsharp"/>类型值。</returns>
        /// <exception cref="NullReferenceException">当<paramref name="s"/>为null、Empty、或空白符时抛出此异常。</exception>
        /// <exception cref="AmbiguousMatchException">
        /// 当<typeparamref name="TCsharp"/>类型未提供匹配的静态方法时；或者参数类型个数等条件不匹配时，抛出此异常。
        /// </exception>
        static public TCsharp ParseTo<TCsharp>(string s)
        {
            if (ComparisonUtils.IsNullOrWhitespace(s)) throw new NullReferenceException();
            MethodInfo parseMethod = typeof(TCsharp).GetMethod("Parse", new Type[1] { typeof(string) });
            if (ComparisonUtils.IsNull(parseMethod)) throw new AmbiguousMatchException();
            return CastUtils<TCsharp>.CastTo(parseMethod.Invoke(null, new object[1] { s }));
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