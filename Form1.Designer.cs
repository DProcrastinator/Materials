namespace Materials
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.subjectView = new System.Windows.Forms.ListView();
            this.addsub_btn = new System.Windows.Forms.Button();
            this.subject_box = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.searchbox = new System.Windows.Forms.Label();
            this.searchView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // subjectView
            // 
            this.subjectView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.subjectView.HideSelection = false;
            this.subjectView.Location = new System.Drawing.Point(9, 82);
            this.subjectView.Name = "subjectView";
            this.subjectView.Size = new System.Drawing.Size(815, 399);
            this.subjectView.TabIndex = 1;
            this.subjectView.UseCompatibleStateImageBehavior = false;
            this.subjectView.DoubleClick += new System.EventHandler(this.subjectView_DoubleClick);
            this.subjectView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.subjectView_MouseDown);
            // 
            // addsub_btn
            // 
            this.addsub_btn.Location = new System.Drawing.Point(285, 23);
            this.addsub_btn.Name = "addsub_btn";
            this.addsub_btn.Size = new System.Drawing.Size(124, 23);
            this.addsub_btn.TabIndex = 2;
            this.addsub_btn.Text = "Add Subject";
            this.addsub_btn.UseVisualStyleBackColor = true;
            this.addsub_btn.Click += new System.EventHandler(this.addsub_btn_Click);
            // 
            // subject_box
            // 
            this.subject_box.Location = new System.Drawing.Point(9, 23);
            this.subject_box.Name = "subject_box";
            this.subject_box.Size = new System.Drawing.Size(258, 20);
            this.subject_box.TabIndex = 3;
            this.subject_box.TextChanged += new System.EventHandler(this.subject_box_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(9, 487);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(196, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(9, 53);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 23);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete Subject";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // textbox_search
            // 
            this.textbox_search.Location = new System.Drawing.Point(438, 23);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(339, 20);
            this.textbox_search.TabIndex = 13;
            this.textbox_search.TextChanged += new System.EventHandler(this.textbox_search_TextChanged);
            // 
            // searchbox
            // 
            this.searchbox.AutoSize = true;
            this.searchbox.Location = new System.Drawing.Point(435, 9);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(62, 13);
            this.searchbox.TabIndex = 14;
            this.searchbox.Text = "SearchBox:";
            // 
            // searchView
            // 
            this.searchView.HideSelection = false;
            this.searchView.Location = new System.Drawing.Point(438, 49);
            this.searchView.Name = "searchView";
            this.searchView.Size = new System.Drawing.Size(339, 236);
            this.searchView.TabIndex = 15;
            this.searchView.UseCompatibleStateImageBehavior = false;
            this.searchView.Visible = false;
            this.searchView.SelectedIndexChanged += new System.EventHandler(this.searchView_SelectedIndexChanged);
            this.searchView.DoubleClick += new System.EventHandler(this.searchView_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 519);
            this.Controls.Add(this.searchView);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.textbox_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.subject_box);
            this.Controls.Add(this.addsub_btn);
            this.Controls.Add(this.subjectView);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
           // this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView subjectView;
        private System.Windows.Forms.Button addsub_btn;
        private System.Windows.Forms.TextBox subject_box;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Label searchbox;
        private System.Windows.Forms.ListView searchView;
    }
}

