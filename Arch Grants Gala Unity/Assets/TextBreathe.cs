using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextBreathe : MonoBehaviour
{
    public float effectSpeed;
    
    [Range(0, 1)]
    public float alphaMin;

    [Range(0, 1)]
    public float alphaMax;

    public TextMeshProUGUI tapText;

    private float textAlpha;


    void Start()
    {
        textAlpha = tapText.faceColor.a;
        textAlpha = 0.0f;
    }


    void Update()
    {
        textAlpha = Mathf.PingPong(Time.time * effectSpeed, alphaMax);
        print(textAlpha);
    }
}
