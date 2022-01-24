using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materials
{
    [Serializable]
   public class subject
    {
        public string Name { get; set; }
        public MaterialList materiallist { get; set; }
        public subject()
        {

        }
        public  subject(string subject_name)
        {
            Name = subject_name;
            materiallist = new MaterialList();
          
        }

        internal void AddMaterial(Material material)
        {
            materiallist.Add(material);
        }

        internal void OpenMaterials()
        {
            subjectForm form = new subjectForm(this);
            form.ShowDialog();
        }
    }
}
