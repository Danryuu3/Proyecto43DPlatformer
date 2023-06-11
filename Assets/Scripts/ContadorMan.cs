using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorMan : MonoBehaviour
{
    public int numEnemigos;

    // Update is called once per frame
    void Update()
    {
        print(numEnemigos);
    }

    public void NumeroEnemigoAsesinados(int enemy)
    {
        numEnemigos += enemy;
    }

    public void ReinciaEnemigos()
    {
        numEnemigos = 0;
    }
}
