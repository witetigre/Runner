using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurikenControl : MonoBehaviour, IHostile
{
    // Start is called before the first frame update

    public int Demage = 1;
    private float rotationZ = 1.0f;
    public int GetDemage() {
        return Demage;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player")) 
        {
            GameObject.Destroy(gameObject);
        
        }
    }

    void Update()
    {
        gameObject.transform.Rotate(0.0f, 0.0f, rotationZ++, Space.Self);
    }

}
