using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using MeowLL.Helpers;
using MeowLL.LiveLink;
using Newtonsoft.Json;

namespace MeowLL.MeowFace
{
    public class MeowPipe
    {
        public string ListenIp { get; set; } = "127.0.0.1";
        public int ListenPort { get; set; } = 49983;
        public string SendIp { get; set; } = "127.0.0.1";
        public int SendPort { get; set; } = 11111;
        public string PhoneIp { get; set; } = "127.0.0.1";
        public bool Active { get; set; } = false;

        public bool TrackExpression { get; set; } = true;
        public bool TrackRotation { get; set; } = true;

        private byte[] _recvBuffer = new byte[4096];
        private IPEndPoint _recvPoint;
        private IPEndPoint _sendPoint;
        private Socket _recvSocket;
        private Socket _sendSocket;
        private const float RadianConst = 0.0174533f;
        private readonly Dictionary<string, GenericShape> _map = new Dictionary<string, GenericShape>()
        {
            { "jawOpen", GenericShape.JawOpen },
            { "eyeLookOut_R", GenericShape.EyeLookOutRight },
            { "eyeLookOut_L", GenericShape.EyeLookOutLeft },
            { "eyeLookDown_R", GenericShape.EyeLookDownRight },
            { "eyeLookDown_L", GenericShape.EyeLookDownLeft },
            { "noseSneer_L", GenericShape.NoseSneerLeft },
            { "noseSneer_R", GenericShape.NoseSneerRight },
            { "mouthLeft", GenericShape.MouthLeft },
            { "mouthRight", GenericShape.MouthRight },
            { "eyeLookUp_L", GenericShape.EyeLookUpLeft },
            { "eyeLookUp_R", GenericShape.EyeLookUpRight },
            { "mouthRollLower", GenericShape.MouthRollLower },
            { "mouthRollUpper", GenericShape.MouthRollUpper },
            { "cheekPuff", GenericShape.CheekPuff },
            { "browOuterUp_R", GenericShape.BrowOuterUpRight },
            { "browOuterUp_L", GenericShape.BrowOuterUpLeft },
            { "eyeLookIn_R", GenericShape.EyeLookInRight },
            { "eyeLookIn_L", GenericShape.EyeLookInLeft },
            { "mouthUpperUp_L", GenericShape.MouthUpperUpLeft },
            { "mouthUpperUp_R", GenericShape.MouthUpperUpRight },
            { "browInnerUp", GenericShape.BrowInnerUp },
            { "headRollRight", GenericShape.HeadRoll },
            { "jawLeft", GenericShape.JawLeft },
            { "jawRight", GenericShape.JawRight },
            { "browDown_R", GenericShape.BrowDownRight },
            { "browDown_L", GenericShape.BrowDownLeft },
            { "eyeWide_R", GenericShape.EyeWideRight },
            { "eyeWide_L", GenericShape.EyeWideLeft },
            { "mouthShrugUpper", GenericShape.MouthShrugUpper },
            { "mouthShrugLower", GenericShape.MouthShrugLower },
            { "tongueOut", GenericShape.TongueOut },
            { "eyeSquint_L", GenericShape.EyeSquintLeft },
            { "eyeSquint_R", GenericShape.EyeSquintRight },
            { "mouthLowerDown_R", GenericShape.MouthLowerDownRight },
            { "mouthLowerDown_L", GenericShape.MouthLowerDownLeft },
            { "mouthFrown_L", GenericShape.MouthFrownLeft },
            { "mouthFrown_R", GenericShape.MouthFrownRight },
            { "mouthSmile_R", GenericShape.MouthSmileRight },
            { "mouthSmile_L", GenericShape.MouthSmileLeft },
            { "eyeBlink_L", GenericShape.EyeBlinkLeft },
            { "eyeBlink_R", GenericShape.EyeBlinkRight },
            { "mouthPucker", GenericShape.MouthPucker },
            { "mouthFunnel", GenericShape.MouthFunnel }
        };

        public void SendConnect()
        {
            var s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint target = new IPEndPoint(IPAddress.Parse(PhoneIp), ListenPort);
            var data = Encoding.UTF8.GetBytes("iFacialMocap_sahuasouryya9218sauhuiayeta91555dy3719|sendDataVersion=v2");
            s.SendTo(data, 0, data.Length, SocketFlags.None, target);
            s.Dispose();
        }

        public void Start()
        {
            End();
            _recvPoint = new IPEndPoint(IPAddress.Parse(ListenIp), ListenPort);
            _recvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _recvSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.ReuseAddress, true);
            _recvSocket.Bind(_recvPoint);

            _sendPoint = new IPEndPoint(IPAddress.Parse(SendIp), SendPort);
            _sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            Active = true;
            try
            {
                SendConnect();
            }
            catch (Exception)
            {
                //Just in case user uses localhost as phone ip
            }
            BeginReceive();
          
        }

        void BeginReceive()
        {
            try
            {
                if (_recvSocket != null)
                {
                    var ep = (EndPoint)_recvPoint;
                    _recvSocket.BeginReceiveFrom(_recvBuffer, 0, _recvBuffer.Length, SocketFlags.None, ref ep, EndReceive, ep);
                }
            }
            catch (Exception)
            {
                //ignore
            }
        }

