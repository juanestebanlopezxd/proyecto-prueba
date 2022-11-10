namespace Test3
{
    partial class FormSalones
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
            this.GPsavebloque = new System.Windows.Forms.GroupBox();
            this.butonsave = new System.Windows.Forms.Button();
            this.textBoxnumsal = new System.Windows.Forms.TextBox();
            this.textBoxbloque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submenusalones = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnaggsal = new System.Windows.Forms.Button();
            this.textBoxidsalon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GPsavebloque.SuspendLayout();
            this.submenusalones.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPsavebloque
            // 
            this.GPsavebloque.BackColor = System.Drawing.Color.LightSlateGray;
            this.GPsavebloque.Controls.Add(this.label3);
            this.GPsavebloque.Controls.Add(this.textBoxidsalon);
            this.GPsavebloque.Controls.Add(this.butonsave);
            this.GPsavebloque.Controls.Add(this.textBoxnumsal);
            this.GPsavebloque.Controls.Add(this.textBoxbloque);
            this.GPsavebloque.Controls.Add(this.label2);
            this.GPsavebloque.Controls.Add(this.label1);
            this.GPsavebloque.Location = new System.Drawing.Point(65, 12);
            this.GPsavebloque.Name = "GPsavebloque";
            this.GPsavebloque.Size = new System.Drawing.Size(515, 554);
            this.GPsavebloque.TabIndex = 21;
            this.GPsavebloque.TabStop = false;
            this.GPsavebloque.Text = "groupBox1";
            this.GPsavebloque.Visible = false;
            // 
            // butonsave
            // 
            this.butonsave.Location = new System.Drawing.Point(224, 321);
            this.butonsave.Name = "butonsave";
            this.butonsave.Size = new System.Drawing.Size(75, 23);
            this.butonsave.TabIndex = 6;
            this.butonsave.Text = "Guardar";
            this.butonsave.UseVisualStyleBackColor = true;
            this.butonsave.Click += new System.EventHandler(this.butonsave_Click);
            // 
            // textBoxnumsal
            // 
            this.textBoxnumsal.Location = new System.Drawing.Point(214, 239);
            this.textBoxnumsal.Name = "textBoxnumsal";
            this.textBoxnumsal.Size = new System.Drawing.Size(100, 23);
            this.textBoxnumsal.TabIndex = 4;
            // 
            // textBoxbloque
            // 
            this.textBoxbloque.Location = new System.Drawing.Point(224, 172);
            this.textBoxbloque.Name = "textBoxbloque";
            this.textBoxbloque.Size = new System.Drawing.Size(100, 23);
            this.textBoxbloque.TabIndex = 3;
            this.textBoxbloque.TextChanged += new System.EventHandler(this.textBoxbloque_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese numero del salon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese bloque";
            // 
            // submenusalones
            // 
            this.submenusalones.BackColor = System.Drawing.Color.ForestGreen;
            this.submenusalones.Controls.Add(this.button1);
            this.submenusalones.Controls.Add(this.button2);
            this.submenusalones.Controls.Add(this.btnaggsal);
            this.submenusalones.Location = new System.Drawing.Point(12, 123);
            this.submenusalones.Name = "submenusalones";
            this.submenusalones.Size = new System.Drawing.Size(153, 164);
            this.submenusalones.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(9, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 55);
            this.button1.TabIndex = 22;
            this.button1.Text = "Modificar salones";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(9, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "Eliminar salon";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnaggsal
            // 
            this.btnaggsal.FlatAppearance.BorderSize = 0;
            this.btnaggsal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnaggsal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaggsal.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnaggsal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnaggsal.Location = new System.Drawing.Point(3, 3);
            this.btnaggsal.Name = "btnaggsal";
            this.btnaggsal.Size = new System.Drawing.Size(131, 36);
            this.btnaggsal.TabIndex = 20;
            this.btnaggsal.Text = "Agregar salon";
            this.btnaggsal.UseVisualStyleBackColor = true;
            this.btnaggsal.Click += new System.EventHandler(this.btnaggsal_Click);
            // 
            // textBoxidsalon
            // 
            this.textBoxidsalon.Location = new System.Drawing.Point(214, 292);
            this.textBoxidsalon.Name = "textBoxidsalon";
            this.textBoxidsalon.Size = new System.Drawing.Size(100, 23);
            this.textBoxidsalon.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese id del salon";
            // 
            // FormSalones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 578);
            this.Controls.Add(this.submenusalones);
            this.Controls.Add(this.GPsavebloque);
            this.Name = "FormSalones";
            this.Text = "Salones";
            this.GPsavebloque.ResumeLayout(false);
            this.GPsavebloque.PerformLayout();
            this.submenusalones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GPsavebloque;
        private Button butonsave;
        private TextBox textBoxnumsal;
        private TextBox textBoxbloque;
        private Label label2;
        private Label label1;
        private Panel submenusalones;
        private Button button1;
        private Button button2;
        private Button btnaggsal;
        private Label label3;
        private TextBox textBoxidsalon;
    }
}