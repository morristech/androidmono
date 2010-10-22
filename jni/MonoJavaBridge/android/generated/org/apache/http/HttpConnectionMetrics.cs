namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpConnectionMetrics_))]
	public partial interface HttpConnectionMetrics  : global::MonoJavaBridge.IJavaObject 
	{
		void reset();
		long getRequestCount();
		long getResponseCount();
		long getSentBytesCount();
		long getReceivedBytesCount();
		global::java.lang.Object getMetric(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpConnectionMetrics))]
	public sealed partial class HttpConnectionMetrics_ : java.lang.Object, HttpConnectionMetrics
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpConnectionMetrics_()
		{
			InitJNI();
		}
		internal HttpConnectionMetrics_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset31417;
		 void org.apache.http.HttpConnectionMetrics.reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._reset31417);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_.staticClass, global::org.apache.http.HttpConnectionMetrics_._reset31417);
		}
		internal static global::MonoJavaBridge.MethodId _getRequestCount31418;
		 long org.apache.http.HttpConnectionMetrics.getRequestCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._getRequestCount31418);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_.staticClass, global::org.apache.http.HttpConnectionMetrics_._getRequestCount31418);
		}
		internal static global::MonoJavaBridge.MethodId _getResponseCount31419;
		 long org.apache.http.HttpConnectionMetrics.getResponseCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._getResponseCount31419);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_.staticClass, global::org.apache.http.HttpConnectionMetrics_._getResponseCount31419);
		}
		internal static global::MonoJavaBridge.MethodId _getSentBytesCount31420;
		 long org.apache.http.HttpConnectionMetrics.getSentBytesCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._getSentBytesCount31420);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_.staticClass, global::org.apache.http.HttpConnectionMetrics_._getSentBytesCount31420);
		}
		internal static global::MonoJavaBridge.MethodId _getReceivedBytesCount31421;
		 long org.apache.http.HttpConnectionMetrics.getReceivedBytesCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._getReceivedBytesCount31421);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_.staticClass, global::org.apache.http.HttpConnectionMetrics_._getReceivedBytesCount31421);
		}
		internal static global::MonoJavaBridge.MethodId _getMetric31422;
		 global::java.lang.Object org.apache.http.HttpConnectionMetrics.getMetric(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_._getMetric31422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpConnectionMetrics_.staticClass, global::org.apache.http.HttpConnectionMetrics_._getMetric31422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpConnectionMetrics_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpConnectionMetrics"));
			global::org.apache.http.HttpConnectionMetrics_._reset31417 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "reset", "()V");
			global::org.apache.http.HttpConnectionMetrics_._getRequestCount31418 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "getRequestCount", "()J");
			global::org.apache.http.HttpConnectionMetrics_._getResponseCount31419 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "getResponseCount", "()J");
			global::org.apache.http.HttpConnectionMetrics_._getSentBytesCount31420 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "getSentBytesCount", "()J");
			global::org.apache.http.HttpConnectionMetrics_._getReceivedBytesCount31421 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "getReceivedBytesCount", "()J");
			global::org.apache.http.HttpConnectionMetrics_._getMetric31422 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnectionMetrics_.staticClass, "getMetric", "(Ljava/lang/String;)Ljava/lang/Object;");
		}
	}
}
