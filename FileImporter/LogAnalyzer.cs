using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesImporter
{
    public class LogAnalyzer
    {
        public bool IsWorking = false;

        public int FilePassed { get; private set; }
        public long SizePassed { get; private set; }

        public long LineCount { get; private set; }
        public int WrongLines { get; private set; }
        public int Errors { get; private set; }

        public void Analyze(string log)
        {
            string[] arr = log.Split(new string[] { "[", "]" }, StringSplitOptions.RemoveEmptyEntries);

            switch (arr[0])
            {
                case ("INF"):
                    {
                        switch (arr[3])
                        {
                            case ("STARTED"):
                                IsWorking = true;
                                break;
                            case ("File passed"):
                                FilePassed++;
                                break;
                            case ("Line Count"):
                                LineCount += Int32.Parse(arr[4]);
                                break;
                            case ("Size"):
                                SizePassed += Int32.Parse(arr[4]) / 1024;
                                break;
                            case ("progress"):
                                {
                                    switch (arr[4])
                                    {
                                        case (" STOPPED"):
                                            IsWorking = false;
                                            break;
                                    }
                                    break;
                                }
                        }
                    }
                    break;

                case ("ERR"):
                    {
                        switch (arr[3])
                        {
                            case ("Wrong Line"):
                                WrongLines++;
                                break;
                            case ("File error"):
                                Errors++;
                                break;
                        }
                        break;
                    }
            }
            }
        
        public void SetDefultValue()
        {
            FilePassed = 0;
            FilePassed = 0;
            SizePassed = 0;
            LineCount = 0;
            WrongLines = 0;
            Errors = 0;
        }
    }
}
