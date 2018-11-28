using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScale : MonoBehaviour {

    Renderer rend;
    
    // Use this for initialization
    void Start () {

        rend = GetComponent<Renderer>();

        // Animates main texture
        float scaleX = transform.localScale.x;
        float scaleY = transform.localScale.y;
        rend.material.mainTextureScale = new Vector2(scaleX, scaleY);
    }
	
	// Update is called once per frame
	void Update () {

    }
}
