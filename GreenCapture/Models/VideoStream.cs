using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GreenCapture.Models
{
    public class VideoStream
    {
        #region Variables & Properties
        public byte FrameRate { get; private set; }
        public byte Bitrate { get; private set; }
        public Frame Frame { get; private set; }
        public Frame NativeFrame { get; } = new(SystemParameters.PrimaryScreenWidth, SystemParameters.PrimaryScreenHeight);

        public Encoder Encoder { get; set; }

        public int FramePool { get; set; }
        #endregion

        #region Constructor
        public VideoStream(byte frameRate, double width, double height, byte bitrate)
        {
            this.FrameRate = frameRate;
            this.Frame = new(width, height);
            Bitrate = bitrate;
        }
        #endregion
    }
}
