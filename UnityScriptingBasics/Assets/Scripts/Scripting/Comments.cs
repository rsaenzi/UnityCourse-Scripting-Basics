using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// private field assigned but not used.
#pragma warning disable 0414

public class Comments : MonoBehaviour {

    // - Comentarios:

    // Esto es un comentario de una sola linea

    // https://learn.unity.com/course/beginner-scripting

    // https://learn.unity.com/project/unity-c-scripting-fundamentals

    /*
        Esto es un comentario multilinea,
        puedo agregar tanto texto como desee
        nada de esto va a ser ejecutado...
    */

    /*
     * Esta es otra forma de comentarios de multiples
     * lineas, la unica diferencia son los asteriscos.
     * Los comentarios son ignorados por el procesador
    */


    // - Instrucciones:
    
    bool nivelSuperado;

    int vidas = 5; // Al tocar un enemigo disminuye en 1

    // Las instrucciones tambien son llamadas
    // Comandos o Statements

    // Las instrucciones de una sola linea
    // deben terminar con un ;


    // Existen tambien instrucciones multilinea
    // ellas no requieren el uso de ;

    void CalcularPuntaje() {

    }

    // En cambio tiene un cuerpo, delimitado por { y }
}