using UnityEngine; 
using System.Collections;

namespace UnityStandardAssets._2D
{

  [RequireComponent(typeof (PlatformerCharacter2D))]
   public class Walker : MonoBehaviour {
	
	    public float velocidadCaminar = 5.0f;
		public float wallLeft = 0.5f;
		public float wallRight = 0.1f;
	
	    float direccionCaminar = 1.0f;
	    Vector3 walkAmount;

		private PlatformerCharacter2D m_Character;
		public bool m_Jump;

		private Rigidbody2D m_Rigidbody;


		private void Awake()
		{
			m_Character = GetComponent<PlatformerCharacter2D>();
				wallLeft = transform.position.x - 8.5f;
				wallRight = transform.position.x + 4.5f;
			m_Rigidbody = GetComponent<Rigidbody2D>();
			Debug.Log(m_Rigidbody.transform.position.x);
		}
	
	// Update is called once per frame
	private void Update () {
		
		walkAmount.x = direccionCaminar * velocidadCaminar * Time.deltaTime;
		
		if (direccionCaminar > 0.0f && m_Rigidbody.transform.position.x >= wallRight){
			direccionCaminar = -0.8f;
				float h = direccionCaminar;
				bool crouch = false;
				//if ( (h == -0.8f) && (m_Rigidbody.position.x == 81.05614) ){
					m_Jump = true;
					m_Character.Move(h, crouch, m_Jump);
				Debug.Log(m_Rigidbody.transform.position.x);
					//}
				//else

		}
			else if (direccionCaminar < 0.0f && m_Rigidbody.transform.position.x <= wallLeft){
			direccionCaminar = -0.8f;
				float h = direccionCaminar;
				bool crouch = false; 
				m_Jump = true;
				m_Character.Move(h, crouch, m_Jump);
				Debug.Log(m_Rigidbody.transform.position.x);
		}
		
		transform.Translate(walkAmount);
	}



}
}