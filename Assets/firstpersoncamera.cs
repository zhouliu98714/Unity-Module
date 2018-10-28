using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstpersoncamera : MonoBehaviour {
        float speed = 6.0f;
        float rspeed = 6.0f;
	// Use this for initialization
	void Start () {
	

	}


	
	
	void Update () {
	

       
        CharacterController controller = (CharacterController)base.GetComponent(typeof(CharacterController));
       
        transform.Rotate(0, Input.GetAxis("Horizontal") * rspeed, 0);
       

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        
        float curSpeed = speed * Input.GetAxis("Vertical");
        
        controller.SimpleMove(forward * curSpeed);

       	        

	}
}