using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CustomTriggerEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void selfOnclick()
    {
        Debug.Log("selfOnclick");
    }
    public void selfPointEnter()
    {
        Debug.Log("_selfPointEnter");
    }

    public void selfPointExit()
    {
        Debug.Log("_selfPointExit");
    }

    public void selfPointUp()
    {
        Debug.Log("_selfPointUp");
    }

    public void selfPointDown()
    {
        Debug.Log("_selfPointDown");
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("_TriggerEvent:_Enter=");
        PointerEventData.InputButton btn = eventData.button;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("_TriggerEvent:_Exit=");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("_TriggerEvent:_Up=");
        PointerEventData.InputButton btn = eventData.button;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("_TriggerEvent:_Down=");
        PointerEventData.InputButton btn = eventData.button;
    }

}
