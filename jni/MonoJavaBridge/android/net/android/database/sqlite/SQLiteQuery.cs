namespace android.database.sqlite 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SQLiteQuery : android.database.sqlite.SQLiteProgram
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SQLiteQuery() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.sqlite.SQLiteQuery), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.sqlite.SQLiteQuery(@__env); 
			} 
		} 
		protected SQLiteQuery(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString2357; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteQuery)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString2357)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.sqlite.SQLiteQuery.staticClass, _toString2357)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close2358; 
		public override void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteQuery)) 
				@__env.CallVoidMethod(this, _close2358); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteQuery.staticClass, _close2358); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindNull2359; 
		public override void bindNull(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteQuery)) 
				@__env.CallVoidMethod(this, _bindNull2359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteQuery.staticClass, _bindNull2359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindLong2360; 
		public override void bindLong(int arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteQuery)) 
				@__env.CallVoidMethod(this, _bindLong2360, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteQuery.staticClass, _bindLong2360, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindDouble2361; 
		public override void bindDouble(int arg0, double arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteQuery)) 
				@__env.CallVoidMethod(this, _bindDouble2361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteQuery.staticClass, _bindDouble2361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindString2362; 
		public override void bindString(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteQuery)) 
				@__env.CallVoidMethod(this, _bindString2362, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteQuery.staticClass, _bindString2362, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.sqlite.SQLiteQuery.staticClass = @__class; 
			global::android.database.sqlite.SQLiteQuery._toString2357 = @__env.GetMethodID(global::android.database.sqlite.SQLiteQuery.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.database.sqlite.SQLiteQuery._close2358 = @__env.GetMethodID(global::android.database.sqlite.SQLiteQuery.staticClass, "close", "()V"); 
			global::android.database.sqlite.SQLiteQuery._bindNull2359 = @__env.GetMethodID(global::android.database.sqlite.SQLiteQuery.staticClass, "bindNull", "(I)V"); 
			global::android.database.sqlite.SQLiteQuery._bindLong2360 = @__env.GetMethodID(global::android.database.sqlite.SQLiteQuery.staticClass, "bindLong", "(IJ)V"); 
			global::android.database.sqlite.SQLiteQuery._bindDouble2361 = @__env.GetMethodID(global::android.database.sqlite.SQLiteQuery.staticClass, "bindDouble", "(ID)V"); 
			global::android.database.sqlite.SQLiteQuery._bindString2362 = @__env.GetMethodID(global::android.database.sqlite.SQLiteQuery.staticClass, "bindString", "(ILjava/lang/String;)V"); 
		} 
	} 
} 