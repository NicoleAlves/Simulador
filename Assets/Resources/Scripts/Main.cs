using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour 
{
	bool click = false;
	void Start()
	{
		SpawnUr ();
	}

	void SpawnUr()
	{
		Object[] n = Resources.LoadAll("Prefabs");
		for(int i = 0; i < PlayerPrefs.GetFloat ("Ur");i++)
		{
			Instantiate(n[3],new Vector3(Random.Range(-11f,2f),Random.Range(0,6f),10f),this.transform.rotation);
		}
	}

	void SpawnN()
	{
		Object[] n = Resources.LoadAll("Prefabs");
		Quaternion rotation = Quaternion.identity;
		float angle = Random.Range(0, 360F);
		rotation.eulerAngles = new Vector3(0,0,angle);
		Vector3 pos = camera.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10));
		Instantiate (n[2],pos,rotation);

	}

	void Update()
	{
		if (Input.GetMouseButtonDown (0) && !click) 
		{
			SpawnN();
			click = true;
		}
	}
}