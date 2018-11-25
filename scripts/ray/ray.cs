using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class ray : MonoBehaviour {



	Color lastcolor;

        Collider lastcollider;

	bool initial=true;

	// Update is called once per frame

	void Update () {

Ray ray = new Ray(transform.position, transform.forward * 100);

RaycastHit hit;		



if (Physics.Raycast(ray, out hit, 60)&&hit.collider.gameObject.tag=="book") { 

            if(initial){

            initial=false;

            lastcollider=hit.collider;

            lastcolor=hit.collider.  GetComponent<Renderer>().material.color;

}

            Color past=hit.collider.  GetComponent<Renderer>().material.color; 

            if(hit.collider != lastcollider){

            lastcollider.GetComponent<Renderer>().material.color = lastcolor;

            lastcolor=past;

            lastcollider=hit.collider;

}
     hit.collider.  GetComponent<Renderer>().material.color = Color.red;            

       GameObject gob = hit.collider.gameObject;
    
    if(Input.GetMouseButtonDown(0)){
      if(gob.name!=""){
         Application.OpenURL(gob.name);
   }

 }

}

else if(lastcollider){

     lastcollider.GetComponent<Renderer>().material.color = lastcolor;

}     


}

}
