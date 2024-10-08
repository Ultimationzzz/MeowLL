using System.Collections.Generic;

namespace MeowLL.MeowFace
{
    public class MeowBlendShape
    {
        public string K { get; set; }
        public float V { get; set; }
    }

    

    public class MeowVector
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }

   

    public class MeowData
    {
        public long Timestamp { get; set; }
        public int Hotkey { get; set; }
        public bool FaceFound { get; set; }
        public MeowVector Rotation { get; set; }
        public MeowVector Position { get; set; }
        public MeowVector VNyanPos { get; set; }
        public MeowVector EyeLeft { get; set; }
        public MeowVector EyeRight { get; set; }
        public List<MeowBlendShape> BlendShapes { get; set; }
    }

}
