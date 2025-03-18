namespace AracSimulasyonu.UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cmbArac = new ComboBox();
            txtGunSayisi = new TextBox();
            lstKiralamaGecmisi = new ListBox();
            btnKirala = new Button();
            label1 = new Label();
            label2 = new Label();
            lblKiralamaUcreti = new Label();
            lblSonuc = new Label();
            btnJsonConvert = new Button();
            SuspendLayout();
            // 
            // cmbArac
            // 
            cmbArac.BackColor = Color.LightYellow;
            cmbArac.FormattingEnabled = true;
            cmbArac.Location = new Point(122, 25);
            cmbArac.Margin = new Padding(3, 4, 3, 4);
            cmbArac.Name = "cmbArac";
            cmbArac.Size = new Size(575, 28);
            cmbArac.TabIndex = 0;
            // 
            // txtGunSayisi
            // 
            txtGunSayisi.BackColor = Color.LightYellow;
            txtGunSayisi.Location = new Point(123, 61);
            txtGunSayisi.Margin = new Padding(3, 4, 3, 4);
            txtGunSayisi.Name = "txtGunSayisi";
            txtGunSayisi.Size = new Size(575, 27);
            txtGunSayisi.TabIndex = 1;
            // 
            // lstKiralamaGecmisi
            // 
            lstKiralamaGecmisi.BackColor = Color.LightCyan;
            lstKiralamaGecmisi.FormattingEnabled = true;
            lstKiralamaGecmisi.Location = new Point(38, 170);
            lstKiralamaGecmisi.Margin = new Padding(3, 4, 3, 4);
            lstKiralamaGecmisi.Name = "lstKiralamaGecmisi";
            lstKiralamaGecmisi.Size = new Size(661, 184);
            lstKiralamaGecmisi.TabIndex = 2;
            // 
            // btnKirala
            // 
            btnKirala.BackColor = Color.LightGreen;
            btnKirala.Location = new Point(602, 122);
            btnKirala.Margin = new Padding(3, 4, 3, 4);
            btnKirala.Name = "btnKirala";
            btnKirala.Size = new Size(97, 40);
            btnKirala.TabIndex = 3;
            btnKirala.Text = "Araç Kirala";
            btnKirala.UseVisualStyleBackColor = false;
            btnKirala.Click += btnKirala_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(37, 68);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 4;
            label1.Text = "Gün Sayısı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(37, 33);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 4;
            label2.Text = "Araçlar";
            // 
            // lblKiralamaUcreti
            // 
            lblKiralamaUcreti.AutoSize = true;
            lblKiralamaUcreti.ForeColor = Color.DarkBlue;
            lblKiralamaUcreti.Location = new Point(37, 106);
            lblKiralamaUcreti.Name = "lblKiralamaUcreti";
            lblKiralamaUcreti.Size = new Size(111, 20);
            lblKiralamaUcreti.TabIndex = 4;
            lblKiralamaUcreti.Text = "Kiralama Ücreti";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.ForeColor = Color.Red;
            lblSonuc.Location = new Point(154, 106);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 20);
            lblSonuc.TabIndex = 4;
            // 
            // btnJsonConvert
            // 
            btnJsonConvert.BackColor = Color.LightCoral;
            btnJsonConvert.Location = new Point(38, 362);
            btnJsonConvert.Margin = new Padding(3, 4, 3, 4);
            btnJsonConvert.Name = "btnJsonConvert";
            btnJsonConvert.Size = new Size(662, 65);
            btnJsonConvert.TabIndex = 3;
            btnJsonConvert.Text = "Json Formatına Dönüştür ";
            btnJsonConvert.UseVisualStyleBackColor = false;
            btnJsonConvert.Click += btnJsonConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(705, 426);
            Controls.Add(label2);
            Controls.Add(lblSonuc);
            Controls.Add(lblKiralamaUcreti);
            Controls.Add(label1);
            Controls.Add(btnJsonConvert);
            Controls.Add(btnKirala);
            Controls.Add(lstKiralamaGecmisi);
            Controls.Add(txtGunSayisi);
            Controls.Add(cmbArac);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Araç Kiralama Simülasyonu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbArac;
        private TextBox txtGunSayisi;
        private ListBox lstKiralamaGecmisi;
        private Button btnKirala;
        private Label label1;
        private Label label2;
        private Label lblKiralamaUcreti;
        private Label lblSonuc;
        private Button btnJsonConvert;
    }
}
