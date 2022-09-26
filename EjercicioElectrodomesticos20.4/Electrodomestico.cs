using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioElectrodomesticos20._4 {
    class Electrodomestico {

        // Atributos
        private float precioBase;
        public  enum TipoColor { Blanco,Negro,Rojo,Azul,Gris };
        private TipoColor color;
        public enum TipoConsumoEnergetico {F,E,D,C,B,A};
        private TipoConsumoEnergetico consumoEnergetico;

        private bool boolColor = true;
        private bool boolConsumo = true;

        private float peso;

        // Propiedades
        // Solo con "Get" porque quiero "Preguntar que tiene" ,
        //  modificarlo no , eso lo hace el constructor
        // "Get" -> Lectura , "Set" -> Escritura
        public float PrecioBase { get => precioBase; }
        public float Peso { get => peso;  }
        private TipoColor Color { get => color; set => color = value; }
       
        private TipoConsumoEnergetico ConsumoEnergetico { get => consumoEnergetico; set => consumoEnergetico = value; }

        // Constructores
        // Por defecto
        public Electrodomestico() {
            this.precioBase = 100;
            this.peso = 5;
        }
        // Parametros -> Precio y Peso
        public Electrodomestico(float precio, float peso) {
            this.precioBase = precio;
            this.peso = peso;
         
        }
        // Todos los parametros
        public Electrodomestico(float precio, float peso, string color, string consumo) {
            this.precioBase = precio;
            this.peso = peso;
            comprobarColor(color);
            comprobarConsumoEnergetico(consumo);
            if (boolColor) {
                this.color = (TipoColor)Enum.Parse(typeof(TipoColor), color);
            }
            if (boolConsumo) {
                this.consumoEnergetico = (TipoConsumoEnergetico)Enum.Parse(typeof(TipoConsumoEnergetico), consumo);
            }
        }

        
        private void comprobarConsumoEnergetico(string letra) {
           // Con Enum.isDefined devuelve un bool si
           // el valor pasado es valido para el tipoPasado
           // Para este caso no hace falta convertir "letra" al tipo Enum con Enum.Parse()
            if (!(Enum.IsDefined(typeof(TipoConsumoEnergetico),letra ))) {
                this.consumoEnergetico = TipoConsumoEnergetico.F;
                boolConsumo = false;
            }            
        }
        private void comprobarColor(string letra) {
            if (!(Enum.IsDefined(typeof(TipoColor), letra))) {
                this.color = TipoColor.Blanco;
                boolColor = false;
            }
        }

        // Metodo de Testeo que muestra datos
        public void mostrarDatos() {
            Console.WriteLine("{0} {1} {2} {3}",PrecioBase,Peso,Color,ConsumoEnergetico);
        }

    } // Fin de la clase
}
