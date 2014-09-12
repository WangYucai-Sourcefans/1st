#region "BaseDictionary"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-12 15:00:40
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Collections
 * 
 * ####     Type Name : BaseDictionary
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Collections.BaseDictionary
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
using System.Collections.Generic;

namespace SourcefansStudio.FoundationFramework.Commons.Collections
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.Collections.BaseDictionary</para>
    /// <para>
    /// 提供了基本的字典集合操作。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class BaseDictionary<TKey, TValue> : IBaseDictionary<TKey, TValue>, IDictionary<TKey, TValue>
    {
        private IDictionary<TKey, TValue> _baseDictCollection;

        #region BaseDictCollection
        /// <summary>
        /// 设置或获取基础的字典集合实例。
        /// </summary>
        protected virtual IDictionary<TKey, TValue> BaseDictCollection
        {
            get { return _baseDictCollection; }
            set { _baseDictCollection = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="BaseDictionary{TKey,TValue}" />对象实例。</para>
        /// </summary>
        public BaseDictionary()
        {
            this.BaseDictCollection = new Dictionary<TKey, TValue>();
        }

        #endregion

        #region Add
        /// <summary>
        /// 添加键、值到字典中。
        /// </summary>
        /// <param name="key">键。</param>
        /// <param name="value">值。</param>
        public virtual void Add(TKey key, TValue value)
        {
            this.BaseDictCollection.Add(key, value);
        }
        #endregion

        #region ContainsKey
        /// <summary>
        /// 验证字典中是否包含键<paramref name="key"/>。
        /// </summary>
        /// <param name="key">键。</param>
        /// <returns>true or false。</returns>
        public virtual bool ContainsKey(TKey key)
        {
            return this.BaseDictCollection.ContainsKey(key);
        }
        #endregion

        #region Keys
        /// <summary>
        /// 获取键集合。
        /// </summary>
        public virtual ICollection<TKey> Keys
        {
            get { return this.BaseDictCollection.Keys; }
        }
        #endregion

        #region Remove
        /// <summary>
        /// 从字典中移除键<paramref name="key"/>对应的值。
        /// </summary>
        /// <param name="key">键。</param>
        /// <returns>
        /// <para>
        /// 如果字典中不包含<paramref name="key"/>，则返回false。
        /// </para>
        /// <para>
        /// 如果移除失败则返回false。
        /// </para>
        /// </returns>
        public virtual bool Remove(TKey key)
        {
            if (this.ContainsKey(key))
            {
                return this.BaseDictCollection.Remove(key);
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region TryGetValue
        /// <summary>
        /// 尝试获取键<paramref name="key"/>对应的值。
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值。</param>
        /// <returns>
        /// true or false。
        /// <para>如果字典中不包含<paramref name="key"/>，则返回true。<paramref name="value"/>为<typeparamref name="TValue"/>类型的默认值。</para>
        /// </returns>
        public virtual bool TryGetValue(TKey key, out TValue value)
        {
            value = TUtils<TValue>.Default;
            if (this.ContainsKey(key))
            {
                return this.BaseDictCollection.TryGetValue(key, out value);
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Values
        /// <summary>
        /// 获取字典中的值集合。
        /// </summary>
        public virtual ICollection<TValue> Values
        {
            get { return this.BaseDictCollection.Values; }
        }
        #endregion

        #region this
        /// <summary>
        /// 设置或获取键<paramref name="key"/>对应的值。
        /// </summary>
        /// <param name="key">键。</param>
        /// <returns>值。</returns>
        public virtual TValue this[TKey key]
        {
            get
            {
                return this.BaseDictCollection[key];
            }
            set
            {
                this.BaseDictCollection[key] = value;
            }
        }
        #endregion

        #region Add
        /// <summary>
        /// 添加键值对到字典中。
        /// </summary>
        /// <param name="kv"><see cref="KeyValuePair{TKey,TValue}"/>结构。</param>
        public virtual void Add(KeyValuePair<TKey, TValue> kv)
        {
            this.BaseDictCollection.Add(kv);
        }
        #endregion

        #region Clear
        /// <summary>
        /// 清空字典。
        /// </summary>
        public virtual void Clear()
        {
            this.BaseDictCollection.Clear();
        }
        #endregion

        #region Contains
        /// <summary>
        /// 验证集合中是否包含键值对<paramref name="kv"/>。
        /// </summary>
        /// <param name="kv"><see cref="KeyValuePair{TKey,TValue}"/>结构。</param>
        /// <returns>true or false。</returns>
        public virtual bool Contains(KeyValuePair<TKey, TValue> kv)
        {
            return this.BaseDictCollection.Contains(kv);
        }
        #endregion

        #region ICollection<KeyValuePair<TKey, TValue>>.CopyTo
        /// <summary>
        /// 尚未实现。
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        /// <exception cref="NotImplementedException"></exception>
        void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Count
        /// <summary>
        /// 获取字典中的元素个数。
        /// </summary>
        public virtual int Count
        {
            get { return this.BaseDictCollection.Count; }
        }
        #endregion

        #region IsReadOnly
        /// <summary>
        /// 获取此字典是否只读。
        /// </summary>
        public virtual bool IsReadOnly
        {
            get { return false; }
        }
        #endregion

        #region Remove
        /// <summary>
        /// 从集合中移除指定的键值对。
        /// </summary>
        /// <param name="kv"><see cref="KeyValuePair{TKey,TValue}"/>结构。</param>
        /// <returns>
        /// <para>如果字典中不包含指定键值对，则返回false。</para>
        /// <para>如果移除失败，则返回false。</para>
        /// </returns>
        public virtual bool Remove(KeyValuePair<TKey, TValue> kv)
        {
            if (this.ContainsKey(kv.Key) && this.Contains(kv))
            {
                return this.BaseDictCollection.Remove(kv);
                throw new NotImplementedException();
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region GetEnumerator
        /// <summary>
        /// 获取字典的枚举器。
        /// </summary>
        /// <returns><see cref="IEnumerator{T}"/>对象实例。</returns>
        public virtual IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return this.BaseDictCollection.GetEnumerator();
        }
        #endregion

        #region System.Collections.IEnumerable.GetEnumerator
        /// <summary>
        /// 获取集合的枚举器。
        /// </summary>
        /// <returns><see cref="System.Collections.IEnumerator"/>对象实例。</returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion

        #region Add
        /// <summary>
        /// 添加键值对到字典中。
        /// </summary>
        /// <param name="kv"><see cref="IKeyValuePair{TKey,TValue}"/>对象实例。</param>
        public virtual void Add(IKeyValuePair<TKey, TValue> kv)
        {
            this.Add(kv.ConvertTo());
        }
        #endregion

        #region ForeachKeys
        /// <summary>
        /// 执行foreach循环，枚举字典中的键。
        /// </summary>
        /// <param name="func"><see cref="ElementFunc{TKey}"/>方法委托。</param>
        public virtual void ForeachKeys(ElementFunc<TKey> func)
        {
            foreach (var item in this.Keys) func(item);
        }
        #endregion

        #region ForeachValues
        /// <summary>
        /// 执行foreach循环，枚举字典中的值。
        /// </summary>
        /// <param name="func"><see cref="ElementFunc{TValue}"/>方法委托。</param>
        public virtual void ForeachValues(ElementFunc<TValue> func)
        {
            foreach (var item in this.Values) func(item);
        }
        #endregion

        #region Foreach
        /// <summary>
        /// 执行foreach循环，枚举字典。
        /// </summary>
        /// <param name="func"><see cref="KeyValuePairFunc{TKey,TValue}"/>方法委托。</param>
        public virtual void Foreach(KeyValuePairFunc<TKey, TValue> func)
        {
            foreach (var key in this.Keys)
                func(
                    BaseKeyValuePair<TKey, TValue>.ConvertFrom(
                        new KeyValuePair<TKey, TValue>(key, this[key])
                        )
                    );
        }
        #endregion

        #region NoElements
        /// <summary>
        /// 获取字典中是否不包含任何元素。
        /// </summary>
        public virtual bool NoElements
        {
            get { return ComparisonUtils.IsZero(this.Count); }
        }
        #endregion

        #region operator +
        /// <summary>
        /// 重载的+运算符。
        /// </summary>
        /// <param name="dictionary">字典。</param>
        /// <param name="kv">有效的键值对。</param>
        /// <returns>字典集合。</returns>
        /// <exception cref="NullReferenceException">
        /// 当<paramref name="dictionary"/>或<paramref name="kv"/>为null时，抛出此异常。
        /// </exception>
        /// <exception cref="DuplicateWaitObjectException">
        /// 当字典<paramref name="dictionary"/>已经包含<paramref name="kv"/>的键，抛出此异常。
        /// </exception>
        public static BaseDictionary<TKey, TValue> operator +(BaseDictionary<TKey, TValue> dictionary, IKeyValuePair<TKey, TValue> kv)
        {
            if (ComparisonUtils.IsNull(dictionary) || ComparisonUtils.IsNull(kv)) throw new NullReferenceException();
            if (dictionary.ContainsKey(kv.Key)) throw new DuplicateWaitObjectException();
            dictionary.Add(kv);
            return dictionary;
        }
        #endregion

        #region operator -
        /// <summary>
        /// 重载的-运算符。
        /// </summary>
        /// <param name="dictionary">字典。</param>
        /// <param name="kv">键值对。</param>
        /// <returns>字典集合。</returns>
        /// <exception cref="NullReferenceException">
        /// 当<paramref name="dictionary"/>为null时，抛出此异常。
        /// </exception>
        public static BaseDictionary<TKey, TValue> operator -(BaseDictionary<TKey, TValue> dictionary, IKeyValuePair<TKey, TValue> kv)
        {
            if (ComparisonUtils.IsNull(dictionary)) throw new NullReferenceException();
            if (ComparisonUtils.NotNull(kv) && dictionary.ContainsKey(kv.Key)) dictionary.Remove(kv.Key);
            return dictionary;
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