using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw : MonoBehaviour
{
    string heroname = "Othman"; 
     int heroHeight = 165;
    int heroage = 16;
    string herosuperpower = "fire";

    string villianname = "Abdurahman";
     int villianHeight = 173;
    int villianage = 15;
    string villiansuperpower = "mind control";
    

    // Start is called before the first frame update
    void Start()
    {
        print(" The hero's name is " + heroname + " The hero's age is " + heroage + " The hero's height is " + heroHeight + " The hero's super power is " + herosuperpower);
        print(" The villian's name is " + villianname + " The hero's age is " + villianage + " The hero's height is " + villianHeight + " The hero's super power is " + villiansuperpower);
        print(" age difference is " + ( heroage - villianage ));



    }









    // Update is called once per frame
    void Update()
    {

    }
}