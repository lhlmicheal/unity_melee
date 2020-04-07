using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestSelfBtnEvent : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame updat

    public void OnPointerClick(PointerEventData pointerEvent)
    {
        if (pointerEvent.button == PointerEventData.InputButton.Right)
        {
            Debug.Log("testSelfBtnEvent:_inputPoint_right");
        }
        if (pointerEvent.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("testSelfBtnEvent:_inputPoint_Left");
        }
    }
}
