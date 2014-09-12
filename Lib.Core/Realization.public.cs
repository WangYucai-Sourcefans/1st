#region "Realization"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-12 10:58:38
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : Realization
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Realization
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.Realization</para>
    /// <para>
    /// 提供了验证指定类型是否实现指定接口的方法。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <typeparam name="TInterface">接口类型。</typeparam>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    /// <exception cref="ArgumentException">
    /// 当<typeparamref name="TInterface"/>不是接口是抛出此异常。
    /// </exception>
    public class Realization<TInterface> : IRealization<TInterface>
    {
        private Type _classType;

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="Realization{TInterface}" />对象实例。</para>
        /// </summary>
        public Realization()
        {
            if (!typeof(TInterface).IsInterface)
                throw new ArgumentException();
        }

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="Realization{TInterface}" />对象实例。</para>
        /// </summary>
        /// <param name="classType">类的类型。</param>
        public Realization(Type classType)
            : this()
        {
            this.Class = classType;
        }

        #endregion

        #region Class
        /// <summary>
        /// 设置或获取需要验证的类的类型。
        /// </summary>
        public virtual Type Class
        {
            get
            {
                return this._classType;
            }
            set
            {
                this._classType = value;
            }
        }
        #endregion

        #region ImplementedInterface
        /// <summary>
        /// 验证Class是否实现了<typeparamref name="TInterface"/>类型的接口。
        /// </summary>
        /// <returns>true or false 。</returns>
        /// <exception cref="NullReferenceException">
        /// 当Class为null值时抛出此异常。
        /// </exception>
        /// <exception cref="ArgumentException">
        /// 当Class代表的不是一个类时，抛出此异常。
        /// </exception>
        public virtual bool ImplementedInterface()
        {
            if (ComparisonUtils.IsNull(this.Class)) throw new NullReferenceException();
            if (!this.Class.IsClass) throw new ArgumentException();
            return this.ImplementedInterface(this.Class);
        }

        /// <summary>
        /// 验证Class是否实现了<typeparamref name="TInterface"/>类型的接口。
        /// </summary>
        /// <param name="classType">类型。</param>
        /// <returns>true or false 。</returns>
        protected virtual bool ImplementedInterface(Type classType)
        {
            Type[] types = classType.GetInterfaces();
            bool implemented = false;
            foreach (Type item in types)
            {
                implemented = item.Equals(typeof(TInterface));
                if (implemented) break;
            }
            if (ComparisonUtils.NotNull(classType.BaseType))
                implemented = ImplementedInterface(classType.BaseType);
            return implemented;
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