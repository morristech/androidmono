namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Deprecated_))]
	public partial interface Deprecated : java.lang.annotation.Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Deprecated))]
	public sealed partial class Deprecated_ : java.lang.Object, Deprecated
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Deprecated_()
		{
			InitJNI();
		}
		internal Deprecated_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals19966;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Deprecated_._equals19966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Deprecated_.staticClass, global::java.lang.Deprecated_._equals19966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString19967;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Deprecated_._toString19967)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Deprecated_.staticClass, global::java.lang.Deprecated_._toString19967)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19968;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Deprecated_._hashCode19968);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Deprecated_.staticClass, global::java.lang.Deprecated_._hashCode19968);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType19969;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Deprecated_._annotationType19969)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Deprecated_.staticClass, global::java.lang.Deprecated_._annotationType19969)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Deprecated_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Deprecated"));
			global::java.lang.Deprecated_._equals19966 = @__env.GetMethodIDNoThrow(global::java.lang.Deprecated_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Deprecated_._toString19967 = @__env.GetMethodIDNoThrow(global::java.lang.Deprecated_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Deprecated_._hashCode19968 = @__env.GetMethodIDNoThrow(global::java.lang.Deprecated_.staticClass, "hashCode", "()I");
			global::java.lang.Deprecated_._annotationType19969 = @__env.GetMethodIDNoThrow(global::java.lang.Deprecated_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
