using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class DoTweenCountUp : MonoBehaviour
{
	[SerializeField] Text text;

     void Start()
    {

		DOVirtual.Float(0f, 100f, 3f, value =>
		{
			text.text = "Count : " + (int)value;
		});							
	}
}
