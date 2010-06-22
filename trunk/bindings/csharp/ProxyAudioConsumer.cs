/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ProxyAudioConsumer : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ProxyAudioConsumer(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ProxyAudioConsumer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ProxyAudioConsumer() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        tinyWRAPPINVOKE.delete_ProxyAudioConsumer(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public ProxyAudioConsumer() : this(tinyWRAPPINVOKE.new_ProxyAudioConsumer(), true) {
    SwigDirectorConnect();
  }

  public virtual int prepare(int ptime, int rate, int channels) {
    int ret = ((this.GetType() == typeof(ProxyAudioConsumer)) ? tinyWRAPPINVOKE.ProxyAudioConsumer_prepare(swigCPtr, ptime, rate, channels) : tinyWRAPPINVOKE.ProxyAudioConsumer_prepareSwigExplicitProxyAudioConsumer(swigCPtr, ptime, rate, channels));
    return ret;
  }

  public virtual int start() {
    int ret = ((this.GetType() == typeof(ProxyAudioConsumer)) ? tinyWRAPPINVOKE.ProxyAudioConsumer_start(swigCPtr) : tinyWRAPPINVOKE.ProxyAudioConsumer_startSwigExplicitProxyAudioConsumer(swigCPtr));
    return ret;
  }

  public virtual int pause() {
    int ret = ((this.GetType() == typeof(ProxyAudioConsumer)) ? tinyWRAPPINVOKE.ProxyAudioConsumer_pause(swigCPtr) : tinyWRAPPINVOKE.ProxyAudioConsumer_pauseSwigExplicitProxyAudioConsumer(swigCPtr));
    return ret;
  }

  public virtual int stop() {
    int ret = ((this.GetType() == typeof(ProxyAudioConsumer)) ? tinyWRAPPINVOKE.ProxyAudioConsumer_stop(swigCPtr) : tinyWRAPPINVOKE.ProxyAudioConsumer_stopSwigExplicitProxyAudioConsumer(swigCPtr));
    return ret;
  }

  public void setActivate(bool enabled) {
    tinyWRAPPINVOKE.ProxyAudioConsumer_setActivate(swigCPtr, enabled);
  }

  public uint pull(byte[] output, uint size) {
    uint ret = tinyWRAPPINVOKE.ProxyAudioConsumer_pull(swigCPtr, output, size);
    return ret;
  }

  public static bool registerPlugin() {
    bool ret = tinyWRAPPINVOKE.ProxyAudioConsumer_registerPlugin();
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("prepare", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateProxyAudioConsumer_0(SwigDirectorprepare);
    if (SwigDerivedClassHasMethod("start", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateProxyAudioConsumer_1(SwigDirectorstart);
    if (SwigDerivedClassHasMethod("pause", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateProxyAudioConsumer_2(SwigDirectorpause);
    if (SwigDerivedClassHasMethod("stop", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateProxyAudioConsumer_3(SwigDirectorstop);
    tinyWRAPPINVOKE.ProxyAudioConsumer_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ProxyAudioConsumer));
    return hasDerivedMethod;
  }

  private int SwigDirectorprepare(int ptime, int rate, int channels) {
    return prepare(ptime, rate, channels);
  }

  private int SwigDirectorstart() {
    return start();
  }

  private int SwigDirectorpause() {
    return pause();
  }

  private int SwigDirectorstop() {
    return stop();
  }

  public delegate int SwigDelegateProxyAudioConsumer_0(int ptime, int rate, int channels);
  public delegate int SwigDelegateProxyAudioConsumer_1();
  public delegate int SwigDelegateProxyAudioConsumer_2();
  public delegate int SwigDelegateProxyAudioConsumer_3();

  private SwigDelegateProxyAudioConsumer_0 swigDelegate0;
  private SwigDelegateProxyAudioConsumer_1 swigDelegate1;
  private SwigDelegateProxyAudioConsumer_2 swigDelegate2;
  private SwigDelegateProxyAudioConsumer_3 swigDelegate3;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(int), typeof(int), typeof(int) };
  private static Type[] swigMethodTypes1 = new Type[] {  };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] {  };
}
