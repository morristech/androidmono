namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UriMatcher : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UriMatcher()
		{
			InitJNI();
		}
		protected UriMatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _match1833;
		public virtual int match(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.UriMatcher._match1833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.UriMatcher.staticClass, global::android.content.UriMatcher._match1833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addURI1834;
		public virtual void addURI(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.UriMatcher._addURI1834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.UriMatcher.staticClass, global::android.content.UriMatcher._addURI1834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _UriMatcher1835;
		public UriMatcher(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.UriMatcher.staticClass, global::android.content.UriMatcher._UriMatcher1835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int NO_MATCH
		{
			get
			{
				return -1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.UriMatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/UriMatcher"));
			global::android.content.UriMatcher._match1833 = @__env.GetMethodIDNoThrow(global::android.content.UriMatcher.staticClass, "match", "(Landroid/net/Uri;)I");
			global::android.content.UriMatcher._addURI1834 = @__env.GetMethodIDNoThrow(global::android.content.UriMatcher.staticClass, "addURI", "(Ljava/lang/String;Ljava/lang/String;I)V");
			global::android.content.UriMatcher._UriMatcher1835 = @__env.GetMethodIDNoThrow(global::android.content.UriMatcher.staticClass, "<init>", "(I)V");
		}
	}
}
