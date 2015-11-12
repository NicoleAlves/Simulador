using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour 
{
	private InputField inputF;
	
	void Start()
	{
		inputF = GameObject.FindGameObjectWithTag("TextInput").GetComponent<InputField>();
	}
	
	void Update ()
	{

	}
	public void ChangeScene()
	{
		try
		{
			PlayerPrefs.SetFloat("Ur", float.Parse(inputF.text));
			Application.LoadLevel (1);
		}
		catch
		{
			inputF.text = "";
			Text placeholder = inputF.placeholder.gameObject.GetComponent<Text>();
			placeholder.text = "Please enter a valid number and press enter";
			placeholder.color = Color.white;
			inputF.image.color = Color.red;
		}
	}
}