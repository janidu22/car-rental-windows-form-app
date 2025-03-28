namespace CarRental_app
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
            this.Title = new System.Windows.Forms.Label();
            this.Title2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.DtRented = new System.Windows.Forms.DateTimePicker();
            this.DtReturned = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CbTypeOfCar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBooking = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCustomerNic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Title.Font = new System.Drawing.Font("Arial Narrow", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title.Location = new System.Drawing.Point(434, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(187, 77);
            this.Title.TabIndex = 0;
            this.Title.Text = "Carva";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Title2
            // 
            this.Title2.AutoSize = true;
            this.Title2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2.Location = new System.Drawing.Point(455, 86);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(146, 22);
            this.Title2.TabIndex = 1;
            this.Title2.Text = "Rent A Car Now";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerName.Location = new System.Drawing.Point(58, 186);
            this.TxtCustomerName.Multiline = true;
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(388, 45);
            this.TxtCustomerName.TabIndex = 3;
            // 
            // DtRented
            // 
            this.DtRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtRented.Location = new System.Drawing.Point(586, 209);
            this.DtRented.Name = "DtRented";
            this.DtRented.Size = new System.Drawing.Size(437, 36);
            this.DtRented.TabIndex = 4;
            // 
            // DtReturned
            // 
            this.DtReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtReturned.Location = new System.Drawing.Point(586, 280);
            this.DtReturned.Name = "DtReturned";
            this.DtReturned.Size = new System.Drawing.Size(437, 36);
            this.DtReturned.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(604, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pickup Date / Drop off Date";
            // 
            // CbTypeOfCar
            // 
            this.CbTypeOfCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTypeOfCar.FormattingEnabled = true;
            this.CbTypeOfCar.Items.AddRange(new object[] {
            "Toyota Yaris",
            "Honda Fit",
            "Nissan Versa",
            "Hyundai Accent",
            "Kia Rio",
            "Toyota Corolla",
            "Honda Civic",
            "Nissan Altima",
            "Hyundai Elantra",
            "Mazda 3"});
            this.CbTypeOfCar.Location = new System.Drawing.Point(58, 465);
            this.CbTypeOfCar.Name = "CbTypeOfCar";
            this.CbTypeOfCar.Size = new System.Drawing.Size(388, 37);
            this.CbTypeOfCar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type Of The Car";
            // 
            // BtnBooking
            // 
            this.BtnBooking.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBooking.Location = new System.Drawing.Point(687, 465);
            this.BtnBooking.Name = "BtnBooking";
            this.BtnBooking.Size = new System.Drawing.Size(239, 59);
            this.BtnBooking.TabIndex = 9;
            this.BtnBooking.Text = "Confirm Booking";
            this.BtnBooking.UseVisualStyleBackColor = false;
            this.BtnBooking.Click += new System.EventHandler(this.BtnBooking_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Customer NIC";
            // 
            // TxtCustomerNic
            // 
            this.TxtCustomerNic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerNic.Location = new System.Drawing.Point(58, 305);
            this.TxtCustomerNic.Multiline = true;
            this.TxtCustomerNic.Name = "TxtCustomerNic";
            this.TxtCustomerNic.Size = new System.Drawing.Size(388, 45);
            this.TxtCustomerNic.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(604, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cost ";
            // 
            // TxtCost
            // 
            this.TxtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCost.Location = new System.Drawing.Point(586, 380);
            this.TxtCost.Multiline = true;
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(437, 45);
            this.TxtCost.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1086, 565);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCustomerNic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnBooking);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbTypeOfCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtReturned);
            this.Controls.Add(this.DtRented);
            this.Controls.Add(this.TxtCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.DateTimePicker DtRented;
        private System.Windows.Forms.DateTimePicker DtReturned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbTypeOfCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBooking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCustomerNic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCost;
    }
}

