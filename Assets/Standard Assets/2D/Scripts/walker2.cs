using UnityEngine;
using System.Collections;

namespace UnityStandardAssets._2D{
	[RequireComponent(typeof (PlatformerCharacter2D))]
public class walker2 : MonoBehaviour {
		public float floor_1x;
		public float floor_1y;
		public float floor_2x;
		public float floor_2y;
		public float Floor_2x;
		public float Floor_2y;
		public float velocidadCaminar = 5.0f;
		//float direccionCaminar = 1.0f;
		private PlatformerCharacter2D m_Character;



	// Use this for initialization
	void Start () {
			floor_1x = -6.45f;
			floor_1y = 1.51f;
			floor_2x = 12.42f;
			floor_2y = 3.24f;
			Floor_2x = 29.118f;
			Floor_2y = 5.9145f;
			m_Character = GetComponent<PlatformerCharacter2D>();
			Debug.Log (m_Character.transform.position.x);
	}
	
	// Update is called once per frame
	void Update () {
			if(m_Character.transform.position.x == floor_1x){

	}
		}
	}
}

