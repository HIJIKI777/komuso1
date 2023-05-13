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
        if(Input.GetKey(KeyCode.S)) this.transform.Translate(0,0,-0.01f);   //後退
        if(Input.GetKey(KeyCode.W)) this.transform.Translate(0,0,0.01f);    //前進
        if(Input.GetKey(KeyCode.A)) this.transform.Translate(-0.01f,0,0);   //左へ移動
        if(Input.GetKey(KeyCode.D)) this.transform.Translate(0.01f,0,0);    //右へ移動

        if(isGround && Input.GetKeyDown("space")) rb.AddForce(new Vector3(0, 200, 0));
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
