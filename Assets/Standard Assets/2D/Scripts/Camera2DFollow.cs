using System;
using UnityEngine;
using System.Collections;

namespace UnityStandardAssets._2D
{
    public class Camera2DFollow : MonoBehaviour
    {
		//public float dampTime = 0.15f;
		//private Vector3 velocity = Vector3.zero;
		public Transform Target;

        // Use this for initialization
     


        // Update is called once per frame
		void Update () 
		{
			//if (target)
			//{
				//Vector3 point = camera.WorldToViewportPoint(target.position);
				//Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
				//Vector3 destination = transform.position + delta;
				//transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
				transform.position = new Vector3 (Target.position.x, 0, -10); // Camera follows the player but 6 to the right
			    
			//}
			
		}
    }
}
