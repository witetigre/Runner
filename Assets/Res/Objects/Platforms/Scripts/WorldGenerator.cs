using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Platform;
 
    private int frameCount = 0;
    private int blockCount = 0;
   
    private float platformWidth = 0f;
    void Start()
    {
        platformWidth = Platform.GetComponent<SpriteRenderer>().sprite.texture.width / 128;

        for (int x = 0; x < 100; x++)
        {
            float platformXpos = gameObject.transform.position.x + (blockCount * platformWidth);
            GameObject temp = GameObject.Instantiate(Platform, new Vector3(platformXpos, gameObject.transform.position.y, 0), gameObject.transform.rotation);
            

            blockCount++;
        }
    }

    // Update is called once per frame
    
    void Update()
    {
       /* frameCount++;
        if (frameCount >= 100)
        {

            float platformXpos = gameObject.transform.position.x + (blockCount * platformWidth);
            GameObject temp = GameObject.Instantiate(Platform, new Vector3(platformXpos, gameObject.transform.position.y, 0), gameObject.transform.rotation);

            blockCount++;
            

            frameCount = 0;
        }*/
    }
}
