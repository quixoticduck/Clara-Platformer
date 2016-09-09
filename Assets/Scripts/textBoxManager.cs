using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textBoxManager : MonoBehaviour {

	public GameObject textBox;

	public Text theText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

//	public PlayerController player;

	public bool isActive;

	public bool stopPlayerMovement;
	
	// Use this for initialization
	void Start () 
	{
//		player = FindObjectOfType<PlayerController>();

		if(textFile != null)
			
		{
			// \n represents a line break (whenever our text file has an enter pressed)
			textLines = (textFile.text.Split ('\n'));
		}

		if (endAtLine == 0)
		{
			endAtLine = textLines.Length - 1;
		}

		if (isActive) {
			EnabletextBox();
		}

		else {
			DisabletextBox();
		}

	}


	void Update()
	{
		if (!isActive)
		{
			return;
		}

		theText.text = textLines[currentLine];

		if(Input.GetKeyDown(KeyCode.Return))
		{
			currentLine +=1;
		}


		if(currentLine > endAtLine) 
		{
			DisabletextBox();
		}

	}

	public void EnabletextBox()
	{
		textBox.SetActive(true);
		isActive = true;
		Debug.Log("enable text box");
//		if (stopPlayerMovement) 
//		{
//			player.canMove = false;
//		}

	}	

	public void DisabletextBox()
	{
		textBox.SetActive(false);
		isActive = false;

//
//		player.canMove = true; 
//
	}

	public void ReloadScript(TextAsset theText)
	{
			if(theText != null)
		{
			textLines = new string[1]; 
			// \n represents a line break (whenever our text file has an enter pressed)
			textLines = (theText.text.Split ('\n'));
		}
	}
}