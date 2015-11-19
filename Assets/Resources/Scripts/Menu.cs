using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour 
{
	private InputField inputF;
	
	void Start()
	{
		if(Application.loadedLevel == 0)
			inputF = GameObject.FindGameObjectWithTag("TextInput").GetComponent<InputField>();
	}
	
	void Update ()
	{

	}
	public void ChangeScene()
	{
		switch(Application.loadedLevel)
		{
			case 0:
				try
				{
					PlayerPrefs.SetFloat("Ur", float.Parse(inputF.text));
					Application.LoadLevel (1);
				}
				catch
				{
					inputF.text = "";
					Text placeholder = inputF.placeholder.gameObject.GetComponent<Text>();
					placeholder.text = "Enter a valid number";
					placeholder.color = Color.white;
					inputF.image.color = Color.red;
				}
				break;
			case 1:
				Application.LoadLevel(0);
				break;
		}
	}
}