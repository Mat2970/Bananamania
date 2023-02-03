using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public GameObject clic; // Referencia al game object que detecta el clickeo del boton
    public GameObject upgrade; // Referencia al game object que detecta el clickeo del boton de mejora
    public MenuController menuController; // Referencia al script menu controller

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // El metodo que incrementa el valor de bananas por el valor de uTierCount
    public void Clicking()
    {
        Contador.bananaCount += Contador.uTierCount;
    }

    // Es el metodo de mejora donde se incrementa el valor de uTierCount
    public void Upgrading()
    {
        Contador.uTierCount += 1;
    }

    public void MainGame()
    {
        menuController.OnButton1Click();
    }
    public void AUpgrade()
    {
        menuController.OnButton2Click();
    }
    public void CUpgrade()
    {
        menuController.OnButton3Click();
    }
    public void Options()
    {
        menuController.OnButton4Click();
    }
}
