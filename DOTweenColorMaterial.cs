using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTweenColorMaterial : MonoBehaviour
{
	[SerializeField] private Color setColor;

	// Start is called before the first frame update
	void Start()
    {
		var material = GetComponent<MeshRenderer>().material;
		material.DOColor(setColor,2f);
	}

}
