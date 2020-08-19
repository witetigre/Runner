using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlatform : MonoBehaviour
{

    public GameObject Grass;
    public GameObject Grass_2;
    public GameObject Tree_1;
    public GameObject Tree_2;
    public bool isForest = false;
    public List<Sprite> Trees;
    public List<Sprite> Grasses;
    public int Chance = 3;

    private int frames = 0;

    private void generateBlock()
    {
       

        if (isForest) Chance = 100;




           if (Chance >= UnityEngine.Random.Range(0, 100))
            {
               Tree_1.GetComponent<SpriteRenderer>().sprite = Trees[UnityEngine.Random.Range(0, Trees.Count)];
            }

            if (Chance >= UnityEngine.Random.Range(0, 100))
            {
                Tree_2.GetComponent<SpriteRenderer>().sprite = Trees[UnityEngine.Random.Range(0, Trees.Count)];

            }


            Grass.GetComponent<SpriteRenderer>().sprite = Grasses[UnityEngine.Random.Range(0, Grasses.Count)];
            Grass_2.GetComponent<SpriteRenderer>().sprite = Grasses[UnityEngine.Random.Range(0, Grasses.Count)];

    }
    
    void Awake()
    {

        generateBlock();
       

    }
    void OnBecameInvisible()
    {
        generateBlock();
        float platformWidth = gameObject.GetComponent<SpriteRenderer>().sprite.texture.width / 128;
        float platformXpos = gameObject.transform.position.x + (98 * platformWidth);
        gameObject.transform.position = new Vector3(platformXpos, gameObject.transform.position.y, 0);
        //SetPosLast
        //GameObject.Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
            
        
    }

}

