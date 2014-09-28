#region "MotherBoard"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-28 10:09:06
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.HardwareInformation
 * 
 * ####     Type Name : MotherBoard
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.HardwareInformation.MotherBoard
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
using SourcefansStudio.FoundationFramework.Commons.Virtualizations;

namespace SourcefansStudio.FoundationFramework.Commons.HardwareInformation
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.HardwareInformation.MotherBoard</para>
    /// <para>
    /// 主板信息对象。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class MotherBoard : IMotherBoard
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="MotherBoard" />对象实例。</para>
        /// </summary>
        public MotherBoard()
        {
        }

        #endregion

        #region SerialNumber
        private SerialNumber _sn;
        /// <summary>
        /// 设置或获取主板序列号信息。
        /// </summary>
        public virtual ISerialNumber SerialNumber
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

        #region Manufacturer
        private Manufacturer _manufacturer;
        /// <summary>
        /// 设置或获取制造商信息。
        /// </summary>
        public virtual IManufacturer Manufacturer
        {
            get
            {
                return this._manufacturer;
            }
            set
            {
                this._manufacturer = value;
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