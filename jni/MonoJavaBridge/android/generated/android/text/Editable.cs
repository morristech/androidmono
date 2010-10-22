namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.Editable_))]
	public partial interface Editable : java.lang.CharSequence, GetChars, Spannable, java.lang.Appendable
	{
		global::android.text.Editable append(java.lang.CharSequence arg0, int arg1, int arg2);
		global::android.text.Editable append(java.lang.CharSequence arg0);
		global::android.text.Editable append(char arg0);
		void clear();
		global::android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4);
		global::android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2);
		global::android.text.Editable delete(int arg0, int arg1);
		global::android.text.Editable insert(int arg0, java.lang.CharSequence arg1);
		global::android.text.Editable insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3);
		void setFilters(android.text.InputFilter[] arg0);
		global::android.text.InputFilter[] getFilters();
		void clearSpans();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.Editable))]
	public sealed partial class Editable_ : java.lang.Object, Editable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Editable_()
		{
			InitJNI();
		}
		internal Editable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _append12684;
		 global::android.text.Editable android.text.Editable.append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append12684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append12684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _append12685;
		 global::android.text.Editable android.text.Editable.append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append12685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append12685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _append12686;
		 global::android.text.Editable android.text.Editable.append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append12686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append12686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _clear12687;
		 void android.text.Editable.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._clear12687);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._clear12687);
		}
		internal static global::MonoJavaBridge.MethodId _replace12688;
		 global::android.text.Editable android.text.Editable.replace(int arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._replace12688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._replace12688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _replace12689;
		 global::android.text.Editable android.text.Editable.replace(int arg0, int arg1, java.lang.CharSequence arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._replace12689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._replace12689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _delete12690;
		 global::android.text.Editable android.text.Editable.delete(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._delete12690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._delete12690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _insert12691;
		 global::android.text.Editable android.text.Editable.insert(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._insert12691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._insert12691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _insert12692;
		 global::android.text.Editable android.text.Editable.insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._insert12692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._insert12692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _setFilters12693;
		 void android.text.Editable.setFilters(android.text.InputFilter[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._setFilters12693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._setFilters12693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFilters12694;
		 global::android.text.InputFilter[] android.text.Editable.getFilters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._getFilters12694)) as android.text.InputFilter[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getFilters12694)) as android.text.InputFilter[];
		}
		internal static global::MonoJavaBridge.MethodId _clearSpans12695;
		 void android.text.Editable.clearSpans() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._clearSpans12695);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._clearSpans12695);
		}
		internal static global::MonoJavaBridge.MethodId _toString12696;
		 global::java.lang.String java.lang.CharSequence.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._toString12696)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._toString12696)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length12697;
		 int java.lang.CharSequence.length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Editable_._length12697);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._length12697);
		}
		internal static global::MonoJavaBridge.MethodId _charAt12698;
		 char java.lang.CharSequence.charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.text.Editable_._charAt12698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._charAt12698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence12699;
		 global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._subSequence12699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._subSequence12699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getChars12700;
		 void android.text.GetChars.getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._getChars12700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getChars12700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setSpan12701;
		 void android.text.Spannable.setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._setSpan12701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._setSpan12701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeSpan12702;
		 void android.text.Spannable.removeSpan(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Editable_._removeSpan12702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._removeSpan12702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpans12703;
		 global::java.lang.Object[] android.text.Spanned.getSpans(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._getSpans12703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getSpans12703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getSpanStart12704;
		 int android.text.Spanned.getSpanStart(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Editable_._getSpanStart12704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getSpanStart12704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanEnd12705;
		 int android.text.Spanned.getSpanEnd(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Editable_._getSpanEnd12705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getSpanEnd12705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanFlags12706;
		 int android.text.Spanned.getSpanFlags(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Editable_._getSpanFlags12706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._getSpanFlags12706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextSpanTransition12707;
		 int android.text.Spanned.nextSpanTransition(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Editable_._nextSpanTransition12707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._nextSpanTransition12707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _append12708;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append12708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append12708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append12709;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append12709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append12709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append12710;
		 global::java.lang.Appendable java.lang.Appendable.append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_._append12710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_.staticClass, global::android.text.Editable_._append12710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Editable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Editable"));
			global::android.text.Editable_._append12684 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.Editable_._append12685 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.Editable_._append12686 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(C)Landroid/text/Editable;");
			global::android.text.Editable_._clear12687 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "clear", "()V");
			global::android.text.Editable_._replace12688 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.Editable_._replace12689 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.Editable_._delete12690 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "delete", "(II)Landroid/text/Editable;");
			global::android.text.Editable_._insert12691 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.Editable_._insert12692 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.Editable_._setFilters12693 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "setFilters", "([Landroid/text/InputFilter;)V");
			global::android.text.Editable_._getFilters12694 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getFilters", "()[Landroid/text/InputFilter;");
			global::android.text.Editable_._clearSpans12695 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "clearSpans", "()V");
			global::android.text.Editable_._toString12696 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.Editable_._length12697 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "length", "()I");
			global::android.text.Editable_._charAt12698 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "charAt", "(I)C");
			global::android.text.Editable_._subSequence12699 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::android.text.Editable_._getChars12700 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getChars", "(II[CI)V");
			global::android.text.Editable_._setSpan12701 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "setSpan", "(Ljava/lang/Object;III)V");
			global::android.text.Editable_._removeSpan12702 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "removeSpan", "(Ljava/lang/Object;)V");
			global::android.text.Editable_._getSpans12703 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;");
			global::android.text.Editable_._getSpanStart12704 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getSpanStart", "(Ljava/lang/Object;)I");
			global::android.text.Editable_._getSpanEnd12705 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I");
			global::android.text.Editable_._getSpanFlags12706 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I");
			global::android.text.Editable_._nextSpanTransition12707 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I");
			global::android.text.Editable_._append12708 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::android.text.Editable_._append12709 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::android.text.Editable_._append12710 = @__env.GetMethodIDNoThrow(global::android.text.Editable_.staticClass, "append", "(C)Ljava/lang/Appendable;");
		}
	}
}
