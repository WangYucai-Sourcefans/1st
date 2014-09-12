#region "IBaseList"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-12 11:47:50
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Collections
 * 
 * ####     Type Name : IBaseList
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Collections.IBaseList
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.Collections.IBaseList</para>
    /// <para>
    /// 定义了基本的列表集合操作。
    /// </para>
    /// </summary>
    /// <typeparam name="TElement">集合元素类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IBaseList<TElement> : IList<TElement>, IBaseCollection
    {
        #region Foreach
        /// <summary>
        /// 用于美誉集合中的每个元素，并调用<paramref name="func"/>进行处理。
        /// </summary>
        /// <param name="func"><see cref="ElementFunc{TElement}"/>方法委托。</param>
        void Foreach(ElementFunc<TElement> func);
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