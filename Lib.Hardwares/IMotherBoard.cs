#region "IMotherBoard"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-28 9:55:22
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.HardwareInformation
 * 
 * ####     Type Name : IMotherBoard
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.HardwareInformation.IMotherBoard
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

using SourcefansStudio.FoundationFramework.Commons.Virtualizations;

namespace SourcefansStudio.FoundationFramework.Commons.HardwareInformation
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.HardwareInformation.IMotherBoard</para>
    /// <para>
    /// 主板信息接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IMotherBoard
    {
        #region SerialNumber
        /// <summary>
        /// 设置或获取主板序列号。
        /// </summary>
        ISerialNumber SerialNumber { get; set; }
        #endregion

        #region Manufacturer
        /// <summary>
        /// 设置或获取主板制造商信息。
        /// </summary>
        IManufacturer Manufacturer { get; set; }
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