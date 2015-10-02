using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public Transform target;
	public float xOffset;
	// I think this is not used.
    public float yOffsetValue;


    void Update()
	{
		transform.position = new Vector3 (target.position.x + xOffset, transform.position.y, transform.position.z);
	}
}
