namespace GUI
{
    partial class Apartments
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
            this.ApartmentID = new System.Windows.Forms.Label();
            this.UnitNumber = new System.Windows.Forms.Label();
            this.Floor = new System.Windows.Forms.Label();
            this.Bedrooms = new System.Windows.Forms.Label();
            this.Rent = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // ApartmentID
            // 
            this.ApartmentID.AutoSize = true;
            this.ApartmentID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApartmentID.Location = new System.Drawing.Point(477, 101);
            this.ApartmentID.Name = "ApartmentID";
            this.ApartmentID.Size = new System.Drawing.Size(121, 29);
            this.ApartmentID.TabIndex = 0;
            this.ApartmentID.Text = "ApartmentID";
            this.ApartmentID.Click += new System.EventHandler(this.label1_Click);
            // 
            // UnitNumber
            // 
            this.UnitNumber.AutoSize = true;
            this.UnitNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitNumber.Location = new System.Drawing.Point(715, 101);
            this.UnitNumber.Name = "UnitNumber";
            this.UnitNumber.Size = new System.Drawing.Size(117, 29);
            this.UnitNumber.TabIndex = 1;
            this.UnitNumber.Text = "UnitNumber";
            // 
            // Floor
            // 
            this.Floor.AutoSize = true;
            this.Floor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Floor.Location = new System.Drawing.Point(962, 101);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(58, 29);
            this.Floor.TabIndex = 2;
            this.Floor.Text = "Floor";
            // 
            // Bedrooms
            // 
            this.Bedrooms.AutoSize = true;
            this.Bedrooms.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bedrooms.Location = new System.Drawing.Point(1059, 101);
            this.Bedrooms.Name = "Bedrooms";
            this.Bedrooms.Size = new System.Drawing.Size(103, 29);
            this.Bedrooms.TabIndex = 3;
            this.Bedrooms.Text = "Bedrooms";
            // 
            // Rent
            // 
            this.Rent.AutoSize = true;
            this.Rent.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent.Location = new System.Drawing.Point(1233, 101);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(54, 29);
            this.Rent.TabIndex = 4;
            this.Rent.Text = "Rent";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(1377, 101);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(68, 29);
            this.Status.TabIndex = 5;
            this.Status.Text = "Status";
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(45, 929);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(186, 45);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.52401F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.47599F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(472, 133);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.40278F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.59722F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1019, 576);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Apartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 1003);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.Bedrooms);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.UnitNumber);
            this.Controls.Add(this.ApartmentID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Apartments";
            this.Text = "Apartments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ApartmentID;
        private System.Windows.Forms.Label UnitNumber;
        private System.Windows.Forms.Label Floor;
        private System.Windows.Forms.Label Bedrooms;
        private System.Windows.Forms.Label Rent;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}