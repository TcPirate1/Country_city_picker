namespace Country_city_picker
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
            this.CountryListBox = new System.Windows.Forms.ListBox();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.NameEntryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CountryListBox
            // 
            this.CountryListBox.FormattingEnabled = true;
            this.CountryListBox.Location = new System.Drawing.Point(408, 102);
            this.CountryListBox.Name = "CountryListBox";
            this.CountryListBox.Size = new System.Drawing.Size(120, 95);
            this.CountryListBox.TabIndex = 0;
            this.CountryListBox.SelectedIndexChanged += new System.EventHandler(this.CountryListBox_SelectedIndexChanged);
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(534, 102);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(121, 21);
            this.CityComboBox.TabIndex = 1;
            // 
            // NameEntryTextBox
            // 
            this.NameEntryTextBox.Location = new System.Drawing.Point(81, 102);
            this.NameEntryTextBox.Name = "NameEntryTextBox";
            this.NameEntryTextBox.Size = new System.Drawing.Size(167, 20);
            this.NameEntryTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a Country and City from the List";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(316, 299);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(105, 37);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "Submit";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameEntryTextBox);
            this.Controls.Add(this.CityComboBox);
            this.Controls.Add(this.CountryListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CountryListBox;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.TextBox NameEntryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button1;
    }
}

