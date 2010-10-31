namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.RowSetInternal_))]
	public partial interface RowSetInternal  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object[] getParams();
		global::java.sql.Connection getConnection();
		global::java.sql.ResultSet getOriginal();
		void setMetaData(javax.sql.RowSetMetaData arg0);
		global::java.sql.ResultSet getOriginalRow();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.RowSetInternal))]
	internal sealed partial class RowSetInternal_ : java.lang.Object, RowSetInternal
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RowSetInternal_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object[] javax.sql.RowSetInternal.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::javax.sql.RowSetInternal_.staticClass, "getParams", "()[Ljava/lang/Object;", ref global::javax.sql.RowSetInternal_._m0) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.sql.Connection javax.sql.RowSetInternal.getConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Connection>(this, global::javax.sql.RowSetInternal_.staticClass, "getConnection", "()Ljava/sql/Connection;", ref global::javax.sql.RowSetInternal_._m1) as java.sql.Connection;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.sql.ResultSet javax.sql.RowSetInternal.getOriginal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::javax.sql.RowSetInternal_.staticClass, "getOriginal", "()Ljava/sql/ResultSet;", ref global::javax.sql.RowSetInternal_._m2) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void javax.sql.RowSetInternal.setMetaData(javax.sql.RowSetMetaData arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSetInternal_.staticClass, "setMetaData", "(Ljavax/sql/RowSetMetaData;)V", ref global::javax.sql.RowSetInternal_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.sql.ResultSet javax.sql.RowSetInternal.getOriginalRow()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::javax.sql.RowSetInternal_.staticClass, "getOriginalRow", "()Ljava/sql/ResultSet;", ref global::javax.sql.RowSetInternal_._m4) as java.sql.ResultSet;
		}
		static RowSetInternal_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetInternal_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetInternal"));
		}
	}
}