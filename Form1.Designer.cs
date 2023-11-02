namespace klasaProces
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
            this.buttonWord = new System.Windows.Forms.Button();
            this.buttonStartINFO = new System.Windows.Forms.Button();
            this.buttonInternet = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWord
            // 
            this.buttonWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWord.Location = new System.Drawing.Point(201, 122);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(150, 37);
            this.buttonWord.TabIndex = 0;
            this.buttonWord.Text = "Pokreni Word";
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // buttonStartINFO
            // 
            this.buttonStartINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartINFO.Location = new System.Drawing.Point(385, 192);
            this.buttonStartINFO.Name = "buttonStartINFO";
            this.buttonStartINFO.Size = new System.Drawing.Size(150, 37);
            this.buttonStartINFO.TabIndex = 1;
            this.buttonStartINFO.Text = "Start Info.";
            this.buttonStartINFO.UseVisualStyleBackColor = true;
            this.buttonStartINFO.Click += new System.EventHandler(this.buttonStartINFO_Click);
            // 
            // buttonInternet
            // 
            this.buttonInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInternet.Location = new System.Drawing.Point(385, 122);
            this.buttonInternet.Name = "buttonInternet";
            this.buttonInternet.Size = new System.Drawing.Size(180, 64);
            this.buttonInternet.TabIndex = 2;
            this.buttonInternet.Text = "Pokreni Internet explorer";
            this.buttonInternet.UseVisualStyleBackColor = true;
            this.buttonInternet.Click += new System.EventHandler(this.buttonInternet_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcel.Location = new System.Drawing.Point(201, 192);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(150, 37);
            this.buttonExcel.TabIndex = 3;
            this.buttonExcel.Text = "Pokreni Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 557);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonInternet);
            this.Controls.Add(this.buttonStartINFO);
            this.Controls.Add(this.buttonWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWord;
        private System.Windows.Forms.Button buttonStartINFO;
        private System.Windows.Forms.Button buttonInternet;
        private System.Windows.Forms.Button buttonExcel;
    }
}

