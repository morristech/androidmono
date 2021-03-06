namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DrawableMarginSpan : java.lang.Object, LeadingMarginSpan, LineHeightSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DrawableMarginSpan()
		{
			InitJNI();
		}
		protected DrawableMarginSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLeadingMargin8242;
		public virtual int getLeadingMargin(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.DrawableMarginSpan._getLeadingMargin8242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.DrawableMarginSpan.staticClass, global::android.text.style.DrawableMarginSpan._getLeadingMargin8242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawLeadingMargin8243;
		public virtual void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.DrawableMarginSpan._drawLeadingMargin8243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.DrawableMarginSpan.staticClass, global::android.text.style.DrawableMarginSpan._drawLeadingMargin8243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
		}
		public void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, string arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11)
		{
			drawLeadingMargin(arg0, arg1, arg2, arg3, arg4, arg5, arg6, (global::java.lang.CharSequence)(global::java.lang.String)arg7, arg8, arg9, arg10, arg11);
		}
		internal static global::MonoJavaBridge.MethodId _chooseHeight8244;
		public virtual void chooseHeight(java.lang.CharSequence arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Paint.FontMetricsInt arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.DrawableMarginSpan._chooseHeight8244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.DrawableMarginSpan.staticClass, global::android.text.style.DrawableMarginSpan._chooseHeight8244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		public void chooseHeight(string arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Paint.FontMetricsInt arg5)
		{
			chooseHeight((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		internal static global::MonoJavaBridge.MethodId _DrawableMarginSpan8245;
		public DrawableMarginSpan(android.graphics.drawable.Drawable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.DrawableMarginSpan.staticClass, global::android.text.style.DrawableMarginSpan._DrawableMarginSpan8245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DrawableMarginSpan8246;
		public DrawableMarginSpan(android.graphics.drawable.Drawable arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.DrawableMarginSpan.staticClass, global::android.text.style.DrawableMarginSpan._DrawableMarginSpan8246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.DrawableMarginSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/DrawableMarginSpan"));
			global::android.text.style.DrawableMarginSpan._getLeadingMargin8242 = @__env.GetMethodIDNoThrow(global::android.text.style.DrawableMarginSpan.staticClass, "getLeadingMargin", "(Z)I");
			global::android.text.style.DrawableMarginSpan._drawLeadingMargin8243 = @__env.GetMethodIDNoThrow(global::android.text.style.DrawableMarginSpan.staticClass, "drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V");
			global::android.text.style.DrawableMarginSpan._chooseHeight8244 = @__env.GetMethodIDNoThrow(global::android.text.style.DrawableMarginSpan.staticClass, "chooseHeight", "(Ljava/lang/CharSequence;IIIILandroid/graphics/Paint$FontMetricsInt;)V");
			global::android.text.style.DrawableMarginSpan._DrawableMarginSpan8245 = @__env.GetMethodIDNoThrow(global::android.text.style.DrawableMarginSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.text.style.DrawableMarginSpan._DrawableMarginSpan8246 = @__env.GetMethodIDNoThrow(global::android.text.style.DrawableMarginSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;I)V");
		}
	}
}
