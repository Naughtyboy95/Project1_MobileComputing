package md58febb2b943d65fd140852c6563b21ac5;


public class BookActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Project1_MobileComputing.BookActivity, Project1_MobileComputing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BookActivity.class, __md_methods);
	}


	public BookActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BookActivity.class)
			mono.android.TypeManager.Activate ("Project1_MobileComputing.BookActivity, Project1_MobileComputing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
