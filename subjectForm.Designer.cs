namespace Materials
{
    partial class subjectForm
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
            this.btn_addmaterial = new System.Windows.Forms.Button();
            this.materialView = new System.Windows.Forms.ListView();
            this.delete_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addmaterial
            // 
            this.btn_addmaterial.Location = new System.Drawing.Point(3, 484);
            this.btn_addmaterial.Name = "btn_addmaterial";
            this.btn_addmaterial.Size = new System.Drawing.Size(158, 23);
            this.btn_addmaterial.TabIndex = 20;
            this.btn_addmaterial.Text = "Add Material ";
            this.btn_addmaterial.UseVisualStyleBackColor = true;
            this.btn_addmaterial.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialView
            // 
            this.materialView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.materialView.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.materialView.HideSelection = false;
            this.materialView.Location = new System.Drawing.Point(3, 12);
            this.materialView.Name = "materialView";
            this.materialView.Size = new System.Drawing.Size(822, 466);
            this.materialView.TabIndex = 21;
            this.materialView.UseCompatibleStateImageBehavior = false;
            this.materialView.DoubleClick += new System.EventHandler(this.materialView_DoubleClick);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(181, 484);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(155, 23);
            this.delete_btn.TabIndex = 22;
            this.delete_btn.Text = "Delete Material";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // subjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 512);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.materialView);
            this.Controls.Add(this.btn_addmaterial);
            this.MaximizeBox = false;
            this.Name = "subjectForm";
            this.Text = "subjectForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addmaterial;
        private System.Windows.Forms.ListView materialView;
        private System.Windows.Forms.Button delete_btn;
    }
}