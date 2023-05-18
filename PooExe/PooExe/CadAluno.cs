using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExe
{   
    class SalaAula
    {
        public int SALA;
    }
    internal class CadAluno : SalaAula
    {
        public string NOME;
        public float[] NOTA = new float[4];

        public float CalMedia()
        {
            byte i;
            float SOMA = 0, MEDIA;
            
            for(i = 0; i < 3; i++)
                SOMA += NOTA[i];
            MEDIA = SOMA / 4;
            return MEDIA;
            
        }

    }
}
