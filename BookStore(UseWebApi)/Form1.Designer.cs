namespace BookStore_UseWebApi_
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listBoxGet = new System.Windows.Forms.ListBox();
            this.textBoxGetId = new System.Windows.Forms.TextBox();
            this.listBoxGetId = new System.Windows.Forms.ListBox();
            this.textBoxIdPUT = new System.Windows.Forms.TextBox();
            this.textBoxNamePUT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonGetId = new System.Windows.Forms.Button();
            this.buttonPUT = new System.Windows.Forms.Button();
            this.buttonPOST = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNamePOST = new System.Windows.Forms.TextBox();
            this.textBoxIdPOST = new System.Windows.Forms.TextBox();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIdDELETE = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonGet);
            this.tabPage1.Controls.Add(this.listBoxGet);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GET";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonGetId);
            this.tabPage2.Controls.Add(this.listBoxGetId);
            this.tabPage2.Controls.Add(this.textBoxGetId);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GET(ID)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonPUT);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.textBoxNamePUT);
            this.tabPage3.Controls.Add(this.textBoxIdPUT);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(755, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PUT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonPOST);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.textBoxNamePOST);
            this.tabPage4.Controls.Add(this.textBoxIdPOST);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(755, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "POST";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonDELETE);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.textBoxIdDELETE);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(755, 400);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "DELETE";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // listBoxGet
            // 
            this.listBoxGet.FormattingEnabled = true;
            this.listBoxGet.Location = new System.Drawing.Point(6, 35);
            this.listBoxGet.Name = "listBoxGet";
            this.listBoxGet.Size = new System.Drawing.Size(721, 277);
            this.listBoxGet.TabIndex = 0;
            // 
            // textBoxGetId
            // 
            this.textBoxGetId.Location = new System.Drawing.Point(72, 6);
            this.textBoxGetId.Name = "textBoxGetId";
            this.textBoxGetId.Size = new System.Drawing.Size(655, 20);
            this.textBoxGetId.TabIndex = 0;
            this.textBoxGetId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBoxGetId
            // 
            this.listBoxGetId.FormattingEnabled = true;
            this.listBoxGetId.Location = new System.Drawing.Point(15, 32);
            this.listBoxGetId.Name = "listBoxGetId";
            this.listBoxGetId.Size = new System.Drawing.Size(712, 290);
            this.listBoxGetId.TabIndex = 1;
            // 
            // textBoxIdPUT
            // 
            this.textBoxIdPUT.Location = new System.Drawing.Point(39, 6);
            this.textBoxIdPUT.Name = "textBoxIdPUT";
            this.textBoxIdPUT.Size = new System.Drawing.Size(655, 20);
            this.textBoxIdPUT.TabIndex = 1;
            // 
            // textBoxNamePUT
            // 
            this.textBoxNamePUT.Location = new System.Drawing.Point(39, 32);
            this.textBoxNamePUT.Name = "textBoxNamePUT";
            this.textBoxNamePUT.Size = new System.Drawing.Size(655, 20);
            this.textBoxNamePUT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(6, 318);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(721, 54);
            this.buttonGet.TabIndex = 1;
            this.buttonGet.Text = "GET";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonGetId
            // 
            this.buttonGetId.Location = new System.Drawing.Point(15, 328);
            this.buttonGetId.Name = "buttonGetId";
            this.buttonGetId.Size = new System.Drawing.Size(712, 43);
            this.buttonGetId.TabIndex = 2;
            this.buttonGetId.Text = "GetById";
            this.buttonGetId.UseVisualStyleBackColor = true;
            this.buttonGetId.Click += new System.EventHandler(this.buttonGetId_Click);
            // 
            // buttonPUT
            // 
            this.buttonPUT.Location = new System.Drawing.Point(3, 58);
            this.buttonPUT.Name = "buttonPUT";
            this.buttonPUT.Size = new System.Drawing.Size(691, 39);
            this.buttonPUT.TabIndex = 5;
            this.buttonPUT.Text = "PUT";
            this.buttonPUT.UseVisualStyleBackColor = true;
            this.buttonPUT.Click += new System.EventHandler(this.buttonPUT_Click);
            // 
            // buttonPOST
            // 
            this.buttonPOST.Location = new System.Drawing.Point(6, 58);
            this.buttonPOST.Name = "buttonPOST";
            this.buttonPOST.Size = new System.Drawing.Size(691, 39);
            this.buttonPOST.TabIndex = 10;
            this.buttonPOST.Text = "POST";
            this.buttonPOST.UseVisualStyleBackColor = true;
            this.buttonPOST.Click += new System.EventHandler(this.buttonPOST_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // textBoxNamePOST
            // 
            this.textBoxNamePOST.Location = new System.Drawing.Point(42, 32);
            this.textBoxNamePOST.Name = "textBoxNamePOST";
            this.textBoxNamePOST.Size = new System.Drawing.Size(655, 20);
            this.textBoxNamePOST.TabIndex = 7;
            // 
            // textBoxIdPOST
            // 
            this.textBoxIdPOST.Location = new System.Drawing.Point(42, 6);
            this.textBoxIdPOST.Name = "textBoxIdPOST";
            this.textBoxIdPOST.Size = new System.Drawing.Size(655, 20);
            this.textBoxIdPOST.TabIndex = 6;
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Location = new System.Drawing.Point(20, 32);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(691, 39);
            this.buttonDELETE.TabIndex = 13;
            this.buttonDELETE.Text = "POST";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID";
            // 
            // textBoxIdDELETE
            // 
            this.textBoxIdDELETE.Location = new System.Drawing.Point(50, 6);
            this.textBoxIdDELETE.Name = "textBoxIdDELETE";
            this.textBoxIdDELETE.Size = new System.Drawing.Size(655, 20);
            this.textBoxIdDELETE.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxGet;
        private System.Windows.Forms.ListBox listBoxGetId;
        private System.Windows.Forms.TextBox textBoxGetId;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNamePUT;
        private System.Windows.Forms.TextBox textBoxIdPUT;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button buttonGetId;
        private System.Windows.Forms.Button buttonPUT;
        private System.Windows.Forms.Button buttonPOST;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNamePOST;
        private System.Windows.Forms.TextBox textBoxIdPOST;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIdDELETE;
    }
}

