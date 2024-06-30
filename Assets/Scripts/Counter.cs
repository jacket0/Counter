using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
	[SerializeField] private float _counter = 0f;
	[SerializeField] private float _additionConst = 1f;
	[SerializeField] private OutputText _output;

	private bool _IsCount = false;
	private Coroutine _coroutine;

	public void StartCount()
	{
		if (_IsCount = !_IsCount)
		{
			_coroutine = StartCoroutine(CountWithDelay());
		}
		else 
		{ 
			StopCoroutine(_coroutine);
		}
	}

	private IEnumerator CountWithDelay()
	{
		var waitTime = new WaitForSecondsRealtime(_additionConst);

		while (_IsCount) 
		{
			_output.Output(++_counter);
			yield return waitTime;
		}
	}
}
