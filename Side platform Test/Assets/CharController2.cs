using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController2 : MonoBehaviour {
    public float runspeed;

    Rigidbody Rigid;

    bool facingRight;
    void Start () {
        Rigid = GetComponent<Rigidbody> ();
        facingRight = true;

    }

    // Update is called once per frame
    void Update () {

    }

    void FixedUpdate () {
        float move = Input.GetAxis ("Horizontal");
        Rigid.velocity = new Vector3 (move * runspeed, Rigid.velocity.y, 0);
        if (move > 0 && !facingRight) Flip ();
        else if (move < 0 && facingRight) Flip ();

    }
    void Flip () {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.z *= -1;
        transform.localScale = theScale;
    }

}