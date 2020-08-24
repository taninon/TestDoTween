using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class DoTweenAppend : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		DOTween.Sequence()
			.Append(this.transform.DOMoveX(3, 1f).SetRelative())
			.Append(this.transform.DOMoveY(-3, 1f).SetRelative())
			.Play();

	}

}
