namespace RegisztracioAlkalmazas
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.label_Nev = new System.Windows.Forms.Label();
            this.label_SzulDatum = new System.Windows.Forms.Label();
            this.label_Nem = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.textBox_SzulDatum = new System.Windows.Forms.TextBox();
            this.radioButton_Ferfi = new System.Windows.Forms.RadioButton();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.label_KedvencHobbi = new System.Windows.Forms.Label();
            this.listBox_Hobbik = new System.Windows.Forms.ListBox();
            this.label_UjHobbi = new System.Windows.Forms.Label();
            this.textBox_UjHobbi = new System.Windows.Forms.TextBox();
            this.button_HobbiHozzaad = new System.Windows.Forms.Button();
            this.button_Mentes = new System.Windows.Forms.Button();
            this.button_Betoltes = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label_KivalasztottHobbi = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label_Nev
            // 
            this.label_Nev.AutoSize = true;
            this.label_Nev.Location = new System.Drawing.Point(80, 36);
            this.label_Nev.Name = "label_Nev";
            this.label_Nev.Size = new System.Drawing.Size(40, 20);
            this.label_Nev.TabIndex = 0;
            this.label_Nev.Text = "Név:";
            // 
            // label_SzulDatum
            // 
            this.label_SzulDatum.AutoSize = true;
            this.label_SzulDatum.Location = new System.Drawing.Point(23, 80);
            this.label_SzulDatum.Name = "label_SzulDatum";
            this.label_SzulDatum.Size = new System.Drawing.Size(97, 20);
            this.label_SzulDatum.TabIndex = 1;
            this.label_SzulDatum.Text = "Szül. dátum:";
            // 
            // label_Nem
            // 
            this.label_Nem.AutoSize = true;
            this.label_Nem.Location = new System.Drawing.Point(74, 125);
            this.label_Nem.Name = "label_Nem";
            this.label_Nem.Size = new System.Drawing.Size(46, 20);
            this.label_Nem.TabIndex = 2;
            this.label_Nem.Text = "Nem:";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(158, 33);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(151, 26);
            this.textBox_Nev.TabIndex = 3;
            // 
            // textBox_SzulDatum
            // 
            this.textBox_SzulDatum.Location = new System.Drawing.Point(158, 77);
            this.textBox_SzulDatum.Name = "textBox_SzulDatum";
            this.textBox_SzulDatum.Size = new System.Drawing.Size(151, 26);
            this.textBox_SzulDatum.TabIndex = 4;
            // 
            // radioButton_Ferfi
            // 
            this.radioButton_Ferfi.AutoSize = true;
            this.radioButton_Ferfi.Location = new System.Drawing.Point(169, 123);
            this.radioButton_Ferfi.Name = "radioButton_Ferfi";
            this.radioButton_Ferfi.Size = new System.Drawing.Size(59, 24);
            this.radioButton_Ferfi.TabIndex = 5;
            this.radioButton_Ferfi.TabStop = true;
            this.radioButton_Ferfi.Text = "Férfi";
            this.radioButton_Ferfi.UseVisualStyleBackColor = true;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Location = new System.Drawing.Point(250, 123);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(47, 24);
            this.radioButton_No.TabIndex = 6;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "Nő";
            this.radioButton_No.UseVisualStyleBackColor = true;
            // 
            // label_KedvencHobbi
            // 
            this.label_KedvencHobbi.AutoSize = true;
            this.label_KedvencHobbi.Location = new System.Drawing.Point(567, 39);
            this.label_KedvencHobbi.Name = "label_KedvencHobbi";
            this.label_KedvencHobbi.Size = new System.Drawing.Size(117, 20);
            this.label_KedvencHobbi.TabIndex = 7;
            this.label_KedvencHobbi.Text = "Kedvenc hobbi:";
            // 
            // listBox_Hobbik
            // 
            this.listBox_Hobbik.FormattingEnabled = true;
            this.listBox_Hobbik.ItemHeight = 20;
            this.listBox_Hobbik.Location = new System.Drawing.Point(571, 73);
            this.listBox_Hobbik.Name = "listBox_Hobbik";
            this.listBox_Hobbik.Size = new System.Drawing.Size(201, 84);
            this.listBox_Hobbik.TabIndex = 8;
            this.listBox_Hobbik.SelectedIndexChanged += new System.EventHandler(this.listBox_Hobbik_SelectedIndexChanged);
            // 
            // label_UjHobbi
            // 
            this.label_UjHobbi.AutoSize = true;
            this.label_UjHobbi.Location = new System.Drawing.Point(485, 185);
            this.label_UjHobbi.Name = "label_UjHobbi";
            this.label_UjHobbi.Size = new System.Drawing.Size(71, 20);
            this.label_UjHobbi.TabIndex = 9;
            this.label_UjHobbi.Text = "Új hobbi:";
            // 
            // textBox_UjHobbi
            // 
            this.textBox_UjHobbi.Location = new System.Drawing.Point(571, 182);
            this.textBox_UjHobbi.Name = "textBox_UjHobbi";
            this.textBox_UjHobbi.Size = new System.Drawing.Size(201, 26);
            this.textBox_UjHobbi.TabIndex = 10;
            // 
            // button_HobbiHozzaad
            // 
            this.button_HobbiHozzaad.Location = new System.Drawing.Point(674, 231);
            this.button_HobbiHozzaad.Name = "button_HobbiHozzaad";
            this.button_HobbiHozzaad.Size = new System.Drawing.Size(98, 33);
            this.button_HobbiHozzaad.TabIndex = 11;
            this.button_HobbiHozzaad.Text = "Hozzáad";
            this.button_HobbiHozzaad.UseVisualStyleBackColor = true;
            this.button_HobbiHozzaad.Click += new System.EventHandler(this.button_HobbiHozzaad_Click);
            // 
            // button_Mentes
            // 
            this.button_Mentes.Location = new System.Drawing.Point(571, 311);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(98, 32);
            this.button_Mentes.TabIndex = 12;
            this.button_Mentes.Text = "Mentés";
            this.button_Mentes.UseVisualStyleBackColor = true;
            this.button_Mentes.Click += new System.EventHandler(this.button_Mentes_Click);
            // 
            // button_Betoltes
            // 
            this.button_Betoltes.Location = new System.Drawing.Point(674, 311);
            this.button_Betoltes.Name = "button_Betoltes";
            this.button_Betoltes.Size = new System.Drawing.Size(98, 32);
            this.button_Betoltes.TabIndex = 13;
            this.button_Betoltes.Text = "Betöltés";
            this.button_Betoltes.UseVisualStyleBackColor = true;
            this.button_Betoltes.Click += new System.EventHandler(this.button_Betoltes_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "Ügyfél";
            // 
            // label_KivalasztottHobbi
            // 
            this.label_KivalasztottHobbi.AutoSize = true;
            this.label_KivalasztottHobbi.Location = new System.Drawing.Point(688, 39);
            this.label_KivalasztottHobbi.Name = "label_KivalasztottHobbi";
            this.label_KivalasztottHobbi.Size = new System.Drawing.Size(0, 20);
            this.label_KivalasztottHobbi.TabIndex = 14;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "Ügyfél";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 508);
            this.Controls.Add(this.label_KivalasztottHobbi);
            this.Controls.Add(this.button_Betoltes);
            this.Controls.Add(this.button_Mentes);
            this.Controls.Add(this.button_HobbiHozzaad);
            this.Controls.Add(this.textBox_UjHobbi);
            this.Controls.Add(this.label_UjHobbi);
            this.Controls.Add(this.listBox_Hobbik);
            this.Controls.Add(this.label_KedvencHobbi);
            this.Controls.Add(this.radioButton_No);
            this.Controls.Add(this.radioButton_Ferfi);
            this.Controls.Add(this.textBox_SzulDatum);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label_Nem);
            this.Controls.Add(this.label_SzulDatum);
            this.Controls.Add(this.label_Nev);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form";
            this.Text = "Regisztráció Alkalmazás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Nev;
        private System.Windows.Forms.Label label_SzulDatum;
        private System.Windows.Forms.Label label_Nem;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.TextBox textBox_SzulDatum;
        private System.Windows.Forms.RadioButton radioButton_Ferfi;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.Label label_KedvencHobbi;
        private System.Windows.Forms.ListBox listBox_Hobbik;
        private System.Windows.Forms.Label label_UjHobbi;
        private System.Windows.Forms.TextBox textBox_UjHobbi;
        private System.Windows.Forms.Button button_HobbiHozzaad;
        private System.Windows.Forms.Button button_Mentes;
        private System.Windows.Forms.Button button_Betoltes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label_KivalasztottHobbi;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

