using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIEventTrigger :EventTrigger {


    public delegate void Handler();
 
    //public static UIEventTrigger Get(GameObject go)
    //{
    //    UIEventTrigger trigger = go.GetComponent<UIEventTrigger>();
    //    if (trigger == null)
    //        trigger = go.AddComponent<UIEventTrigger>();
    //    return trigger;
    //}
    /// <summary>
    /// 当单击的时候
    /// </summary>
    public event Handler onClick;
    public override void OnPointerClick(PointerEventData eventData)
    {
        if (onClick != null)
            onClick();
    }
    /// <summary>
    /// 当拖拽的时候
    /// </summary>
    public event Handler onDrag;
    public override void OnDrag(PointerEventData eventData)
    {
        if (onDrag != null)
            onDrag();
    }
    /// <summary>
    /// 当开始拖拽的时候
    /// </summary>
    public event Handler onBeginDrag;
    public override void OnBeginDrag(PointerEventData eventData)
    {
        if (onBeginDrag != null)
            onBeginDrag();
    }
    /// <summary>
    /// 当选择的时候
    /// </summary>
    public event Handler onSelect;
    public override void OnSelect(BaseEventData eventData)
    {
        if (onSelect != null)
            onSelect();
    }


}
