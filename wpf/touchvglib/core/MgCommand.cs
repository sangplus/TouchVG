/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

using System;
using System.Runtime.InteropServices;

public class MgCommand : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MgCommand(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgCommand obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgCommand() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgCommand(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public MgCommand(string name) : this(touchvgPINVOKE.new_MgCommand(name), true) {
    SwigDirectorConnect();
  }

  public string getName() {
    string ret = touchvgPINVOKE.MgCommand_getName(swigCPtr);
    return ret;
  }

  public virtual void release() {
    touchvgPINVOKE.MgCommand_release(swigCPtr);
  }

  public virtual bool cancel(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("cancel", swigMethodTypes1) ? touchvgPINVOKE.MgCommand_cancelSwigExplicitMgCommand(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommand_cancel(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public virtual bool initialize(MgMotion sender, MgStorage s) {
    bool ret = (SwigDerivedClassHasMethod("initialize", swigMethodTypes2) ? touchvgPINVOKE.MgCommand_initializeSwigExplicitMgCommand(swigCPtr, MgMotion.getCPtr(sender), MgStorage.getCPtr(s)) : touchvgPINVOKE.MgCommand_initialize(swigCPtr, MgMotion.getCPtr(sender), MgStorage.getCPtr(s)));
    return ret;
  }

  public virtual bool backStep(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("backStep", swigMethodTypes3) ? touchvgPINVOKE.MgCommand_backStepSwigExplicitMgCommand(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommand_backStep(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public virtual bool draw(MgMotion sender, GiGraphics gs) {
    bool ret = touchvgPINVOKE.MgCommand_draw(swigCPtr, MgMotion.getCPtr(sender), GiGraphics.getCPtr(gs));
    return ret;
  }

  public virtual int gatherShapes(MgMotion sender, MgShapes shapes) {
    int ret = (SwigDerivedClassHasMethod("gatherShapes", swigMethodTypes5) ? touchvgPINVOKE.MgCommand_gatherShapesSwigExplicitMgCommand(swigCPtr, MgMotion.getCPtr(sender), MgShapes.getCPtr(shapes)) : touchvgPINVOKE.MgCommand_gatherShapes(swigCPtr, MgMotion.getCPtr(sender), MgShapes.getCPtr(shapes)));
    return ret;
  }

  public virtual bool click(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("click", swigMethodTypes6) ? touchvgPINVOKE.MgCommand_clickSwigExplicitMgCommand(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommand_click(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public virtual bool doubleClick(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("doubleClick", swigMethodTypes7) ? touchvgPINVOKE.MgCommand_doubleClickSwigExplicitMgCommand(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommand_doubleClick(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public virtual bool longPress(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("longPress", swigMethodTypes8) ? touchvgPINVOKE.MgCommand_longPressSwigExplicitMgCommand(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommand_longPress(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public virtual bool touchBegan(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("touchBegan", swigMethodTypes9) ? touchvgPINVOKE.MgCommand_touchBeganSwigExplicitMgCommand(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommand_touchBegan(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public virtual bool touchMoved(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("touchMoved", swigMethodTypes10) ? touchvgPINVOKE.MgCommand_touchMovedSwigExplicitMgCommand(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommand_touchMoved(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public virtual bool touchEnded(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("touchEnded", swigMethodTypes11) ? touchvgPINVOKE.MgCommand_touchEndedSwigExplicitMgCommand(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommand_touchEnded(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public virtual bool mouseHover(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("mouseHover", swigMethodTypes12) ? touchvgPINVOKE.MgCommand_mouseHoverSwigExplicitMgCommand(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommand_mouseHover(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public virtual bool twoFingersMove(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("twoFingersMove", swigMethodTypes13) ? touchvgPINVOKE.MgCommand_twoFingersMoveSwigExplicitMgCommand(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommand_twoFingersMove(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public virtual bool isDrawingCommand() {
    bool ret = (SwigDerivedClassHasMethod("isDrawingCommand", swigMethodTypes14) ? touchvgPINVOKE.MgCommand_isDrawingCommandSwigExplicitMgCommand(swigCPtr) : touchvgPINVOKE.MgCommand_isDrawingCommand(swigCPtr));
    return ret;
  }

  public virtual bool isFloatingCommand() {
    bool ret = (SwigDerivedClassHasMethod("isFloatingCommand", swigMethodTypes15) ? touchvgPINVOKE.MgCommand_isFloatingCommandSwigExplicitMgCommand(swigCPtr) : touchvgPINVOKE.MgCommand_isFloatingCommand(swigCPtr));
    return ret;
  }

  public virtual bool doContextAction(MgMotion sender, int action) {
    bool ret = (SwigDerivedClassHasMethod("doContextAction", swigMethodTypes16) ? touchvgPINVOKE.MgCommand_doContextActionSwigExplicitMgCommand(swigCPtr, MgMotion.getCPtr(sender), action) : touchvgPINVOKE.MgCommand_doContextAction(swigCPtr, MgMotion.getCPtr(sender), action));
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("release", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateMgCommand_0(SwigDirectorrelease);
    if (SwigDerivedClassHasMethod("cancel", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateMgCommand_1(SwigDirectorcancel);
    if (SwigDerivedClassHasMethod("initialize", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateMgCommand_2(SwigDirectorinitialize);
    if (SwigDerivedClassHasMethod("backStep", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateMgCommand_3(SwigDirectorbackStep);
    if (SwigDerivedClassHasMethod("draw", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateMgCommand_4(SwigDirectordraw);
    if (SwigDerivedClassHasMethod("gatherShapes", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateMgCommand_5(SwigDirectorgatherShapes);
    if (SwigDerivedClassHasMethod("click", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateMgCommand_6(SwigDirectorclick);
    if (SwigDerivedClassHasMethod("doubleClick", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateMgCommand_7(SwigDirectordoubleClick);
    if (SwigDerivedClassHasMethod("longPress", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateMgCommand_8(SwigDirectorlongPress);
    if (SwigDerivedClassHasMethod("touchBegan", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateMgCommand_9(SwigDirectortouchBegan);
    if (SwigDerivedClassHasMethod("touchMoved", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateMgCommand_10(SwigDirectortouchMoved);
    if (SwigDerivedClassHasMethod("touchEnded", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateMgCommand_11(SwigDirectortouchEnded);
    if (SwigDerivedClassHasMethod("mouseHover", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateMgCommand_12(SwigDirectormouseHover);
    if (SwigDerivedClassHasMethod("twoFingersMove", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateMgCommand_13(SwigDirectortwoFingersMove);
    if (SwigDerivedClassHasMethod("isDrawingCommand", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateMgCommand_14(SwigDirectorisDrawingCommand);
    if (SwigDerivedClassHasMethod("isFloatingCommand", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateMgCommand_15(SwigDirectorisFloatingCommand);
    if (SwigDerivedClassHasMethod("doContextAction", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateMgCommand_16(SwigDirectordoContextAction);
    touchvgPINVOKE.MgCommand_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(MgCommand));
    return hasDerivedMethod;
  }

  private void SwigDirectorrelease() {
    release();
  }

  private bool SwigDirectorcancel(IntPtr sender) {
    return cancel((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectorinitialize(IntPtr sender, IntPtr s) {
    return initialize((sender == IntPtr.Zero) ? null : new MgMotion(sender, false), (s == IntPtr.Zero) ? null : new MgStorage(s, false));
  }

  private bool SwigDirectorbackStep(IntPtr sender) {
    return backStep((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectordraw(IntPtr sender, IntPtr gs) {
    return draw((sender == IntPtr.Zero) ? null : new MgMotion(sender, false), (gs == IntPtr.Zero) ? null : new GiGraphics(gs, false));
  }

  private int SwigDirectorgatherShapes(IntPtr sender, IntPtr shapes) {
    return gatherShapes((sender == IntPtr.Zero) ? null : new MgMotion(sender, false), (shapes == IntPtr.Zero) ? null : new MgShapes(shapes, false));
  }

  private bool SwigDirectorclick(IntPtr sender) {
    return click((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectordoubleClick(IntPtr sender) {
    return doubleClick((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectorlongPress(IntPtr sender) {
    return longPress((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortouchBegan(IntPtr sender) {
    return touchBegan((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortouchMoved(IntPtr sender) {
    return touchMoved((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortouchEnded(IntPtr sender) {
    return touchEnded((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectormouseHover(IntPtr sender) {
    return mouseHover((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortwoFingersMove(IntPtr sender) {
    return twoFingersMove((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectorisDrawingCommand() {
    return isDrawingCommand();
  }

  private bool SwigDirectorisFloatingCommand() {
    return isFloatingCommand();
  }

  private bool SwigDirectordoContextAction(IntPtr sender, int action) {
    return doContextAction((sender == IntPtr.Zero) ? null : new MgMotion(sender, false), action);
  }

  public delegate void SwigDelegateMgCommand_0();
  public delegate bool SwigDelegateMgCommand_1(IntPtr sender);
  public delegate bool SwigDelegateMgCommand_2(IntPtr sender, IntPtr s);
  public delegate bool SwigDelegateMgCommand_3(IntPtr sender);
  public delegate bool SwigDelegateMgCommand_4(IntPtr sender, IntPtr gs);
  public delegate int SwigDelegateMgCommand_5(IntPtr sender, IntPtr shapes);
  public delegate bool SwigDelegateMgCommand_6(IntPtr sender);
  public delegate bool SwigDelegateMgCommand_7(IntPtr sender);
  public delegate bool SwigDelegateMgCommand_8(IntPtr sender);
  public delegate bool SwigDelegateMgCommand_9(IntPtr sender);
  public delegate bool SwigDelegateMgCommand_10(IntPtr sender);
  public delegate bool SwigDelegateMgCommand_11(IntPtr sender);
  public delegate bool SwigDelegateMgCommand_12(IntPtr sender);
  public delegate bool SwigDelegateMgCommand_13(IntPtr sender);
  public delegate bool SwigDelegateMgCommand_14();
  public delegate bool SwigDelegateMgCommand_15();
  public delegate bool SwigDelegateMgCommand_16(IntPtr sender, int action);

  private SwigDelegateMgCommand_0 swigDelegate0;
  private SwigDelegateMgCommand_1 swigDelegate1;
  private SwigDelegateMgCommand_2 swigDelegate2;
  private SwigDelegateMgCommand_3 swigDelegate3;
  private SwigDelegateMgCommand_4 swigDelegate4;
  private SwigDelegateMgCommand_5 swigDelegate5;
  private SwigDelegateMgCommand_6 swigDelegate6;
  private SwigDelegateMgCommand_7 swigDelegate7;
  private SwigDelegateMgCommand_8 swigDelegate8;
  private SwigDelegateMgCommand_9 swigDelegate9;
  private SwigDelegateMgCommand_10 swigDelegate10;
  private SwigDelegateMgCommand_11 swigDelegate11;
  private SwigDelegateMgCommand_12 swigDelegate12;
  private SwigDelegateMgCommand_13 swigDelegate13;
  private SwigDelegateMgCommand_14 swigDelegate14;
  private SwigDelegateMgCommand_15 swigDelegate15;
  private SwigDelegateMgCommand_16 swigDelegate16;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes2 = new Type[] { typeof(MgMotion), typeof(MgStorage) };
  private static Type[] swigMethodTypes3 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes4 = new Type[] { typeof(MgMotion), typeof(GiGraphics) };
  private static Type[] swigMethodTypes5 = new Type[] { typeof(MgMotion), typeof(MgShapes) };
  private static Type[] swigMethodTypes6 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes7 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes8 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes9 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes10 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes11 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes12 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes13 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes14 = new Type[] {  };
  private static Type[] swigMethodTypes15 = new Type[] {  };
  private static Type[] swigMethodTypes16 = new Type[] { typeof(MgMotion), typeof(int) };
}

}