        void HandleMsg(byte[] msg)
        {
            Dictionary<GenericShape, float> _shapes = [];
            var llMsg = new MsgBasicRole();
            var data = Encoding.UTF8.GetString(msg, 0, msg.Length);
            if (data.StartsWith("{"))
            {
                var json = JsonConvert.DeserializeObject<MeowData>(data);
                //Json msg
                if (TrackRotation)
                {
                    llMsg.Set(GenericShape.HeadYaw, json.Rotation.X * RadianConst);
                    llMsg.Set(GenericShape.HeadPitch, -json.Rotation.Y * RadianConst);
                    llMsg.Set(GenericShape.HeadRoll, json.Rotation.Z * RadianConst);

                    //RightEye
                    llMsg.Set(GenericShape.RightEyePitch, json.EyeRight.X * RadianConst);
                    llMsg.Set(GenericShape.RightEyeYaw, -json.EyeRight.Y * RadianConst);
                    llMsg.Set(GenericShape.RightEyeRoll, json.EyeRight.Z * RadianConst);

                    //LeftEye
                    llMsg.Set(GenericShape.LeftEyePitch, json.EyeLeft.X * RadianConst);
                    llMsg.Set(GenericShape.LeftEyeYaw, -json.EyeLeft.Y * RadianConst);
                    llMsg.Set(GenericShape.LeftEyeRoll, json.EyeLeft.Z * RadianConst);
                }

                if (TrackExpression)
                {
                    foreach (var s in json.BlendShapes)
                    {
                        if (_map.TryGetValue(s.K, out var val))
                        {
                            llMsg.Set(val, s.V);
                        }
                    }
                }
               
            }
            else
            {
                //this is not elegant and probably a better way
                var datas = data.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var d in datas)
                {

                    if (d.Contains("#"))
                    {
                        var subData = d.Split(new char[] { '#', ',' });
                        if (TrackRotation)
                        {
                            switch (subData[0].Replace("=", ""))
                            {
                                case "head":
                                {
                                    llMsg.Set(GenericShape.HeadPitch, -float.Parse(subData[1]) * RadianConst);
                                    llMsg.Set(GenericShape.HeadYaw, float.Parse(subData[2]) * RadianConst);
                                    llMsg.Set(GenericShape.HeadRoll, float.Parse(subData[3]) * RadianConst);
                                    break;
                                }
                                case "rightEye":
                                {
                                    //Data has wrong axis..
                                    llMsg.Set(GenericShape.RightEyePitch, float.Parse(subData[1]) * RadianConst);
                                    llMsg.Set(GenericShape.RightEyeYaw, -float.Parse(subData[2]) * RadianConst);
                                    llMsg.Set(GenericShape.RightEyeRoll, float.Parse(subData[3]) * RadianConst);
                                    break;
                                }
                                case "leftEye":
                                {
                                    llMsg.Set(GenericShape.LeftEyePitch, float.Parse(subData[1]) * RadianConst);
                                    llMsg.Set(GenericShape.LeftEyeYaw, -float.Parse(subData[2]) * RadianConst);
                                    llMsg.Set(GenericShape.LeftEyeRoll, float.Parse(subData[3]) * RadianConst);
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (TrackExpression)
                        {
                            var subData = d.Replace(" ", "")
                                .Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
                            if (_map.TryGetValue(subData[0], out var shape))
                            {
                                llMsg.Set(shape, float.Parse(subData[1]) / 100.0f);
                            }
                        }
                    }
                }
                Send(llMsg);
            }
        }

        void Send(MsgBasicRole msg)
        {
            if (_sendSocket != null)
            {
                _sendSocket.SendTo(msg.Build(), SocketFlags.None, _sendPoint);
            }
        }
        void EndReceive(IAsyncResult ar)
        {
            try
            {
                if (ar.IsCompleted)
                {
                    var ep = (EndPoint)ar.AsyncState;
                    if (ep is IPEndPoint)
                    {
                        int len = _recvSocket.EndReceiveFrom(ar, ref ep);
                        if (len > 0)
                        {
                            byte[] buff = new byte[len];
                            Array.Copy(_recvBuffer, 0, buff, 0, len);
                            try
                            {
                                HandleMsg(buff);
                            }
                            catch (Exception)
                            {
                                //Shouldn't ever get called
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {
                //ignore
            }
            if (_recvSocket != null)
                BeginReceive();
        }
        public void End()
        {
            Active = false;
            try
            {
                _recvSocket?.Close();
                _recvSocket?.Dispose();
            }
            catch (Exception)
            {
            }
            try
            {
                _sendSocket?.Close();
                _sendSocket?.Dispose();
            }
            catch (Exception)
            {
            }


        }

        public void LookForward()
        {
            var s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint target = new IPEndPoint(IPAddress.Parse(PhoneIp), ListenPort);
            var data = Encoding.UTF8.GetBytes("iFacialMocap_lookForward");
            s.SendTo(data, 0, data.Length, SocketFlags.None, target);
            s.Dispose();
        }
    }
}
