using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    int a = 50;
    int b = 25;
    int c;
    int Ocean(int a, int b)
    {
        return a + b;
    }
    int Imprimante(int a, int b)
    {
        return a - b;
    }
     int Zebla(int a, int b)
    {
        return a / b;
    }
    int Chleka(int a, int b)
    {
        return a * b;
    }
    int Cocacola(int a, int b)
    {
        return a % b;
    }
    void Start()
    {
        int Solution = Ocean(a, b);
        Debug.Log(Solution);

        int Result = Imprimante(a, b);
        Debug.Log(Result);

        int River = Zebla(a, b);
        Debug.Log(River);

        int Oasis = Chleka(a, b);
        Debug.Log(Oasis);

        int Sea = Cocacola(a, b);
        Debug.Log(Sea);
    }
    void Update()
    {
    

    }
}

