
namespace EntityUrunProje
{
    partial class FrmAnaForm
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
            this.btnKategoriIslemleri = new System.Windows.Forms.Button();
            this.btnUrunIslemleri = new System.Windows.Forms.Button();
            this.btnIstatistikler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKategoriIslemleri
            // 
            this.btnKategoriIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.btnKategoriIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriIslemleri.Location = new System.Drawing.Point(12, 31);
            this.btnKategoriIslemleri.Name = "btnKategoriIslemleri";
            this.btnKategoriIslemleri.Size = new System.Drawing.Size(213, 108);
            this.btnKategoriIslemleri.TabIndex = 0;
            this.btnKategoriIslemleri.Text = "Kategori İşlemleri";
            this.btnKategoriIslemleri.UseVisualStyleBackColor = false;
            this.btnKategoriIslemleri.Click += new System.EventHandler(this.btnKategoriIslemleri_Click);
            // 
            // btnUrunIslemleri
            // 
            this.btnUrunIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunIslemleri.Location = new System.Drawing.Point(266, 31);
            this.btnUrunIslemleri.Name = "btnUrunIslemleri";
            this.btnUrunIslemleri.Size = new System.Drawing.Size(213, 108);
            this.btnUrunIslemleri.TabIndex = 1;
            this.btnUrunIslemleri.Text = "Ürün İşlemleri";
            this.btnUrunIslemleri.UseVisualStyleBackColor = true;
            this.btnUrunIslemleri.Click += new System.EventHandler(this.btnUrunIslemleri_Click);
            // 
            // btnIstatistikler
            // 
            this.btnIstatistikler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.btnIstatistikler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIstatistikler.ForeColor = System.Drawing.Color.White;
            this.btnIstatistikler.Location = new System.Drawing.Point(510, 31);
            this.btnIstatistikler.Name = "btnIstatistikler";
            this.btnIstatistikler.Size = new System.Drawing.Size(213, 108);
            this.btnIstatistikler.TabIndex = 2;
            this.btnIstatistikler.Text = "İstatistikler";
            this.btnIstatistikler.UseVisualStyleBackColor = false;
            this.btnIstatistikler.Click += new System.EventHandler(this.btnIstatistikler_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 175);
            this.Controls.Add(this.btnIstatistikler);
            this.Controls.Add(this.btnUrunIslemleri);
            this.Controls.Add(this.btnKategoriIslemleri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAnaForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKategoriIslemleri;
        private System.Windows.Forms.Button btnUrunIslemleri;
        private System.Windows.Forms.Button btnIstatistikler;
    }
}