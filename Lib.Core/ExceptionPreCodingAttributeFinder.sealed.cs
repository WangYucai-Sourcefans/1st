#region "ExceptionPreCodingAttributeFinder"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-11 15:15:42
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : ExceptionPreCodingAttributeFinder
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.ExceptionPreCodingAttributeFinder
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.ExceptionPreCodingAttributeFinder</para>
    /// <para>
    /// 在异常类型中搜索<see cref="ExceptionPreCodingAttribute"/>。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    public sealed class ExceptionPreCodingAttributeFinder :
        TypeCustomAttributeFinder<ExceptionPreCodingAttribute>, ICustomAttributeFinder<Type, ExceptionPreCodingAttribute>
    {
        private Generalization<Exception> _generalization;

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ExceptionPreCodingAttributeFinder" />对象实例。</para>
        /// </summary>
        /// <param name="exceptionType">
        /// 当<paramref name="exceptionType"/>未继承自<see cref="Exception"/>时，抛出此异常。
        /// </param>
        public ExceptionPreCodingAttributeFinder(Type exceptionType)
            : base(exceptionType)
        {
            _generalization = new Generalization<Exception>(){SubClass = exceptionType};
            if (!_generalization.InheritsFrom()) throw new ArgumentException();
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