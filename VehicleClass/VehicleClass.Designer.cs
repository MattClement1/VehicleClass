namespace VehicleClass
{
    partial class frmVehicleClass
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
            this.btnNewVehicle = new System.Windows.Forms.Button();
            this.lstVehicleList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNewVehicle
            // 
            this.btnNewVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewVehicle.Location = new System.Drawing.Point(96, 208);
            this.btnNewVehicle.Name = "btnNewVehicle";
            this.btnNewVehicle.Size = new System.Drawing.Size(93, 41);
            this.btnNewVehicle.TabIndex = 0;
            this.btnNewVehicle.Text = "New Vehicle";
            this.btnNewVehicle.UseVisualStyleBackColor = true;
            this.btnNewVehicle.Click += new System.EventHandler(this.btnNewVehicle_Click);
            // 
            // lstVehicleList
            // 
            this.lstVehicleList.FormattingEnabled = true;
            this.lstVehicleList.Location = new System.Drawing.Point(12, 12);
            this.lstVehicleList.Name = "lstVehicleList";
            this.lstVehicleList.Size = new System.Drawing.Size(260, 173);
            this.lstVehicleList.TabIndex = 1;
            // 
            // frmVehicleClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstVehicleList);
            this.Controls.Add(this.btnNewVehicle);
            this.Name = "frmVehicleClass";
            this.Text = "Vehicle Class";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewVehicle;
        private System.Windows.Forms.ListBox lstVehicleList;
    }
}

