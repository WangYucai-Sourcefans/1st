#region "ILength"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-12 17:03:57
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Virtualizations
 * 
 * ####     Type Name : ILength
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Virtualizations.ILength
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

namespace SourcefansStudio.FoundationFramework.Commons.Virtualizations
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.Virtualizations.ILength</para>
    /// <para>
    /// 定义了与长度相关的接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface ILength
    {
        #region Value
        /// <summary>
        /// 设置或获取长度值。
        /// </summary>
        decimal Value { get; set; }
        #endregion

        #region Unit
        /// <summary>
        /// 设置或获取长度单位。
        /// </summary>
        LengthUnits Unit { get; set; }
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