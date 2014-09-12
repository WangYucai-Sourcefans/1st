#region "KeyValuePairFunc"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-12 14:26:46
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Collections
 * 
 * ####     Type Name : KeyValuePairFunc
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Collections.KeyValuePairFunc
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

namespace SourcefansStudio.FoundationFramework.Commons.Collections
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.Collections.KeyValuePairFunc</para>
    /// <para>
    /// 用于枚举字典集合中的键值对。
    /// </para>
    /// </summary>
    /// <typeparam name="TKey">键类型。</typeparam>
    /// <typeparam name="TValue">值类型。</typeparam>
    /// <param name="kv">键值对对象实例。</param>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public delegate void KeyValuePairFunc<TKey, TValue>(IKeyValuePair<TKey, TValue> kv);
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