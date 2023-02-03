using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Autoclick : MonoBehaviour
{
public float interval = 1f;
private int countToAdd = 0;
private int currentCount = 0;



  public void StartCounting(int count)
  {
        // Almacenamos la cantidad a sumar
        countToAdd += count;

        // Iniciamos la corrutina
        StartCoroutine(IncrementCount());
  }

IEnumerator IncrementCount()
{
        // Continuamos la ejecución hasta que la aplicación se cierre
        while (true)
        {
            // Incrementamos la cantidad actual
            Contador.bananaCount += countToAdd;

            // Actualizamos el contador
            UpdateCount(currentCount);

            // Esperamos el intervalo establecido
            yield return new WaitForSeconds(interval);
        }
    }

 void UpdateCount(int count)
 {
    // Actualizamos el contador
    Contador.bananaCount += count;
 }
}

