using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materials
{
    public partial class subjectForm : Form
    {
        public subjectForm(subject subject)
        {
            InitializeComponent();

            this.Text = subject.Name;
           
            selectedSubject = subject;

            ImageList = new ImageList();
            ImageList.ImageSize = new Size(30,30);
            ImageList.ColorDepth = ColorDepth.Depth32Bit;
           
            materialView.LargeImageList = ImageList;
            materialList = new MaterialList();
           DisplayAllMaterials();
        }
        private void DisplayAllMaterials()
        {  
            foreach(Material m in selectedSubject.materiallist.materials)
            {
                showInView(m);
            }
        }
        public subject selectedSubject;
        public Material material;
        public ImageList ImageList;
        public MaterialList materialList;
      
        string filelocation;
        private void button1_Click(object sender, EventArgs e)
        {

            filelocation = openDialogBox();
            if(filelocation !="")
            {
                material = new Material(filelocation);
                selectedSubject.AddMaterial(material);
                showInView(material);
                GlobalClass.openForm = true;
            }
          
        }

        private string openDialogBox()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*  | Pdf Files|*.pdf  " +
            //     "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png" +
            //    "Office Files|*.doc;*.xls;*.ppt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
               
                return destinationFileName(openFileDialog.FileName);
                //return openFileDialog.FileName;
                 return "";
            
        }
         public FileInfo fileInfo;
        private string destinationFileName(string fileToCopy)
        {
           
            string destDirectory = @"D:\c#\";
            string destFile = destDirectory + Path.GetFileName(fileToCopy); 
            File.Copy(fileToCopy, destFile,true);

            return destFile;
        }
        private void showInView(Material material)
        { 
            ImageList.Images.Add(GetIconofFile(material.filePath));
            materialView.Items.Add(new FileInfo(material.filePath).Name, ImageList.Images.Count-1);
        }

        private Image GetIconofFile(string filePath)
        {
          return System.Drawing.Icon.ExtractAssociatedIcon(filePath).ToBitmap();
        }

        private void materialView_DoubleClick(object sender, EventArgs e)
        {
            //if (materialView.SelectedItems.Count >= 1)
            //{
            //    selectedSubject.materiallist.materials[materialView.Items.IndexOf(materialView.SelectedItems[0])].start();
            //}
            for (int i = 0; i < materialView.Items.Count; i++)
            {
                if (materialView.Items[i].Selected == true)
                {
                    index = i;
                    selectedSubject.materiallist.materials[index].start();
                }
            }
        }
        int index;
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (materialView.SelectedItems.Count > 0)

                //&&
                //materialList.materials.Count > 0
            {
                index = selectedIndex();

                if (index != -1)
                {
                    materialView.Items.RemoveAt(index);
                     File.Delete(selectedSubject.materiallist.materials[index].filePath);
                   selectedSubject.materiallist.materials.RemoveAt(index);
                   
                                
                }
            }
     }
        public int selectedIndex()
        {
            for (int i = 0; i < materialView.Items.Count; i++)
            {
                if (materialView.Items[i].Selected == true)
                {
                    index = i;
                    return index;

                }
            }
            return -1;
        }

    
        
    }
}
 