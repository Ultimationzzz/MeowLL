using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeowLL.Helpers;

namespace MeowLL.LiveLink
{
    public class MsgBasicRole
    {
        public byte Version { get; set; } = 6;
        public string DeviceId { get; set; } = "Webcam";
        public string SubjectId { get; set; } = "BasicRole";
        public int Frame { get; set; } = 0;
        public int SubFrame { get; set; } = 0;
        public int Fps { get; set; } = 60;
        public int Denominator { get; set; } = 0;
        public float[] BlendShapes { get; set; } = new float[61];

        public void Set(GenericShape shape, float value)
        {
            BlendShapes[(int)shape] = value;
        }
        public byte[] Build()
        {
            using (var strm = new MemoryStream())
            {
                using (var wtr = new BinaryWriter(strm))
                {
                    wtr.Write((byte)Version);
                    wtr.WriteInt32BE(DeviceId.Length);
                    wtr.Write(Encoding.ASCII.GetBytes(DeviceId));

                    wtr.WriteInt32BE(SubjectId.Length);
                    wtr.Write(Encoding.ASCII.GetBytes(SubjectId));

                    wtr.WriteInt32BE(Frame);
                    wtr.WriteInt32BE(SubFrame);
                    wtr.WriteInt32BE(Fps);
                    wtr.WriteInt32BE(Denominator);
                    wtr.Write((byte)BlendShapes.Length); //always 61
                    for (int i = 0; i < BlendShapes.Length; i++)
                    {
                        wtr.WriteSingleBE(BlendShapes[i]);
                    }

                    return strm.ToArray();
                }
            }
        }
    }
}
