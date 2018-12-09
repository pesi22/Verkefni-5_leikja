using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//þessi scrip átti upprunalega að vera bara controller er varð svo bara fyrir allt sem tengdist player

public class PlayerContoller : MonoBehaviour
{
    public Animator animator;
    //carecter speed
    public float topspeed = 10f;
    public GameObject shot;  
    public AudioSource effect;

    /*private void Start()
    {
        effect.clip = jumpPlay; // stilli sound effect
    }*/



    private void FixedUpdate()
    {

        float moveUP = Input.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveUP * topspeed, GetComponent<Rigidbody2D>().velocity.y);

        float move = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * topspeed, GetComponent<Rigidbody2D>().velocity.x);
        float targetX = transform.position.x;
        float targetY = transform.position.y;


        if (Input.GetKeyDown(KeyCode.Space)) // ef space er notað er addað force up
        {
            Instantiate(shot, new Vector2(targetX,targetY), Quaternion.identity);
        }

        //animator.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal"))); //running animation

    

    }


    /*void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.name == "GrassJoinHillRight2(Clone)")
        {
            animator.SetBool("inAir", false); // end jumping animation ef hann lendir á platformi
            jumps = 0;
            jumps = 3;

        }

        if (coll.gameObject.name == "coin(Clone)") // ef hann nær coin
        {
            Destroy(coll.collider.transform.root.gameObject);//eyði coin
            scoreINT++; //bæti við score
            score.text = "" + scoreINT;//print score
        }


        if (coll.gameObject.name == "DeathBarDOWN")
        {
            endgame.text = "Game Over \n Your score is: " + scoreINT;
            Destroy(GameObject.Find("spawner"));
            //hætti að spawna platforms þegar player er eytt
        }
    }*/



}