using System;

namespace ClasesYmetodosAbstractos
{
    public abstract class Animal
    {
        public abstract void HacerSonido(); // Método abstracto

        public void Dormir() // Método normal
        {
            Console.WriteLine("Durmiendo"); 
        }

        public virtual void Comer() // Método virtual
        {
            Console.WriteLine("Comiendo como un Animal");
        }
    }

    public class Perro : Animal
    {
        public override void HacerSonido() // Implementación del método abstracto
        {
            Console.WriteLine("Ladrando");
        }
        public override void Comer() // Sobrescritura del método virtual
        {
            Console.WriteLine("El Perro esta comiendo Croquetas");
        }
    }

    public class Gato : Animal
    {
        public override void HacerSonido() // Implementación del método abstracto
        {
            Console.WriteLine("Miau Miau");
        }
        public override void Comer() // Sobrescritura del método virtual
        {
            Console.WriteLine("El Gato esta comiendo Atún Princesa");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de las clases derivadas
            Animal miPerro = new Perro();
            miPerro.HacerSonido(); // Ladrando
            miPerro.Comer(); // El Perro esta comiendo Croquetas
            miPerro.Dormir(); // Durmiendo
            Animal miGato = new Gato();
            miGato.HacerSonido(); // Miau Miau
            miGato.Comer(); // El Gato esta comiendo Atún Princesa
            miGato.Dormir(); // Durmiendo
        }
    }
}
