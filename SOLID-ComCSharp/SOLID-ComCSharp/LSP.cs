using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID_ComCSharp
{
    class LSP
    {
    }

    public class A
    {
        public void GetNome()
        {
            Console.WriteLine("Meu nome é A");
        }
    }

    public class B : A
    {
        public new void GetNome()
        {
            Console.WriteLine("Meu nome é B");
        }
    }

    public class Program
    {
        public static void ImprimeNome(A objeto)
        {
            objeto.GetNome();
        }

        public static void Main(string[] args)
        {
            A objeto1 = new A();
            B objeto2 = new B();

            ImprimeNome(objeto1); // Meu nome é A
            ImprimeNome(objeto2); // Meu nome é B
        }
    }






    internal class ContratoDeTrabalho
    {
    }

    //# - Sobrescrevendo um método que não faz nada...
    class Voluntario : ContratoDeTrabalho
    {
        public static void Remuneracao()
        {
            // não faz nada
        }
    }


    //# - Lançando uma exceção inesperada...
    class MusicPlay
    {
        public void Play(string file)
        {
            // toca a música
        }
    }

    class Mp3MusicPlay : MusicPlay
    {
        public static void Play(string file)
        {
            if (Path.GetExtension(file) != ".mp3")
            {
                throw new Exception();
            }
            // toca a música
        }
    }

    //# - Retornando valores de tipos diferentes...
    class Auth
    {
        public bool CheckCredentials(string login, string password)
        {
            // faz alguma coisa
            return true;
        }
    }

    class AuthApi : Auth
    {
        public new Dictionary<string, object> CheckCredentials(string login, string password)
        {
            // faz alguma coisa
            return new Dictionary<string, object> { { "auth", true }, { "status", 200 } };
        }
    }









}



