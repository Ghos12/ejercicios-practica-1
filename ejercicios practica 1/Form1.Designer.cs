
namespace ejercicios_practica_1
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
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_num3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.comboOperaciones = new System.Windows.Forms.ComboBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_num1
            // 
            this.txt_num1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_num1.Location = new System.Drawing.Point(24, 27);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(57, 20);
            this.txt_num1.TabIndex = 5;
            this.txt_num1.Text = "Número 1";
            // 
            // txt_num2
            // 
            this.txt_num2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_num2.Location = new System.Drawing.Point(183, 27);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(56, 20);
            this.txt_num2.TabIndex = 6;
            this.txt_num2.Text = "Número 2";
            // 
            // txt_num3
            // 
            this.txt_num3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_num3.Location = new System.Drawing.Point(24, 128);
            this.txt_num3.Name = "txt_num3";
            this.txt_num3.Size = new System.Drawing.Size(71, 20);
            this.txt_num3.TabIndex = 7;
            this.txt_num3.Text = "Operaciones";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Window;
            this.btnCalcular.Location = new System.Drawing.Point(183, 117);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(86, 31);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // comboOperaciones
            // 
            this.comboOperaciones.FormattingEnabled = true;
            this.comboOperaciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "División"});
            this.comboOperaciones.Location = new System.Drawing.Point(24, 180);
            this.comboOperaciones.Name = "comboOperaciones";
            this.comboOperaciones.Size = new System.Drawing.Size(121, 21);
            this.comboOperaciones.TabIndex = 9;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(24, 77);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 10;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(183, 77);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.comboOperaciones);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txt_num3);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_num3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox comboOperaciones;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
    }
}