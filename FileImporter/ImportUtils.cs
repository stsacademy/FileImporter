using SharpCompress.Reader;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FilesImporter
{
    public class ImportUtils
    {
        public static List<string> ReadFile(string filePath, int skipLines, int linesToRead)
        {
            List<string> list = new List<string>();

            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                StreamReader reader = new StreamReader(stream);

                for (int i = 0; i < skipLines; i++)
                    reader.ReadLine();

                while (!reader.EndOfStream && list.Count < linesToRead)
                    list.Add(reader.ReadLine());
            }
            return list;
        }

        public static IFormatProvider[] GetProviders(Type[] types, string decimalSeparator, DateTimeFormatInfo dateTime)
        {
            IFormatProvider[] providers = new IFormatProvider[types.Length];

            for (int i = 0; i < providers.Length; i++)
            {
                if (types[i] == typeof(double) || types[i] == typeof(float))
                {
                    providers[i] = new NumberFormatInfo();
                    ((NumberFormatInfo)providers[i]).NumberDecimalSeparator = decimalSeparator;
                }
                else if (types[i] == typeof(DateTime))
                {
                    providers[i] = new DateTimeFormatInfo();
                    providers[i] = dateTime;
                }
                else
                    providers[i] = CultureInfo.CurrentCulture;
            }

            return providers;
        }

        public static Type GetType(string types)
        {
            switch (types)
            {
                case "System.Boolean":
                    return typeof(bool);
                    break;
                case "System.Byte":
                    return typeof(byte);
                    break;
                case "System.SByte":
                    return typeof(sbyte);
                    break;
                case "System.Char":
                    return typeof(char);
                    break;
                case "System.Decimal":
                    return typeof(decimal);
                    break;
                case "System.Double":
                    return typeof(double);
                    break;
                case "System.Single":
                    return typeof(float);
                    break;
                case "System.Int32":
                    return typeof(int);
                    break;
                case "System.UInt32":
                    return typeof(uint);
                    break;
                case "System.Int64":
                    return typeof(long);
                    break;
                case "System.UInt64":
                    return typeof(ulong);
                    break;
                case "System.Int16":
                    return typeof(short);
                    break;
                case "System.UInt16":
                    return typeof(ushort);
                    break;
                case "System.String":
                    return typeof(string);
                    break;
                case "DateTime":
                    return typeof(DateTime);
                    break;
                default:
                    throw new NotSupportedException();
                    break;
            }
        }
    }
}

