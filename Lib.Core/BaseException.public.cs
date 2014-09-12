#region "BaseException"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-11 13:44:24
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : BaseException
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.BaseException
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.BaseException</para>
    /// <para>
    /// 定义了异常基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable, ExceptionPreCoding(10000)]
    public class BaseException : Exception, IExceptionPreCoding, IPreCoding<int>
    {
        private ExceptionPreCodingAttributeFinder _baseAttributeFinder;

        #region BaseAttributeFinder
        /// <summary>
        /// 设置或获取<see cref="ExceptionPreCodingAttributeFinder"/>对象实例。
        /// </summary>
        protected ExceptionPreCodingAttributeFinder BaseAttributeFinder
        {
            get { return _baseAttributeFinder; }
            set { _baseAttributeFinder = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="BaseException" />对象实例。</para>
        /// </summary>
        public BaseException()
            : base()
        {
            this.BaseAttributeFinder = new ExceptionPreCodingAttributeFinder(this.GetType());
        }

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="BaseException" />对象实例。</para>
        /// </summary>
        /// <param name="message">异常信息。</param>
        /// <param name="innerException">引发此次异常的<see cref="Exception"/>对象实例。</param>
        public BaseException(string message, Exception innerException)
            : base(message, innerException)
        {
            this.BaseAttributeFinder = new ExceptionPreCodingAttributeFinder(this.GetType());
        }

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="BaseException" />对象实例。</para>
        /// </summary>
        /// <param name="message">异常信息。</param>
        public BaseException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="BaseException" />对象实例。</para>
        /// </summary>
        /// <param name="innerException">引发此次异常的<see cref="Exception"/>对象实例。</param>
        public BaseException(Exception innerException)
            : this(string.Empty, innerException)
        {
        }

        #endregion

        #region IPreCoding<int> Members

        #region IPreCoding<int>.Code
        /// <summary>
        /// 获取预定义的异常代码。
        /// </summary>
        int IPreCoding<int>.Code
        {
            get { return this.GetExceptionPreCode(); }
        }
        #endregion

        #region IPreCoding<int>.GetCode
        /// <summary>
        /// 获取预定义的异常代码。
        /// </summary>
        /// <returns>异常代码。</returns>
        int IPreCoding<int>.GetCode()
        {
            return this.GetExceptionPreCode();
        }
        #endregion

        #endregion

        #region GetExceptionPreCode
        /// <summary>
        /// 获取异常的预定义代码。
        /// </summary>
        /// <returns>异常预定义代码。</returns>
        public virtual int GetExceptionPreCode()
        {
            ExceptionPreCodingAttribute attr = this.BaseAttributeFinder.GetCustomAttribute();
            return ComparisonUtils.IsNull(attr) ? 0 : attr.PreCode;
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