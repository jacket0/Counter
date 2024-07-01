using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
	[SerializeField] private float _value = 0f;
	[SerializeField] private float _additionConst = 1f;
	[SerializeField] private CounterView _output;

	private bool _isCount = false;
	private Coroutine _coroutine;

	public void StartCount()
	{
		if (_isCount = !_isCount)
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

		while (_isCount) 
		{
			_output.Output(++_value);
			yield return waitTime;
		}
	}
}
