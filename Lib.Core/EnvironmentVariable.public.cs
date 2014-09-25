#region "EnvironmentVariable"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-25 16:43:21
 * 
 * ####     Namespace : SourcefansStudio.FoundationFramework.Commons
 * 
 * ####     Type Name : EnvironmentVariable
 * 
 * ####     Full Name : SourcefansStudio.FoundationFramework.Commons.EnvironmentVariable
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
    /// <para>SourcefansStudio.FoundationFramework.Commons.EnvironmentVariable</para>
    /// <para>
    /// 环境变量信息实体。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class EnvironmentVariable : BaseKeyValuePair<string, string>, IEnvironmentVariable, IKeyValuePair<string, string>
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="EnvironmentVariable" />对象实例。</para>
        /// </summary>
        public EnvironmentVariable()
            : base()
        {
        }

        #endregion

        #region Name
        /// <summary>
        /// 设置或获取环境变量名称。
        /// </summary>
        public virtual string Name
        {
            get
            {
                return base.Key;
            }
            set
            {
                base.Key = value;
            }
        }
        #endregion

        #region Create
        /// <summary>
        /// 创建此环境变量。
        /// </summary>
        /// <param name="target"><see cref="EnvironmentVariableTarget"/>中的一个值。</param>
        /// <exception cref="NullReferenceException">
        /// <para>当环境变量名称为null、String.Empty、或空白符时，抛出此异常。</para>
        /// <para>当环境变量值为null时，抛出此异常。</para>
        /// </exception>
        public virtual void Create(EnvironmentVariableTarget target = EnvironmentVariableTarget.Machine)
        {
            if (ComparisonUtils.IsNull(base.Value) || ComparisonUtils.IsNullOrWhitespace(this.Name))
                throw new NullReferenceException();
            try
            {
                Environment.SetEnvironmentVariable(this.Name, base.Value, target);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Get
        /// <summary>
        /// 获取指定名称的环境变量。
        /// </summary>
        /// <param name="name">环境变量名称。</param>
        /// <param name="target">
        /// <see cref="EnvironmentVariableTarget"/>中的一个值。
        /// <para>默认为<see cref="EnvironmentVariableTarget"/>.Machine。</para>
        /// </param>
        /// <returns>实现了<see cref="IEnvironmentVariable"/>接口的对象实例。</returns>
        static public IEnvironmentVariable Get(string name, EnvironmentVariableTarget target = EnvironmentVariableTarget.Machine)
        {
            string value = Environment.GetEnvironmentVariable(name, target);
            return new EnvironmentVariable() { Name = name, Value = value };
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