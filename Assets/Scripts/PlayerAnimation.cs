using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

    private Animator animator;
    private SpriteRenderer[] renderers;
    public bool jump;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // Jumping

        if (jump==true)
        {


            // Change animation
            animator.SetTrigger("Jumping");
        }


    }

    void Awake()
    {

        // Get the animator
        animator = GetComponent<Animator>();

        // Get the renderers in children
        renderers = GetComponentsInChildren<SpriteRenderer>();


    }



    void OnDrawGizmos()
    {
        // A little tip: you can display debug information in your scene with Gizmos
        //if (hasSpawn && isAttacking == false)
        {
            //Gizmos.DrawSphere(positionTarget, 0.25f);
        }
    }

}
