using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowCommonEffects : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isOpening;
    public bool isClosing;
    public float speedAlpha;
    public float targetAlpha;
    public float defaultTime;
    void Start()
    {
        isOpening = false;
        isClosing = false;
        defaultTime = 0.5f;
        speedAlpha = 0;
        targetAlpha = 0;
        // gameObject.transform.GetComponent<UI>().alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // if (isOpening)
        // {
        //     gameObject.rectTransform.GetComponent<UI>().alpha += speedAlpha;
        //     if (gameObject.transform.GetComponent<UI>().alpha >= targetAlpha)
        //     {
        //         isOpening = false;
        //     }
        // }
        // if (isClosing)
        // {
        //     gameObject.transform.GetComponent<UI>().alpha -= speedAlpha;
        //     if (gameObject.transform.GetComponent<UI>().alpha <= targetAlpha)
        //     {
        //         isClosing = false;
        //     }
        // }
    }

    //淡入淡出效果
    // public void FadeIn(float opacity, float time)
    // {
    //     if (opacity > 1)
    //         opacity = 1;
    //     var curAlpha = gameObject.transform.GetComponent<UIPanel>().alpha;
    //     targetAlpha = (curAlpha < opacity) ? opacity : curAlpha;
    //     speedAlpha = opacity / time;
    //     Debug.Log("fadeIn:speedAlpha=" + speedAlpha);
    //     isClosing = false;
    //     if (isOpening) return;
    //     isOpening = true;
    // }
    // public void FadeOut(float opacity, float time)
    // {
    //     isOpening = false;
    //     if (opacity < 0)
    //         opacity = 0;
    //     var curAlpha = gameObject.transform.GetComponent<UIPanel>().alpha;
    //     targetAlpha = (curAlpha > opacity) ? opacity : curAlpha;
    //     speedAlpha = (gameObject.transform.GetComponent<UIPanel>().alpha - targetAlpha) / time;
    //     Debug.Log("fadeOut:speedAlpha=" + speedAlpha);
    //     if (isClosing) return;
    //     isClosing = true;
    // }
}
