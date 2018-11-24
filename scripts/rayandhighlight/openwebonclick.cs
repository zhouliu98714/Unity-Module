using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class rayandhighlight : MonoBehaviour {



	Color lastcolor;

        Collider lastcollider;

	bool initial=true;

	// Update is called once per frame

	void Update () {

Ray ray = new Ray(transform.position, transform.forward * 100);

RaycastHit hit;		



if (Physics.Raycast(ray, out hit, 60)) { 

            if(initial){

            initial=false;

            lastcollider=hit.collider;

            lastcolor=hit.collider.  renderer.material.color;

}

            Color past=hit.collider.  renderer.material.color; 

            if(hit.collider != lastcollider){

            lastcollider.renderer.material.color = lastcolor;

            lastcolor=past;

            lastcollider=hit.collider;

}
 hit.collider.  renderer.material.color = Color.red;            

GameObject gob = hit.collider.gameObject;
if(Input.GetMouseButton(0)){
      if(gob.tag!=""){
         Application.OpenURL(gob.tag);
}

}

}

else if(lastcollider){

     lastcollider.renderer.material.color = lastcolor;

}     


}

}
