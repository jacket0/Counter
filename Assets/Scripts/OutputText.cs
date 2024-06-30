using System;
using UnityEngine;
using UnityEngine.UI;

public class OutputText : MonoBehaviour
{
	private Text _text;

	private void Start()
	{
		_text = GetComponent<Text>();
	}

	public void Output(float counter)
	{
		_text.text = Convert.ToString(counter);
	}

}
