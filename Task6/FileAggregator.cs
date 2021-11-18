using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSix
{
    public class FileAggregator : IFileAggregator
    {
        public const string ErrorFile = "errors.txt";

        //public string IsContent(string directory)
        //{
        //    try
        //    {
        //        var file = ReadText(directory);

        //        if (!string.IsNullOrEmpty(file))
        //        {
        //            return "taip";
        //        }
        //        else
        //        {
        //            return "ne";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        WriteToFile(ex.Message, ErrorFile);

        //        return string.Empty;
        //    }
        //}

        public string IsContent(string directory)
        {
            return WrapWithExceptionHandler(() =>
            {
                var file = ReadText(directory);

                if (!string.IsNullOrEmpty(file))
                {
                    return "taip";
                }
                else
                {
                    return "ne";
                }
            });
        }

        public async void WriteToFile(string newContent, string directory)
        {
            var oldContent = ReadText(directory);

            string[] lines =
            {
                oldContent,
                newContent
            };

            await File.WriteAllLinesAsync(directory, lines);
        }

        //public string ReadText(string directory)
        //{
        //    try
        //    {
        //        var file = File.ReadAllText(directory);

        //        return file;
        //    }
        //    catch (Exception ex)
        //    {
        //        WriteToFile(ex.Message, ErrorFile);

        //        return string.Empty;
        //    }
        //}

        public string ReadText(string directory)
        {
            return WrapWithExceptionHandler(() =>
            {
                var file = File.ReadAllText(directory);

                return file;
            });
        }

        public string WrapWithExceptionHandler(Func<string> func)
        {
            try
            {
                return func();
            }
            catch (Exception ex)
            {
                WriteToFile(ex.Message, ErrorFile);

                return string.Empty;
            }
        }
    }
}
