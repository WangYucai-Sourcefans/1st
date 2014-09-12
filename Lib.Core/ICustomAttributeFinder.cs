#region "ICustomAttributeFinder"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-11 13:48:43
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : ICustomAttributeFinder
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.ICustomAttributeFinder
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.ICustomAttributeFinder</para>
    /// <para>
    /// 用于搜索<see cref="Attribute"/>的接口。
    /// </para>
    /// </summary>
    /// <typeparam name="TTarget">需要搜索的目标类型。</typeparam>
    /// <typeparam name="TAttribute">需要搜索的<see cref="Attribute"/>类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface ICustomAttributeFinder<TTarget, TAttribute>
        where TAttribute : Attribute
    {
        #region GetCustomAttribute
        /// <summary>
        /// 获取<typeparamref name="TAttribute"/>类型的<see cref="Attribute"/>对象实例。
        /// </summary>
        /// <returns><see cref="Attribute"/>对象实例。</returns>
        TAttribute GetCustomAttribute();
        #endregion

        #region GetCustomAttributes
        /// <summary>
        /// 获取<typeparamref name="TAttribute"/>类型的<see cref="Attribute"/>对象实例数组。
        /// </summary>
        /// <returns><see cref="Attribute"/>数组。</returns>
        TAttribute[] GetCustomAttributes();
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