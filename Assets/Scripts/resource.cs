using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resource : MonoBehaviour, IResource {

    public int amount;
    public string name;

    public resource addResource()
    {
        throw new NotImplementedException();
    }

    public List<resource> resources()
    {
        throw new NotImplementedException();
    }

    public void addAmount(int amountToAdd)
    {
        this.amount += amountToAdd;
    }

    public void subtractAmount(int amountToAdd)
    {
        this.amount -= amountToAdd;
    }

}
