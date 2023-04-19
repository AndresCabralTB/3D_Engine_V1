namespace _3D_3ngine_V1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.BTN_EXE = new System.Windows.Forms.Button();
            this.OBJ_BTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBarTrX = new System.Windows.Forms.TrackBar();
            this.trackBarTrY = new System.Windows.Forms.TrackBar();
            this.trackBarTrZ = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrZ)).BeginInit();
            this.SuspendLayout();
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCT_CANVAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCT_CANVAS.Location = new System.Drawing.Point(209, 14);
            this.PCT_CANVAS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(1346, 603);
            this.PCT_CANVAS.TabIndex = 0;
            this.PCT_CANVAS.TabStop = false;
            // 
            // BTN_EXE
            // 
            this.BTN_EXE.BackColor = System.Drawing.Color.Red;
            this.BTN_EXE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXE.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_EXE.ForeColor = System.Drawing.Color.Silver;
            this.BTN_EXE.Location = new System.Drawing.Point(4, 105);
            this.BTN_EXE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTN_EXE.Name = "BTN_EXE";
            this.BTN_EXE.Size = new System.Drawing.Size(182, 38);
            this.BTN_EXE.TabIndex = 1;
            this.BTN_EXE.Text = "EXE";
            this.BTN_EXE.UseVisualStyleBackColor = false;
            this.BTN_EXE.Click += new System.EventHandler(this.BTN_EXE_Click);
            // 
            // OBJ_BTN
            // 
            this.OBJ_BTN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OBJ_BTN.Location = new System.Drawing.Point(4, 14);
            this.OBJ_BTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OBJ_BTN.Name = "OBJ_BTN";
            this.OBJ_BTN.Size = new System.Drawing.Size(182, 84);
            this.OBJ_BTN.TabIndex = 9;
            this.OBJ_BTN.Text = "Open OBJ File";
            this.OBJ_BTN.UseVisualStyleBackColor = false;
            this.OBJ_BTN.Click += new System.EventHandler(this.OBJ_BTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 635);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Scale:";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(100, 683);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar1.Maximum = 360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(562, 45);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(102, 742);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar2.Maximum = 360;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(561, 45);
            this.trackBar2.TabIndex = 18;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 804);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Z rotation:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 752);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "X rotation:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 699);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Y rotation:";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(102, 794);
            this.trackBar3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar3.Maximum = 360;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(561, 45);
            this.trackBar3.TabIndex = 22;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(209, 624);
            this.trackBar4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar4.Maximum = 200;
            this.trackBar4.Minimum = -10;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(1346, 45);
            this.trackBar4.TabIndex = 23;
            this.trackBar4.Value = 5;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBarTrX
            // 
            this.trackBarTrX.Location = new System.Drawing.Point(808, 742);
            this.trackBarTrX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarTrX.Maximum = 50;
            this.trackBarTrX.Minimum = -50;
            this.trackBarTrX.Name = "trackBarTrX";
            this.trackBarTrX.Size = new System.Drawing.Size(729, 45);
            this.trackBarTrX.TabIndex = 24;
            this.trackBarTrX.Scroll += new System.EventHandler(this.trackBarTrX_Scroll);
            // 
            // trackBarTrY
            // 
            this.trackBarTrY.Location = new System.Drawing.Point(808, 683);
            this.trackBarTrY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarTrY.Maximum = 50;
            this.trackBarTrY.Minimum = -50;
            this.trackBarTrY.Name = "trackBarTrY";
            this.trackBarTrY.Size = new System.Drawing.Size(729, 45);
            this.trackBarTrY.TabIndex = 25;
            this.trackBarTrY.Scroll += new System.EventHandler(this.trackBarTrY_Scroll);
            // 
            // trackBarTrZ
            // 
            this.trackBarTrZ.Location = new System.Drawing.Point(808, 794);
            this.trackBarTrZ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarTrZ.Maximum = 50;
            this.trackBarTrZ.Minimum = -50;
            this.trackBarTrZ.Name = "trackBarTrZ";
            this.trackBarTrZ.Size = new System.Drawing.Size(729, 45);
            this.trackBarTrZ.TabIndex = 26;
            this.trackBarTrZ.Scroll += new System.EventHandler(this.trackBarTrZ_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1569, 860);
            this.Controls.Add(this.trackBarTrZ);
            this.Controls.Add(this.trackBarTrY);
            this.Controls.Add(this.trackBarTrX);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OBJ_BTN);
            this.Controls.Add(this.BTN_EXE);
            this.Controls.Add(this.PCT_CANVAS);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "DEMO";
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Button BTN_EXE;
        private System.Windows.Forms.Button OBJ_BTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBarTrX;
        private System.Windows.Forms.TrackBar trackBarTrY;
        private System.Windows.Forms.TrackBar trackBarTrZ;
    }
}

