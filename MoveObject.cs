using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A second way of payment by moving items to the check out location.

public class MoveObject : MonoBehaviour
{

    // three game objects connected for coherent movement
    public GameObject item; // the object we want to pick up
    public GameObject tempParent; // the one who picks up the object
    public Transform guide; // the movement

    void Start()
    {
        item.GetComponent<Rigidbody>().useGravity = false; // let the object remain where it is, otherwise
        // it will fall down due to the force of gravity
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown(){
        // while clicking the mouse, we move the object in our hand
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().isKinematic = true;
        item.transform.position = guide.transform.position;
        item.transform.rotation = guide.transform.rotation;
        item.transform.parent = tempParent.transform;
    }
    private void OnMouseUp()
    {
        // once we release the object, let the object falls down at its own will 
        item.GetComponent<Rigidbody>().useGravity = true;
        item.GetComponent<Rigidbody>().isKinematic = false;
        item.transform.parent = null;
        item.transform.position = guide.transform.position;
    }


}
