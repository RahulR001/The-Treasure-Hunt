using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    private CharacterController controller;
    public static float speed = 10f;
    public float movespeed = 5f;
    public float fource = 10f;
   
    public float gravity = 12f;
    private float yvelocity = 0f,xvelocity=0f;
    private Animator animechange;
    private Animation anime;
     
    private float animationduration = 3f;
    public  static int   coincount = 0;
    public AudioSource coinsound;


    // Start is called before the first frame update
    void Start()
    {
         
        controller=GetComponent<CharacterController>();
        animechange =gameObject . GetComponent <Animator>();        
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Time .time < animationduration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }
       // Vector3 movevector0 = new Vector3(0, 0, 0);

       Vector3 movevector = new Vector3(0, 0, 0) * Time.deltaTime;
        movevector.x =  xvelocity ;
        
        xvelocity  = Input.GetAxisRaw("Horizontal") * movespeed ;


       
        movevector.z = speed;
        movevector.y = yvelocity  ;

        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                //anime = true  ;



                animechange.SetTrigger("Jump");
                yvelocity = fource * Time.deltaTime;

            }



            //yvelocity = -0.5f;
        }
        else
        {
            yvelocity -= gravity * Time.deltaTime;
        }


      


        //animechange.SetBool("jump", false);

        //movevector.y = verticalvelocity;
        controller.Move(movevector * Time.deltaTime);
        //float tempspeed = speed-gameui.;
        //tempspeed = tempspeed + 0.1f;
        //anime.SetFloat("blend",tempspeed );
       
    }
    public static void setspeed(float  speeds)
      {
        speed = 10f + speeds;
        
        
      }

    
    


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject .tag == "coin")
        {
            coinsound.Play();
        }
    }
}
