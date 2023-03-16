using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Progra3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Municipio[] muni = new Municipio[48];

            muni[0] = new Municipio("Chalatenango", "Nueva Concepcion");
            muni[1] = new Municipio("Chalatenango", "Agua Caliente");
            muni[2] = new Municipio("Chalatenango", "Azacualpa");
            muni[3] = new Municipio("Chalatenango", "Potonico");
            muni[4] = new Municipio("Chalatenango", "El Paraiso");
            muni[5] = new Municipio("Chalatenango", "La Laguna");
            muni[6] = new Municipio("Chalatenango", "Ojos de Agua");
            muni[7] = new Municipio("Chalatenango", "Tejutla");
            muni[8] = new Municipio("Cabañas", "Dolores");
            muni[9] = new Municipio("Cabañas", "Jutiapa");
            muni[10] = new Municipio("Cabañas", "Victoria");
            muni[11] = new Municipio("Cabañas", "Tejutepeque");
            muni[12] = new Municipio("Cabañas", "San Isidro");
            muni[13] = new Municipio("Cabañas", "Guacotecti");
            muni[14] = new Municipio("Cabañas", "Sensutepeque");
            muni[15] = new Municipio("Cabañas", "Cinquera");
            muni[16] = new Municipio("Cuscatlán", "Candelaria");
            muni[17] = new Municipio("Cuscatlán", "El Carmen");
            muni[18] = new Municipio("Cuscatlán", "El Rosario");
            muni[19] = new Municipio("Cuscatlán", "San Cristóbal\r\n");
            muni[20] = new Municipio("Cuscatlán", "Tenancingo");
            muni[21] = new Municipio("Cuscatlán", "San Ramón");
            muni[22] = new Municipio("Cuscatlán", "San Rafael Cedros");
            muni[23] = new Municipio("Cuscatlán", "Suchitoto");
            muni[24] = new Municipio("La Libertad", "Chiltiupán");
            muni[25] = new Municipio("La Libertad", "Ciudad Arce");
            muni[26] = new Municipio("La Libertad", "Colón");
            muni[27] = new Municipio("La Libertad", "Comasagua");
            muni[28] = new Municipio("La Libertad", "Huizúcar");
            muni[29] = new Municipio("La Libertad", "Jayaque");
            muni[30] = new Municipio("La Libertad", "Jicalapa");
            muni[31] = new Municipio("La Libertad", "La Libertad");
            muni[32] = new Municipio("La Paz", "El Rosario");
            muni[33] = new Municipio("La Paz", "Jerusalén");
            muni[34] = new Municipio("La Paz", "Mercedes La Ceiba");
            muni[35] = new Municipio("La Paz", "Olocuilta");
            muni[36] = new Municipio("La Paz", "Paraíso de Osorio");
            muni[37] = new Municipio("La Paz", "San Antonio Masahuat");
            muni[38] = new Municipio("La Paz", "San Emigdio");
            muni[39] = new Municipio("La Paz", "San Francisco Chinameca");
            muni[40] = new Municipio("Morazán", "Cacaopersona");
            muni[41] = new Municipio("Morazán", "Chilanga");
            muni[42] = new Municipio("Morazán", "Corinto");
            muni[43] = new Municipio("Morazán", "Delicias de Concepción");
            muni[44] = new Municipio("Morazán", "El Divisadero");
            muni[45] = new Municipio("Morazán", "El Rosario");
            muni[46] = new Municipio("Morazán", "Gualococti");
            muni[47] = new Municipio("Morazán", "Guatajiagua");

            Console.WriteLine("Bienvenido cuantos registros desea guardar?");
            int cant = Convert.ToInt32(Console.ReadLine());
            Persona[] person = new Persona[cant];
            for (int k = 0; k < cant; k ++)
            {
                Console.Clear();
                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escriba un departamento Chalatenango, Cabañas, Cuscatlán, La Libertad, La Paz, Morazán");
                string depa = Console.ReadLine();

                Console.Clear();
                for (int i = 0; i < muni.Length; i++)
                {
                    if (muni[i].departamento == depa)
                    {
                        Console.WriteLine(i + " - " + muni[i].muni);
                    }

                }
                Console.WriteLine("Seleccione un muni");
                int opc = Convert.ToInt32(Console.ReadLine());

                person[k] = new Persona(nombre, edad, muni[opc].departamento, muni[opc].muni);
            }
            Console.Clear();
            for (int i = 0; i < person.Length; i++)
            {
                Console.WriteLine(person[i]+" edad = "+person[i].edad);
            }
            Console.ReadLine();
        }

        public class Persona
        {
            public string nombre { get; set; }
            public string departamento { get; set; }
            public string muni { get; set; }
            public int edad { get; set; }
            public Persona(string nombre, int edad, string departamento, string muni)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.departamento = departamento;
                this.muni = muni;
            }
        }

        public abstract class Departamento
        {
            public abstract string departamento { get; set; }
        }

        public class Municipio : Departamento
        {
            public string muni { get; set; }
            public override string departamento { get; set; }

            public Municipio(string departamento, string muni)
            {
                this.departamento = departamento;
                this.muni = muni;
            }
        }
    }
}