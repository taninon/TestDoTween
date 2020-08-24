using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenScale: MonoBehaviour
{
    void Start()
    {
		this.transform.DOScale(new Vector3(2,2,2), 2f).SetEase(Ease.OutBounce);
	}
}
