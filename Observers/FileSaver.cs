using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observers
{
    public class FileSaver : IObserver<AbstractStringSubject>
    {
        private readonly string filename;// Ficheiro onde pôr as teclas pressionadas

        public FileSaver(string filename) //Construtor
        {
            this.filename = filename;
        }

        public void Update(AbstractStringSubject sub) //Update sempre que algo novo acontece
        {
            FileSaver.AppendAllText(filename, sub.key); //Guarda no ficheiro a ultima tecla pressionada
        }
    }
}