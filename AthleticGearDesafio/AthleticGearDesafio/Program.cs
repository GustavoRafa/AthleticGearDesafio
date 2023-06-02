using System;
using System.Text.RegularExpressions;

class AthleticGearDesafio
{
    public static void Main()
    {
        //SENHAS
        string[] senhas = new string[] { "#forTe1", "senhafraca", "Qu@s1", "Voce@Consegue!2023" };

        for (int i = 0; i < senhas.Length; i++)
        {
            if (validarNumerosCharacter(senhas[i].Length) == true && validarLetraMaiscula(senhas[i]) == true && validarLetraMinuscula(senhas[i]) == true
                && validarNumero(senhas[i]) == true && validarCharacterEspecial(senhas[i]) == true)
            {
                Console.WriteLine(senhas[i] + "\n");
            }
        }
    }

    // FUNÇÃO PARA VERIFICAR A QUANTIDADE DE CARACTERES NA SENHA
    static bool validarNumerosCharacter(int senhas)
    {
        bool valido = false;

        for (int i = 0; i < senhas; i++)
        {
            if (senhas >= 7)
                valido = true;
            else
                valido = false;
        }

        return valido;

    }

    // FUNÇÃO PARA VERIFICAR SE HÁ ALGUMA LETRA MAIUSCULA NA SENHA
    static bool validarLetraMaiscula(string senhas)
    {
        bool valido = false;

        for (int i = 0; i < senhas.Length; i++)
        {
            if (char.IsUpper(senhas[i]))
                return true;
            else
                valido = false;
        }

            return valido;
    }

    // FUNÇÃO PARA VERIFICAR SE HÁ ALGUMA LETRA MINUSCULA NA SENHA
    static bool validarLetraMinuscula(string senhas)
    {
        bool valido = false;

        for (int i = 0; i < senhas.Length; i++)
        {
            if (char.IsLower(senhas[i]))
                return true;
            else
                valido = false;
        }

        return valido;
    }

    // FUNÇÃO PARA VERIFICAR SE HÁ ALGUM NÚMERO NA SENHA
    static bool validarNumero(string senhas)
    {
        bool valido = false;

        for (int i = 0; i < senhas.Length; i++)
        {
            if (char.IsNumber(senhas[i]))
                return true;
            else
                valido = false;
        }

        return valido;
    }

    // FUNÇÃO PARA VERIFICAR SE HÁ ALGUM CARACTER ESPECIAL NA SENHA
    static bool validarCharacterEspecial(string senhas)
    {
        bool valido = false;; 
        

        for (int i = 0; i < senhas.Length; i++)
        {
            if (HasSpecialCharacters(senhas))
                return true;
            else
                valido = false;
        }

        return valido;
    }

    //Esta funcao HasSpecialCharacters, eu pesquisei no google como fazer uma verificacao de caracteres e encontrei no stackoverflow
    static bool HasSpecialCharacters(string input)
    {
        Regex regex = new Regex("[^a-zA-Z0-9]");
        return regex.IsMatch(input);
    }

}