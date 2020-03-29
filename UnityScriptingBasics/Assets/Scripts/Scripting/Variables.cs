using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// private field assigned but not used.
#pragma warning disable 0414

public class Variables : MonoBehaviour {

    // - Variables:

    // Tambien conocidas como Propiedades, Objectos, Instancias
    // Representan grupos de bits de la memoria RAM


    // - Variables Primitivas (Value Types):

    // Valores booleanos: true o false
    public bool esHombre;

    // Números Enteros: -5, 0, 4500, -963563
    public int edad;

    // Números Decimales: 3.141589, -0.4575
    public float altura;

    // Cadenas de Texto: "Hola, soy Carlos"
    public string introduccion;


    // Si la variable no tiene la palabra public
    // no será visible en el Unity Editor



    // - Variables Compuestas (Objects):
    public Vector2 cuadrado;
    public Vector3 ubicacion;
    public Color colorCabello;

    public ParticleSystem lluvia;
    public Light luzDelSol;
    public Collider box;
    public GameObject usuario;



    // Esto se llama Declarar e Inicializar una variable
    bool estaSoltera = false;
    int profundidad = -80;
    float distancia = 23.67f;
    string nombre = "Katherine";


    void Start() {

        // La asignacion se puede hacer luego de la declaracion
        altura = 1.75f;
        edad = 35;
        introduccion = "Mi nombre es Carlos";

        // Para la asignacion se usa el operador =
        esHombre = false;



        // El contenido de una variable puede cambiar
        // tantas veces como se quiera
        esHombre = true;
        esHombre = false;


        // Vamos a cambiar el valor de la variable edad a 50
        edad = 50;

        // Ahora, despues de ejecutar esta instruccion, edad vale 70
        edad = 70;



        // - Orden de Ejecucion

        // Todas las instrucciones se ejecutan de manera secuencial,
        // una por una, primero las que estan mas arriba

        // Para utilizar una variable, esta debe ser declarada primero
        //longitud = 34;
        //int longitud;



        // - Asignaciones erroneas
        //edad = "Hola";
        //altura = true;
        //presentacion = 67.3f;
        //esHombre = "Pedro";


        // - Operaciones
        // Se pueden realizar operaciones aritmeticas
        // con variables de tipo int y float
        edad = 45 + 8;
        edad = 45 - 8;
        edad = 45 * 8;
        edad = 45 / 8;
        edad = 45 % 8;

        int vidas = edad + 5;
        vidas = 7 / edad;



        // - Errores de funcionamiento
        // Tambien llamados Excepciones, Crash

        // float presion;
        // altura = presion + 2;

        // Siempre es recomendable darle un valor inicial
        // a todas las variables, sino podemos obtener null



        // - Constructores

        // Para asignar valores a una variable compuesta (Objeto)
        // Se usan Constructores, los cuales inicializan las variables internas
        Color otroColor = new Color(0.5f, 0.3f, 0.1f, 0.5f);
        Vector3 posicion = new Vector3(1, 2, 4);
        GameObject casa = new GameObject("hogar");


        // Version corta del constructor
        Vector3 posicionBoss1 = new Vector3(1, 0, 0);
        Vector3 posicionBoss2 = Vector3.right;


        // Valores por defecto en constructores
        Color colorDelCielo1 = new Color(0.0f, 0.0f, 1.0f);

        // Cambiar una variable interna
        Vector3 posicionEnemigo = new Vector3(6, 3, 2);
        posicionEnemigo.x = 23;
        posicionEnemigo.y = 12 * 8;
    }
}