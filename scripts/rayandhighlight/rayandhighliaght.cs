using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayandhighliaght : MonoBehaviour {

	Color lastcolor;
        Collider lastcollider;
	bool initial=true;
	// Update is called once per frame
	void Update () {
Ray ray = new Ray(transform.position, transform.forward * 100);
RaycastHit hit;		

if (Physics.Raycast(ray, out hit, 30)) { 
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
            
        Color lightred=Color.red;
           
 hit.collider.  renderer.material.color = lightred;            

              
}
else if(lastcollider){
     lastcollider.renderer.material.color = lastcolor;
}     
	}
}
