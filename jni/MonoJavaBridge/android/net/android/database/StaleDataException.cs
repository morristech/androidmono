namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class StaleDataException : java.lang.RuntimeException
	{ 
		internal static global::java.lang.Class staticClass; 
		static StaleDataException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.StaleDataException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.StaleDataException(@__env); 
			} 
		} 
		protected StaleDataException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _StaleDataException2432; 
		public StaleDataException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.StaleDataException.staticClass, _StaleDataException2432, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _StaleDataException2433; 
		public StaleDataException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.StaleDataException.staticClass, _StaleDataException2433, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.StaleDataException.staticClass = @__class; 
			global::android.database.StaleDataException._StaleDataException2432 = @__env.GetMethodID(global::android.database.StaleDataException.staticClass, "<init>", "()V"); 
			global::android.database.StaleDataException._StaleDataException2433 = @__env.GetMethodID(global::android.database.StaleDataException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
