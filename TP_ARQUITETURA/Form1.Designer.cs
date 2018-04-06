namespace TP_ARQUITETURA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_proc_freqmax = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txt_proc_arq = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_proc_l3 = new MetroFramework.Controls.MetroTextBox();
            this.txt_proc_l2 = new MetroFramework.Controls.MetroTextBox();
            this.txt_proc_l1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_proc_log = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_prox_nuc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_proc_modelo = new MetroFramework.Controls.MetroTextBox();
            this.circularProgressBarCPU = new CircularProgressBar.CircularProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txt_ram_Clock = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txt_ram_uso = new MetroFramework.Controls.MetroTextBox();
            this.txt_ram_total = new MetroFramework.Controls.MetroTextBox();
            this.txt_ram_livre = new MetroFramework.Controls.MetroTextBox();
            this.txt_ram_volts = new MetroFramework.Controls.MetroTextBox();
            this.txt_ram_freq = new MetroFramework.Controls.MetroTextBox();
            this.txt_ram_bar = new MetroFramework.Controls.MetroTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.circularProgressBarMemory = new CircularProgressBar.CircularProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroListViewStorage = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_proc_freqmax);
            this.groupBox1.Controls.Add(this.metroLabel16);
            this.groupBox1.Controls.Add(this.metroLabel15);
            this.groupBox1.Controls.Add(this.txt_proc_arq);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txt_proc_l3);
            this.groupBox1.Controls.Add(this.txt_proc_l2);
            this.groupBox1.Controls.Add(this.txt_proc_l1);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txt_proc_log);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txt_prox_nuc);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txt_proc_modelo);
            this.groupBox1.Controls.Add(this.circularProgressBarCPU);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 185);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processador";
            // 
            // txt_proc_freqmax
            // 
            // 
            // 
            // 
            this.txt_proc_freqmax.CustomButton.Image = null;
            this.txt_proc_freqmax.CustomButton.Location = new System.Drawing.Point(34, 1);
            this.txt_proc_freqmax.CustomButton.Name = "";
            this.txt_proc_freqmax.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_proc_freqmax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_proc_freqmax.CustomButton.TabIndex = 1;
            this.txt_proc_freqmax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_proc_freqmax.CustomButton.UseSelectable = true;
            this.txt_proc_freqmax.CustomButton.Visible = false;
            this.txt_proc_freqmax.Lines = new string[0];
            this.txt_proc_freqmax.Location = new System.Drawing.Point(176, 88);
            this.txt_proc_freqmax.MaxLength = 32767;
            this.txt_proc_freqmax.Name = "txt_proc_freqmax";
            this.txt_proc_freqmax.PasswordChar = '\0';
            this.txt_proc_freqmax.ReadOnly = true;
            this.txt_proc_freqmax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_proc_freqmax.SelectedText = "";
            this.txt_proc_freqmax.SelectionLength = 0;
            this.txt_proc_freqmax.SelectionStart = 0;
            this.txt_proc_freqmax.ShortcutsEnabled = true;
            this.txt_proc_freqmax.Size = new System.Drawing.Size(56, 23);
            this.txt_proc_freqmax.TabIndex = 32;
            this.txt_proc_freqmax.UseSelectable = true;
            this.txt_proc_freqmax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_proc_freqmax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(29, 92);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(124, 19);
            this.metroLabel16.TabIndex = 31;
            this.metroLabel16.Text = "Frequência Máxima";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(251, 88);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(75, 19);
            this.metroLabel15.TabIndex = 30;
            this.metroLabel15.Text = "Arquitetura";
            // 
            // txt_proc_arq
            // 
            // 
            // 
            // 
            this.txt_proc_arq.CustomButton.Image = null;
            this.txt_proc_arq.CustomButton.Location = new System.Drawing.Point(34, 1);
            this.txt_proc_arq.CustomButton.Name = "";
            this.txt_proc_arq.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_proc_arq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_proc_arq.CustomButton.TabIndex = 1;
            this.txt_proc_arq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_proc_arq.CustomButton.UseSelectable = true;
            this.txt_proc_arq.CustomButton.Visible = false;
            this.txt_proc_arq.Lines = new string[0];
            this.txt_proc_arq.Location = new System.Drawing.Point(338, 84);
            this.txt_proc_arq.MaxLength = 32767;
            this.txt_proc_arq.Name = "txt_proc_arq";
            this.txt_proc_arq.PasswordChar = '\0';
            this.txt_proc_arq.ReadOnly = true;
            this.txt_proc_arq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_proc_arq.SelectedText = "";
            this.txt_proc_arq.SelectionLength = 0;
            this.txt_proc_arq.SelectionStart = 0;
            this.txt_proc_arq.ShortcutsEnabled = true;
            this.txt_proc_arq.Size = new System.Drawing.Size(56, 23);
            this.txt_proc_arq.TabIndex = 29;
            this.txt_proc_arq.UseSelectable = true;
            this.txt_proc_arq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_proc_arq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(199, 153);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(22, 19);
            this.metroLabel7.TabIndex = 28;
            this.metroLabel7.Text = "L3";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(110, 153);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(22, 19);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "L2";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(27, 153);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(20, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "L1";
            // 
            // txt_proc_l3
            // 
            // 
            // 
            // 
            this.txt_proc_l3.CustomButton.Image = null;
            this.txt_proc_l3.CustomButton.Location = new System.Drawing.Point(30, 1);
            this.txt_proc_l3.CustomButton.Name = "";
            this.txt_proc_l3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_proc_l3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_proc_l3.CustomButton.TabIndex = 1;
            this.txt_proc_l3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_proc_l3.CustomButton.UseSelectable = true;
            this.txt_proc_l3.CustomButton.Visible = false;
            this.txt_proc_l3.Lines = new string[0];
            this.txt_proc_l3.Location = new System.Drawing.Point(227, 149);
            this.txt_proc_l3.MaxLength = 32767;
            this.txt_proc_l3.Name = "txt_proc_l3";
            this.txt_proc_l3.PasswordChar = '\0';
            this.txt_proc_l3.ReadOnly = true;
            this.txt_proc_l3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_proc_l3.SelectedText = "";
            this.txt_proc_l3.SelectionLength = 0;
            this.txt_proc_l3.SelectionStart = 0;
            this.txt_proc_l3.ShortcutsEnabled = true;
            this.txt_proc_l3.Size = new System.Drawing.Size(52, 23);
            this.txt_proc_l3.TabIndex = 25;
            this.txt_proc_l3.UseSelectable = true;
            this.txt_proc_l3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_proc_l3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_proc_l2
            // 
            // 
            // 
            // 
            this.txt_proc_l2.CustomButton.Image = null;
            this.txt_proc_l2.CustomButton.Location = new System.Drawing.Point(30, 1);
            this.txt_proc_l2.CustomButton.Name = "";
            this.txt_proc_l2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_proc_l2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_proc_l2.CustomButton.TabIndex = 1;
            this.txt_proc_l2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_proc_l2.CustomButton.UseSelectable = true;
            this.txt_proc_l2.CustomButton.Visible = false;
            this.txt_proc_l2.Lines = new string[0];
            this.txt_proc_l2.Location = new System.Drawing.Point(138, 149);
            this.txt_proc_l2.MaxLength = 32767;
            this.txt_proc_l2.Name = "txt_proc_l2";
            this.txt_proc_l2.PasswordChar = '\0';
            this.txt_proc_l2.ReadOnly = true;
            this.txt_proc_l2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_proc_l2.SelectedText = "";
            this.txt_proc_l2.SelectionLength = 0;
            this.txt_proc_l2.SelectionStart = 0;
            this.txt_proc_l2.ShortcutsEnabled = true;
            this.txt_proc_l2.Size = new System.Drawing.Size(52, 23);
            this.txt_proc_l2.TabIndex = 24;
            this.txt_proc_l2.UseSelectable = true;
            this.txt_proc_l2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_proc_l2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_proc_l1
            // 
            // 
            // 
            // 
            this.txt_proc_l1.CustomButton.Image = null;
            this.txt_proc_l1.CustomButton.Location = new System.Drawing.Point(30, 1);
            this.txt_proc_l1.CustomButton.Name = "";
            this.txt_proc_l1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_proc_l1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_proc_l1.CustomButton.TabIndex = 1;
            this.txt_proc_l1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_proc_l1.CustomButton.UseSelectable = true;
            this.txt_proc_l1.CustomButton.Visible = false;
            this.txt_proc_l1.Lines = new string[0];
            this.txt_proc_l1.Location = new System.Drawing.Point(53, 149);
            this.txt_proc_l1.MaxLength = 32767;
            this.txt_proc_l1.Name = "txt_proc_l1";
            this.txt_proc_l1.PasswordChar = '\0';
            this.txt_proc_l1.ReadOnly = true;
            this.txt_proc_l1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_proc_l1.SelectedText = "";
            this.txt_proc_l1.SelectionLength = 0;
            this.txt_proc_l1.SelectionStart = 0;
            this.txt_proc_l1.ShortcutsEnabled = true;
            this.txt_proc_l1.Size = new System.Drawing.Size(52, 23);
            this.txt_proc_l1.TabIndex = 23;
            this.txt_proc_l1.UseSelectable = true;
            this.txt_proc_l1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_proc_l1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(29, 122);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(141, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Informações do Cache";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(29, 59);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(141, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Processadores Lógicos";
            // 
            // txt_proc_log
            // 
            // 
            // 
            // 
            this.txt_proc_log.CustomButton.Image = null;
            this.txt_proc_log.CustomButton.Location = new System.Drawing.Point(34, 1);
            this.txt_proc_log.CustomButton.Name = "";
            this.txt_proc_log.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_proc_log.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_proc_log.CustomButton.TabIndex = 1;
            this.txt_proc_log.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_proc_log.CustomButton.UseSelectable = true;
            this.txt_proc_log.CustomButton.Visible = false;
            this.txt_proc_log.Lines = new string[0];
            this.txt_proc_log.Location = new System.Drawing.Point(176, 55);
            this.txt_proc_log.MaxLength = 32767;
            this.txt_proc_log.Name = "txt_proc_log";
            this.txt_proc_log.PasswordChar = '\0';
            this.txt_proc_log.ReadOnly = true;
            this.txt_proc_log.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_proc_log.SelectedText = "";
            this.txt_proc_log.SelectionLength = 0;
            this.txt_proc_log.SelectionStart = 0;
            this.txt_proc_log.ShortcutsEnabled = true;
            this.txt_proc_log.Size = new System.Drawing.Size(56, 23);
            this.txt_proc_log.TabIndex = 20;
            this.txt_proc_log.UseSelectable = true;
            this.txt_proc_log.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_proc_log.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(251, 55);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Núcleos";
            // 
            // txt_prox_nuc
            // 
            // 
            // 
            // 
            this.txt_prox_nuc.CustomButton.Image = null;
            this.txt_prox_nuc.CustomButton.Location = new System.Drawing.Point(34, 1);
            this.txt_prox_nuc.CustomButton.Name = "";
            this.txt_prox_nuc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_prox_nuc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_prox_nuc.CustomButton.TabIndex = 1;
            this.txt_prox_nuc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_prox_nuc.CustomButton.UseSelectable = true;
            this.txt_prox_nuc.CustomButton.Visible = false;
            this.txt_prox_nuc.Lines = new string[0];
            this.txt_prox_nuc.Location = new System.Drawing.Point(338, 55);
            this.txt_prox_nuc.MaxLength = 32767;
            this.txt_prox_nuc.Name = "txt_prox_nuc";
            this.txt_prox_nuc.PasswordChar = '\0';
            this.txt_prox_nuc.ReadOnly = true;
            this.txt_prox_nuc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_prox_nuc.SelectedText = "";
            this.txt_prox_nuc.SelectionLength = 0;
            this.txt_prox_nuc.SelectionStart = 0;
            this.txt_prox_nuc.ShortcutsEnabled = true;
            this.txt_prox_nuc.Size = new System.Drawing.Size(56, 23);
            this.txt_prox_nuc.TabIndex = 18;
            this.txt_prox_nuc.UseSelectable = true;
            this.txt_prox_nuc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_prox_nuc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Modelo";
            // 
            // txt_proc_modelo
            // 
            // 
            // 
            // 
            this.txt_proc_modelo.CustomButton.Image = null;
            this.txt_proc_modelo.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.txt_proc_modelo.CustomButton.Name = "";
            this.txt_proc_modelo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_proc_modelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_proc_modelo.CustomButton.TabIndex = 1;
            this.txt_proc_modelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_proc_modelo.CustomButton.UseSelectable = true;
            this.txt_proc_modelo.CustomButton.Visible = false;
            this.txt_proc_modelo.Lines = new string[0];
            this.txt_proc_modelo.Location = new System.Drawing.Point(90, 26);
            this.txt_proc_modelo.MaxLength = 32767;
            this.txt_proc_modelo.Name = "txt_proc_modelo";
            this.txt_proc_modelo.PasswordChar = '\0';
            this.txt_proc_modelo.ReadOnly = true;
            this.txt_proc_modelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_proc_modelo.SelectedText = "";
            this.txt_proc_modelo.SelectionLength = 0;
            this.txt_proc_modelo.SelectionStart = 0;
            this.txt_proc_modelo.ShortcutsEnabled = true;
            this.txt_proc_modelo.Size = new System.Drawing.Size(304, 23);
            this.txt_proc_modelo.TabIndex = 16;
            this.txt_proc_modelo.UseSelectable = true;
            this.txt_proc_modelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_proc_modelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // circularProgressBarCPU
            // 
            this.circularProgressBarCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarCPU.AnimationSpeed = 500;
            this.circularProgressBarCPU.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarCPU.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.circularProgressBarCPU.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarCPU.InnerMargin = 2;
            this.circularProgressBarCPU.InnerWidth = -1;
            this.circularProgressBarCPU.Location = new System.Drawing.Point(688, 33);
            this.circularProgressBarCPU.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarCPU.Name = "circularProgressBarCPU";
            this.circularProgressBarCPU.OuterColor = System.Drawing.Color.AliceBlue;
            this.circularProgressBarCPU.OuterMargin = -25;
            this.circularProgressBarCPU.OuterWidth = 26;
            this.circularProgressBarCPU.ProgressColor = System.Drawing.SystemColors.MenuHighlight;
            this.circularProgressBarCPU.ProgressWidth = 12;
            this.circularProgressBarCPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.circularProgressBarCPU.Size = new System.Drawing.Size(120, 120);
            this.circularProgressBarCPU.StartAngle = 270;
            this.circularProgressBarCPU.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarCPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarCPU.SubscriptText = "";
            this.circularProgressBarCPU.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarCPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarCPU.SuperscriptText = "";
            this.circularProgressBarCPU.TabIndex = 7;
            this.circularProgressBarCPU.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBarCPU.Value = 68;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(542, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Porcentagem de Uso";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.metroLabel14);
            this.groupBox2.Controls.Add(this.txt_ram_Clock);
            this.groupBox2.Controls.Add(this.metroLabel13);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.txt_ram_uso);
            this.groupBox2.Controls.Add(this.txt_ram_total);
            this.groupBox2.Controls.Add(this.txt_ram_livre);
            this.groupBox2.Controls.Add(this.txt_ram_volts);
            this.groupBox2.Controls.Add(this.txt_ram_freq);
            this.groupBox2.Controls.Add(this.txt_ram_bar);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.circularProgressBarMemory);
            this.groupBox2.Location = new System.Drawing.Point(23, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(909, 153);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Memória";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(29, 88);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(41, 19);
            this.metroLabel14.TabIndex = 42;
            this.metroLabel14.Text = "Clock";
            // 
            // txt_ram_Clock
            // 
            // 
            // 
            // 
            this.txt_ram_Clock.CustomButton.Image = null;
            this.txt_ram_Clock.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.txt_ram_Clock.CustomButton.Name = "";
            this.txt_ram_Clock.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ram_Clock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ram_Clock.CustomButton.TabIndex = 1;
            this.txt_ram_Clock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ram_Clock.CustomButton.UseSelectable = true;
            this.txt_ram_Clock.CustomButton.Visible = false;
            this.txt_ram_Clock.Lines = new string[0];
            this.txt_ram_Clock.Location = new System.Drawing.Point(114, 89);
            this.txt_ram_Clock.MaxLength = 32767;
            this.txt_ram_Clock.Name = "txt_ram_Clock";
            this.txt_ram_Clock.PasswordChar = '\0';
            this.txt_ram_Clock.ReadOnly = true;
            this.txt_ram_Clock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ram_Clock.SelectedText = "";
            this.txt_ram_Clock.SelectionLength = 0;
            this.txt_ram_Clock.SelectionStart = 0;
            this.txt_ram_Clock.ShortcutsEnabled = true;
            this.txt_ram_Clock.Size = new System.Drawing.Size(81, 23);
            this.txt_ram_Clock.TabIndex = 41;
            this.txt_ram_Clock.UseSelectable = true;
            this.txt_ram_Clock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ram_Clock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(217, 59);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(89, 19);
            this.metroLabel13.TabIndex = 40;
            this.metroLabel13.Text = "Memória Uso";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(217, 31);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(94, 19);
            this.metroLabel12.TabIndex = 39;
            this.metroLabel12.Text = "Memória Total";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(217, 88);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(94, 19);
            this.metroLabel11.TabIndex = 38;
            this.metroLabel11.Text = "Memória Livre";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(29, 30);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(79, 19);
            this.metroLabel10.TabIndex = 37;
            this.metroLabel10.Text = "Barramento";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(29, 60);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(73, 19);
            this.metroLabel9.TabIndex = 36;
            this.metroLabel9.Text = "Frequência";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(29, 117);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(65, 19);
            this.metroLabel8.TabIndex = 35;
            this.metroLabel8.Text = "Voltagem";
            // 
            // txt_ram_uso
            // 
            // 
            // 
            // 
            this.txt_ram_uso.CustomButton.Image = null;
            this.txt_ram_uso.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.txt_ram_uso.CustomButton.Name = "";
            this.txt_ram_uso.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ram_uso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ram_uso.CustomButton.TabIndex = 1;
            this.txt_ram_uso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ram_uso.CustomButton.UseSelectable = true;
            this.txt_ram_uso.CustomButton.Visible = false;
            this.txt_ram_uso.Lines = new string[0];
            this.txt_ram_uso.Location = new System.Drawing.Point(317, 59);
            this.txt_ram_uso.MaxLength = 32767;
            this.txt_ram_uso.Name = "txt_ram_uso";
            this.txt_ram_uso.PasswordChar = '\0';
            this.txt_ram_uso.ReadOnly = true;
            this.txt_ram_uso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ram_uso.SelectedText = "";
            this.txt_ram_uso.SelectionLength = 0;
            this.txt_ram_uso.SelectionStart = 0;
            this.txt_ram_uso.ShortcutsEnabled = true;
            this.txt_ram_uso.Size = new System.Drawing.Size(81, 23);
            this.txt_ram_uso.TabIndex = 34;
            this.txt_ram_uso.UseSelectable = true;
            this.txt_ram_uso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ram_uso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_ram_total
            // 
            // 
            // 
            // 
            this.txt_ram_total.CustomButton.Image = null;
            this.txt_ram_total.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.txt_ram_total.CustomButton.Name = "";
            this.txt_ram_total.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ram_total.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ram_total.CustomButton.TabIndex = 1;
            this.txt_ram_total.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ram_total.CustomButton.UseSelectable = true;
            this.txt_ram_total.CustomButton.Visible = false;
            this.txt_ram_total.Lines = new string[0];
            this.txt_ram_total.Location = new System.Drawing.Point(317, 30);
            this.txt_ram_total.MaxLength = 32767;
            this.txt_ram_total.Name = "txt_ram_total";
            this.txt_ram_total.PasswordChar = '\0';
            this.txt_ram_total.ReadOnly = true;
            this.txt_ram_total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ram_total.SelectedText = "";
            this.txt_ram_total.SelectionLength = 0;
            this.txt_ram_total.SelectionStart = 0;
            this.txt_ram_total.ShortcutsEnabled = true;
            this.txt_ram_total.Size = new System.Drawing.Size(81, 23);
            this.txt_ram_total.TabIndex = 33;
            this.txt_ram_total.UseSelectable = true;
            this.txt_ram_total.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ram_total.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_ram_livre
            // 
            // 
            // 
            // 
            this.txt_ram_livre.CustomButton.Image = null;
            this.txt_ram_livre.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.txt_ram_livre.CustomButton.Name = "";
            this.txt_ram_livre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ram_livre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ram_livre.CustomButton.TabIndex = 1;
            this.txt_ram_livre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ram_livre.CustomButton.UseSelectable = true;
            this.txt_ram_livre.CustomButton.Visible = false;
            this.txt_ram_livre.Lines = new string[0];
            this.txt_ram_livre.Location = new System.Drawing.Point(317, 88);
            this.txt_ram_livre.MaxLength = 32767;
            this.txt_ram_livre.Name = "txt_ram_livre";
            this.txt_ram_livre.PasswordChar = '\0';
            this.txt_ram_livre.ReadOnly = true;
            this.txt_ram_livre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ram_livre.SelectedText = "";
            this.txt_ram_livre.SelectionLength = 0;
            this.txt_ram_livre.SelectionStart = 0;
            this.txt_ram_livre.ShortcutsEnabled = true;
            this.txt_ram_livre.Size = new System.Drawing.Size(81, 23);
            this.txt_ram_livre.TabIndex = 32;
            this.txt_ram_livre.UseSelectable = true;
            this.txt_ram_livre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ram_livre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_ram_volts
            // 
            // 
            // 
            // 
            this.txt_ram_volts.CustomButton.Image = null;
            this.txt_ram_volts.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.txt_ram_volts.CustomButton.Name = "";
            this.txt_ram_volts.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ram_volts.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ram_volts.CustomButton.TabIndex = 1;
            this.txt_ram_volts.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ram_volts.CustomButton.UseSelectable = true;
            this.txt_ram_volts.CustomButton.Visible = false;
            this.txt_ram_volts.Lines = new string[0];
            this.txt_ram_volts.Location = new System.Drawing.Point(114, 118);
            this.txt_ram_volts.MaxLength = 32767;
            this.txt_ram_volts.Name = "txt_ram_volts";
            this.txt_ram_volts.PasswordChar = '\0';
            this.txt_ram_volts.ReadOnly = true;
            this.txt_ram_volts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ram_volts.SelectedText = "";
            this.txt_ram_volts.SelectionLength = 0;
            this.txt_ram_volts.SelectionStart = 0;
            this.txt_ram_volts.ShortcutsEnabled = true;
            this.txt_ram_volts.Size = new System.Drawing.Size(81, 23);
            this.txt_ram_volts.TabIndex = 31;
            this.txt_ram_volts.UseSelectable = true;
            this.txt_ram_volts.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ram_volts.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_ram_freq
            // 
            // 
            // 
            // 
            this.txt_ram_freq.CustomButton.Image = null;
            this.txt_ram_freq.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.txt_ram_freq.CustomButton.Name = "";
            this.txt_ram_freq.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ram_freq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ram_freq.CustomButton.TabIndex = 1;
            this.txt_ram_freq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ram_freq.CustomButton.UseSelectable = true;
            this.txt_ram_freq.CustomButton.Visible = false;
            this.txt_ram_freq.Lines = new string[0];
            this.txt_ram_freq.Location = new System.Drawing.Point(114, 60);
            this.txt_ram_freq.MaxLength = 32767;
            this.txt_ram_freq.Name = "txt_ram_freq";
            this.txt_ram_freq.PasswordChar = '\0';
            this.txt_ram_freq.ReadOnly = true;
            this.txt_ram_freq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ram_freq.SelectedText = "";
            this.txt_ram_freq.SelectionLength = 0;
            this.txt_ram_freq.SelectionStart = 0;
            this.txt_ram_freq.ShortcutsEnabled = true;
            this.txt_ram_freq.Size = new System.Drawing.Size(81, 23);
            this.txt_ram_freq.TabIndex = 30;
            this.txt_ram_freq.UseSelectable = true;
            this.txt_ram_freq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ram_freq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_ram_bar
            // 
            // 
            // 
            // 
            this.txt_ram_bar.CustomButton.Image = null;
            this.txt_ram_bar.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.txt_ram_bar.CustomButton.Name = "";
            this.txt_ram_bar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ram_bar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ram_bar.CustomButton.TabIndex = 1;
            this.txt_ram_bar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ram_bar.CustomButton.UseSelectable = true;
            this.txt_ram_bar.CustomButton.Visible = false;
            this.txt_ram_bar.Lines = new string[0];
            this.txt_ram_bar.Location = new System.Drawing.Point(114, 31);
            this.txt_ram_bar.MaxLength = 32767;
            this.txt_ram_bar.Name = "txt_ram_bar";
            this.txt_ram_bar.PasswordChar = '\0';
            this.txt_ram_bar.ReadOnly = true;
            this.txt_ram_bar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ram_bar.SelectedText = "";
            this.txt_ram_bar.SelectionLength = 0;
            this.txt_ram_bar.SelectionStart = 0;
            this.txt_ram_bar.ShortcutsEnabled = true;
            this.txt_ram_bar.Size = new System.Drawing.Size(81, 23);
            this.txt_ram_bar.TabIndex = 29;
            this.txt_ram_bar.UseSelectable = true;
            this.txt_ram_bar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ram_bar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(548, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Porcentagem de Uso";
            // 
            // circularProgressBarMemory
            // 
            this.circularProgressBarMemory.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarMemory.AnimationSpeed = 500;
            this.circularProgressBarMemory.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarMemory.ForeColor = System.Drawing.Color.Lime;
            this.circularProgressBarMemory.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarMemory.InnerMargin = 2;
            this.circularProgressBarMemory.InnerWidth = -1;
            this.circularProgressBarMemory.Location = new System.Drawing.Point(688, 20);
            this.circularProgressBarMemory.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarMemory.Name = "circularProgressBarMemory";
            this.circularProgressBarMemory.OuterColor = System.Drawing.Color.Honeydew;
            this.circularProgressBarMemory.OuterMargin = -25;
            this.circularProgressBarMemory.OuterWidth = 26;
            this.circularProgressBarMemory.ProgressColor = System.Drawing.Color.Lime;
            this.circularProgressBarMemory.ProgressWidth = 12;
            this.circularProgressBarMemory.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.circularProgressBarMemory.Size = new System.Drawing.Size(120, 120);
            this.circularProgressBarMemory.StartAngle = 270;
            this.circularProgressBarMemory.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarMemory.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarMemory.SubscriptText = "";
            this.circularProgressBarMemory.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarMemory.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarMemory.SuperscriptText = "";
            this.circularProgressBarMemory.TabIndex = 8;
            this.circularProgressBarMemory.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBarMemory.Value = 68;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.metroListViewStorage);
            this.groupBox3.Location = new System.Drawing.Point(23, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(909, 315);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Armazenamento de Dados";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // metroListViewStorage
            // 
            this.metroListViewStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroListViewStorage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.metroListViewStorage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListViewStorage.FullRowSelect = true;
            this.metroListViewStorage.Location = new System.Drawing.Point(6, 19);
            this.metroListViewStorage.Name = "metroListViewStorage";
            this.metroListViewStorage.OwnerDraw = true;
            this.metroListViewStorage.Size = new System.Drawing.Size(897, 290);
            this.metroListViewStorage.TabIndex = 0;
            this.metroListViewStorage.UseCompatibleStateImageBehavior = false;
            this.metroListViewStorage.UseSelectable = true;
            this.metroListViewStorage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Propriedade";
            this.columnHeader1.Width = 238;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor";
            this.columnHeader2.Width = 241;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(851, 743);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Information";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(954, 770);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(954, 770);
            this.Name = "Form1";
            this.Text = "SysInfo 1.0.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar circularProgressBarCPU;
        private CircularProgressBar.CircularProgressBar circularProgressBarMemory;
        private System.Windows.Forms.Label label20;
        private MetroFramework.Controls.MetroListView metroListViewStorage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_proc_modelo;
        private MetroFramework.Controls.MetroTextBox txt_proc_l1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_proc_log;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_prox_nuc;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_proc_l3;
        private MetroFramework.Controls.MetroTextBox txt_proc_l2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txt_ram_uso;
        private MetroFramework.Controls.MetroTextBox txt_ram_total;
        private MetroFramework.Controls.MetroTextBox txt_ram_livre;
        private MetroFramework.Controls.MetroTextBox txt_ram_volts;
        private MetroFramework.Controls.MetroTextBox txt_ram_freq;
        private MetroFramework.Controls.MetroTextBox txt_ram_bar;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txt_ram_Clock;
        private MetroFramework.Controls.MetroTextBox txt_proc_freqmax;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txt_proc_arq;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

