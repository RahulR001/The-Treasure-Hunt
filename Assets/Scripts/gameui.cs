using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameui : MonoBehaviour
{
    private int maxdificultyspeed = 200;
    private int dificulty = 10;
    private int scoretoincreasespeed = 10;
    private float speedincrease = 1f;
    // Start is called before the first frame update
    public GameObject scoretext;
    private Animator anime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playermovement.coincount >= scoretoincreasespeed)
        {
            increasespeed();
            anime.SetFloat("blend",scoretoincreasespeed  );
        }
      

        scoretext.GetComponent<Text>().text = "" + playermovement.coincount;
       
       
    }
    void increasespeed()
    {
        if (dificulty == maxdificultyspeed)
            return;
        scoretoincreasespeed *= 2;
        dificulty++;
       
        playermovement.setspeed(dificulty );

        float incspeed = 1f;
        anime.SetFloat("blend",incspeed   );

    }
}
