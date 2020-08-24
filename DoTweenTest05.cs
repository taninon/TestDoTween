using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenTest05 : MonoBehaviour
{
    void Start()
    {
		this.transform.DOMoveX(5,1f).SetRelative();
	}
}
