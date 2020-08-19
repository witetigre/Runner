using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurikenGun : MonoBehaviour
{
    public GameObject Suriken;
    public float thrust = 500f;
    // Start is called before the first frame update
    void Start()
    {
        GenerateHostile();

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void GenerateHostile() {
        GameObject _suriken = GameObject.Instantiate(Suriken, gameObject.transform);

        Rigidbody2D rb = _suriken.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.left * thrust);
    }
}
