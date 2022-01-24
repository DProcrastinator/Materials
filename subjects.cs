using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Materials
{
    [Serializable]
  public  class subjects
    {
      public  subjects()
        {
            subject = new subject();
            listSubject = new List<subject>();
            searchResults = new List<subject>();
         
        }
        public  List<subject> listSubject { get; set; }
        public subject subject;
        public List<subject> searchResults;
     
    

        internal void addSubjct(string subject_name)
        {
            listSubject.Add(new subject(subject_name));
                
        }
        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"D:\subject.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, this);
            stream.Close();

        }
        public void Load(string filename)
        {
            if (File.Exists(filename))//&& new FileInfo(filename).Length != 0 
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                subjects subjects = (subjects)formatter.Deserialize(stream);
                this.listSubject = subjects.listSubject;
                stream.Close();
            }
        }

        internal void OpenMaterials(int index)
        {
            listSubject[index].OpenMaterials();
        }

        internal void checkForSubject(string word)
        {

            searchResults.Clear();

            for (int i = 0; i < listSubject.Count; i++)
            {
                if (listSubject[i].Name.Contains(word))//  || listSubject[i].Name.StartsWith(word)
                    searchResults.Add(listSubject[i]);
            }

        }

        internal void searchResultopen(int index)
        {
           
            searchResults[index].OpenMaterials();
        }

        internal void checkForMaterial(string text)
        {
        //    for (int i = 0; i < listSubject.Count; i++)
        //    {
               
        //    }
        }
    }
}
