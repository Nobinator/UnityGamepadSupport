using UnityEngine;
using System.Collections;

public class TransformCorrector : MonoBehaviour {

    Vector3 startpos;

	void Start () {
		startpos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position,startpos,0.07f);
	}
}
