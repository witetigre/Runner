using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{
    // Start is called before the first frame update
    public int LifePoint = 3;
    private Animator animator;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("hostile"))
        {
            IHostile sur = collision.gameObject.GetComponent<SurikenControl>();
            LifePoint -= sur.GetDemage();

            if (LifePoint > 0)
            {
                animator.SetTrigger("Damage");
            }
            else {
                animator.SetTrigger("Dead");
                Debug.Log("You'e dead!");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
