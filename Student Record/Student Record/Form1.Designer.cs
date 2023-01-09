namespace Student_Record
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
            this.LstResult = new System.Windows.Forms.ListBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtLastNmae = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstResult
            // 
            this.LstResult.FormattingEnabled = true;
            this.LstResult.Location = new System.Drawing.Point(12, 29);
            this.LstResult.Name = "LstResult";
            this.LstResult.Size = new System.Drawing.Size(199, 329);
            this.LstResult.TabIndex = 10;
            this.LstResult.SelectedIndexChanged += new System.EventHandler(this.LstResult_SelectedIndexChanged);
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(251, 211);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(212, 20);
            this.txtNationality.TabIndex = 5;
            this.txtNationality.Text = "Nationality";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(251, 174);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(212, 20);
            this.txtCountry.TabIndex = 4;
            this.txtCountry.Text = "Country";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(251, 137);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(212, 20);
            this.txtState.TabIndex = 3;
            this.txtState.Text = "State";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(251, 101);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(212, 20);
            this.txtCity.TabIndex = 2;
            this.txtCity.Text = "City";
            // 
            // txtLastNmae
            // 
            this.txtLastNmae.Location = new System.Drawing.Point(251, 66);
            this.txtLastNmae.Name = "txtLastNmae";
            this.txtLastNmae.Size = new System.Drawing.Size(212, 20);
            this.txtLastNmae.TabIndex = 1;
            this.txtLastNmae.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(251, 29);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(212, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Text = "First Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Update_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(251, 264);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 38);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Add New Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.AddNewRe);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(251, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 38);
            this.button4.TabIndex = 8;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 372);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastNmae);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.LstResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstResult;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtLastNmae;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button4;
    }
}

