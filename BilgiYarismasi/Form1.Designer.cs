namespace BilgiYarismasi
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
            this.components = new System.ComponentModel.Container();
            this.RTBoxSoru = new System.Windows.Forms.RichTextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.LblSoruNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSonraki = new System.Windows.Forms.Button();
            this.LblSoru = new System.Windows.Forms.Label();
            this.LblDogru = new System.Windows.Forms.Label();
            this.LblYanlis = new System.Windows.Forms.Label();
            this.PBoxYanlis = new System.Windows.Forms.PictureBox();
            this.PBoxDogru = new System.Windows.Forms.PictureBox();
            this.LblDogruCevap = new System.Windows.Forms.Label();
            this.LblCevap = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Timer(this.components);
            this.LblSure = new System.Windows.Forms.Label();
            this.LblSureDegeri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxYanlis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxDogru)).BeginInit();
            this.SuspendLayout();
            // 
            // RTBoxSoru
            // 
            this.RTBoxSoru.Location = new System.Drawing.Point(0, 0);
            this.RTBoxSoru.Name = "RTBoxSoru";
            this.RTBoxSoru.Size = new System.Drawing.Size(458, 216);
            this.RTBoxSoru.TabIndex = 0;
            this.RTBoxSoru.Text = "";
            // 
            // BtnA
            // 
            this.BtnA.Location = new System.Drawing.Point(12, 231);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(218, 47);
            this.BtnA.TabIndex = 1;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.Location = new System.Drawing.Point(236, 231);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(218, 47);
            this.BtnB.TabIndex = 2;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(12, 284);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(218, 47);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnD
            // 
            this.BtnD.Location = new System.Drawing.Point(236, 284);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(218, 47);
            this.BtnD.TabIndex = 4;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // LblSoruNo
            // 
            this.LblSoruNo.AutoSize = true;
            this.LblSoruNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoruNo.Location = new System.Drawing.Point(493, 37);
            this.LblSoruNo.Name = "LblSoruNo";
            this.LblSoruNo.Size = new System.Drawing.Size(81, 22);
            this.LblSoruNo.TabIndex = 5;
            this.LblSoruNo.Text = "Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(510, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(510, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlış:";
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.Location = new System.Drawing.Point(537, 160);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(218, 47);
            this.BtnSonraki.TabIndex = 8;
            this.BtnSonraki.Text = "Sonraki Soru";
            this.BtnSonraki.UseVisualStyleBackColor = true;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // LblSoru
            // 
            this.LblSoru.AutoSize = true;
            this.LblSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoru.Location = new System.Drawing.Point(591, 37);
            this.LblSoru.Name = "LblSoru";
            this.LblSoru.Size = new System.Drawing.Size(20, 22);
            this.LblSoru.TabIndex = 9;
            this.LblSoru.Text = "0";
            // 
            // LblDogru
            // 
            this.LblDogru.AutoSize = true;
            this.LblDogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDogru.Location = new System.Drawing.Point(591, 77);
            this.LblDogru.Name = "LblDogru";
            this.LblDogru.Size = new System.Drawing.Size(20, 22);
            this.LblDogru.TabIndex = 10;
            this.LblDogru.Text = "0";
            // 
            // LblYanlis
            // 
            this.LblYanlis.AutoSize = true;
            this.LblYanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblYanlis.Location = new System.Drawing.Point(591, 117);
            this.LblYanlis.Name = "LblYanlis";
            this.LblYanlis.Size = new System.Drawing.Size(20, 22);
            this.LblYanlis.TabIndex = 11;
            this.LblYanlis.Text = "0";
            // 
            // PBoxYanlis
            // 
            this.PBoxYanlis.Image = global::BilgiYarismasi.Properties.Resources.yanlis;
            this.PBoxYanlis.Location = new System.Drawing.Point(631, 228);
            this.PBoxYanlis.Name = "PBoxYanlis";
            this.PBoxYanlis.Size = new System.Drawing.Size(124, 103);
            this.PBoxYanlis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxYanlis.TabIndex = 13;
            this.PBoxYanlis.TabStop = false;
            this.PBoxYanlis.Visible = false;
            // 
            // PBoxDogru
            // 
            this.PBoxDogru.Image = global::BilgiYarismasi.Properties.Resources.dogru;
            this.PBoxDogru.Location = new System.Drawing.Point(497, 228);
            this.PBoxDogru.Name = "PBoxDogru";
            this.PBoxDogru.Size = new System.Drawing.Size(124, 103);
            this.PBoxDogru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBoxDogru.TabIndex = 12;
            this.PBoxDogru.TabStop = false;
            this.PBoxDogru.Visible = false;
            // 
            // LblDogruCevap
            // 
            this.LblDogruCevap.AutoSize = true;
            this.LblDogruCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDogruCevap.Location = new System.Drawing.Point(196, 355);
            this.LblDogruCevap.Name = "LblDogruCevap";
            this.LblDogruCevap.Size = new System.Drawing.Size(111, 22);
            this.LblDogruCevap.TabIndex = 14;
            this.LblDogruCevap.Text = "DogruCevap";
            this.LblDogruCevap.Visible = false;
            // 
            // LblCevap
            // 
            this.LblCevap.AutoSize = true;
            this.LblCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCevap.Location = new System.Drawing.Point(313, 355);
            this.LblCevap.Name = "LblCevap";
            this.LblCevap.Size = new System.Drawing.Size(62, 22);
            this.LblCevap.TabIndex = 15;
            this.LblCevap.Text = "Cevap";
            this.LblCevap.Visible = false;
            // 
            // sure
            // 
            this.sure.Interval = 1000;
            this.sure.Tick += new System.EventHandler(this.sure_Tick);
            // 
            // LblSure
            // 
            this.LblSure.AutoSize = true;
            this.LblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSure.Location = new System.Drawing.Point(658, 37);
            this.LblSure.Name = "LblSure";
            this.LblSure.Size = new System.Drawing.Size(53, 22);
            this.LblSure.TabIndex = 16;
            this.LblSure.Text = "Süre:";
            // 
            // LblSureDegeri
            // 
            this.LblSureDegeri.AutoSize = true;
            this.LblSureDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSureDegeri.Location = new System.Drawing.Point(735, 37);
            this.LblSureDegeri.Name = "LblSureDegeri";
            this.LblSureDegeri.Size = new System.Drawing.Size(20, 22);
            this.LblSureDegeri.TabIndex = 17;
            this.LblSureDegeri.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 343);
            this.Controls.Add(this.LblSureDegeri);
            this.Controls.Add(this.LblSure);
            this.Controls.Add(this.LblCevap);
            this.Controls.Add(this.LblDogruCevap);
            this.Controls.Add(this.PBoxYanlis);
            this.Controls.Add(this.PBoxDogru);
            this.Controls.Add(this.LblYanlis);
            this.Controls.Add(this.LblDogru);
            this.Controls.Add(this.LblSoru);
            this.Controls.Add(this.BtnSonraki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblSoruNo);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.RTBoxSoru);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxYanlis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxDogru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBoxSoru;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Label LblSoruNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSonraki;
        private System.Windows.Forms.Label LblSoru;
        private System.Windows.Forms.Label LblDogru;
        private System.Windows.Forms.Label LblYanlis;
        private System.Windows.Forms.PictureBox PBoxDogru;
        private System.Windows.Forms.PictureBox PBoxYanlis;
        private System.Windows.Forms.Label LblDogruCevap;
        private System.Windows.Forms.Label LblCevap;
        private System.Windows.Forms.Timer sure;
        private System.Windows.Forms.Label LblSure;
        private System.Windows.Forms.Label LblSureDegeri;
    }
}

