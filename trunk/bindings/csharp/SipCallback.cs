/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class SipCallback : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SipCallback(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SipCallback obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~SipCallback() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        tinyWRAPPINVOKE.delete_SipCallback(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public SipCallback() : this(tinyWRAPPINVOKE.new_SipCallback(), true) {
    SwigDirectorConnect();
  }

  public virtual int OnDialogEvent(DialogEvent e) {
    int ret = ((this.GetType() == typeof(SipCallback)) ? tinyWRAPPINVOKE.SipCallback_OnDialogEvent(swigCPtr, DialogEvent.getCPtr(e)) : tinyWRAPPINVOKE.SipCallback_OnDialogEventSwigExplicitSipCallback(swigCPtr, DialogEvent.getCPtr(e)));
    return ret;
  }

  public virtual int OnStackEvent(StackEvent e) {
    int ret = ((this.GetType() == typeof(SipCallback)) ? tinyWRAPPINVOKE.SipCallback_OnStackEvent(swigCPtr, StackEvent.getCPtr(e)) : tinyWRAPPINVOKE.SipCallback_OnStackEventSwigExplicitSipCallback(swigCPtr, StackEvent.getCPtr(e)));
    return ret;
  }

  public virtual int OnCallEvent(CallEvent e) {
    int ret = ((this.GetType() == typeof(SipCallback)) ? tinyWRAPPINVOKE.SipCallback_OnCallEvent(swigCPtr, CallEvent.getCPtr(e)) : tinyWRAPPINVOKE.SipCallback_OnCallEventSwigExplicitSipCallback(swigCPtr, CallEvent.getCPtr(e)));
    return ret;
  }

  public virtual int OnMessagingEvent(MessagingEvent e) {
    int ret = ((this.GetType() == typeof(SipCallback)) ? tinyWRAPPINVOKE.SipCallback_OnMessagingEvent(swigCPtr, MessagingEvent.getCPtr(e)) : tinyWRAPPINVOKE.SipCallback_OnMessagingEventSwigExplicitSipCallback(swigCPtr, MessagingEvent.getCPtr(e)));
    return ret;
  }

  public virtual int OnOptionsEvent(OptionsEvent e) {
    int ret = ((this.GetType() == typeof(SipCallback)) ? tinyWRAPPINVOKE.SipCallback_OnOptionsEvent(swigCPtr, OptionsEvent.getCPtr(e)) : tinyWRAPPINVOKE.SipCallback_OnOptionsEventSwigExplicitSipCallback(swigCPtr, OptionsEvent.getCPtr(e)));
    return ret;
  }

  public virtual int OnPublicationEvent(PublicationEvent e) {
    int ret = ((this.GetType() == typeof(SipCallback)) ? tinyWRAPPINVOKE.SipCallback_OnPublicationEvent(swigCPtr, PublicationEvent.getCPtr(e)) : tinyWRAPPINVOKE.SipCallback_OnPublicationEventSwigExplicitSipCallback(swigCPtr, PublicationEvent.getCPtr(e)));
    return ret;
  }

  public virtual int OnRegistrationEvent(RegistrationEvent e) {
    int ret = ((this.GetType() == typeof(SipCallback)) ? tinyWRAPPINVOKE.SipCallback_OnRegistrationEvent(swigCPtr, RegistrationEvent.getCPtr(e)) : tinyWRAPPINVOKE.SipCallback_OnRegistrationEventSwigExplicitSipCallback(swigCPtr, RegistrationEvent.getCPtr(e)));
    return ret;
  }

  public virtual int OnSubscriptionEvent(SubscriptionEvent e) {
    int ret = ((this.GetType() == typeof(SipCallback)) ? tinyWRAPPINVOKE.SipCallback_OnSubscriptionEvent(swigCPtr, SubscriptionEvent.getCPtr(e)) : tinyWRAPPINVOKE.SipCallback_OnSubscriptionEventSwigExplicitSipCallback(swigCPtr, SubscriptionEvent.getCPtr(e)));
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnDialogEvent", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateSipCallback_0(SwigDirectorOnDialogEvent);
    if (SwigDerivedClassHasMethod("OnStackEvent", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateSipCallback_1(SwigDirectorOnStackEvent);
    if (SwigDerivedClassHasMethod("OnCallEvent", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateSipCallback_2(SwigDirectorOnCallEvent);
    if (SwigDerivedClassHasMethod("OnMessagingEvent", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateSipCallback_3(SwigDirectorOnMessagingEvent);
    if (SwigDerivedClassHasMethod("OnOptionsEvent", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateSipCallback_4(SwigDirectorOnOptionsEvent);
    if (SwigDerivedClassHasMethod("OnPublicationEvent", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateSipCallback_5(SwigDirectorOnPublicationEvent);
    if (SwigDerivedClassHasMethod("OnRegistrationEvent", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateSipCallback_6(SwigDirectorOnRegistrationEvent);
    if (SwigDerivedClassHasMethod("OnSubscriptionEvent", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateSipCallback_7(SwigDirectorOnSubscriptionEvent);
    tinyWRAPPINVOKE.SipCallback_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(SipCallback));
    return hasDerivedMethod;
  }

  private int SwigDirectorOnDialogEvent(IntPtr e) {
    return OnDialogEvent((e == IntPtr.Zero) ? null : new DialogEvent(e, false));
  }

  private int SwigDirectorOnStackEvent(IntPtr e) {
    return OnStackEvent((e == IntPtr.Zero) ? null : new StackEvent(e, false));
  }

  private int SwigDirectorOnCallEvent(IntPtr e) {
    return OnCallEvent((e == IntPtr.Zero) ? null : new CallEvent(e, false));
  }

  private int SwigDirectorOnMessagingEvent(IntPtr e) {
    return OnMessagingEvent((e == IntPtr.Zero) ? null : new MessagingEvent(e, false));
  }

  private int SwigDirectorOnOptionsEvent(IntPtr e) {
    return OnOptionsEvent((e == IntPtr.Zero) ? null : new OptionsEvent(e, false));
  }

  private int SwigDirectorOnPublicationEvent(IntPtr e) {
    return OnPublicationEvent((e == IntPtr.Zero) ? null : new PublicationEvent(e, false));
  }

  private int SwigDirectorOnRegistrationEvent(IntPtr e) {
    return OnRegistrationEvent((e == IntPtr.Zero) ? null : new RegistrationEvent(e, false));
  }

  private int SwigDirectorOnSubscriptionEvent(IntPtr e) {
    return OnSubscriptionEvent((e == IntPtr.Zero) ? null : new SubscriptionEvent(e, false));
  }

  public delegate int SwigDelegateSipCallback_0(IntPtr e);
  public delegate int SwigDelegateSipCallback_1(IntPtr e);
  public delegate int SwigDelegateSipCallback_2(IntPtr e);
  public delegate int SwigDelegateSipCallback_3(IntPtr e);
  public delegate int SwigDelegateSipCallback_4(IntPtr e);
  public delegate int SwigDelegateSipCallback_5(IntPtr e);
  public delegate int SwigDelegateSipCallback_6(IntPtr e);
  public delegate int SwigDelegateSipCallback_7(IntPtr e);

  private SwigDelegateSipCallback_0 swigDelegate0;
  private SwigDelegateSipCallback_1 swigDelegate1;
  private SwigDelegateSipCallback_2 swigDelegate2;
  private SwigDelegateSipCallback_3 swigDelegate3;
  private SwigDelegateSipCallback_4 swigDelegate4;
  private SwigDelegateSipCallback_5 swigDelegate5;
  private SwigDelegateSipCallback_6 swigDelegate6;
  private SwigDelegateSipCallback_7 swigDelegate7;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(DialogEvent) };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(StackEvent) };
  private static Type[] swigMethodTypes2 = new Type[] { typeof(CallEvent) };
  private static Type[] swigMethodTypes3 = new Type[] { typeof(MessagingEvent) };
  private static Type[] swigMethodTypes4 = new Type[] { typeof(OptionsEvent) };
  private static Type[] swigMethodTypes5 = new Type[] { typeof(PublicationEvent) };
  private static Type[] swigMethodTypes6 = new Type[] { typeof(RegistrationEvent) };
  private static Type[] swigMethodTypes7 = new Type[] { typeof(SubscriptionEvent) };
}
