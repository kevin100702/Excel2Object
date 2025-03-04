using System;
using System.IO;

namespace Chsword.Excel2Object.Tests
{
    public class BaseExcelTest
    {
        protected string GetFilePath(string file)
        {
            return Path.Combine(Environment.CurrentDirectory, file);
        }

        protected string GetLocalFilePath(string file)
        {
            return Path.Combine(Environment.CurrentDirectory, "ExcelDir", file);
        }
    }
}