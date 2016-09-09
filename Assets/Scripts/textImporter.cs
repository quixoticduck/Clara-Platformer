using UnityEngine;
using System.Collections;

public class textImporter : MonoBehaviour {

	public TextAsset textFile;
	public string[] textLines;

	// Use this for initialization
	void Start () {

		if(textFile != null)

		{
			// \n represents a line break (whenever our text file has an enter pressed)
			textLines = (textFile.text.Split ('\n'));
		}
	
	}
}
