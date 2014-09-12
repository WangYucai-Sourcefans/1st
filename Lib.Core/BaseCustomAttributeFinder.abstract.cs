#region "BaseCustomAttributeFinder"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-11 14:21:55
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : BaseCustomAttributeFinder
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.BaseCustomAttributeFinder
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.BaseCustomAttributeFinder</para>
    /// <para>
    /// 定义了基本的获取<see cref="Attribute"/>的方法。
    /// </para>
    /// </summary>
    /// <typeparam name="TTarget">需要搜索的目标类型。</typeparam>
    /// <typeparam name="TAttribute">需要搜索的<see cref="Attribute"/>类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public abstract class BaseCustomAttributeFinder<TTarget, TAttribute> : ICustomAttributeFinder<TTarget, TAttribute>
        where TAttribute : Attribute
    {
        private TTarget _baseTarget;

        #region BaseTarget
        /// <summary>
        /// 设置或获取<typeparamref name="TTarget"/>类型的对象实例。
        /// </summary>
        protected virtual TTarget BaseTarget
        {
            get { return _baseTarget; }
            set { _baseTarget = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="BaseCustomAttributeFinder{TTarget, TAttribute}" />对象实例。</para>
        /// </summary>
        /// <param name="targetObj"><typeparamref name="TTarget"/>类型的对象实例。</param>
        protected BaseCustomAttributeFinder(TTarget targetObj)
        {
            this.BaseTarget = targetObj;
        }

        #endregion

        #region GetCustomAttribute
        /// <summary>
        /// 获取<typeparamref name="TAttribute"/>类型的<see cref="Attribute"/>对象实例。
        /// </summary>
        /// <returns><typeparamref name="TAttribute"/>类型的<see cref="Attribute"/>对象实例。</returns>
        public abstract TAttribute GetCustomAttribute();
        #endregion

        #region GetCustomAttributes
        /// <summary>
        /// 获取<typeparamref name="TAttribute"/>类型的<see cref="Attribute"/>对象实例数组。
        /// </summary>
        /// <returns><typeparamref name="TAttribute"/>类型的<see cref="Attribute"/>对象实例数组。</returns>
        public abstract TAttribute[] GetCustomAttributes();
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