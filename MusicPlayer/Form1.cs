using System.Diagnostics.Eventing.Reader;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TrackBar trackBar = new TrackBar();
            trackBar.Dock = DockStyle.Bottom;
            trackBar1.PlayPause += TrackBar1_PlayPause;
            trackBar1.PlayNext += TrackBar1_PlayNext;
            trackBar1.PlayPrevious += TrackBar1_PlayPrevious;
        }

        private void TrackBar1_PlayPrevious(object? sender, EventArgs e)
        {
            int index = musicArea.Controls.IndexOf(play);
            if (index == 0)
            {
                index = musicArea.Controls.Count;
            }
            Control previousTrack = musicArea.Controls[index - 1];
            Newtrack_MusicPlay(previousTrack, e);
        }

        private void TrackBar1_PlayNext(object? sender, EventArgs e)
        {
            int index = musicArea.Controls.IndexOf(play);
            if (index + 1 == musicArea.Controls.Count)
            {
                index = -1;
            }
            Control nextTrack = musicArea.Controls[index + 1];
            Newtrack_MusicPlay(nextTrack, e);
        }

        private void TrackBar1_PlayPause(object? sender, EventArgs e)
        {
            bool player = (bool)sender;
            if (player)
            {
                play.ButtonPlay = false;
            }
            else if (play is null)
                return;
            else
                play.ButtonPlay = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            string[] directories = Directory.GetDirectories("./Music");


            foreach (string directory in directories)
            {
                var imagePaths = Directory.GetFiles(directory, "*.jpg");
                PlayListItem playListItem = new PlayListItem();
                DirectoryInfo dirInfo = new DirectoryInfo(directory);
                playListItem.Title = dirInfo.Name;
                playListItem.Description = dirInfo.CreationTime.ToShortDateString();
                playListItem.Dock = DockStyle.Top;
                playListArea.Controls.Add(playListItem);
                playListItem.FilePath = dirInfo.FullName;

                if (imagePaths.Length > 0)
                {
                    Image playlistImage = Image.FromFile(imagePaths[0]);
                    playListItem.ImageCover = playlistImage;
                }
                else playListItem.ImageCover = Properties.Resources._default;

                playListItem.PlayListItemChanged += PlayListItem_PlayListItemChanged;
            }

            PlayListItem? playList = playListArea.Controls[0] as PlayListItem;
            if (playList != null)
            {
                ShowPlayList(playList);
            }
        }

        private void PlayListItem_PlayListItemChanged(object? sender, EventArgs e)
        {
            PlayListItem? playList = sender as PlayListItem;
            if (playList != null)
            {
                ShowPlayList(playList);
            }
        }

        public void ShowPlayList(PlayListItem playlist)
        {
            musicArea.Controls.Clear();
            string[] files = Directory.GetFiles(playlist.FilePath, "*.mp3");
            string[] imageFiles = Directory.GetFiles(playlist.FilePath, "*.jpg");


            foreach (var musicTrack in files)
            {
                FileInfo file = new FileInfo(musicTrack);
                MusicItem newtrack = new MusicItem();
                newtrack.Title = file.Name.Replace(".mp3", "");
                var currentDir = Directory.GetParent(file.FullName);
                newtrack.Description = playlist.Title;
                newtrack.FilePath = file.FullName;
                newtrack.MusicPlay += Newtrack_MusicPlay;
                newtrack.MusicHover += Newtrack_MusicHover;
                musicArea.Controls.Add(newtrack);
                newtrack.TrackImage = playlist.ImageCover;
            }

        }

        MusicItem hover;
        private void Newtrack_MusicHover(object? sender, EventArgs e)
        {
            if (sender is MusicItem musicItem && hover != musicItem)
            {

                if (hover != null)
                {
                    hover.ButtonVisible = false;
                }
                hover = musicItem;
                hover.ButtonVisible = true;
            }

        }

        MusicItem play;
        private void Newtrack_MusicPlay(object sender, EventArgs e)
        {
            if (sender is MusicItem musicItem)
            {
                if (play == musicItem)
                {
                    trackBar1.ButtonPlayPause_CustomClick(sender, e);
                }
                else
                {
                    if (play != null)
                    {
                        play.ButtonPlay = false;
                    }
                    play = musicItem;
                    play.ButtonPlay = true;
                    trackBar1.Play(play.FilePath);
                }
            }
        }
    }
}