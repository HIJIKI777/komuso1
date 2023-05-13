using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");    //マウスのx移動量
        float mouseY = Input.GetAxis("Mouse Y");    //マウスのy移動量

        if(Mathf.Abs(mouseX) > 0.001f) transform.RotateAround(this.transform.position, Vector3.up, mouseX);
        if(Mathf.Abs(mouseY) > 0.001f) transform.RotateAround(this.transform.position, Vector3.right, mouseY);
    }
}
