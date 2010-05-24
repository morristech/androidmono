namespace java.security 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Timestamp : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Timestamp() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.security.Timestamp), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.security.Timestamp(@__env); 
			} 
		} 
		internal Timestamp(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12471; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Timestamp)) 
				return @__env.CallIntMethod(this, _hashCode12471); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.security.Timestamp.staticClass, _hashCode12471); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12472; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Timestamp)) 
				return @__env.CallBooleanMethod(this, _equals12472, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.security.Timestamp.staticClass, _equals12472, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12473; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Timestamp)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString12473)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.Timestamp.staticClass, _toString12473)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSignerCertPath12474; 
		public java.security.cert.CertPath getSignerCertPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Timestamp)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.cert.CertPath>(@__env, @__env.CallObjectMethodPtr(this, _getSignerCertPath12474)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.cert.CertPath>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.Timestamp.staticClass, _getSignerCertPath12474)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimestamp12475; 
		public java.util.Date getTimestamp() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Timestamp)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallObjectMethodPtr(this, _getTimestamp12475)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.Timestamp.staticClass, _getTimestamp12475)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Timestamp12476; 
		public Timestamp(java.util.Date arg0, java.security.cert.CertPath arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.Timestamp.staticClass, _Timestamp12476, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.Timestamp.staticClass = @__class; 
			global::java.security.Timestamp._hashCode12471 = @__env.GetMethodID(global::java.security.Timestamp.staticClass, "hashCode", "()I"); 
			global::java.security.Timestamp._equals12472 = @__env.GetMethodID(global::java.security.Timestamp.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.security.Timestamp._toString12473 = @__env.GetMethodID(global::java.security.Timestamp.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.security.Timestamp._getSignerCertPath12474 = @__env.GetMethodID(global::java.security.Timestamp.staticClass, "getSignerCertPath", "()Ljava/security/cert/CertPath;"); 
			global::java.security.Timestamp._getTimestamp12475 = @__env.GetMethodID(global::java.security.Timestamp.staticClass, "getTimestamp", "()Ljava/util/Date;"); 
			global::java.security.Timestamp._Timestamp12476 = @__env.GetMethodID(global::java.security.Timestamp.staticClass, "<init>", "(Ljava/util/Date;Ljava/security/cert/CertPath;)V"); 
		} 
	} 
} 
