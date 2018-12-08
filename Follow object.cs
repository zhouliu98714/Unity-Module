using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This is a simple code used for "following a certain object". I used this to create the
// third person camera. 
/*!
 *	----------------------------------------------------------------------
 *	
*/
public class SimpleFollowCam : MonoBehaviour
{
	[SerializeField] private Transform	m_Target		= null;
	[SerializeField] private float		m_FollowSpeed	= 6.0f;


	/*!
	*/
//	private void Start()
//	{
//	}

	/*!
	 *	----------------------------------------------------------------------
	*/
	private void FixedUpdate()
	{
		if( null == m_Target ) return;

		float followSpeed = (m_FollowSpeed * Time.deltaTime);
		Vector3 pos = this.transform.position;
		pos = Vector3.Lerp( pos, m_Target.position, followSpeed );
		this.transform.position = pos;
	}


}
