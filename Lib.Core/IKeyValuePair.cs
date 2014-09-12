#region "IKeyValuePair"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-12 10:17:18
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : IKeyValuePair
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.IKeyValuePair
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

using System.Collections.Generic;

namespace SourcefansStudio.FoundationFramework.Commons
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.IKeyValuePair</para>
    /// <para>
    /// 键值对接口。
    /// </para>
    /// </summary>
    /// <typeparam name="TKey">键类型。</typeparam>
    /// <typeparam name="TValue">值类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IKeyValuePair<TKey, TValue> : IUniqueIdentity<TKey>
    {
        #region Key
        /// <summary>
        /// 设置或获取键名称。
        /// </summary>
        TKey Key { get; set; }
        #endregion

        #region Value
        /// <summary>
        /// 设置或获取值。
        /// </summary>
        TValue Value { get; set; }
        #endregion

        #region ConvertTo
        /// <summary>
        /// 将此对象实例转换成<see cref="System.Collections.Generic.KeyValuePair{TKey,TValue}"/>类型。
        /// </summary>
        /// <returns><see cref="System.Collections.Generic.KeyValuePair{TKey,TValue}"/>类型的结构体。</returns>
        KeyValuePair<TKey, TValue> ConvertTo();
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