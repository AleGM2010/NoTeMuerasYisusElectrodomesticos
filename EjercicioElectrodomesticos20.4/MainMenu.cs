using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioElectrodomesticos20._4 {
    class MainMenu {
        static void Main(string[] args) {

            // Precio , peso , color , consumo
            // Electrodomestico elec = new Electrodomestico(400,20,Electrodomestico.TipoColor.Negro,Electrodomestico.TipoConsumoEnergetico.E);
            Electrodomestico elec = new Electrodomestico(400, 20, "Rojo", "A");
            elec.mostrarDatos();

            
        }
    }
}
