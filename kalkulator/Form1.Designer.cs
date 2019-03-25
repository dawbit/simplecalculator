namespace kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.b7 = new System.Windows.Forms.Button();
            this.bslash = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bstar = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bminus = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.breturn = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.bplus = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.labeloperation = new System.Windows.Forms.Label();
            this.alert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(15, 105);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(45, 45);
            this.b7.TabIndex = 7;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.numberclick);
            // 
            // bslash
            // 
            this.bslash.Location = new System.Drawing.Point(168, 105);
            this.bslash.Name = "bslash";
            this.bslash.Size = new System.Drawing.Size(45, 45);
            this.bslash.TabIndex = 14;
            this.bslash.Text = "/";
            this.bslash.UseVisualStyleBackColor = true;
            this.bslash.Click += new System.EventHandler(this.operatorclick);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(117, 105);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(45, 45);
            this.b9.TabIndex = 9;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.numberclick);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(66, 105);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(45, 45);
            this.b8.TabIndex = 8;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.numberclick);
            // 
            // bCE
            // 
            this.bCE.Location = new System.Drawing.Point(219, 105);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(45, 45);
            this.bCE.TabIndex = 17;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = true;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(219, 156);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(45, 45);
            this.bC.TabIndex = 16;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(66, 156);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(45, 45);
            this.b5.TabIndex = 5;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.numberclick);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(117, 156);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(45, 45);
            this.b6.TabIndex = 6;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.numberclick);
            // 
            // bstar
            // 
            this.bstar.Location = new System.Drawing.Point(168, 156);
            this.bstar.Name = "bstar";
            this.bstar.Size = new System.Drawing.Size(45, 45);
            this.bstar.TabIndex = 13;
            this.bstar.Text = "*";
            this.bstar.UseVisualStyleBackColor = true;
            this.bstar.Click += new System.EventHandler(this.operatorclick);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(15, 156);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(45, 45);
            this.b4.TabIndex = 4;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.numberclick);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(66, 207);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(45, 45);
            this.b2.TabIndex = 2;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.numberclick);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(117, 207);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(45, 45);
            this.b3.TabIndex = 3;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.numberclick);
            // 
            // bminus
            // 
            this.bminus.Location = new System.Drawing.Point(168, 207);
            this.bminus.Name = "bminus";
            this.bminus.Size = new System.Drawing.Size(45, 45);
            this.bminus.TabIndex = 12;
            this.bminus.Text = "-";
            this.bminus.UseVisualStyleBackColor = true;
            this.bminus.Click += new System.EventHandler(this.operatorclick);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(15, 207);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(45, 45);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.numberclick);
            // 
            // breturn
            // 
            this.breturn.Location = new System.Drawing.Point(219, 207);
            this.breturn.Name = "breturn";
            this.breturn.Size = new System.Drawing.Size(45, 96);
            this.breturn.TabIndex = 15;
            this.breturn.Text = "=";
            this.breturn.UseVisualStyleBackColor = true;
            this.breturn.Click += new System.EventHandler(this.breturn_Click);
            // 
            // bdot
            // 
            this.bdot.Location = new System.Drawing.Point(117, 258);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(45, 45);
            this.bdot.TabIndex = 10;
            this.bdot.Text = ".";
            this.bdot.UseVisualStyleBackColor = true;
            this.bdot.Click += new System.EventHandler(this.numberclick);
            // 
            // bplus
            // 
            this.bplus.Location = new System.Drawing.Point(168, 258);
            this.bplus.Name = "bplus";
            this.bplus.Size = new System.Drawing.Size(45, 45);
            this.bplus.TabIndex = 11;
            this.bplus.Text = "+";
            this.bplus.UseVisualStyleBackColor = true;
            this.bplus.Click += new System.EventHandler(this.operatorclick);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(15, 258);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(96, 45);
            this.b0.TabIndex = 0;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.numberclick);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.result.Location = new System.Drawing.Point(18, 56);
            this.result.MaxLength = 16;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result.Size = new System.Drawing.Size(246, 30);
            this.result.TabIndex = 20;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labeloperation
            // 
            this.labeloperation.AutoSize = true;
            this.labeloperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labeloperation.Location = new System.Drawing.Point(12, 31);
            this.labeloperation.Name = "labeloperation";
            this.labeloperation.Size = new System.Drawing.Size(0, 25);
            this.labeloperation.TabIndex = 21;
            this.labeloperation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.Location = new System.Drawing.Point(13, 10);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(0, 17);
            this.alert.TabIndex = 22;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(282, 318);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.labeloperation);
            this.Controls.Add(this.result);
            this.Controls.Add(this.breturn);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.bplus);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.bminus);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.bstar);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.bslash);
            this.Controls.Add(this.b7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 365);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 365);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button bslash;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bstar;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bminus;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button breturn;
        private System.Windows.Forms.Button bdot;
        private System.Windows.Forms.Button bplus;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label labeloperation;
        private System.Windows.Forms.Label alert;
    }
}

