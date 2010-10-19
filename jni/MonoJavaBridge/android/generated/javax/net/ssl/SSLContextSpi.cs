namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLContextSpi_))]
	public abstract partial class SSLContextSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLContextSpi()
		{
			InitJNI();
		}
		protected SSLContextSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit23347;
		protected abstract void engineInit(javax.net.ssl.KeyManager[] arg0, javax.net.ssl.TrustManager[] arg1, java.security.SecureRandom arg2);
		internal static global::MonoJavaBridge.MethodId _engineGetSocketFactory23348;
		protected abstract global::javax.net.ssl.SSLSocketFactory engineGetSocketFactory();
		internal static global::MonoJavaBridge.MethodId _engineGetServerSocketFactory23349;
		protected abstract global::javax.net.ssl.SSLServerSocketFactory engineGetServerSocketFactory();
		internal static global::MonoJavaBridge.MethodId _engineCreateSSLEngine23350;
		protected abstract global::javax.net.ssl.SSLEngine engineCreateSSLEngine(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _engineCreateSSLEngine23351;
		protected abstract global::javax.net.ssl.SSLEngine engineCreateSSLEngine();
		internal static global::MonoJavaBridge.MethodId _engineGetServerSessionContext23352;
		protected abstract global::javax.net.ssl.SSLSessionContext engineGetServerSessionContext();
		internal static global::MonoJavaBridge.MethodId _engineGetClientSessionContext23353;
		protected abstract global::javax.net.ssl.SSLSessionContext engineGetClientSessionContext();
		internal static global::MonoJavaBridge.MethodId _SSLContextSpi23354;
		public SSLContextSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLContextSpi.staticClass, global::javax.net.ssl.SSLContextSpi._SSLContextSpi23354);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLContextSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLContextSpi"));
			global::javax.net.ssl.SSLContextSpi._engineInit23347 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "engineInit", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRandom;)V");
			global::javax.net.ssl.SSLContextSpi._engineGetSocketFactory23348 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "engineGetSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
			global::javax.net.ssl.SSLContextSpi._engineGetServerSocketFactory23349 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "engineGetServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;");
			global::javax.net.ssl.SSLContextSpi._engineCreateSSLEngine23350 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "engineCreateSSLEngine", "(Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;");
			global::javax.net.ssl.SSLContextSpi._engineCreateSSLEngine23351 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "engineCreateSSLEngine", "()Ljavax/net/ssl/SSLEngine;");
			global::javax.net.ssl.SSLContextSpi._engineGetServerSessionContext23352 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "engineGetServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;");
			global::javax.net.ssl.SSLContextSpi._engineGetClientSessionContext23353 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "engineGetClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;");
			global::javax.net.ssl.SSLContextSpi._SSLContextSpi23354 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLContextSpi))]
	public sealed partial class SSLContextSpi_ : javax.net.ssl.SSLContextSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLContextSpi_()
		{
			InitJNI();
		}
		internal SSLContextSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit23355;
		protected override void engineInit(javax.net.ssl.KeyManager[] arg0, javax.net.ssl.TrustManager[] arg1, java.security.SecureRandom arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_._engineInit23355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_.staticClass, global::javax.net.ssl.SSLContextSpi_._engineInit23355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetSocketFactory23356;
		protected override global::javax.net.ssl.SSLSocketFactory engineGetSocketFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_._engineGetSocketFactory23356)) as javax.net.ssl.SSLSocketFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_.staticClass, global::javax.net.ssl.SSLContextSpi_._engineGetSocketFactory23356)) as javax.net.ssl.SSLSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetServerSocketFactory23357;
		protected override global::javax.net.ssl.SSLServerSocketFactory engineGetServerSocketFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_._engineGetServerSocketFactory23357)) as javax.net.ssl.SSLServerSocketFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_.staticClass, global::javax.net.ssl.SSLContextSpi_._engineGetServerSocketFactory23357)) as javax.net.ssl.SSLServerSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _engineCreateSSLEngine23358;
		protected override global::javax.net.ssl.SSLEngine engineCreateSSLEngine(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_._engineCreateSSLEngine23358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_.staticClass, global::javax.net.ssl.SSLContextSpi_._engineCreateSSLEngine23358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngine;
		}
		internal static global::MonoJavaBridge.MethodId _engineCreateSSLEngine23359;
		protected override global::javax.net.ssl.SSLEngine engineCreateSSLEngine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_._engineCreateSSLEngine23359)) as javax.net.ssl.SSLEngine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_.staticClass, global::javax.net.ssl.SSLContextSpi_._engineCreateSSLEngine23359)) as javax.net.ssl.SSLEngine;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetServerSessionContext23360;
		protected override global::javax.net.ssl.SSLSessionContext engineGetServerSessionContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSessionContext>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_._engineGetServerSessionContext23360)) as javax.net.ssl.SSLSessionContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSessionContext>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_.staticClass, global::javax.net.ssl.SSLContextSpi_._engineGetServerSessionContext23360)) as javax.net.ssl.SSLSessionContext;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetClientSessionContext23361;
		protected override global::javax.net.ssl.SSLSessionContext engineGetClientSessionContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSessionContext>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_._engineGetClientSessionContext23361)) as javax.net.ssl.SSLSessionContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSessionContext>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLContextSpi_.staticClass, global::javax.net.ssl.SSLContextSpi_._engineGetClientSessionContext23361)) as javax.net.ssl.SSLSessionContext;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLContextSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLContextSpi"));
			global::javax.net.ssl.SSLContextSpi_._engineInit23355 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi_.staticClass, "engineInit", "([Ljavax/net/ssl/KeyManager;[Ljavax/net/ssl/TrustManager;Ljava/security/SecureRandom;)V");
			global::javax.net.ssl.SSLContextSpi_._engineGetSocketFactory23356 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi_.staticClass, "engineGetSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
			global::javax.net.ssl.SSLContextSpi_._engineGetServerSocketFactory23357 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi_.staticClass, "engineGetServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;");
			global::javax.net.ssl.SSLContextSpi_._engineCreateSSLEngine23358 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi_.staticClass, "engineCreateSSLEngine", "(Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;");
			global::javax.net.ssl.SSLContextSpi_._engineCreateSSLEngine23359 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi_.staticClass, "engineCreateSSLEngine", "()Ljavax/net/ssl/SSLEngine;");
			global::javax.net.ssl.SSLContextSpi_._engineGetServerSessionContext23360 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi_.staticClass, "engineGetServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;");
			global::javax.net.ssl.SSLContextSpi_._engineGetClientSessionContext23361 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLContextSpi_.staticClass, "engineGetClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;");
		}
	}
}