namespace EventGo.Forms
{
    partial class TicketPayment
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
            dgvTicket = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvKeranjang = new DataGridView();
            cbEvent = new ComboBox();
            label4 = new Label();
            tbNamaPemesan = new TextBox();
            tbNoHpPemesan = new TextBox();
            label5 = new Label();
            label6 = new Label();
            numJumlahBeli = new NumericUpDown();
            label7 = new Label();
            btnTambahKeranjang = new Button();
            btnHapusTiket = new Button();
            tbTotalHarga = new TextBox();
            tbUangDiberikan = new TextBox();
            tbKembalian = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnHitungKembalian = new Button();
            btnProsesPembelian = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTicket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJumlahBeli).BeginInit();
            SuspendLayout();
            // 
            // dgvTicket
            // 
            dgvTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTicket.Location = new Point(51, 104);
            dgvTicket.Name = "dgvTicket";
            dgvTicket.RowHeadersWidth = 51;
            dgvTicket.Size = new Size(728, 149);
            dgvTicket.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 33);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 1;
            label1.Text = "Pembelian Ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 81);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Ticket :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 264);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 3;
            label3.Text = "Keranjang :";
            // 
            // dgvKeranjang
            // 
            dgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKeranjang.Location = new Point(51, 301);
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.RowHeadersWidth = 51;
            dgvKeranjang.Size = new Size(728, 139);
            dgvKeranjang.TabIndex = 4;
            // 
            // cbEvent
            // 
            cbEvent.FormattingEnabled = true;
            cbEvent.Location = new Point(51, 477);
            cbEvent.Name = "cbEvent";
            cbEvent.Size = new Size(151, 28);
            cbEvent.TabIndex = 5;
            cbEvent.SelectedIndexChanged += cbEvent_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 454);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 6;
            label4.Text = "Event :";
            // 
            // tbNamaPemesan
            // 
            tbNamaPemesan.Location = new Point(51, 536);
            tbNamaPemesan.Name = "tbNamaPemesan";
            tbNamaPemesan.Size = new Size(151, 27);
            tbNamaPemesan.TabIndex = 7;
            // 
            // tbNoHpPemesan
            // 
            tbNoHpPemesan.Location = new Point(51, 593);
            tbNoHpPemesan.Name = "tbNoHpPemesan";
            tbNoHpPemesan.Size = new Size(151, 27);
            tbNoHpPemesan.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 570);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 9;
            label5.Text = "Nomor Hp Pemesan :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 513);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 10;
            label6.Text = "Nama Pemesan";
            // 
            // numJumlahBeli
            // 
            numJumlahBeli.Location = new Point(248, 478);
            numJumlahBeli.Name = "numJumlahBeli";
            numJumlahBeli.Size = new Size(150, 27);
            numJumlahBeli.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 454);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 12;
            label7.Text = "Jumlah Beli :";
            // 
            // btnTambahKeranjang
            // 
            btnTambahKeranjang.Location = new Point(248, 513);
            btnTambahKeranjang.Name = "btnTambahKeranjang";
            btnTambahKeranjang.Size = new Size(150, 29);
            btnTambahKeranjang.TabIndex = 13;
            btnTambahKeranjang.Text = "Tambah Keranjang";
            btnTambahKeranjang.UseVisualStyleBackColor = true;
            btnTambahKeranjang.Click += btnTambahKeranjang_Click;
            // 
            // btnHapusTiket
            // 
            btnHapusTiket.Location = new Point(248, 548);
            btnHapusTiket.Name = "btnHapusTiket";
            btnHapusTiket.Size = new Size(150, 29);
            btnHapusTiket.TabIndex = 14;
            btnHapusTiket.Text = "Hapus Tiket";
            btnHapusTiket.UseVisualStyleBackColor = true;
            btnHapusTiket.Click += btnHapusTiket_Click;
            // 
            // tbTotalHarga
            // 
            tbTotalHarga.Location = new Point(470, 477);
            tbTotalHarga.Name = "tbTotalHarga";
            tbTotalHarga.ReadOnly = true;
            tbTotalHarga.Size = new Size(148, 27);
            tbTotalHarga.TabIndex = 15;
            // 
            // tbUangDiberikan
            // 
            tbUangDiberikan.Location = new Point(470, 536);
            tbUangDiberikan.Name = "tbUangDiberikan";
            tbUangDiberikan.Size = new Size(148, 27);
            tbUangDiberikan.TabIndex = 16;
            // 
            // tbKembalian
            // 
            tbKembalian.Location = new Point(470, 593);
            tbKembalian.Name = "tbKembalian";
            tbKembalian.ReadOnly = true;
            tbKembalian.Size = new Size(148, 27);
            tbKembalian.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(470, 454);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 18;
            label8.Text = "Total Harga :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(470, 513);
            label9.Name = "label9";
            label9.Size = new Size(119, 20);
            label9.TabIndex = 19;
            label9.Text = "Uang DIberikan :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(470, 570);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 20;
            label10.Text = "Kembalian :";
            // 
            // btnHitungKembalian
            // 
            btnHitungKembalian.Location = new Point(624, 476);
            btnHitungKembalian.Name = "btnHitungKembalian";
            btnHitungKembalian.Size = new Size(144, 29);
            btnHitungKembalian.TabIndex = 21;
            btnHitungKembalian.Text = "Hitung Kembalian";
            btnHitungKembalian.UseVisualStyleBackColor = true;
            btnHitungKembalian.Click += btnHitungKembalian_Click;
            // 
            // btnProsesPembelian
            // 
            btnProsesPembelian.Location = new Point(624, 513);
            btnProsesPembelian.Name = "btnProsesPembelian";
            btnProsesPembelian.Size = new Size(144, 29);
            btnProsesPembelian.TabIndex = 22;
            btnProsesPembelian.Text = "Proses Pembelian";
            btnProsesPembelian.UseVisualStyleBackColor = true;
            btnProsesPembelian.Click += btnProsesPembelian_Click;
            // 
            // TicketPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 644);
            Controls.Add(btnProsesPembelian);
            Controls.Add(btnHitungKembalian);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(tbKembalian);
            Controls.Add(tbUangDiberikan);
            Controls.Add(tbTotalHarga);
            Controls.Add(btnHapusTiket);
            Controls.Add(btnTambahKeranjang);
            Controls.Add(label7);
            Controls.Add(numJumlahBeli);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbNoHpPemesan);
            Controls.Add(tbNamaPemesan);
            Controls.Add(label4);
            Controls.Add(cbEvent);
            Controls.Add(dgvKeranjang);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTicket);
            Name = "TicketPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicketPayment";
            ((System.ComponentModel.ISupportInitialize)dgvTicket).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJumlahBeli).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTicket;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvKeranjang;
        private ComboBox cbEvent;
        private Label label4;
        private TextBox tbNamaPemesan;
        private TextBox tbNoHpPemesan;
        private Label label5;
        private Label label6;
        private NumericUpDown numJumlahBeli;
        private Label label7;
        private Button btnTambahKeranjang;
        private Button btnHapusTiket;
        private TextBox tbTotalHarga;
        private TextBox tbUangDiberikan;
        private TextBox tbKembalian;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnHitungKembalian;
        private Button btnProsesPembelian;
    }
}