using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    TextMeshProUGUI text;
    float theTime;
    public float speed = 1;
    bool playing = true;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

 
    // Update is called once per frame
    void Update()
    {
        if (playing == true)
        {
            theTime += Time.deltaTime * speed;
            string minutes = Mathf.Floor((theTime % 3600) / 60).ToString("00");
            string seconds = (theTime % 60).ToString("00");
            text.text = minutes + ":" + seconds;
        }
    }

    void Play()
    {
        playing = true;
    }

    void Stop()
    {
        playing = false;
    }
}
