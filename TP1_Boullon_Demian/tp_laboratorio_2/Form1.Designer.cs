namespace tp_laboratorio_2
{
    partial class FormCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculadora));
            this.lblResultado = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.textBoxOperador1 = new System.Windows.Forms.TextBox();
            this.textBoxOperador2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResultado.Location = new System.Drawing.Point(12, 20);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(400, 35);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.BackColor = System.Drawing.Color.Silver;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClear.Location = new System.Drawing.Point(12, 119);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(188, 29);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "CC";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonIgual
            // 
            this.buttonIgual.AutoSize = true;
            this.buttonIgual.BackColor = System.Drawing.Color.Silver;
            this.buttonIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIgual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonIgual.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonIgual.Location = new System.Drawing.Point(206, 118);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(206, 30);
            this.buttonIgual.TabIndex = 3;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = false;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            this.buttonIgual.Resize += new System.EventHandler(this.buttonIgual_Click);
            // 
            // textBoxOperador1
            // 
            this.textBoxOperador1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxOperador1.Location = new System.Drawing.Point(12, 79);
            this.textBoxOperador1.Name = "textBoxOperador1";
            this.textBoxOperador1.Size = new System.Drawing.Size(157, 20);
            this.textBoxOperador1.TabIndex = 0;
            this.textBoxOperador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxOperador2
            // 
            this.textBoxOperador2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxOperador2.Location = new System.Drawing.Point(219, 79);
            this.textBoxOperador2.Name = "textBoxOperador2";
            this.textBoxOperador2.Size = new System.Drawing.Size(193, 20);
            this.textBoxOperador2.TabIndex = 2;
            this.textBoxOperador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.comboBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(175, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(38, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // FormCalculadora
            // 
            this.AcceptButton = this.buttonIgual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.BackgroundImage = global::tp_laboratorio_2.Properties.Resources.Penguins;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 162);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxOperador2);
            this.Controls.Add(this.textBoxOperador1);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.lblResultado);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(434, 200);
            this.MinimumSize = new System.Drawing.Size(434, 200);
            this.Name = "FormCalculadora";
            this.Text = "Calculadora";
            this.TransparencyKey = System.Drawing.SystemColors.ButtonShadow;
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.TextBox textBoxOperador1;
        private System.Windows.Forms.TextBox textBoxOperador2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

