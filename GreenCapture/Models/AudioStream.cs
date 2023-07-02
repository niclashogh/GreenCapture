using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCapture.Models
{
    #region Enum
    public enum Channels
    {
        
    }
    #endregion

    public class AudioStream
    {
        #region Variables & Properties
        public bool Enabled { get; private set; }
        public byte Bitrate { get; private set; }
        public byte Volume { get; private set; }

        //Channel
        #endregion

        #region Constructor
        public AudioStream()
        {

        }
        #endregion
    }
}
