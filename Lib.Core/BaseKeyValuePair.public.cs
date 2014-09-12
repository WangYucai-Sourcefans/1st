#region "BaseKeyValuePair"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-12 10:23:40
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : BaseKeyValuePair
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.BaseKeyValuePair
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.BaseKeyValuePair</para>
    /// <para>
    /// 定义了基本的键值对基类。
    /// </para>
    /// </summary>
    /// <typeparam name="TKey">键类型。</typeparam>
    /// <typeparam name="TValue">值类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class BaseKeyValuePair<TKey, TValue> : IKeyValuePair<TKey, TValue>, IUniqueIdentity<TKey>, IOnlyGetUniqueIdentity<TKey>
    {
        private TKey _keyObj;
        private TValue _valueObj;

        #region IOnlyGetUniqueIdentity Members

        #region IOnlyGetUniqueIdentity<TKey>.UniqueId
        /// <summary>
        /// 获取唯一标识：键。
        /// </summary>
        TKey IOnlyGetUniqueIdentity<TKey>.UniqueId
        {
            get { return this.Key; }
        }
        #endregion

        #endregion

        #region IUniqueIdentity Members

        #region IUniqueIdentity<TKey>.UniqueId
        /// <summary>
        /// 设置或获取唯一标识：键。
        /// </summary>
        TKey IUniqueIdentity<TKey>.UniqueId
        {
            get
            {
                return this.Key;
            }
            set
            {
                this.Key = value;
            }
        }
        #endregion

        #endregion

        #region IKeyValuePair Members

        #region Key
        /// <summary>
        /// 设置或获取键名称。
        /// </summary>
        public virtual TKey Key
        {
            get
            {
                return this._keyObj;
            }
            set
            {
                this._keyObj = value;
            }
        }
        #endregion

        #region Value
        /// <summary>
        /// 设置或获取值。
        /// </summary>
        public virtual TValue Value
        {
            get
            {
                return this._valueObj;
            }
            set
            {
                this._valueObj = value;
            }
        }
        #endregion

        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="BaseKeyValuePair{TKey,TValue}" />对象实例。</para>
        /// </summary>
        public BaseKeyValuePair()
        {
            this.Key = TUtils<TKey>.Default;
            this.Value = TUtils<TValue>.Default;
        }

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="BaseKeyValuePair{TKey,TValue}" />对象实例。</para>
        /// </summary>
        /// <param name="key">键。</param>
        /// <param name="value">值。</param>
        public BaseKeyValuePair(TKey key, TValue value)
            : base()
        {
            this.Key = key;
            this.Value = value;
        }

        #endregion

        #region ConvertTo
        /// <summary>
        /// 将<see cref="BaseKeyValuePair{TKey,TValue}"/>对象实例转换成<see cref="System.Collections.Generic.KeyValuePair{TKey,TValue}"/>类型的结构。
        /// </summary>
        /// <returns><see cref="System.Collections.Generic.KeyValuePair{TKey,TValue}"/>类型的结构。</returns>
        public virtual System.Collections.Generic.KeyValuePair<TKey, TValue> ConvertTo()
        {
            return new System.Collections.Generic.KeyValuePair<TKey, TValue>(this.Key, this.Value);
        }
        #endregion

        #region ConvertFrom
        /// <summary>
        /// 将<see cref="System.Collections.Generic.KeyValuePair{TKey,TValue}"/>类型的结构转换成<see cref="IKeyValuePair{TKey,TValue}"/>对象实例。
        /// </summary>
        /// <param name="kv"><see cref="System.Collections.Generic.KeyValuePair{TKey,TValue}"/>类型的结构。</param>
        /// <returns>实现了<see cref="IKeyValuePair{TKey,TValue}"/>接口的对象实例。</returns>
        static public IKeyValuePair<TKey, TValue> ConvertFrom(System.Collections.Generic.KeyValuePair<TKey,TValue> kv)
        {
            return new BaseKeyValuePair<TKey, TValue>(kv.Key, kv.Value);
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