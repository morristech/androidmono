namespace android.text.method
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class DigitsKeyListener : android.text.method.NumberKeyListener
	{
		internal new static global::java.lang.Class staticClass;
		static DigitsKeyListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.method.DigitsKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.method.DigitsKeyListener(@__env);
			}
		}
		protected DigitsKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance7144;
		public static global::android.text.method.DigitsKeyListener getInstance(bool arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.DigitsKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._getInstance7144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance7145;
		public static global::android.text.method.DigitsKeyListener getInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.DigitsKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._getInstance7145));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance7146;
		public static global::android.text.method.DigitsKeyListener getInstance(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.DigitsKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._getInstance7146, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _filter7147;
		public override global::java.lang.CharSequence filter(java.lang.CharSequence arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.method.DigitsKeyListener._filter7147, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._filter7147, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)));
		}
		public java.lang.CharSequence filter(string arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5)
		{
			return filter((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputType7148;
		public override int getInputType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.method.DigitsKeyListener._getInputType7148);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._getInputType7148);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAcceptedChars7149;
		protected override char[] getAcceptedChars() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.text.method.DigitsKeyListener._getAcceptedChars7149));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._getAcceptedChars7149));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DigitsKeyListener7150;
		public DigitsKeyListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._DigitsKeyListener7150, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _DigitsKeyListener7151;
		public DigitsKeyListener(bool arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.method.DigitsKeyListener.staticClass, global::android.text.method.DigitsKeyListener._DigitsKeyListener7151, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.method.DigitsKeyListener.staticClass = @__class;
			global::android.text.method.DigitsKeyListener._getInstance7144 = @__env.GetStaticMethodID(global::android.text.method.DigitsKeyListener.staticClass, "getInstance", "(ZZ)Landroid/text/method/DigitsKeyListener;");
			global::android.text.method.DigitsKeyListener._getInstance7145 = @__env.GetStaticMethodID(global::android.text.method.DigitsKeyListener.staticClass, "getInstance", "()Landroid/text/method/DigitsKeyListener;");
			global::android.text.method.DigitsKeyListener._getInstance7146 = @__env.GetStaticMethodID(global::android.text.method.DigitsKeyListener.staticClass, "getInstance", "(Ljava/lang/String;)Landroid/text/method/DigitsKeyListener;");
			global::android.text.method.DigitsKeyListener._filter7147 = @__env.GetMethodID(global::android.text.method.DigitsKeyListener.staticClass, "filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;");
			global::android.text.method.DigitsKeyListener._getInputType7148 = @__env.GetMethodID(global::android.text.method.DigitsKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.DigitsKeyListener._getAcceptedChars7149 = @__env.GetMethodID(global::android.text.method.DigitsKeyListener.staticClass, "getAcceptedChars", "()[C");
			global::android.text.method.DigitsKeyListener._DigitsKeyListener7150 = @__env.GetMethodID(global::android.text.method.DigitsKeyListener.staticClass, "<init>", "()V");
			global::android.text.method.DigitsKeyListener._DigitsKeyListener7151 = @__env.GetMethodID(global::android.text.method.DigitsKeyListener.staticClass, "<init>", "(ZZ)V");
		}
	}
}