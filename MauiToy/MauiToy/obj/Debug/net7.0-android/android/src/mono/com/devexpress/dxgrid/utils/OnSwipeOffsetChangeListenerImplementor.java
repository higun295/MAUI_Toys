package mono.com.devexpress.dxgrid.utils;


public class OnSwipeOffsetChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.devexpress.dxgrid.utils.OnSwipeOffsetChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_rowSwipeOffsetChanged:()V:GetRowSwipeOffsetChangedHandler:DevExpress.Android.Grid.Utils.IOnSwipeOffsetChangeListenerInvoker, DevExpress.Android.Grid\n" +
			"";
		mono.android.Runtime.register ("DevExpress.Android.Grid.Utils.IOnSwipeOffsetChangeListenerImplementor, DevExpress.Android.Grid", OnSwipeOffsetChangeListenerImplementor.class, __md_methods);
	}


	public OnSwipeOffsetChangeListenerImplementor ()
	{
		super ();
		if (getClass () == OnSwipeOffsetChangeListenerImplementor.class) {
			mono.android.TypeManager.Activate ("DevExpress.Android.Grid.Utils.IOnSwipeOffsetChangeListenerImplementor, DevExpress.Android.Grid", "", this, new java.lang.Object[] {  });
		}
	}


	public void rowSwipeOffsetChanged ()
	{
		n_rowSwipeOffsetChanged ();
	}

	private native void n_rowSwipeOffsetChanged ();

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
