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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Subjects";
            this.searchView.View = System.Windows.Forms.View.List;
            subjects = new subjects();
            
          subjects.Load(@"D:\subject.txt");

            form2 = new Form2();
            ShowInListView();

            imageList = new ImageList();
            imageList.ImageSize = new Size( 64,64);


            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.Images.Add(Properties.Resources.folder);

            subjectView.LargeImageList = imageList;
            searchView.SmallImageList = imageList;

            form2.savebtnDown += Form2_savebtnDown;
          
        }

       

        public subjects subjects;
        public ImageList imageList;
        public Form2 form2;
        

        private void addsub_btn_Click(object sender, EventArgs e)
        {
            if (subject_box.Text != "")
            {
                subjects.addSubjct(subject_box.Text);
              
                subjectView.Items.Add(subject_box.Text);
                addIcon();
                subject_box.Text = "";
                GlobalClass.openForm = true;
               
                
            }

            else
            {
                MessageBox.Show("enter subject name");
            }
        }
        private void addIcon()
        {          

            for (int i = 0; i < subjectView.Items.Count;  i++)
            { 
                    subjectView.Items[i].ImageIndex = 0;
               
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            subjects.Save();
            GlobalClass.openForm = false;
        }

        private void ShowInListView()
        {
            for (int i=0;i< subjects.listSubject.Count;i++)
            {
                subjectView.Items.Add(subjects.listSubject[i].Name);
                subjectView.Items[i].ImageIndex = 0;
      
            }
        }

       
      public  int index;
        private void btn_delete_Click(object sender, EventArgs e)
        {
      
                if (subjectView.SelectedItems.Count > 0)
                
                index = selectedIndex();
            if (index != -1)
                GlobalClass.openForm = true;
                    subjectView.Items.RemoveAt(index);
                    subjects.listSubject.RemoveAt(index);
                
                 
                   
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && subject_box.Text != " ")
            {
                subjects.addSubjct(subject_box.Text);
                subjectView.Items.Add(subject_box.Text);
                addIcon();
                subject_box.Text = "";
            }

        }

        //protected override void OnKeyPress(KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char) Keys.Enter && subject_box.Text != " ")
        //{
        //    subjects.addSubjct(subject_box.Text);
        //    subjectView.Items.Add(subject_box.Text);
        //    addIcon();
        //    subject_box.Text = "";
        //}
        //}

        private void subjectView_DoubleClick(object sender, EventArgs e)
        {
            index = selectedIndex();
            if (index != -1)
                subjects.OpenMaterials(index);//  listSubjectForm[index].showForm(subjects.listSubject[index]);
        }

        public int selectedIndex()
        {
            for (int i = 0; i < subjectView.Items.Count; i++)
            {
                if (subjectView.Items[i].Selected == true)
                { 
                    index = i;
                    return index;     
                    
                }
            }
            return -1;
        }

     

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            searchView.Visible = false;
        }

       

        private void showSearchResult()
        {
            if (subjects.searchResults.Count != 0)

                for (int i = 0; i < subjects.searchResults.Count; i++)
                {

                    searchView.Items.Add(subjects.searchResults[i].Name);
                    searchView.Items[i].ImageIndex = 0;
                }
            else
                searchView.Items.Add("No Results");
        }


        private void subjectView_MouseDown(object sender, MouseEventArgs e)
        {
            searchView.Visible = false;
        }

        private void subject_box_TextChanged(object sender, EventArgs e)
        {
            searchView.Visible = false;
           
        }

        private void searchView_DoubleClick(object sender, EventArgs e)
        {
            index = selectedSearchIndex();
            if (index != -1)
                subjects.searchResultopen(index);
        }


        public int selectedSearchIndex()
        {
            for (int i = 0; i < searchView.Items.Count; i++)
            {
                if (searchView.Items[i].Selected == true)
                {
                    index = i;
                    return index;
                }
            }
            return -1;
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {

            searchView.Items.Clear();
            searchView.Visible = true;
            subjects.checkForSubject((sender as TextBox).Text);
            subjects.checkForMaterial((sender as TextBox).Text);

            showSearchResult();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalClass.openForm)
                form2.ShowDialog();

           
            if (GlobalClass.cancelClicked)
            {
                e.Cancel = true;
                GlobalClass.cancelClicked = false;
            }
              
        }

        private void Form2_savebtnDown(object sender, EventArgs e)
        {
            subjects.Save();
        }
      
        private void searchView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
