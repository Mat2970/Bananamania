using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Observable observable;

    private void Start()
    {
        //creo una instancia de Observable y agrego los observadores a la lista de observadores
        observable = new Observable();

        ClicksObserver clicksObserver = new ClicksObserver();
        TimePlayedObserver timePlayedObserver = new TimePlayedObserver();
        BananasGatheredObserver bananasGatheredObserver = new BananasGatheredObserver();

        observable.AddObserver(clicksObserver);
        observable.AddObserver(timePlayedObserver);
        observable.AddObserver(bananasGatheredObserver);
    }

    private void Update()
    {
        // se encarga de detectar clics en el juego y notificar a los observadores.
        if (Input.GetMouseButtonDown(0))
        {
            observable.NotifyObservers();
        }
    }
}
