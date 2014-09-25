#region "Manufacturer"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-25 16:02:43
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.Virtualizations
 * 
 * ####     Type Name : Manufacturer
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.Virtualizations.Manufacturer
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.Virtualizations.Manufacturer</para>
    /// <para>
    /// 制造商信息对象。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class Manufacturer : IManufacturer
    {
        private string _name;

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="Manufacturer" />对象实例。</para>
        /// </summary>
        public Manufacturer()
        {
        }

        #endregion

        #region Name
        /// <summary>
        /// 设置或获取制造商名称。
        /// </summary>
        public virtual string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
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