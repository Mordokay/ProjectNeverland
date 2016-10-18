using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class randomCardMaterial : MonoBehaviour
{

    public List<Texture> CardImages;

    void Start()
    {
        //Material myMat = new Material(Shader.Find("Standard"));
        Material myMat = this.GetComponent<Renderer>().material;
        myMat.SetTexture("_EmissionMap", CardImages[Random.Range(0, CardImages.Count - 1)]);

        float emission = 1.0f;
        Color baseColor = Color.white;
        Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);
        myMat.SetColor("_EmissionColor", finalColor);

        this.GetComponent<Renderer>().material = myMat;
        
    }
}
