using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]private bool isGround = false;
    private Rigidbody rb;
    public int HP = 100;
    public GameObject AttackArea;
    [SerializeField] float AttackTime;
    private float UnableToInputTime = 0.0f;
    public float MoveSpeed = 0.07f;

    // Start is called before the first frame update
    void Start()
    {
        AttackArea.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");    //マウスのx移動量
        float mouseY = Input.GetAxis("Mouse Y");    //マウスのy移動量
        if(Input.GetKey(KeyCode.S)) this.transform.Translate(0,0,-MoveSpeed);   //後退
        if(Input.GetKey(KeyCode.W)) this.transform.Translate(0,0,MoveSpeed);    //前進
        if(Input.GetKey(KeyCode.A)) this.transform.Translate(-MoveSpeed,0,0);   //左へ移動
        if(Input.GetKey(KeyCode.D)) this.transform.Translate(MoveSpeed,0,0);    //右へ移動

        if(isGround && Input.GetKeyDown("space")) rb.AddForce(new Vector3(0, 200, 0));

        //マウスを動かして視点移動
        if(Mathf.Abs(mouseX) > 0.001f) transform.RotateAround(this.transform.position, Vector3.up, mouseX);
        if(Mathf.Abs(mouseY) > 0.001f) transform.RotateAround(this.transform.position, Vector3.right, mouseY);

        if(Input.GetMouseButton(0) && UnableToInputTime <= 0.0f) UnableToInputTime = AttackTime;

        if(UnableToInputTime > AttackTime - 0.2f){
            AttackArea.SetActive(true);
            UnableToInputTime -= Time.deltaTime;
            // this.transform.rotation.z -= 0.1f;
        }else if(UnableToInputTime <= AttackTime - 0.2f && UnableToInputTime >= 0.0f){
            UnableToInputTime -= Time.deltaTime;
            AttackArea.SetActive(false);
            // this.transform.rotation.z -= 0.1f;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Ground" ) isGround = true;
    }
 
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Ground" ) isGround = false;
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Enemy") HP -=10;
    }

}
