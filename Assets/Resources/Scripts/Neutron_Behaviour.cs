using UnityEngine;
using System.Collections;

public class Neutron_Behaviour : MonoBehaviour 
{	
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Uranio")
		{
			col.gameObject.SendMessage("Split");
			Destroy(this.gameObject);
		}
	}

	void Update () {
		transform.Translate(new Vector2(-1*Time.deltaTime,0));
	}
}