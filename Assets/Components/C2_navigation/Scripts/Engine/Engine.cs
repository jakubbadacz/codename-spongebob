using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine
{
    //initializing variables for the engine
    private int energy;
    private int power;
    private int velocity;
    private bool isOn = false;

    //SetEnergy method
    public void SetEnergy(int energy)
    {
        this.energy = energy;
    }

    //GetEnergy method
    public int GetEnergy()
    {
        return this.energy;
    }

    //SetPower method
    public void SetPower(int power)
    {
        this.power = power;
    }

    //GetPower method
    public int GetPower()
    {
        return this.power;
    }

    //SetVelocity method
    public void SetVelocity(int velocity)
    {
        this.velocity = velocity;
    }

    //GetVelocity method
    public int GetVelocity()
    {
        return this.velocity;
    }

    //SetIsOn method
    public void SetIsOn(bool isOn)
    {
        this.isOn = isOn;
    }

    //TrunOnEngine method
    //sets power of the engine to zero and isOn to true
    public bool TurnOnEngine()
    {
        if (!this.isOn)
        {
            this.power = 0;
            this.isOn = true;
            return true;
        }
        else
        {
            return false;
        }

    }

    //TrunOffEngine method
    //sets power of the engine to zero and isOn to true
    public bool TurnOffEngine()
    {
        if (this.isOn)
        {
            this.power = 0;
            this.isOn = false;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Accelerate()
    {
        if (this.isOn)
        {
            this.power += 10;
        }
    }

    
}
