namespace android.gesture 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class GestureLibraries : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GestureLibraries() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.gesture.GestureLibraries), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.gesture.GestureLibraries(@__env); 
			} 
		} 
		internal GestureLibraries(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fromFile2398; 
		public static android.gesture.GestureLibrary fromFile(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.GestureLibrary>(@__env, @__env.CallStaticObjectMethodPtr(android.gesture.GestureLibraries.staticClass, _fromFile2398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fromFile2399; 
		public static android.gesture.GestureLibrary fromFile(java.io.File arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.GestureLibrary>(@__env, @__env.CallStaticObjectMethodPtr(android.gesture.GestureLibraries.staticClass, _fromFile2399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fromPrivateFile2400; 
		public static android.gesture.GestureLibrary fromPrivateFile(android.content.Context arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.GestureLibrary>(@__env, @__env.CallStaticObjectMethodPtr(android.gesture.GestureLibraries.staticClass, _fromPrivateFile2400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fromRawResource2401; 
		public static android.gesture.GestureLibrary fromRawResource(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.GestureLibrary>(@__env, @__env.CallStaticObjectMethodPtr(android.gesture.GestureLibraries.staticClass, _fromRawResource2401, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.gesture.GestureLibraries.staticClass = @__class; 
			global::android.gesture.GestureLibraries._fromFile2398 = @__env.GetStaticMethodID(global::android.gesture.GestureLibraries.staticClass, "fromFile", "(Ljava/lang/String;)Landroid/gesture/GestureLibrary;"); 
			global::android.gesture.GestureLibraries._fromFile2399 = @__env.GetStaticMethodID(global::android.gesture.GestureLibraries.staticClass, "fromFile", "(Ljava/io/File;)Landroid/gesture/GestureLibrary;"); 
			global::android.gesture.GestureLibraries._fromPrivateFile2400 = @__env.GetStaticMethodID(global::android.gesture.GestureLibraries.staticClass, "fromPrivateFile", "(Landroid/content/Context;Ljava/lang/String;)Landroid/gesture/GestureLibrary;"); 
			global::android.gesture.GestureLibraries._fromRawResource2401 = @__env.GetStaticMethodID(global::android.gesture.GestureLibraries.staticClass, "fromRawResource", "(Landroid/content/Context;I)Landroid/gesture/GestureLibrary;"); 
		} 
	} 
} 