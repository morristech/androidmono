namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PasswordTransformationMethod : java.lang.Object, TransformationMethod, TextWatcher
	{ 
		internal static global::java.lang.Class staticClass; 
		static PasswordTransformationMethod() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.PasswordTransformationMethod), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.method.PasswordTransformationMethod(@__env); 
			} 
		} 
		protected PasswordTransformationMethod(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance7212; 
		public static android.text.method.PasswordTransformationMethod getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.PasswordTransformationMethod>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.PasswordTransformationMethod.staticClass, _getInstance7212)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged7213; 
		public virtual void onFocusChanged(android.view.View arg0, java.lang.CharSequence arg1, bool arg2, int arg3, android.graphics.Rect arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.PasswordTransformationMethod)) 
				@__env.CallVoidMethod(this, _onFocusChanged7213, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.PasswordTransformationMethod.staticClass, _onFocusChanged7213, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTextChanged7214; 
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.PasswordTransformationMethod)) 
				@__env.CallVoidMethod(this, _onTextChanged7214, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.PasswordTransformationMethod.staticClass, _onTextChanged7214, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _beforeTextChanged7215; 
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.PasswordTransformationMethod)) 
				@__env.CallVoidMethod(this, _beforeTextChanged7215, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.PasswordTransformationMethod.staticClass, _beforeTextChanged7215, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _afterTextChanged7216; 
		public virtual void afterTextChanged(android.text.Editable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.PasswordTransformationMethod)) 
				@__env.CallVoidMethod(this, _afterTextChanged7216, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.PasswordTransformationMethod.staticClass, _afterTextChanged7216, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransformation7217; 
		public virtual java.lang.CharSequence getTransformation(java.lang.CharSequence arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.PasswordTransformationMethod)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getTransformation7217, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.method.PasswordTransformationMethod.staticClass, _getTransformation7217, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PasswordTransformationMethod7218; 
		public PasswordTransformationMethod()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.PasswordTransformationMethod.staticClass, _PasswordTransformationMethod7218, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.PasswordTransformationMethod.staticClass = @__class; 
			global::android.text.method.PasswordTransformationMethod._getInstance7212 = @__env.GetStaticMethodID(global::android.text.method.PasswordTransformationMethod.staticClass, "getInstance", "()Landroid/text/method/PasswordTransformationMethod;"); 
			global::android.text.method.PasswordTransformationMethod._onFocusChanged7213 = @__env.GetMethodID(global::android.text.method.PasswordTransformationMethod.staticClass, "onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V"); 
			global::android.text.method.PasswordTransformationMethod._onTextChanged7214 = @__env.GetMethodID(global::android.text.method.PasswordTransformationMethod.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V"); 
			global::android.text.method.PasswordTransformationMethod._beforeTextChanged7215 = @__env.GetMethodID(global::android.text.method.PasswordTransformationMethod.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V"); 
			global::android.text.method.PasswordTransformationMethod._afterTextChanged7216 = @__env.GetMethodID(global::android.text.method.PasswordTransformationMethod.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V"); 
			global::android.text.method.PasswordTransformationMethod._getTransformation7217 = @__env.GetMethodID(global::android.text.method.PasswordTransformationMethod.staticClass, "getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;"); 
			global::android.text.method.PasswordTransformationMethod._PasswordTransformationMethod7218 = @__env.GetMethodID(global::android.text.method.PasswordTransformationMethod.staticClass, "<init>", "()V"); 
		} 
	} 
} 
