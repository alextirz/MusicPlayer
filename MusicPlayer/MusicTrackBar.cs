using NAudio.Wave;

namespace MusicPlayer
{
    public partial class MusicTrackBar : UserControl
    {
        IWavePlayer _wavePlayer;
        AudioFileReader _audioFileReader;
        public event EventHandler PlayPause;
        public event EventHandler PlayNext;
        public event EventHandler PlayPrevious;
        bool isPlaying;

        public MusicTrackBar()
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
            if (_wavePlayer is null)
            {
                ShowMessage();
            }
            else
            {
                _wavePlayer.Volume = trackBar1.Value / 100f;
            }
        }

        private void ButtonVolumeDown_CustomClick(object? sender, EventArgs e)
        {
            if (_wavePlayer is null)
            {
                ShowMessage();
            }
            else
            {
                _wavePlayer.Volume = 0;
            }
        }

        #endregion
        public void Play(string path)
        {
            if (_wavePlayer != null)
            {
                _wavePlayer.Stop();
                audioTime.Stop();
                isPlaying = false;
            }
            _wavePlayer = new WaveOut();

            _audioFileReader = new AudioFileReader(path);
            _wavePlayer.Init(_audioFileReader);
            _wavePlayer.Play();
            isPlaying = true;
            _wavePlayer.Volume = trackBar1.Value / 100f;
            buttonPlayPause.ButtonImage = Properties.Resources.pause;
            audioTime.Start();
        }



        private void audioTime_Tick(object sender, EventArgs e)
        {
            double timePercent = (_audioFileReader.CurrentTime
                / _audioFileReader.TotalTime) * 100;

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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (sender is TrackBar volumeBar && _wavePlayer != null)
            {
                _wavePlayer.Volume = volumeBar.Value / 100f;
            }
        }
    }
}
