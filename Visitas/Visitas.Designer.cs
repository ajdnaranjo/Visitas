namespace Visits.App
{
    partial class Visitas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.cbDocType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.cbSeller = new System.Windows.Forms.ComboBox();
            this.dtpVisitDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Page1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Page1);
            this.tabControl1.Controls.Add(this.Page2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 544);
            this.tabControl1.TabIndex = 0;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.label11);
            this.Page1.Controls.Add(this.cbDocType);
            this.Page1.Controls.Add(this.btnSave);
            this.Page1.Controls.Add(this.txtObservations);
            this.Page1.Controls.Add(this.cbSeller);
            this.Page1.Controls.Add(this.dtpVisitDate);
            this.Page1.Controls.Add(this.txtAddress);
            this.Page1.Controls.Add(this.txtMail);
            this.Page1.Controls.Add(this.txtPhone);
            this.Page1.Controls.Add(this.txtContactName);
            this.Page1.Controls.Add(this.txtClientName);
            this.Page1.Controls.Add(this.txtIdentification);
            this.Page1.Controls.Add(this.label10);
            this.Page1.Controls.Add(this.label9);
            this.Page1.Controls.Add(this.label8);
            this.Page1.Controls.Add(this.label7);
            this.Page1.Controls.Add(this.label6);
            this.Page1.Controls.Add(this.label5);
            this.Page1.Controls.Add(this.label4);
            this.Page1.Controls.Add(this.label3);
            this.Page1.Controls.Add(this.label2);
            this.Page1.Controls.Add(this.label1);
            this.Page1.Location = new System.Drawing.Point(4, 22);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(573, 518);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Registrar Visita";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tipo documento:";
            // 
            // cbDocType
            // 
            this.cbDocType.FormattingEnabled = true;
            this.cbDocType.Location = new System.Drawing.Point(201, 115);
            this.cbDocType.Name = "cbDocType";
            this.cbDocType.Size = new System.Drawing.Size(98, 21);
            this.cbDocType.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(463, 484);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(38, 362);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(500, 116);
            this.txtObservations.TabIndex = 18;
            // 
            // cbSeller
            // 
            this.cbSeller.FormattingEnabled = true;
            this.cbSeller.Location = new System.Drawing.Point(201, 305);
            this.cbSeller.Name = "cbSeller";
            this.cbSeller.Size = new System.Drawing.Size(337, 21);
            this.cbSeller.TabIndex = 17;
            // 
            // dtpVisitDate
            // 
            this.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVisitDate.Location = new System.Drawing.Point(201, 278);
            this.dtpVisitDate.Name = "dtpVisitDate";
            this.dtpVisitDate.Size = new System.Drawing.Size(199, 20);
            this.dtpVisitDate.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(201, 250);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(337, 20);
            this.txtAddress.TabIndex = 15;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(201, 223);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(199, 20);
            this.txtMail.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(201, 196);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(99, 20);
            this.txtPhone.TabIndex = 13;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(201, 169);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(337, 20);
            this.txtContactName.TabIndex = 12;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(201, 142);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(337, 20);
            this.txtClientName.TabIndex = 11;
            // 
            // txtIdentification
            // 
            this.txtIdentification.Location = new System.Drawing.Point(411, 115);
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.Size = new System.Drawing.Size(127, 20);
            this.txtIdentification.TabIndex = 10;
            this.txtIdentification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentification_KeyPress);
            this.txtIdentification.Leave += new System.EventHandler(this.txtIdentification_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha visita:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vendedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Observaciones:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Persona de contacto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visitas clientes FerroIndustrial";
            // 
            // Page2
            // 
            this.Page2.Location = new System.Drawing.Point(4, 22);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Page2.Size = new System.Drawing.Size(556, 518);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "Buscar Visitas";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // Visitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 546);
            this.Controls.Add(this.tabControl1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Visitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitas";
            this.tabControl1.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.ComboBox cbSeller;
        private System.Windows.Forms.DateTimePicker dtpVisitDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Page2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbDocType;
    }
}

