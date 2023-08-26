using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class day2 : MonoBehaviour
{
    string heroName = "moad";
    int heroPower = 57;

    string villainName = "maloly";
    int villairPower = 55;
    float playrspeed = 2.7f;
    // Start is called before the first frame update
    void Start()
    {
        if (heroPower <= villairPower)
        {
            print("heroPower");
        }

        else if (heroPower >= villairPower) ;
        {
            print("villairPower");
        }



        print(playrspeed);
        SetSpeed(2.5f);
        print(playrspeed);

    }
    float speed1 = 23.5f;
    int speed2 = 23;
    // Update is called once per frame
    void Update()
    {
        
    }
    void SetSpeed(float speed)
    {

        playrspeed = speed;

    }


    void CompareSpeed(float speed1 ,float speed2)
    {
        if(speed2 < speed1)
        {
            print(speed1);
        }
        else if(speed2 > speed1)
        {
            print(speed2);
        }
        else if (speed2 == speed1)
        {
            print(speed1 == speed2);
        }

    }


}
