using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour {
        float speed = 6.0f;
        float rspeed = 6.0f;
	private Transform camTrans;
        private Vector3 camAng;
        
       // Use this for initialization
	void Start () {
        Screen.showCursor = false;
 Screen.lockCursor = true;
        transform.position=new Vector3(50,30,20);
        camTrans = transform;
Vector3 startPos = transform.position;

camTrans.position = startPos;
camTrans.rotation = transform.rotation;
camAng = camTrans.eulerAngles;
        

	}


	
	
	void Update () {
	

       
        CharacterController controller = (CharacterController)base.GetComponent(typeof(CharacterController));
        float y = Input.GetAxis("Mouse X")*rspeed;
float x = Input.GetAxis("Mouse Y")*rspeed;
camAng.x -= x;
camAng.y += y;
camTrans.eulerAngles = camAng;
camTrans.position = new Vector3(this.transform.position.x,camTrans.position.y,this.transform.position.z);
float camy=camAng.y;
this.transform.eulerAngles=new Vector3(this.transform.eulerAngles.x,camy,this.transform.eulerAngles.z);
Vector3 startPos = transform.position;

camTrans.position = startPos;
        
        Vector3 hori = transform.TransformDirection(Vector3.right);
        
        float curSpeed = speed * Input.GetAxis("Horizontal");
        
        controller.SimpleMove(hori * curSpeed);

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        
         curSpeed = speed * Input.GetAxis("Vertical");
        
        controller.SimpleMove(forward * curSpeed);

       	 
      
   

	
      
}
}