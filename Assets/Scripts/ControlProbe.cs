using UnityEngine;
using System.Collections;

public class ControlProbe : MonoBehaviour {

    public GameObject mirror;
    public GameObject character;

    public float offset;
    public Direction directionFaced;

	// Update is called once per frame
	void Update () {
        if (directionFaced.Equals(Direction.X))
        {
            offset = (mirror.transform.position.x - character.transform.position.x);
            transform.position = new Vector3(mirror.transform.position.x + offset, character.transform.position.y, character.transform.position.z);
        }
        else if (directionFaced.Equals(Direction.Y))
        {
            offset = (mirror.transform.position.y - character.transform.position.y);
            transform.position = new Vector3(mirror.transform.position.x, character.transform.position.y + offset, character.transform.position.z);
        }
        else
        {
            offset = (mirror.transform.position.z - character.transform.position.z);
            transform.position = new Vector3(mirror.transform.position.x, character.transform.position.y, character.transform.position.z + offset);
        }
    }

    public enum Direction
    {
        X, Y, Z
    }
}
