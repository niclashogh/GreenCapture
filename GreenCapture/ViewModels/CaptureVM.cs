using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespaces
using GreenCapture.Models;
using GreenCapture.Repositories;

namespace GreenCapture.ViewModels
{
    public class CaptureVM
    {
        #region Variables & Properties (Move to VM later)
        public VideoStream VideoStream { get; private set; }
        public AudioStream AppAudio { get; private set; }
        public AudioStream MicAudio { get; private set; }
        public AudioStream SysAudio { get; private set; }

        private CaptureRepo Repository;
        #endregion

        #region Constructor
        public CaptureVM()
        {
            Repository = new(VideoStream, AppAudio, MicAudio, SysAudio);
        }
        #endregion

        #region Save Settings
        internal void SaveVideoSettings() => Repository.SaveVideoSettings(VideoStream);
        internal void SaveAudioSettings()
        {
            Repository.SaveAudioSettings(AppAudio);
            Repository.SaveAudioSettings(MicAudio);
            Repository.SaveAudioSettings(SysAudio);
        }
        #endregion

        #region Session Recording
        internal void StartSession() => Repository.StartSession();
        internal void EndSession() => Repository.EndSession();
        internal void PauseSession() => Repository.PauseSession();
        #endregion

        #region Clip Recording
        internal void StartClip() => Repository.StartClip();
        internal void EndClip() => Repository.EndClip();
        internal void PauseClip() => Repository.PauseClip();
        internal void SaveClip() => Repository.SaveClip();
        #endregion
    }
}
