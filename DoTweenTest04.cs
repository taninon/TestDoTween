using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenTest04: MonoBehaviour
{
    void Start()
    {
		this.transform.DOMoveX(5, 1f).SetDelay(0.4f).SetEase(Ease.InExpo).OnComplete(()=> { Debug.Log("OK"); });
	}
}
