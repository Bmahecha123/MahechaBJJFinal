using System;
using Android.Graphics;
using Android.Media;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MahechaBJJ.Droid;
using MahechaBJJ.Services;
using static Android.Media.MediaPlayer;

[assembly: Xamarin.Forms.Dependency(typeof(VideoPlayerService_Android))]
namespace MahechaBJJ.Droid
{
    public class VideoPlayerService_Android : Java.Lang.Object, IVideoPlayerService, IOnPreparedListener
    {
        SurfaceType type = new SurfaceType();
        ISurfaceHolder surface;
        SurfaceTexture surfaceTexture = new SurfaceTexture(200);

        private MediaPlayer videoPlayer = new MediaPlayer();

        public bool IsCreating => throw new NotImplementedException();

        public Surface Surface => new Surface(surfaceTexture);

        public Rect SurfaceFrame => new Rect();


        public void PlayVimeoVideo(string url)
        {
            //FileInputStream fis = new FileInputStream(url);
            //videoView = new VideoViewPage(url);
            /*videoPlayer.SetDataSource(url);
            videoPlayer.PrepareAsync();
            videoPlayer.Start(); */
            videoPlayer.SetAudioStreamType(Stream.Music);
            videoPlayer.SetDataSource(url);
            videoPlayer.SetDisplay(surface);
            videoPlayer.SetOnPreparedListener(this);
            SetType(type);
            LockCanvas();
            videoPlayer.Prepare();
            videoPlayer.Completion += delegate {
                videoPlayer.Reset();
            };
        }

        public void OnPrepared(MediaPlayer videoPlayer)
        {

            videoPlayer.Start();
        }


        public void AddCallback(ISurfaceHolderCallback callback)
        {
            callback.SurfaceChanged(surface, Format.Unknown, 100, 100);
        }

        public Canvas LockCanvas()
        {

			Canvas canvas = new Canvas();
			canvas.DrawColor(Color.Aqua);
            return canvas;
        }

        public Canvas LockCanvas(Rect dirty)
        {
            throw new NotImplementedException();
        }

        public void RemoveCallback(ISurfaceHolderCallback callback)
        {
            throw new NotImplementedException();
        }

        public void SetFixedSize(int width, int height)
        {
            throw new NotImplementedException();
        }

        public void SetFormat([GeneratedEnum] Format format)
        {
            throw new NotImplementedException();
        }

        public void SetKeepScreenOn(bool screenOn)
        {
            throw new NotImplementedException();
        }

        public void SetSizeFromLayout()
        {
            throw new NotImplementedException();
        }

        public void SetType([GeneratedEnum] SurfaceType type)
        {
            type = SurfaceType.Normal;
        }

        public void UnlockCanvasAndPost(Canvas canvas)
        {
            throw new NotImplementedException();
        }

        /*public void OnCompletion(MediaPlayer videoPlayer)
		 {
			 videoPlayer.Reset();
		 } */
    }    
}
