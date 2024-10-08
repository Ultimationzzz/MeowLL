using System;
using System.IO;
using System.Linq;
using System.Text;

namespace MeowLL.Helpers
{

    
    public static class Extensions
    {
      
        public static UInt32 ReadUInt32BE(this BinaryReader binRdr)
        {
            return BitConverter.ToUInt32(binRdr.ReadBytes(4).Reverse().ToArray(), 0);
        }
        public static UInt64 ReadUInt64BE(this BinaryReader binRdr)
        {
            return BitConverter.ToUInt64(binRdr.ReadBytes(sizeof(UInt64)).Reverse().ToArray(), 0);
        }
        public static Int32 ReadInt32BE(this BinaryReader binRdr)
        {
            return BitConverter.ToInt32(binRdr.ReadBytes(sizeof(Int32)).Reverse().ToArray(), 0);
        }
        public static float ReadSingleBE(this BinaryReader binRdr)
        {
            return BitConverter.ToSingle(binRdr.ReadBytes(sizeof(float)).Reverse().ToArray(), 0);
        }
        public static string ReadOSCString(this BinaryReader rdr)
        {
            string res = "";
            byte[] temp = null;
            while (true)
            {
                temp = rdr.ReadBytes(4);
                res += Encoding.UTF8.GetString(temp);

                if (temp[3] == 0) break;

            }

            return res.TrimEnd('\0');
        }


        public static void WriteInt32BE(this BinaryWriter wtr, int value)
        {
            wtr.Write(BitConverter.GetBytes(value).Reverse().ToArray());
        }
        public static void WriteUInt32BE(this BinaryWriter wtr,uint value)
        {
            wtr.Write(BitConverter.GetBytes(value).Reverse().ToArray());
        }
        public static void WriteUInt64BE(this BinaryWriter wtr, ulong value)
        {
            wtr.Write(BitConverter.GetBytes(value).Reverse().ToArray());
        }
        public static void WriteSingleBE(this BinaryWriter wtr, float value)
        {
            wtr.Write(BitConverter.GetBytes(value).Reverse().ToArray());
        }
        
    }
}

