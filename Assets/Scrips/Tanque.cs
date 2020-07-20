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
        private int energiaDeImpacto;
        public int EnergiaDeImpacto 
        {
            get
            {
                return energiaDeImpacto;
            }


            set
            {
                energiaDeImpacto = value;
            }
                
                
        }

        public int correcionDeTractoria;

        public int CorreccionDeTractoria
        {

            get 
            {
                return correcionDeTractoria;
            }

            set 
            {
                correcionDeTractoria = value;            
            
            }
        
        }


    }

    public class Estructura
    {
        private int reduccionDeGolpe;

        public int ReduccionDeGolpe
        {
            get
            {
                return reduccionDeGolpe;
            }
            set
            {
                reduccionDeGolpe = value;
            }



        }


        private int tiempoDeVibracion;

        public int TiempoDeVibracion
        {
            get
            {
                return tiempoDeVibracion;
            }
            set 
            {
                tiempoDeVibracion = value;
            }
        
        
        }
    
    }

    public class Tripulación
    {
        //Eficiencia
        private int eficiencia;
        public int Eficiencia
        {
            get 
            {
                return eficiencia;
            }
            set
            {
                eficiencia = value;
            }
        }
        //Liderzgo. 

        private int liderzago;
        public int Liderzago
        {
            get
            {
                return liderzago;
            }
            set
            {
                liderzago = value;
            }
        }
        

        //Entreanmiento físico. 
        public class Entrenamiento
        {
            //Energia
            private int energia;
            public int Energia
            {
                get
                {
                    return energia;
                }
                set
                {
                    energia = value;
                }
            }

            //Recuperación del cansacio. 
            //Equilibrio
            //Recupración de caída. 
            //Probaabilidad de mareo o confusión. 
            //Recuperación de mareo o confusión. 


        }






    }
    

}


