/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package touchvg.core;

public class MgCmdArcTan extends MgCmdArc3P {
  private long swigCPtr;

  protected MgCmdArcTan(long cPtr, boolean cMemoryOwn) {
    super(touchvgJNI.MgCmdArcTan_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(MgCmdArcTan obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        touchvgJNI.delete_MgCmdArcTan(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public MgCmdArcTan(String name) {
    this(touchvgJNI.new_MgCmdArcTan__SWIG_0(name), true);
  }

  public MgCmdArcTan() {
    this(touchvgJNI.new_MgCmdArcTan__SWIG_1(), true);
  }

  public static String Name() {
    return touchvgJNI.MgCmdArcTan_Name();
  }

  public static MgCommand Create() {
    long cPtr = touchvgJNI.MgCmdArcTan_Create();
    return (cPtr == 0) ? null : new MgCommand(cPtr, false);
  }

  public void release() {
    touchvgJNI.MgCmdArcTan_release(swigCPtr, this);
  }

}
