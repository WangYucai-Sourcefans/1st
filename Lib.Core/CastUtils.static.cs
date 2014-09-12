#region "CastUtils"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-11 14:31:18
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : CastUtils
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.CastUtils
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

namespace SourcefansStudio.FoundationFramework.Commons
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.CastUtils</para>
    /// <para>
    /// 提供了强制转换的方法。
    /// </para>
    /// </summary>
    /// <typeparam name="T">强制转换的类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public static class CastUtils<T>
    {
        #region CastTo
        /// <summary>
        /// 将<paramref name="obj"/>强制转换成<typeparamref name="T"/>类型。
        /// </summary>
        /// <param name="obj">未知类型的对象实例。</param>
        /// <returns><typeparamref name="T"/>。</returns>
        /// <exception cref="InvalidCastException">
        /// 当强制转换失败时，抛出此异常。
        /// </exception>
        static public T CastTo(object obj)
        {
            try
            {
                return (T)obj;
            }
            catch { throw new InvalidCastException(); }
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