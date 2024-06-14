using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door2 : MonoBehaviour
{
    public Text text;
    public Transform object1;
    public Transform object2;
    bool IsOpen = false;
    Animation ani;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animation>();
        text = text.GetComponent<Text>();
        text.color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float dis = Vector3.Distance(object1.position, object2.position);
        // Debug.Log(dis);
        if (dis < 2 && !IsOpen)
        {
            ani.Play("Open");
            IsOpen = true;

            text.text = "欢迎来到化学实验室";
            text.color = new Color(0, 0, 0, 1);
            // Debug.Log(1);
        }
        if (dis > 2 && IsOpen)
        {
            ani.Play("Close");
            IsOpen = false;
            text.color = new Color(0, 0, 0, 0);
        }

    }
}