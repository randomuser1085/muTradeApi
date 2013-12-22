/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class TradeQue : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TradeQue(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TradeQue obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TradeQue() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ContextModulePINVOKE.delete_TradeQue(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public bool empty() {
    bool ret = ContextModulePINVOKE.TradeQue_empty(swigCPtr);
    return ret;
  }

  public TradeQue() : this(ContextModulePINVOKE.new_TradeQue__SWIG_0(), true) {
  }

  public TradeQue(uint size, Trade value) : this(ContextModulePINVOKE.new_TradeQue__SWIG_1(size, Trade.getCPtr(value)), true) {
  }

  public TradeQue(uint size) : this(ContextModulePINVOKE.new_TradeQue__SWIG_2(size), true) {
  }

  public TradeQue(TradeQue arg0) : this(ContextModulePINVOKE.new_TradeQue__SWIG_3(TradeQue.getCPtr(arg0)), true) {
    if (ContextModulePINVOKE.SWIGPendingException.Pending) throw ContextModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void assign(uint n, Trade value) {
    ContextModulePINVOKE.TradeQue_assign(swigCPtr, n, Trade.getCPtr(value));
  }

  public void swap(TradeQue x) {
    ContextModulePINVOKE.TradeQue_swap(swigCPtr, TradeQue.getCPtr(x));
    if (ContextModulePINVOKE.SWIGPendingException.Pending) throw ContextModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint size() {
    uint ret = ContextModulePINVOKE.TradeQue_size(swigCPtr);
    return ret;
  }

  public uint max_size() {
    uint ret = ContextModulePINVOKE.TradeQue_max_size(swigCPtr);
    return ret;
  }

  public void resize(uint n, Trade c) {
    ContextModulePINVOKE.TradeQue_resize__SWIG_0(swigCPtr, n, Trade.getCPtr(c));
  }

  public void resize(uint n) {
    ContextModulePINVOKE.TradeQue_resize__SWIG_1(swigCPtr, n);
  }

  public Trade front() {
    IntPtr cPtr = ContextModulePINVOKE.TradeQue_front(swigCPtr);
    Trade ret = (cPtr == IntPtr.Zero) ? null : new Trade(cPtr, false);
    return ret;
  }

  public Trade back() {
    IntPtr cPtr = ContextModulePINVOKE.TradeQue_back(swigCPtr);
    Trade ret = (cPtr == IntPtr.Zero) ? null : new Trade(cPtr, false);
    return ret;
  }

  public void push_front(Trade x) {
    ContextModulePINVOKE.TradeQue_push_front(swigCPtr, Trade.getCPtr(x));
  }

  public void push_back(Trade x) {
    ContextModulePINVOKE.TradeQue_push_back(swigCPtr, Trade.getCPtr(x));
  }

  public void pop_front() {
    ContextModulePINVOKE.TradeQue_pop_front(swigCPtr);
  }

  public void pop_back() {
    ContextModulePINVOKE.TradeQue_pop_back(swigCPtr);
  }

  public void clear() {
    ContextModulePINVOKE.TradeQue_clear(swigCPtr);
  }

  public Trade getitem(int i) {
    IntPtr cPtr = ContextModulePINVOKE.TradeQue_getitem(swigCPtr, i);
    Trade ret = (cPtr == IntPtr.Zero) ? null : new Trade(cPtr, false);
    if (ContextModulePINVOKE.SWIGPendingException.Pending) throw ContextModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setitem(int i, Trade x) {
    ContextModulePINVOKE.TradeQue_setitem(swigCPtr, i, Trade.getCPtr(x));
    if (ContextModulePINVOKE.SWIGPendingException.Pending) throw ContextModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void delitem(int i) {
    ContextModulePINVOKE.TradeQue_delitem(swigCPtr, i);
    if (ContextModulePINVOKE.SWIGPendingException.Pending) throw ContextModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public TradeQue getslice(int i, int j) {
    TradeQue ret = new TradeQue(ContextModulePINVOKE.TradeQue_getslice(swigCPtr, i, j), true);
    return ret;
  }

  public void setslice(int i, int j, TradeQue v) {
    ContextModulePINVOKE.TradeQue_setslice(swigCPtr, i, j, TradeQue.getCPtr(v));
    if (ContextModulePINVOKE.SWIGPendingException.Pending) throw ContextModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void delslice(int i, int j) {
    ContextModulePINVOKE.TradeQue_delslice(swigCPtr, i, j);
  }

}