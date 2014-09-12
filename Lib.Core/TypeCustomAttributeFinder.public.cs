#region "TypeCustomAttributeFinder"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-11 15:05:10
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : TypeCustomAttributeFinder
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.TypeCustomAttributeFinder
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.TypeCustomAttributeFinder</para>
    /// <para>
    /// 提供了搜索<see cref="Type"/>中的<see cref="Attribute"/>的方法。
    /// </para>
    /// </summary>
    /// <typeparam name="TAttribute"><see cref="Attribute"/>类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public class TypeCustomAttributeFinder<TAttribute> : BaseCustomAttributeFinder<Type, TAttribute>, ICustomAttributeFinder<Type, TAttribute>
        where TAttribute : Attribute
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="TypeCustomAttributeFinder{TAttribute}" />对象实例。</para>
        /// </summary>
        /// <param name="type">需要搜索的<see cref="Type"/>。</param>
        public TypeCustomAttributeFinder(Type type)
            : base(type)
        {
        }

        #endregion

        #region GetCustomAttribute
        /// <summary>
        /// 获取<typeparamref name="TAttribute"/>类型的<see cref="Attribute"/>对象实例。
        /// </summary>
        /// <returns><typeparamref name="TAttribute"/>类型的<see cref="Attribute"/>对象实例。</returns>
        public override TAttribute GetCustomAttribute()
        {
            Attribute attr = Attribute.GetCustomAttribute(base.BaseTarget, typeof(TAttribute));
            return ComparisonUtils.IsNull(attr) ? null : CastUtils<TAttribute>.CastTo(attr);
        }
        #endregion

        #region GetCustomAttributes
        /// <summary>
        /// 获取<typeparamref name="TAttribute"/>类型的<see cref="Attribute"/>对象实例数组。
        /// </summary>
        /// <returns><typeparamref name="TAttribute"/>类型的<see cref="Attribute"/>对象实例数组。</returns>
        public override TAttribute[] GetCustomAttributes()
        {
            Attribute[] attrArray = Attribute.GetCustomAttributes(base.BaseTarget, typeof(TAttribute));
            return ComparisonUtils.IsNull(attrArray) || ComparisonUtils.IsZero(attrArray.Length)
                ? null
                : CastUtils<TAttribute[]>.CastTo(attrArray);
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