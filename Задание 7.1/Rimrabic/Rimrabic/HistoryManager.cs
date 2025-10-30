using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rimrabic
{
    public static class HistoryManager
    {
        public static void ExportHistoryToFile(List<string> history, string filePath)
        {
            File.WriteAllLines(filePath, history);
        }
    }
}
