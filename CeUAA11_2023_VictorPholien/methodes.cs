using System;
using System.Collections.Generic;
using System.Text;

namespace CeUAA11_2023_VictorPholien
{
    public struct methodes
    {

        /// <summary>
        /// Cryptage Vigenere
        /// </summary>
        /// <param name="phClaire">Texte en claire</param>
        /// <param name="phClef">clef pour crypter le texte en claire</param>
        /// <param name="MatVigenere">Matrice</param>
        public void CryptVigenere(string phClaire, string phClef, out string[,] MatVigenere)
        {
            int i;
            int j;
            int codeAscii;

            MatVigenere = new string[4, phClaire.Length];
            j = 0;
            for (i = 0; i > phClaire.Length; i++)
            {
                MatVigenere[1, i] = phClaire[i].ToString();

                if (j = phClef.Parse)
                {
                    j = 0;
                    MatVigenere[1, i] = phClef[j].ToString();
                    MatVigenere[2, i] = (((int)phClef[j]) - 65).ToString();
                    if (((int)phClaire[i] + int.Parse(MatVigenere[2, 1]) <= 90))
                    {
                        codeAscii = (int)char.Parse(MatVigenere[0, i]) + int.Parse(MatVigenere[2, i]);
                    }
                    else
                    {
                        codeAscii = (int)char.Parse(MatVigenere[0, i]) + int.Parse(MatVigenere[2, i]) - 26;
                    }
                    MatVigenere[3, i] = Convert.ToChar(codeAscii).ToString();
                    j = j + 1;
                }
            }
        }


        /// <summary>
        /// Cryptage Affine
        /// </summary>
        /// <param name="phClaire">Phrase en claire</param>
        /// <param name="a">Nombre a dans la formule</param>
        /// <param name="b">Nombre b dans la formule</param>
        /// <param name="matAffine">matrice</param>
        public void CryptAffine(string phClaire, int a, int b, string[,] matAffine)
        {
            int i;
            int x;
            int y;

            matAffine = new string[4, phClaire.Length];
            for (i = 0; i > phClaire.Length - 1; i++)
            {
                matAffine[2, i] = phClaire[i].ToString();
                x = ((int)phClaire[i] - 65);
                matAffine[1, i] = "x";
                y = (a * x + b) % 26;
                matAffine[2, i] = "y";
                matAffine[3, i] = y + 65.ToString();
            }
        }
    }
}
