#region "IMotherBoardWMI"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-28 10:24:57
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons.HardwareInformation
 * 
 * ####     Type Name : IMotherBoardWMI
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.HardwareInformation.IMotherBoardWMI
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

namespace SourcefansStudio.FoundationFramework.Commons.HardwareInformation
{
    /// <summary>
    /// <para>SourcefansStudio.FoundationFramework.Commons.HardwareInformation.IMotherBoardWMI</para>
    /// <para>
    /// 使用WMI搜索主板信息。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IMotherBoardWMI : IWMI
    {
        #region GetMotherBoardInfo
        /// <summary>
        /// 获取主板信息。
        /// </summary>
        /// <returns>实现了<see cref="IMotherBoard"/>接口的对象实例。</returns>
        IMotherBoard GetMotherBoardInfo();
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