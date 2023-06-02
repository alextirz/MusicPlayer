using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace MusicPlayer
{
    public partial class TrackBar : UserControl
    {
        IWavePlayer _wavePlayer;
        AudioFileReader _audioFileReader;
        public event EventHandler PlayPause;
        public event EventHandler PlayNext;
        public event EventHandler PlayPrevious;
        bool isPlaying;

        public TrackBar()
        {
            InitializeComponent();
            buttonPlayPause.CustomClick += ButtonPlayPause_CustomClick;
            buttonPrevious.CustomClick += ButtonPrevious_CustomClick;
            buttonNext.CustomClick += ButtonNext_CustomClick;
            buttonVolumeUp.CustomClick += ButtonVolumeUp_CustomClick;
            buttonVolumeDown.CustomClick += ButtonVolumeDown_CustomClick;
        }

        #region CustomClick Implementation
        public void ButtonPlayPause_CustomClick(object? sender, EventArgs e)
        {
            if (_wavePlayer is null)
            {
                ShowMessage();
            }
            else if (isPlaying)
            {
                _wavePlayer.Pause();
                buttonPlayPause.ButtonImage = Properties.Resources.play;
            }
            else
            {
                _wavePlayer.Play();
                buttonPlayPause.ButtonImage = Properties.Resources.pause;
            }
            PlayPause.Invoke(isPlaying, EventArgs.Empty);
            isPlaying = !isPlaying;
        }

        private void ButtonPrevious_CustomClick(object? sender, EventArgs e)
        {
            if (_wavePlayer is null)
            {
                ShowMessage();
            }

            else
            {
                PlayPrevious.Invoke(sender, e);
            }
        }

        private void ButtonNext_CustomClick(object? sender, EventArgs e)
        {
            if (_wavePlayer is null)
            {
                ShowMessage();
            }
            else
            {
                PlayNext.Invoke(sender, e);
            }
        }
        private void ButtonVolumeUp_CustomClick(object? sender, EventArgs e)
        {
            float change = 0.2f;
            if (_wavePlayer is null)
            {
                ShowMessage();
            }
            else if (_wavePlayer.Volume + change > 1)
            {
                _wavePlayer.Volume = 1;
            }
            else
                _wavePlayer.Volume = _wavePlayer.Volume + change;
        }

        private void ButtonVolumeDown_CustomClick(object? sender, EventArgs e)
        {
            float change = 0.2f;
            if (_wavePlayer is null)
            {
                ShowMessage();
            }
            else if ((_wavePlayer.Volume - change < 0))
            {
                _wavePlayer.Volume = 0;
            }
            else
            {
                _wavePlayer.Volume = _wavePlayer.Volume - change;
            }
        }

        #endregion
        public void Play(string path)
        {
            if (_wavePlayer != null)
            {
                //_wavePlayer.Dispose();
                //_audioFileReader.Dispose();
                _wavePlayer.Stop();
                audioTime.Stop();
                isPlaying = false;
            }
            _wavePlayer = new WaveOut();

            label1.Text = path;
            _audioFileReader = new AudioFileReader(path);
            _wavePlayer.Init(_audioFileReader);
            _wavePlayer.Play();
            isPlaying = true;
            _wavePlayer.Volume = 0.5f;
            buttonPlayPause.ButtonImage = Properties.Resources.pause;
            audioTime.Start();
        }

        private void audioTime_Tick(object sender, EventArgs e)
        {
            double timePercent = (_audioFileReader.CurrentTime
                / _audioFileReader.TotalTime) * 100;
            label1.Text = _audioFileReader.CurrentTime
                + "/" + _audioFileReader.TotalTime;

            progress.ColumnStyles[0].Width = (int)timePercent;
            progress.ColumnStyles[1].Width = 100 - (int)timePercent;
        }

        private void progress_MouseClick(object sender, MouseEventArgs e)
        {
            double percent = (double)e.X / progress.Width;
            TimeSpan result = _audioFileReader.TotalTime * percent;
            _audioFileReader.CurrentTime = result;
        }

        private void ShowMessage()
        {
            MessageBox.Show("Select a song!");
        }
    }
}
