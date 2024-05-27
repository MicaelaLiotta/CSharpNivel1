namespace TPFinal_Liotta;
class Program
{
    

//  Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

// a. El mayor de los números pares.
// b. La cantidad de números impares.
// c. El menor de los números primos.

// Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
   static bool Primo(int nro)
{
    
    if (nro <= 1)
        return false;
    for (int i = 2; i <= Math.Sqrt(nro); i++)
    {
        if (nro % i == 0)
            return false;
    }

    return true;
}
    static void Main(string[] args)
    {
        
        int n = 1, mayPar = 0, cantImpar = 0, menorprimo = int.MaxValue;
        bool banPar = false;

        while (n != 0)
        {
            Console.WriteLine("Ingresar un número");
            n = int.Parse(Console.ReadLine());

        if (n != 0)
        
        
          if (n % 2 == 0)
          {

           if (banPar == false)
           {
            mayPar = n;
            banPar = true;
           }
           else if (n > mayPar)
           mayPar = n;

          }
           
          else
          {
        
           cantImpar++; 
          }

        
        for (int i = 2; i <= n; i++)
            {
                if (Primo(i))
                {
                    if (i < menorprimo)
                    {
                        menorprimo = i;
                    }
                    break;
                }
                
            }
        }
        
        
    

        Console.WriteLine("El menor número primo es:" + menorprimo);
        Console.WriteLine("El mayor Par es:" + mayPar);
        Console.WriteLine("La cantidad de números impares es: " + cantImpar);
        
}
}



        


