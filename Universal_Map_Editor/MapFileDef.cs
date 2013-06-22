using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hunter_MapEditor
{
    class MapFileDef
    {
        public string nameIdentifier;
        public string fileType;

        public string separatorString;
        public bool separatorUsed;

        public string endLineString;
        public bool endLineUsed;

        public bool loadFromFile(string fileName)
        {


            return true;
        }

        public bool saveToFile()
        {
            string fileName = nameIdentifier + fileType;

            return true;
        }
    }
}
