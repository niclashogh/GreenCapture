using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespaces
using GreenCapture.Models;

namespace GreenCapture.Repositories
{
    public class CaptureRepo
    {
        #region Constructor
        public CaptureRepo(VideoStream videoStream, AudioStream appAudio, AudioStream micAudio, AudioStream sysAudio)
        {
            videoStream = LoadVideoSettings();
            appAudio = LoadAudioSettings("app");
            micAudio = LoadAudioSettings("mic");
            sysAudio = LoadAudioSettings("sys");
        }
        #endregion

        #region Load Audio/Video
        internal VideoStream LoadVideoSettings()
        {
            return null;
        }

        internal AudioStream LoadAudioSettings(string selected)
        {
            //Select path
            if (selected == "app")
            {
                return null;
            }
            else if (selected == "mic")
            {
                return null;
            }
            else
            {
                return null;
            }

            //Read from file
        }
        #endregion

        #region Save Audio/Video
        internal void SaveVideoSettings(VideoStream videoStream)
        {

        }

        internal void SaveAudioSettings(AudioStream audioStream)
        {

        }
        #endregion

        #region Session Recording
        internal void StartSession()
        {

        }

        internal void EndSession()
        {

        }

        internal void PauseSession()
        {

        }
        #endregion

        #region Clip Recording
        internal void StartClip()
        {

        }

        internal void EndClip()
        {

        }

        internal void PauseClip()
        {

        }

        internal void SaveClip()
        {

        }
        #endregion
    }
}
