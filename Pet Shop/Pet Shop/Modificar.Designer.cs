namespace Pet_Shop
{
    partial class Modificar
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
            this.label1 = new System.Windows.Forms.Label();
            this.textMod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNombreMod = new System.Windows.Forms.TextBox();
            this.textApellidoMod = new System.Windows.Forms.TextBox();
            this.textDireccionMod = new System.Windows.Forms.TextBox();
            this.btn_modificarr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa el ID a modificar:";
            // 
            // textMod
            // 
            this.textMod.Location = new System.Drawing.Point(15, 44);
            this.textMod.Name = "textMod";
            this.textMod.Size = new System.Drawing.Size(243, 22);
            this.textMod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa los datos a modificar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Direccion:";
            // 
            // textNombreMod
            // 
            this.textNombreMod.Location = new System.Drawing.Point(77, 132);
            this.textNombreMod.Name = "textNombreMod";
            this.textNombreMod.Size = new System.Drawing.Size(181, 22);
            this.textNombreMod.TabIndex = 6;
            // 
            // textApellidoMod
            // 
            this.textApellidoMod.Location = new System.Drawing.Point(77, 172);
            this.textApellidoMod.Name = "textApellidoMod";
            this.textApellidoMod.Size = new System.Drawing.Size(181, 22);
            this.textApellidoMod.TabIndex = 7;
            // 
            // textDireccionMod
            // 
            this.textDireccionMod.Location = new System.Drawing.Point(77, 211);
            this.textDireccionMod.Name = "textDireccionMod";
            this.textDireccionMod.Size = new System.Drawing.Size(181, 22);
            this.textDireccionMod.TabIndex = 8;
            // 
            // btn_modificarr
            // 
            this.btn_modificarr.Location = new System.Drawing.Point(177, 252);
            this.btn_modificarr.Name = "btn_modificarr";
            this.btn_modificarr.Size = new System.Drawing.Size(81, 38);
            this.btn_modificarr.TabIndex = 9;
            this.btn_modificarr.Text = "Modificar";
            this.btn_modificarr.UseVisualStyleBackColor = true;
            this.btn_modificarr.Click += new System.EventHandler(this.btn_modificarr_Click);
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 302);
            this.Controls.Add(this.btn_modificarr);
            this.Controls.Add(this.textDireccionMod);
            this.Controls.Add(this.textApellidoMod);
            this.Controls.Add(this.textNombreMod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMod);
            this.Controls.Add(this.label1);
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNombreMod;
        private System.Windows.Forms.TextBox textApellidoMod;
        private System.Windows.Forms.TextBox textDireccionMod;
        private System.Windows.Forms.Button btn_modificarr;
    }
}