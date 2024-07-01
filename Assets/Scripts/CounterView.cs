using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CounterView : MonoBehaviour
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
