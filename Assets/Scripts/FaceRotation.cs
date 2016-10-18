using UnityEngine;
using System.Collections;

public class FaceRotation : MonoBehaviour {

	void Update () {
        this.transform.localRotation = Quaternion.Euler( Camera.main.transform.localRotation.eulerAngles + new Vector3(-90.0f, 0, 90.0f));
	}
}
