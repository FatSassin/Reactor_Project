using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactorMeth : MonoBehaviour
{
    //heat
    public float maxheat;
    public float currentheat;
    public float heatPs;
    //kulant B)
    public float freezeps;
    public float maxfreeze;
    public float currentfreeze;
    //energia
    public float powerps;
    public float maxpower;
    public float currentpower;
    public float fuel;
    //bonusy 
    public float over;
    public float maxfuel;
    public float gqfuel;
    //debuffy
    public float nkul;
    public float nfuel;

    void Start()
    {
        maxheat = 1000;
        currentheat = 0;
        heatPs = 1;

        maxfreeze = 100;
        currentfreeze = 0;
        freezeps = 0;

        powerps = 0;
        currentpower = 0;
        maxpower = 100000;

        fuel = 100;

        over = 1;
        nfuel = 1;
        nkul = 1;
        gqfuel = 1;
    }
    void heat(float maxheat, float currentheat, float heatPs)
    {
        if (currentheat < maxheat)
        {
            currentheat += heatPs = over = nfuel = nkul = Time.deltaTime;
        }
        else
        {

        }
    }
}