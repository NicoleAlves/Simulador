using UnityEngine;
using System.Collections;

public class Uranio_Behaviour : MonoBehaviour 
{
	public void Split()
	{
		Object[] n = Resources.LoadAll("Prefabs");
		Quaternion rotation = Quaternion.identity;
		float angle = Random.Range(0, 360F);
		rotation.eulerAngles = new Vector3(0,0,angle);
		Instantiate(n[0],new Vector3(this.transform.position.x + 0.5f,this.transform.position.y,10f),rotation);
		Instantiate(n[1],new Vector3(this.transform.position.x - 0.5f,this.transform.position.y,10f),rotation);

		for(int i = 0;i< 3;i++)
		{
			angle = Random.Range(0, 360F);
			rotation.eulerAngles = new Vector3(0,0,angle);
			Instantiate(n[2],transform.position,rotation);	
		}
		
		Destroy(this.gameObject);
	}
}