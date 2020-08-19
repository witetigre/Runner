using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public float DeltaSpeed = 0.01f;
    public int SpeedIncrease = 10; // Per frame

    private float motion = 0.01f;
    private int totalRates = 0;
    private Animator animator;
   
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {



        totalRates++;

        if (totalRates % 10 == 0)
        {
            motion += DeltaSpeed;
        }

        gameObject.transform.position = new Vector3(gameObject.transform.position.x + motion, gameObject.transform.position.y);

      

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                
                animator.SetTrigger("Jump");
               

            }
        
       
       
    }
}
