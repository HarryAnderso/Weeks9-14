using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Knight : MonoBehaviour
{
    SpriteRenderer sr;
    public float speed;
    Animator animator;
    public bool canRun = true;
    private AudioSource audiosource;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        sr.flipX = direction < 0;
        animator.SetFloat("movement", Mathf.Abs(direction));

        if(Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("attack");
            canRun = false;
        }
        if(canRun == true)
        {
            transform.position += transform.right * direction * speed * Time.deltaTime;
        }
      

    }
    public void AttackHasFinished()
    {
        Debug.Log("the attack animation has just finished");
        canRun = true;
    }

    public void WalkingSounds()
    {
        audiosource.Play();
        Debug.Log("noise is technicly playing");
    }
}
