using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSix
{
    public interface IFileAggregator
    {
        string IsContent(string directory);

        void WriteToFile(string content, string directory);

        string ReadText(string directory);
    }
}