namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DecelerateInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DecelerateInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual float getInterpolation(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.DecelerateInterpolator.staticClass, "getInterpolation", "(F)F", ref global::android.view.animation.DecelerateInterpolator._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public DecelerateInterpolator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.DecelerateInterpolator._m1.native == global::System.IntPtr.Zero)
				global::android.view.animation.DecelerateInterpolator._m1 = @__env.GetMethodIDNoThrow(global::android.view.animation.DecelerateInterpolator.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.DecelerateInterpolator.staticClass, global::android.view.animation.DecelerateInterpolator._m1);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public DecelerateInterpolator(float arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.DecelerateInterpolator._m2.native == global::System.IntPtr.Zero)
				global::android.view.animation.DecelerateInterpolator._m2 = @__env.GetMethodIDNoThrow(global::android.view.animation.DecelerateInterpolator.staticClass, "<init>", "(F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.DecelerateInterpolator.staticClass, global::android.view.animation.DecelerateInterpolator._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public DecelerateInterpolator(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.DecelerateInterpolator._m3.native == global::System.IntPtr.Zero)
				global::android.view.animation.DecelerateInterpolator._m3 = @__env.GetMethodIDNoThrow(global::android.view.animation.DecelerateInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.DecelerateInterpolator.staticClass, global::android.view.animation.DecelerateInterpolator._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DecelerateInterpolator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.DecelerateInterpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/DecelerateInterpolator"));
		}
	}
}