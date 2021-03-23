using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharController : MonoBehaviour {
    public float speed;
    public float jump;
    float moveVelocity;

    //Grounded Vars
    bool grounded = true;

    public GameObject pauseMenu;
    public GameObject lava;
    public GameObject bgmusic;
    public GameObject exit;
    private Collider[] civilianColliders;
    public Transform civilianCheck;
    public LayerMask whatIsCivilian;
    public float civilianCheckRadius;
    private bool isTouchingCivilian = false;
    public int civiliansSaved;

    void Start()
    {
        civiliansSaved = 0;
    }

    void Update () 
    {   
        if(civilianColliders != null)
        {
            if(civilianColliders.Length > 0)
            {
                isTouchingCivilian = true;
            }
            else
            {
                isTouchingCivilian = false;
            }
        }

        if (Input.GetKeyDown (KeyCode.P))
        {
            pauseMenu.SetActive(true);
            gameObject.SetActive(false);
            lava.SetActive(false);
            bgmusic.SetActive(false);
        }
        
        if(Input.GetButtonDown("Fire3"))
        {
            SaveCivilian(civilianColliders);
        }
        
    }

    void FixedUpdate () 
    {
        civilianColliders = Physics.OverlapSphere(civilianCheck.position, civilianCheckRadius, whatIsCivilian);

        //Jumping
        if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.Z) || Input.GetKeyDown (KeyCode.W)) {
            if (grounded) 
            {
                GetComponent<Rigidbody> ().velocity = new Vector3 (GetComponent<Rigidbody> ().velocity.x, jump);
            }
        }

        moveVelocity = 0;

        //Left Movement
        if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) 
        {
            moveVelocity = -speed;
        }
        //Right
        if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) 
        {
            moveVelocity = speed;
        }

        GetComponent<Rigidbody> ().velocity = new Vector3 (moveVelocity, GetComponent<Rigidbody> ().velocity.y);

    }
    //Check if Grounded
    void OnTriggerEnter3D () 
    {
        grounded = true;
    }
    void OnTriggerExit3D () 
    {
        grounded = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("WinPlat"))
        {
            WinGame();
        }
    }

    private void SaveCivilian(Collider[] civilianColliders)
    {
        if(isTouchingCivilian)
        {
            for (int i = 0; i < civilianColliders.Length; ++i)
            {
                civiliansSaved++;
                //Destroying for now not sure if we want to do this
                Destroy(civilianColliders[i].gameObject);
            }
        }    
    }

    public void WinGame()
    {
        SceneManager.LoadScene("Win");
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(civilianCheck.position, civilianCheckRadius);
    }
}