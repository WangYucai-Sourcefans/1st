#region "IRealization"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-12 10:41:28
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : IRealization
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.IRealization
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.IRealization</para>
    /// <para>
    /// 用于验证指定类型是否实现了某个接口。
    /// </para>
    /// </summary>
    /// <typeparam name="TInterface">接口类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IRealization<TInterface>
    {
        #region Class
        /// <summary>
        /// 设置或获取需要验证的类的类型。
        /// </summary>
        Type Class { get; set; }
        #endregion

        #region ImplementedInterface
        /// <summary>
        /// 验证指定类型是否实现了<typeparamref name="TInterface"/>类型的接口。
        /// </summary>
        /// <returns>true or false 。</returns>
        bool ImplementedInterface();
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