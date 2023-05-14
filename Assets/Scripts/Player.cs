using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]private bool isGround = false;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");    //マウスのx移動量
        float mouseY = Input.GetAxis("Mouse Y");    //マウスのy移動量
        if(Input.GetKey(KeyCode.S)) this.transform.Translate(0,0,-0.1f);   //後退
        if(Input.GetKey(KeyCode.W)) this.transform.Translate(0,0,0.1f);    //前進
        if(Input.GetKey(KeyCode.A)) this.transform.Translate(-0.1f,0,0);   //左へ移動
        if(Input.GetKey(KeyCode.D)) this.transform.Translate(0.1f,0,0);    //右へ移動

        if(isGround && Input.GetKeyDown("space")) rb.AddForce(new Vector3(0, 200, 0));

        if(Mathf.Abs(mouseX) > 0.001f) transform.RotateAround(this.transform.position, Vector3.up, mouseX);
        if(Mathf.Abs(mouseY) > 0.001f) transform.RotateAround(this.transform.position, Vector3.right, mouseY);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Ground" ) isGround = true;
    }
 
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Ground" ) isGround = false;
    }

}
