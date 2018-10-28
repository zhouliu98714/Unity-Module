using System.Collections;
using UnityEngine;

public class Door : MonoBehaviour {

    public Animation anim;
    private int m_LastIndex;
	public void PlayDoorAnim () {
        if (!anim.isPlaying)
        {
            if(m_LastIndex == 0)
            {
                anim.Play("DoorOpen");
                m_LastIndex = 1;
            } else
            {
                anim.Play("DoorClose");
                m_LastIndex = 0;
            }
        }
	}
}
