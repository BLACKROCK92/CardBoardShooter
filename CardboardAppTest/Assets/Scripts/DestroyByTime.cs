using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

	void Start () {
        Destroy(this.gameObject, 3f);
	}
}
