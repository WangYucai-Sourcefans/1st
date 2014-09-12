#region "Generalization"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-11 15:26:09
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : Generalization
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Generalization
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.Generalization</para>
    /// <para>
    /// 提供了验证继承关系的基类。
    /// </para>
    /// </summary>
    /// <typeparam name="TBase">父类类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public class Generalization<TBase> : IGeneralization<TBase>
        where TBase : class
    {
        private Type _subClassType;

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="Generalization{TBase}" />对象实例。</para>
        /// </summary>
        public Generalization()
        {
        }

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="Generalization{TBase}" />对象实例。</para>
        /// </summary>
        /// <param name="subType">子类类型。</param>
        public Generalization(Type subType)
        {
            this.SubClass = subType;
        }

        #endregion

        #region SubClass
        /// <summary>
        /// 设置或获取子类类型。
        /// </summary>
        public virtual Type SubClass
        {
            get
            {
                return _subClassType;
            }
            set
            {
                _subClassType = value;
            }
        }
        #endregion

        #region InheritsFrom
        /// <summary>
        /// 验证SubClass是否继承自<typeparamref name="TBase"/>。
        /// </summary>
        /// <returns>true or false 。</returns>
        /// <exception cref="NullReferenceException">
        /// 当SubClass为null值时，抛出此异常。
        /// </exception>
        public virtual bool InheritsFrom()
        {
            if (ComparisonUtils.IsNull(this.SubClass)) throw new NullReferenceException();
            if (this.SubClass.Equals(typeof(TBase)))
            {
                return true;
            }
            else
            {
                return this.InheritsFrom(this.SubClass.BaseType);
            }
        }

        /// <summary>
        /// 验证SubClass是否继承自<paramref name="baseType"/>
        /// </summary>
        /// <param name="baseType">基类类型。</param>
        /// <returns>true or false 。</returns>
        protected virtual bool InheritsFrom(Type baseType)
        {
            if (ComparisonUtils.NotNull(baseType))
            {
                if (baseType.Equals(typeof(TBase)))
                {
                    return true;
                }
                else
                {
                    return this.InheritsFrom(baseType.BaseType);
                }
            }
            else return false;
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