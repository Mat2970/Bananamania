using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//mantiene una lista de observadores y proporciona métodos para agregar y eliminar observadores, así como notificar a los observadores de cualquier cambio en el estado del juego
public class Observable
{
    private List<Observer> observers;

    public void AddObserver(Observer observer)
    {
        if (observers == null)
        {
            observers = new List<Observer>();
        }
        observers.Add(observer);
    }

    public void RemoveObserver(Observer observer)
    {
        if (observers != null)
        {
            observers.Remove(observer);
        }
    }

    public void NotifyObservers()
    {
        if (observers != null)
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}

public abstract class Observer
{
    public abstract void Update();
}

//se encarga de mantener y actualizar los clicks en el juego
public class ClicksObserver : Observer
{
    private int clicks;

    public override void Update()
    {
        clicks++;
        Debug.Log("Total clicks: " + clicks);
    }
}
//se encarga de mantener y actualizar el tiempo jugado al juego
public class TimePlayedObserver : Observer
{
    private float timePlayed;

    public override void Update()
    {
        timePlayed += Time.deltaTime;
        Debug.Log("Time played: " + timePlayed);
    }
}
//se encarga de mantener y actualizar el total de bananas cpnseguidas en el juego
public class BananasGatheredObserver : Observer
{
    private int bananasGathered;

    public override void Update()
    {
        bananasGathered++;
        Debug.Log("Bananas gathered: " + bananasGathered);
    }
}

