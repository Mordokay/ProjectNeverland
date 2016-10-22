using UnityEngine;
using System.Collections;

public class MapDisplay : MonoBehaviour {

	public Renderer textureRender;
    public GameObject baseMap;

    public void DrawTexture(Texture2D texture) {
		textureRender.sharedMaterial.mainTexture = texture;
		textureRender.transform.localScale = new Vector3 (texture.width, 1, texture.height);
	}

    public void removeMap()
    {
        foreach (Transform child in baseMap.transform)
        {
            GameObject.DestroyImmediate(child.gameObject);
        }
        if(baseMap.transform.childCount > 0)
        {
            removeMap();
        }
    }

    public void DrawCubes(TerrainTexture[] textures, float[,] noiseMap, int mapWidth, int mapHeight, float heightDescrepancy, float cubeScale)
    {
        //Removes the old map
        removeMap();

        //Debug.Log("mapHeight   " + mapHeight + "mapWidth   " + mapWidth);
        for (int y = 0; y < mapHeight; y++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                float currentHeight = noiseMap[x, y];
                for (int i = 0; i < textures.Length; i++)
                {
                    if (currentHeight <= textures[i].height)
                    {
                        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        cube.transform.parent = baseMap.transform;
                        cube.transform.localScale = new Vector3(cubeScale, cubeScale, cubeScale);
                        cube.transform.position = new Vector3(x - (mapWidth / 2) + baseMap.transform.position.x, (int)(currentHeight * heightDescrepancy), y - (mapHeight / 2) + baseMap.transform.position.z) * cubeScale;
                        cube.GetComponent<Renderer>().material = textures[i].material;
                        break;
                    }
                }
            }
        }


        
    }

}
