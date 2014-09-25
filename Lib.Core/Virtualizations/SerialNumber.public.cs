#region "SerialNumber"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-25 16:07:35
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Virtualizations
 * 
 * ####     Type Name : SerialNumber
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Virtualizations.SerialNumber
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.Virtualizations.SerialNumber</para>
    /// <para>
    /// 序列号对象。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class SerialNumber : ISerialNumber, IUniqueIdentity<string>
    {
        private string _sn;

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="SerialNumber" />对象实例。</para>
        /// </summary>
        public SerialNumber()
        {
        }

        #endregion

        #region IUniqueIdentity<string>.UniqueId
        /// <summary>
        /// 设置或获取序列号。
        /// </summary>
        string IUniqueIdentity<string>.UniqueId
        {
            get
            {
                return this.SN;
            }
            set
            {
                this.SN = value;
            }
        }
        #endregion

        #region IOnlyGetUniqueIdentity<string>.UniqueId
        /// <summary>
        /// 获取序列号。
        /// </summary>
        string IOnlyGetUniqueIdentity<string>.UniqueId
        {
            get { return this.SN; }
        }
        #endregion

        #region SN
        /// <summary>
        /// 设置或获取序列号。
        /// </summary>
        public virtual string SN
        {
            get
            {
                return this._sn;
            }
            set
            {
                this._sn = value;
            }
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