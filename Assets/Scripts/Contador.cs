using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public static int bananaCount;  // La cantidad de bananas que el jugador ha obtenido
    public GameObject countDisplay; // Referencia al objeto que muestra el contador de bananas en la interfaz
    public int bananas; // La cantidad de bananas
    public int upgradeTier;  // La cantidad actual del upgrade tier
    public static int uTierCount = 1;  // La cantidad inicial del upgrade tier

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Asigna el valor de bananaCount a la variable bananas
        bananas = bananaCount;
        // Formatea el número y lo abrevía si es necesario
        string formattedCount = FormatCount(bananas);
        // Actualiza el texto del contador de bananas en la interfaz de usuario
        countDisplay.GetComponent<Text>().text = "Bananas: " + FormatCount(bananas);
        // Asigna el valor de uTierCount a la variable upgradeTier
        upgradeTier = uTierCount;
    }
    //Aqui es donde le digo cuando se formatea y por que letra se abrevia
    string FormatCount(int count)
    {
        if (count >= 1000000000)
        {
            return (count / 1000000000f).ToString("0.##") + "C";
        }
        else if (count >= 1000000)
        {
            return (count / 1000000f).ToString("0.##") + "M";
        }
        else if (count >= 1000)
        {
            return (count / 1000f).ToString("0.##") + "K";
        }
        else
        {
            return count.ToString();
        }
    }

}
