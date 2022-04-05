//Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del
//total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
//por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
//mostrar lo pedido en el siguiente formato:
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej09 : MonoBehaviour
{
    public string nombre1;
    public string nombre2;
    public string nombre3;

    public float aporte1;
    public float aporte2;
    public float aporte3;

    float total;
    float porcentaje1;
    float porcentaje2;
    float porcentaje3;

    // Start is called before the first frame update
    void Start()
    {
        total = aporte1 + aporte2 + aporte3;
        porcentaje1 = aporte1 / total * 100;
        porcentaje2 = aporte2 / total * 100;
        porcentaje3 = aporte3 / total * 100;


        Debug.Log("Nombre: " + nombre1 + " capital aportado: $ "  + aporte1 + 
            ", Porcentaje del capital: % " + porcentaje1 +", Monto total aportado: $ "+ total);
        Debug.Log("Nombre: " + nombre2 + " capital aportado: $ " + aporte2 +
            ", Porcentaje del capital: % " + porcentaje2 + ", Monto total aportado: $ " + total);
        Debug.Log("Nombre: " + nombre3 + " capital aportado: $ " + aporte3 +
            ", Porcentaje del capital: % " + porcentaje3 + ", Monto total aportado: $ " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
