using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera MainCamera;
    public GameObject MainBackground;
    private int i = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        MainCamera.transform.position = new Vector3(gameObject.transform.position.x+5f, MainCamera.transform.position.y, MainCamera.transform.position.z);
        MainBackground.transform.position = new Vector3(gameObject.transform.position.x - (i * 0.0001f), MainBackground.transform.position.y, MainBackground.transform.position.z);
    }
}
