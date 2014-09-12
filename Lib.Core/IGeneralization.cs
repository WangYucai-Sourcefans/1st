#region "IGeneralization"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-11 15:20:57
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : IGeneralization
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.IGeneralization
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.IGeneralization</para>
    /// <para>
    /// 验证继承关系的接口。
    /// </para>
    /// </summary>
    /// <typeparam name="TBase">父类类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IGeneralization<TBase>
        where TBase : class
    {
        #region SubClass
        /// <summary>
        /// 设置或获取派生类类型。
        /// </summary>
        Type SubClass { set; get; }
        #endregion

        #region InheritsFrom
        /// <summary>
        /// 验证SubClass是否继承自<typeparamref name="TBase"/>。
        /// </summary>
        /// <returns>true or false 。</returns>
        bool InheritsFrom();
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