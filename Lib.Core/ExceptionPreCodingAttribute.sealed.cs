#region "ExceptionPreCodingAttribute"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-09 16:54:14
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : ExceptionPreCodingAttribute
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.ExceptionPreCodingAttribute
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.ExceptionPreCodingAttribute</para>
    /// <para>
    /// 标记预定义的异常代码<see cref="Attribute"/>。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false), Serializable]
    public sealed class ExceptionPreCodingAttribute : Attribute
    {
        private int _preCode;

        #region PreCode
        /// <summary>
        /// 获取预定义的异常代码。
        /// </summary>
        public int PreCode
        {
            get { return _preCode; }
            private set { _preCode = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ExceptionPreCodingAttribute" />对象实例。</para>
        /// </summary>
        /// <param name="exceptionPreCode">预定义的异常代码。</param>
        public ExceptionPreCodingAttribute(int exceptionPreCode)
        {
            this.PreCode = exceptionPreCode;
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