using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syakuhati : MonoBehaviour
{

    float ShakingSyakuhatiTime = 0.0f;
    float UnableToInputTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && ShakingSyakuhatiTime <= 0.0f) ShakingSyakuhatiTime = UnableToInputTime;

        if(ShakingSyakuhatiTime >= 0.0f && ShakingSyakuhatiTime > UnableToInputTime / 2){
            ShakingSyakuhatiTime -= Time.deltaTime;
            // this.transform.rotation.z -= 0.1f;
            transform.RotateAround(this.transform.position, Vector3.right, 2.0f);
        }else if(ShakingSyakuhatiTime >= 0.0f && ShakingSyakuhatiTime <= UnableToInputTime / 2){
            ShakingSyakuhatiTime -= Time.deltaTime;
            // this.transform.rotation.z -= 0.1f;
            transform.RotateAround(this.transform.position, Vector3.right, -2.0f);
        }else this.transform.rotation = Quaternion.Euler(0,-83,205);

    }
}
