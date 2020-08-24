using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenRotate : MonoBehaviour
{
    void Start()
    {
		this.transform.DORotate(new Vector3(0,240,0), 2f).SetEase(Ease.OutBounce);
	}
}
