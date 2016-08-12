package md58febb2b943d65fd140852c6563b21ac5;


public class DetailActivity_1
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
		mono.android.Runtime.register ("Project1_MobileComputing.DetailActivity_1, Project1_MobileComputing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DetailActivity_1.class, __md_methods);
	}


	public DetailActivity_1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DetailActivity_1.class)
			mono.android.TypeManager.Activate ("Project1_MobileComputing.DetailActivity_1, Project1_MobileComputing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
