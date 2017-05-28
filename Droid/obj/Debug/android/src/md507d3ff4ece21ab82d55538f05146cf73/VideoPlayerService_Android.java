package md507d3ff4ece21ab82d55538f05146cf73;


public class VideoPlayerService_Android
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.media.MediaPlayer.OnPreparedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPrepared:(Landroid/media/MediaPlayer;)V:GetOnPrepared_Landroid_media_MediaPlayer_Handler:Android.Media.MediaPlayer/IOnPreparedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("MahechaBJJ.Droid.VideoPlayerService_Android, MahechaBJJ.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VideoPlayerService_Android.class, __md_methods);
	}


	public VideoPlayerService_Android () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VideoPlayerService_Android.class)
			mono.android.TypeManager.Activate ("MahechaBJJ.Droid.VideoPlayerService_Android, MahechaBJJ.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onPrepared (android.media.MediaPlayer p0)
	{
		n_onPrepared (p0);
	}

	private native void n_onPrepared (android.media.MediaPlayer p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
