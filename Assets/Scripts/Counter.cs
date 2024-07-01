using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
	[SerializeField] private float _value = 0f;
	[SerializeField] private float _additionConst = 1f;

	public event Action<float> UpdateCount;

	private bool _isCount = false;
	private Coroutine _coroutine;

	public void StartCount()
	{
		_isCount = !_isCount;

		if (_isCount)
		{
			_coroutine = StartCoroutine(CountWithDelay());
		}
		else
		{
			StopCount();
		}
	}

	private void StopCount()
	{
		StopCoroutine(_coroutine);
	}

	private IEnumerator CountWithDelay()
	{
		var waitTime = new WaitForSecondsRealtime(_additionConst);

		while (_isCount)
		{
			UpdateCount?.Invoke(++_value);
			yield return waitTime;
		}
	}
}
