#region "BaseList"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-12 13:49:03
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Collections
 * 
 * ####     Type Name : BaseList
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Collections.BaseList
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.Collections.BaseList</para>
    /// <para>
    /// 提供了基本的列表集合操作。
    /// </para>
    /// </summary>
    /// <typeparam name="TElement">元素类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class BaseList<TElement> : IBaseList<TElement>, IList<TElement>
    {
        private IList<TElement> _baseListCollection;

        #region BaseListCollection
        /// <summary>
        /// 设置或获取基本的列表集合。
        /// </summary>
        protected virtual IList<TElement> BaseListCollection
        {
            get { return _baseListCollection; }
            set { _baseListCollection = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="BaseList{TElement}" />对象实例。</para>
        /// </summary>
        public BaseList()
        {
            this.BaseListCollection = new List<TElement>();
        }

        #endregion

        #region IndexOf
        /// <summary>
        /// 获取<paramref name="element"/>在列表中的索引位置。
        /// </summary>
        /// <param name="element"><typeparamref name="TElement"/>类型的对象实例。</param>
        /// <returns><see cref="int"/>类型值。</returns>
        public virtual int IndexOf(TElement element)
        {
            return this.BaseListCollection.IndexOf(element);
        }
        #endregion

        #region Insert
        /// <summary>
        /// 将<paramref name="element"/>插入到集合中的指定位置。
        /// </summary>
        /// <param name="index">位置索引。</param>
        /// <param name="element"><typeparamref name="TElement"/>类型的对象实例。</param>
        public virtual void Insert(int index, TElement element)
        {
            this.BaseListCollection.Insert(index, element);
        }
        #endregion

        #region RemoveAt
        /// <summary>
        /// 移除指定索引处的元素。
        /// </summary>
        /// <param name="index">位置索引。</param>
        public virtual void RemoveAt(int index)
        {
            this.BaseListCollection.RemoveAt(index);
        }
        #endregion

        #region this
        /// <summary>
        /// 设置或获取指定索引处的元素。
        /// </summary>
        /// <param name="index">位置索引。</param>
        /// <returns><typeparamref name="TElement"/>类型的对象实例。</returns>
        public virtual TElement this[int index]
        {
            get
            {
                return this.BaseListCollection[index];
            }
            set
            {
                this.BaseListCollection[index] = value;
            }
        }
        #endregion

        #region Add
        /// <summary>
        /// 添加<paramref name="element"/>到集合的结尾位置。
        /// </summary>
        /// <param name="element"><typeparamref name="TElement"/>类型的对象实例。</param>
        public virtual void Add(TElement element)
        {
            this.BaseListCollection.Add(element);
        }
        #endregion

        #region Clear
        /// <summary>
        /// 清空此列表集合。
        /// </summary>
        public virtual void Clear()
        {
            this.BaseListCollection.Clear();
        }
        #endregion

        #region Contains
        /// <summary>
        /// 验证集合中是否包含<paramref name="element"/>。
        /// </summary>
        /// <param name="element"><typeparamref name="TElement"/>类型的对象实例。</param>
        /// <returns>true or false 。</returns>
        public virtual bool Contains(TElement element)
        {
            return this.BaseListCollection.Contains(element);
        }
        #endregion

        #region ICollection<TElement>.CopyTo
        /// <summary>
        /// 尚未实现。
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        /// <exception cref="NotImplementedException"></exception>
        [Obsolete]
        void ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Count
        /// <summary>
        /// 获取集合中的元素个数。
        /// </summary>
        public virtual int Count
        {
            get { return this.BaseListCollection.Count; }
        }
        #endregion

        #region IsReadOnly
        /// <summary>
        /// 获取此集合是否只读。
        /// </summary>
        public virtual bool IsReadOnly
        {
            get { return false; }
        }
        #endregion

        #region Remove
        /// <summary>
        /// 从集合中移除<paramref name="element"/>。
        /// </summary>
        /// <param name="element"><typeparamref name="TElement"/>类型的对象实例。</param>
        /// <returns>true or false 。</returns>
        public virtual bool Remove(TElement element)
        {
            return this.BaseListCollection.Remove(element);
        }
        #endregion

        #region GetEnumerator
        /// <summary>
        /// 获取<see cref="IEnumerator{TElement}"/>对象实例。
        /// </summary>
        /// <returns><see cref="IEnumerator{TElement}"/>对象实例。</returns>
        public virtual IEnumerator<TElement> GetEnumerator()
        {
            return this.BaseListCollection.GetEnumerator();
        }
        #endregion

        #region System.Collections.IEnumerable.GetEnumerator
        /// <summary>
        /// 获取<see cref="System.Collections.IEnumerator"/>对象实例。
        /// </summary>
        /// <returns></returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion

        #region NoElements
        /// <summary>
        /// 获取集合是否不包含任何元素。
        /// </summary>
        public virtual bool NoElements
        {
            get { return ComparisonUtils.IsZero(this.Count); }
        }
        #endregion

        #region Foreach
        /// <summary>
        /// 执行foreach循环，并调用<paramref name="func"/>进行处理。
        /// </summary>
        /// <param name="func"><see cref="ElementFunc{TElement}"/>方法委托。</param>
        public virtual void Foreach(ElementFunc<TElement> func)
        {
            foreach (var item in this.BaseListCollection) func(item);
        }
        #endregion

        #region operator +
        /// <summary>
        /// 重载的+运算符。
        /// </summary>
        /// <param name="list">列表集合。</param>
        /// <param name="element"><typeparamref name="TElement"/>类型的元素。</param>
        /// <returns>列表集合。</returns>
        /// <exception cref="NullReferenceException">
        /// 当列表元素<paramref name="list"/>为null值时抛出此异常。
        /// </exception>
        /// <exception cref="DuplicateWaitObjectException">
        /// 当列表集合中已经包含<paramref name="element"/>时，抛出此异常。
        /// </exception>
        public static BaseList<TElement> operator +(BaseList<TElement> list, TElement element)
        {
            if (ComparisonUtils.IsNull(list)) throw new NullReferenceException();
            if (list.Contains(element)) throw new DuplicateWaitObjectException();
            if (ComparisonUtils.NotNull(element))
                list.Add(element);
            return list;
        }
        #endregion

        #region operator -
        /// <summary>
        /// 重载的+运算符。
        /// </summary>
        /// <param name="list">列表集合。</param>
        /// <param name="element"><typeparamref name="TElement"/>类型的元素。</param>
        /// <returns>列表集合。</returns>
        /// <exception cref="NullReferenceException">
        /// 当列表元素<paramref name="list"/>为null值时抛出此异常。
        /// </exception>
        public static BaseList<TElement> operator -(BaseList<TElement> list, TElement element)
        {
            if (ComparisonUtils.IsNull(list)) throw new NullReferenceException();
            if (ComparisonUtils.NotNull(element) && list.Contains(element)) list.Remove(element);
            return list;
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