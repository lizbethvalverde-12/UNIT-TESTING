using System;

public class Comida_Rapida
{
    public bool EnvioGratis(double total)
    {
        return total >= 15.0;
    }

    public int AplicarCupon(int total, string codigo)
    {
        return codigo == "PROFE10" ? total - 10 : total;
    }

    public double ConQuesoExtra(double precioBase)
    {
        return precioBase + 1.50;
    }

    public bool EstadoValido(string estado)
    {
        return !string.IsNullOrEmpty(estado);
    }

    public bool EstaAbierto(int hora)
    {
        return hora >= 12 && hora <= 23;
    }
}

//He decidido crear un sistema de gestión de pedidos de comida rápida. El código se ha diseñado con lo metodos del  Clean Code, utilizando nombres de funciones y variables descriptivas para que sea fácil de entender.
//Para asegurar que el proyecto es funcional al 100%, se han programado 5 casos de prueba distintos utilizando el framework xUnit.

/*Cada test incluye un mínimo de 3 aserciones (Assert).

 Comprobar qué pasa si un cliente mete un código de descuento falso, o si intenta pedir comida a las 4 de la mañana cuando el restaurante está cerrado).*/
