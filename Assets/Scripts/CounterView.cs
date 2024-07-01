using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CounterView : MonoBehaviour
{
	[SerializeField] Counter _counter;

	private Text _text;

	private void Start()
	{
		_text = GetComponent<Text>();
	}

	private void OnEnable()
	{
		_counter.UpdateCount += Output;
	}

	private void OnDisable()
	{
		_counter.UpdateCount -= Output;
	}

	public void Output(float counter)
	{
		Debug.Log(counter);
		_text.text = Convert.ToString(counter);
	}

}
