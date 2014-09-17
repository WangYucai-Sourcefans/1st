#region "IBaseDictionary"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-12 14:31:06
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Collections
 * 
 * ####     Type Name : IBaseDictionary
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Collections.IBaseDictionary
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


namespace SourcefansStudio.FoundationFramework.Commons.Collections
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.Collections.IBaseDictionary</para>
    /// <para>
    /// 基本字典集合接口。
    /// </para>
    /// </summary>
    /// <typeparam name="TKey">键类型。</typeparam>
    /// <typeparam name="TValue">值类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IBaseDictionary<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, IBaseCollection
    {
        #region Add
        /// <summary>
        /// 添加键值对到字典中。
        /// </summary>
        /// <param name="kv">键值对。</param>
        void Add(IKeyValuePair<TKey, TValue> kv);
        #endregion

        #region ForeachKeys
        /// <summary>
        /// 执行foreach循环，枚举每一个键，并调用<paramref name="func"/>进行处理。
        /// </summary>
        /// <param name="func"><see cref="ElementFunc{TKey}"/>方法委托。</param>
        void ForeachKeys(ElementFunc<TKey> func);
        #endregion

        #region ForeachValues
        /// <summary>
        /// 执行foreach循环，枚举每个元素，并调用<paramref name="func"/>进行处理。
        /// </summary>
        /// <param name="func"><see cref="ElementFunc{TValue}"/>方法委托。</param>
        void ForeachValues(ElementFunc<TValue> func);
        #endregion

        #region Foreach
        /// <summary>
        /// 执行foreach循环，并调用<paramref name="func"/>进行处理。
        /// </summary>
        /// <param name="func"><see cref="KeyValuePairFunc{TKey,TValue}"/>方法委托。</param>
        void Foreach(KeyValuePairFunc<TKey, TValue> func);
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