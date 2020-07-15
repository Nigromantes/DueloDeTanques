using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanque
{
    //Esto sería una propiedad.
    private string nombre;

    public string Nombre
    {
        get
        {
            return nombre;
        }
        set
        {
            nombre = value;
        }

    }


    public class Cañón
    {
        private int probabilidadDeFallo;

        public int ProbabilidadDeFallo
        {
            get
            {
                return probabilidadDeFallo;
            }

            set
            {
                probabilidadDeFallo = value;
            }


        }

        private int tiempoDeDisparo;

        public int TiempoDeDisparo
        {
            get
            {
                return TiempoDeDisparo;
            }

            set
            {

                tiempoDeDisparo = value;
            }



        }

        private int tiempoDeRecarga;

        public int TiempoDeRecarga
        {

            get
            {
                return tiempoDeRecarga;

            }

            set
            {

                tiempoDeRecarga = value;
            }

        }
        private int precisionDeDisparo;

        public int PrecisionDeDisparo
        {

            get
            {

                return precisionDeDisparo;
            }
            set
            {
                precisionDeDisparo = value; 
            
            }


        }

    }

    public class Bala
    { 
    
    
    }

    public class Estructura
    { 
    
    
    }

    public class Tripulación
    { 
    
    
    }
    

}


