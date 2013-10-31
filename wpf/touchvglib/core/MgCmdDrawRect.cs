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

public class MgCmdDrawRect : MgCommandDraw {
  private HandleRef swigCPtr;

  internal MgCmdDrawRect(IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgCmdDrawRect_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgCmdDrawRect obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgCmdDrawRect() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgCmdDrawRect(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MgCmdDrawRect(string name) : this(touchvgPINVOKE.new_MgCmdDrawRect__SWIG_0(name), true) {
    SwigDirectorConnect();
  }

  public MgCmdDrawRect() : this(touchvgPINVOKE.new_MgCmdDrawRect__SWIG_1(), true) {
    SwigDirectorConnect();
  }

  public static string Name() {
    string ret = touchvgPINVOKE.MgCmdDrawRect_Name();
    return ret;
  }

  public static MgCommand Create() {
    IntPtr cPtr = touchvgPINVOKE.MgCmdDrawRect_Create();
    MgCommand ret = (cPtr == IntPtr.Zero) ? null : new MgCommand(cPtr, false);
    return ret;
  }

  public override void release() {
    if (SwigDerivedClassHasMethod("release", swigMethodTypes0)) touchvgPINVOKE.MgCmdDrawRect_releaseSwigExplicitMgCmdDrawRect(swigCPtr); else touchvgPINVOKE.MgCmdDrawRect_release(swigCPtr);
  }

  public override bool initialize(MgMotion sender, MgStorage s) {
    bool ret = (SwigDerivedClassHasMethod("initialize", swigMethodTypes2) ? touchvgPINVOKE.MgCmdDrawRect_initializeSwigExplicitMgCmdDrawRect(swigCPtr, MgMotion.getCPtr(sender), MgStorage.getCPtr(s)) : touchvgPINVOKE.MgCmdDrawRect_initialize(swigCPtr, MgMotion.getCPtr(sender), MgStorage.getCPtr(s)));
    return ret;
  }

  public override bool backStep(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("backStep", swigMethodTypes3) ? touchvgPINVOKE.MgCmdDrawRect_backStepSwigExplicitMgCmdDrawRect(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCmdDrawRect_backStep(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool touchBegan(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("touchBegan", swigMethodTypes9) ? touchvgPINVOKE.MgCmdDrawRect_touchBeganSwigExplicitMgCmdDrawRect(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCmdDrawRect_touchBegan(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool touchMoved(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("touchMoved", swigMethodTypes10) ? touchvgPINVOKE.MgCmdDrawRect_touchMovedSwigExplicitMgCmdDrawRect(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCmdDrawRect_touchMoved(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool touchEnded(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("touchEnded", swigMethodTypes11) ? touchvgPINVOKE.MgCmdDrawRect_touchEndedSwigExplicitMgCmdDrawRect(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCmdDrawRect_touchEnded(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  protected virtual void addRectShape(MgMotion sender) {
    if (SwigDerivedClassHasMethod("addRectShape", swigMethodTypes20)) touchvgPINVOKE.MgCmdDrawRect_addRectShapeSwigExplicitMgCmdDrawRect(swigCPtr, MgMotion.getCPtr(sender)); else touchvgPINVOKE.MgCmdDrawRect_addRectShape(swigCPtr, MgMotion.getCPtr(sender));
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("release", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateMgCmdDrawRect_0(SwigDirectorrelease);
    if (SwigDerivedClassHasMethod("cancel", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateMgCmdDrawRect_1(SwigDirectorcancel);
    if (SwigDerivedClassHasMethod("initialize", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateMgCmdDrawRect_2(SwigDirectorinitialize);
    if (SwigDerivedClassHasMethod("backStep", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateMgCmdDrawRect_3(SwigDirectorbackStep);
    if (SwigDerivedClassHasMethod("draw", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateMgCmdDrawRect_4(SwigDirectordraw);
    if (SwigDerivedClassHasMethod("gatherShapes", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateMgCmdDrawRect_5(SwigDirectorgatherShapes);
    if (SwigDerivedClassHasMethod("click", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateMgCmdDrawRect_6(SwigDirectorclick);
    if (SwigDerivedClassHasMethod("doubleClick", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateMgCmdDrawRect_7(SwigDirectordoubleClick);
    if (SwigDerivedClassHasMethod("longPress", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateMgCmdDrawRect_8(SwigDirectorlongPress);
    if (SwigDerivedClassHasMethod("touchBegan", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateMgCmdDrawRect_9(SwigDirectortouchBegan);
    if (SwigDerivedClassHasMethod("touchMoved", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateMgCmdDrawRect_10(SwigDirectortouchMoved);
    if (SwigDerivedClassHasMethod("touchEnded", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateMgCmdDrawRect_11(SwigDirectortouchEnded);
    if (SwigDerivedClassHasMethod("mouseHover", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateMgCmdDrawRect_12(SwigDirectormouseHover);
    if (SwigDerivedClassHasMethod("twoFingersMove", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateMgCmdDrawRect_13(SwigDirectortwoFingersMove);
    if (SwigDerivedClassHasMethod("isDrawingCommand", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateMgCmdDrawRect_14(SwigDirectorisDrawingCommand);
    if (SwigDerivedClassHasMethod("isFloatingCommand", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateMgCmdDrawRect_15(SwigDirectorisFloatingCommand);
    if (SwigDerivedClassHasMethod("doContextAction", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateMgCmdDrawRect_16(SwigDirectordoContextAction);
    if (SwigDerivedClassHasMethod("getShapeType", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateMgCmdDrawRect_17(SwigDirectorgetShapeType);
    if (SwigDerivedClassHasMethod("getMaxStep", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateMgCmdDrawRect_18(SwigDirectorgetMaxStep);
    if (SwigDerivedClassHasMethod("setStepPoint", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateMgCmdDrawRect_19(SwigDirectorsetStepPoint);
    if (SwigDerivedClassHasMethod("addRectShape", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateMgCmdDrawRect_20(SwigDirectoraddRectShape);
    touchvgPINVOKE.MgCmdDrawRect_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(MgCmdDrawRect));
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

  private int SwigDirectorgetShapeType() {
    return getShapeType();
  }

  private int SwigDirectorgetMaxStep() {
    return getMaxStep();
  }

  private void SwigDirectorsetStepPoint(int step, IntPtr pt) {
    setStepPoint(step, new Point2d(pt, false));
  }

  private void SwigDirectoraddRectShape(IntPtr sender) {
    addRectShape((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  public delegate void SwigDelegateMgCmdDrawRect_0();
  public delegate bool SwigDelegateMgCmdDrawRect_1(IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_2(IntPtr sender, IntPtr s);
  public delegate bool SwigDelegateMgCmdDrawRect_3(IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_4(IntPtr sender, IntPtr gs);
  public delegate int SwigDelegateMgCmdDrawRect_5(IntPtr sender, IntPtr shapes);
  public delegate bool SwigDelegateMgCmdDrawRect_6(IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_7(IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_8(IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_9(IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_10(IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_11(IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_12(IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_13(IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_14();
  public delegate bool SwigDelegateMgCmdDrawRect_15();
  public delegate bool SwigDelegateMgCmdDrawRect_16(IntPtr sender, int action);
  public delegate int SwigDelegateMgCmdDrawRect_17();
  public delegate int SwigDelegateMgCmdDrawRect_18();
  public delegate void SwigDelegateMgCmdDrawRect_19(int step, IntPtr pt);
  public delegate void SwigDelegateMgCmdDrawRect_20(IntPtr sender);

  private SwigDelegateMgCmdDrawRect_0 swigDelegate0;
  private SwigDelegateMgCmdDrawRect_1 swigDelegate1;
  private SwigDelegateMgCmdDrawRect_2 swigDelegate2;
  private SwigDelegateMgCmdDrawRect_3 swigDelegate3;
  private SwigDelegateMgCmdDrawRect_4 swigDelegate4;
  private SwigDelegateMgCmdDrawRect_5 swigDelegate5;
  private SwigDelegateMgCmdDrawRect_6 swigDelegate6;
  private SwigDelegateMgCmdDrawRect_7 swigDelegate7;
  private SwigDelegateMgCmdDrawRect_8 swigDelegate8;
  private SwigDelegateMgCmdDrawRect_9 swigDelegate9;
  private SwigDelegateMgCmdDrawRect_10 swigDelegate10;
  private SwigDelegateMgCmdDrawRect_11 swigDelegate11;
  private SwigDelegateMgCmdDrawRect_12 swigDelegate12;
  private SwigDelegateMgCmdDrawRect_13 swigDelegate13;
  private SwigDelegateMgCmdDrawRect_14 swigDelegate14;
  private SwigDelegateMgCmdDrawRect_15 swigDelegate15;
  private SwigDelegateMgCmdDrawRect_16 swigDelegate16;
  private SwigDelegateMgCmdDrawRect_17 swigDelegate17;
  private SwigDelegateMgCmdDrawRect_18 swigDelegate18;
  private SwigDelegateMgCmdDrawRect_19 swigDelegate19;
  private SwigDelegateMgCmdDrawRect_20 swigDelegate20;

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
  private static Type[] swigMethodTypes17 = new Type[] {  };
  private static Type[] swigMethodTypes18 = new Type[] {  };
  private static Type[] swigMethodTypes19 = new Type[] { typeof(int), typeof(Point2d) };
  private static Type[] swigMethodTypes20 = new Type[] { typeof(MgMotion) };
}

}
