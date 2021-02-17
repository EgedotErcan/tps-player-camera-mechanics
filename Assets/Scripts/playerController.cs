using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;
    public Animator playerAnim;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 movePosition = speed * playerInput * Time.deltaTime;
        transform.Translate(movePosition);
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            playerAnim.SetFloat("mainSpeed", Mathf.Abs(0));
        }
        else
        {
            playerAnim.SetFloat("mainSpeed", Mathf.Abs(5));
        }

        
        
        
    }
   
  
}
