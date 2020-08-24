using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenTest03 : MonoBehaviour
{
    void Start()
    {
		this.transform.DOMoveX(10, 1f).OnComplete(()=> {
			Debug.Log("移動終了");
		});
	}
}
