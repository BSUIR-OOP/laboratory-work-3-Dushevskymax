namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowList = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ChooseFilm = new System.Windows.Forms.ComboBox();
            this.NameF = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Serialize = new System.Windows.Forms.Button();
            this.Deserialize = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Director = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowList
            // 
            this.ShowList.FormattingEnabled = true;
            this.ShowList.ItemHeight = 25;
            this.ShowList.Location = new System.Drawing.Point(504, 18);
            this.ShowList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShowList.Name = "ShowList";
            this.ShowList.Size = new System.Drawing.Size(263, 554);
            this.ShowList.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(17, 445);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(127, 37);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(279, 445);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(127, 37);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ChooseFilm
            // 
            this.ChooseFilm.FormattingEnabled = true;
            this.ChooseFilm.Location = new System.Drawing.Point(17, 18);
            this.ChooseFilm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChooseFilm.Name = "ChooseFilm";
            this.ChooseFilm.Size = new System.Drawing.Size(378, 33);
            this.ChooseFilm.TabIndex = 1;
            
            // 
            // NameF
            // 
            this.NameF.Location = new System.Drawing.Point(17, 110);
            this.NameF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NameF.Name = "NameF";
            this.NameF.Size = new System.Drawing.Size(155, 31);
            this.NameF.TabIndex = 2;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(17, 200);
            this.Year.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(155, 31);
            this.Year.TabIndex = 3;
            // 
            // Serialize
            // 
            this.Serialize.Location = new System.Drawing.Point(27, 530);
            this.Serialize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Serialize.Name = "Serialize";
            this.Serialize.Size = new System.Drawing.Size(117, 37);
            this.Serialize.TabIndex = 8;
            this.Serialize.Text = "Serialize";
            this.Serialize.UseVisualStyleBackColor = true;
            this.Serialize.Click += new System.EventHandler(this.Serialize_Click);
            // 
            // Deserialize
            // 
            this.Deserialize.Location = new System.Drawing.Point(153, 530);
            this.Deserialize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Deserialize.Name = "Deserialize";
            this.Deserialize.Size = new System.Drawing.Size(117, 37);
            this.Deserialize.TabIndex = 9;
            this.Deserialize.Text = "Deseriazize";
            this.Deserialize.UseVisualStyleBackColor = true;
            this.Deserialize.Click += new System.EventHandler(this.Deserialize_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(153, 445);
            this.Edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(117, 37);
            this.Edit.TabIndex = 6;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Year";
            // 
            // Director
            // 
            this.Director.Location = new System.Drawing.Point(17, 287);
            this.Director.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(155, 31);
            this.Director.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Director";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 602);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Deserialize);
            this.Controls.Add(this.Serialize);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.NameF);
            this.Controls.Add(this.ChooseFilm);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ShowList);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ShowList;
        private Button Add;
        private Button Delete;


        private ComboBox ChooseFilm;
        private TextBox NameF;
        private TextBox Year;
        private Button Serialize;
        private Button Deserialize;
        private Button Edit;
        private Label label1;
        private Label label2;
        private TextBox Director;
        private Label label3;
    }
}