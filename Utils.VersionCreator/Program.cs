using System;
using System.IO;
using SourcefansStudio.FoundationFramework.Commons;

namespace MasterDuner.ToolkitsGallery.VersionCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            InitBackgroundColor();
            InitForegroundColor();

            if (HasStarupArgs(args))
            {
                OutputByStartupArgs(args);
            }
            else
            {
                OutputReadme();
                string cmd = Console.ReadLine();
                GetBuildAndRevision(cmd.Split(' ')[1], cmd.Split(' ')[2]);
            }

            Console.ReadLine();
        }

        #region InitBackgroundColor
        /// <summary>
        /// 初始化控制台背景色。
        /// </summary>
        static private void InitBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        #endregion

        #region InitForegroundColor
        /// <summary>
        /// 初始化前景色。
        /// </summary>
        static private void InitForegroundColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        #region HasStarupArgs
        /// <summary>
        /// 验证是否有启动参数。
        /// </summary>
        /// <param name="args">启动参数数组。</param>
        /// <returns>true/false。</returns>
        static private bool HasStarupArgs(string[] args)
        {
            if (ComparisonUtils.NotNull(args) && args.Length >= 3 && args[0].Equals("/c"))
            {
                return true;
            }
            return false;
        }
        #endregion

        #region GetBuildAndRevision
        /// <summary>
        /// 获取Build和Revision数字。
        /// </summary>
        /// <param name="build">内部版本号。</param>
        /// <param name="revision">修正版本号。</param>
        static private void GetBuildAndRevision(out int build, out int revision)
        {
            DateTime _20000101 = new DateTime(2000, 1, 1, 0, 0, 0);
            DateTime now = DateTime.Now;
            DateTime today = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            build = (now - _20000101).Days;
            revision = CastUtils<int>.CastTo((int)((now - today).TotalSeconds) / 2);
        }

        /// <summary>
        /// 获取Build和Revision数字。
        /// </summary>
        /// <param name="major">主版本号。</param>
        /// <param name="minor">次版本号。</param>
        static private void GetBuildAndRevision(string major, string minor)
        {
            DateTime _20000101 = new DateTime(2000, 1, 1, 0, 0, 0);
            DateTime now = DateTime.Now;
            DateTime today = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            int build = (now - _20000101).Days;
            int revision = CastUtils<int>.CastTo((int)((now - today).TotalSeconds) / 2);
            Console.WriteLine("Your version : {0}.{1}.{2}.{3}",
                StringParser.ParseTo<int>(major),
                StringParser.ParseTo<int>(minor),
                build,
                revision
                );
        }
        #endregion

        #region OutputByStartupArgs
        /// <summary>
        /// 使用启动参数创建并输出。
        /// </summary>
        /// <param name="args">启动参数数组。</param>
        static private void OutputByStartupArgs(string[] args)
        {
            int major = StringParser.ParseTo<int>(args[1]);
            int minor = StringParser.ParseTo<int>(args[2]);
            int build = 0;
            int revision = 0;
            GetBuildAndRevision(out build, out revision);
            Console.WriteLine("Your version : {0}.{1}.{2}.{3}", major, minor, build, revision);
        }
        #endregion

        #region OutputReadme
        /// <summary>
        /// 输出README内容。
        /// </summary>
        static private void OutputReadme()
        {
            using (Stream stream = typeof(Program).Assembly.GetManifestResourceStream("MasterDuner.ToolkitsGallery.VersionCreator.README"))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    try
                    {
                        string text = reader.ReadLine();
                        while (!ComparisonUtils.IsNullOrWhitespace(text))
                        {
                            Console.WriteLine(text);
                            text = reader.ReadLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        reader.Close();
                        stream.Close();
                    }
                }
            }
        }
        #endregion
    }
}
