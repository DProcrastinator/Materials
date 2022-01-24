using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.CodeDom;

namespace Materials
{
   [Serializable]
  public  class Material
    {
        public string filePath { get; set; }
        //public MaterialTypes type { get; set; }

        // public List<string> searchtags;
        //public enum MaterialTypes
        //{
        //    Doc,
        //    Text,
        //    PDF,
        //    Slide,
        //    spreadsheet,
        //    image   
        //}
        public Material(string fileLocation)
        {
            filePath = fileLocation;
        }
        internal void start()
        {
            Process.Start(filePath);
        }
    }

    [Serializable]
  public class MaterialList
    { 
       public List<Material> materials;

        public MaterialList()
        {
            materials = new List<Material>();
        }
        internal void Add(Material material)
        {
            materials.Add(material);
        }
      
    }
}
