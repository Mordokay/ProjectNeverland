using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

    public GameObject bullet;
    float velocity = 50.0f;
    
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject myBullet = Instantiate(bullet) as GameObject;
            myBullet.GetComponent<Rigidbody>().velocity = Camera.main.transform.forward.normalized * velocity;
            myBullet.transform.position = this.transform.position + Camera.main.transform.forward.normalized * 2.0f;
            Destroy(myBullet, 5.0f);
        }
	}
}
