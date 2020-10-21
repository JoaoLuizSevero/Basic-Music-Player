namespace NAudioTests
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.btn_pause = new System.Windows.Forms.Button();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.trb_pitch = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_playWave = new System.Windows.Forms.Button();
            this.cb_waves = new System.Windows.Forms.ComboBox();
            this.btn_stopWave = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trb_progress = new System.Windows.Forms.TrackBar();
            this.lb_decTime = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.lb_length = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vsb_volumeM = new System.Windows.Forms.HScrollBar();
            this.lb_volumeR = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_volumeL = new System.Windows.Forms.Label();
            this.cb_controle = new System.Windows.Forms.CheckBox();
            this.lb_volumeM = new System.Windows.Forms.Label();
            this.vsb_volumeR = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vsb_volumeL = new System.Windows.Forms.HScrollBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_pitch)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_progress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(6, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(193, 10);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar2.Location = new System.Drawing.Point(6, 45);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(193, 10);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 2;
            // 
            // progressBar3
            // 
            this.progressBar3.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar3.Location = new System.Drawing.Point(6, 55);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(193, 10);
            this.progressBar3.Step = 1;
            this.progressBar3.TabIndex = 3;
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(106, 18);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.Text = "Play";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // progressBar4
            // 
            this.progressBar4.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar4.Location = new System.Drawing.Point(6, 65);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(193, 10);
            this.progressBar4.Step = 1;
            this.progressBar4.TabIndex = 5;
            // 
            // progressBar6
            // 
            this.progressBar6.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar6.Location = new System.Drawing.Point(6, 75);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(193, 10);
            this.progressBar6.Step = 1;
            this.progressBar6.TabIndex = 7;
            // 
            // progressBar7
            // 
            this.progressBar7.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar7.Location = new System.Drawing.Point(6, 85);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(193, 10);
            this.progressBar7.Step = 1;
            this.progressBar7.TabIndex = 8;
            // 
            // progressBar8
            // 
            this.progressBar8.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar8.Location = new System.Drawing.Point(6, 95);
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(193, 10);
            this.progressBar8.Step = 1;
            this.progressBar8.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 273);
            this.panel1.TabIndex = 10;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Location = new System.Drawing.Point(0, 147);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer2.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer2.Panel1.Controls.Add(this.progressBar4);
            this.splitContainer2.Panel1.Controls.Add(this.progressBar8);
            this.splitContainer2.Panel1.Controls.Add(this.progressBar6);
            this.splitContainer2.Panel1.Controls.Add(this.progressBar2);
            this.splitContainer2.Panel1.Controls.Add(this.progressBar3);
            this.splitContainer2.Panel1.Controls.Add(this.progressBar7);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel3);
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Size = new System.Drawing.Size(629, 115);
            this.splitContainer2.SplitterDistance = 212;
            this.splitContainer2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.trb_pitch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 111);
            this.panel3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pitch";
            // 
            // trb_pitch
            // 
            this.trb_pitch.LargeChange = 1;
            this.trb_pitch.Location = new System.Drawing.Point(12, 25);
            this.trb_pitch.Maximum = 2;
            this.trb_pitch.Minimum = -2;
            this.trb_pitch.Name = "trb_pitch";
            this.trb_pitch.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trb_pitch.Size = new System.Drawing.Size(45, 75);
            this.trb_pitch.TabIndex = 0;
            this.trb_pitch.Scroll += new System.EventHandler(this.trb_pitch_Scroll);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btn_playWave);
            this.panel2.Controls.Add(this.cb_waves);
            this.panel2.Controls.Add(this.btn_stopWave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 111);
            this.panel2.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Wave Form";
            // 
            // btn_playWave
            // 
            this.btn_playWave.Location = new System.Drawing.Point(19, 52);
            this.btn_playWave.Name = "btn_playWave";
            this.btn_playWave.Size = new System.Drawing.Size(167, 23);
            this.btn_playWave.TabIndex = 14;
            this.btn_playWave.Text = "Play";
            this.btn_playWave.UseVisualStyleBackColor = true;
            this.btn_playWave.Click += new System.EventHandler(this.btn_playWave_Click);
            // 
            // cb_waves
            // 
            this.cb_waves.FormattingEnabled = true;
            this.cb_waves.Location = new System.Drawing.Point(19, 25);
            this.cb_waves.Name = "cb_waves";
            this.cb_waves.Size = new System.Drawing.Size(167, 21);
            this.cb_waves.TabIndex = 15;
            // 
            // btn_stopWave
            // 
            this.btn_stopWave.Location = new System.Drawing.Point(19, 78);
            this.btn_stopWave.Name = "btn_stopWave";
            this.btn_stopWave.Size = new System.Drawing.Size(167, 23);
            this.btn_stopWave.TabIndex = 16;
            this.btn_stopWave.Text = "Stop";
            this.btn_stopWave.UseVisualStyleBackColor = true;
            this.btn_stopWave.Click += new System.EventHandler(this.btn_stopWave_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trb_progress);
            this.splitContainer1.Panel1.Controls.Add(this.lb_decTime);
            this.splitContainer1.Panel1.Controls.Add(this.btn_stop);
            this.splitContainer1.Panel1.Controls.Add(this.btn_open);
            this.splitContainer1.Panel1.Controls.Add(this.lb_length);
            this.splitContainer1.Panel1.Controls.Add(this.btn_pause);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lb_name);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.vsb_volumeM);
            this.splitContainer1.Panel2.Controls.Add(this.lb_volumeR);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.lb_volumeL);
            this.splitContainer1.Panel2.Controls.Add(this.cb_controle);
            this.splitContainer1.Panel2.Controls.Add(this.lb_volumeM);
            this.splitContainer1.Panel2.Controls.Add(this.vsb_volumeR);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.vsb_volumeL);
            this.splitContainer1.Size = new System.Drawing.Size(631, 147);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 12;
            // 
            // trb_progress
            // 
            this.trb_progress.LargeChange = 10;
            this.trb_progress.Location = new System.Drawing.Point(8, 104);
            this.trb_progress.Maximum = 100;
            this.trb_progress.Name = "trb_progress";
            this.trb_progress.Size = new System.Drawing.Size(202, 45);
            this.trb_progress.TabIndex = 13;
            this.trb_progress.TickFrequency = 5;
            this.trb_progress.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trb_progress.Scroll += new System.EventHandler(this.trb_progress_Scroll);
            // 
            // lb_decTime
            // 
            this.lb_decTime.AutoSize = true;
            this.lb_decTime.Location = new System.Drawing.Point(227, 114);
            this.lb_decTime.Name = "lb_decTime";
            this.lb_decTime.Size = new System.Drawing.Size(0, 13);
            this.lb_decTime.TabIndex = 12;
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(187, 18);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 11;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(18, 18);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(82, 23);
            this.btn_open.TabIndex = 5;
            this.btn_open.Text = "Open File";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // lb_length
            // 
            this.lb_length.AutoSize = true;
            this.lb_length.Location = new System.Drawing.Point(77, 78);
            this.lb_length.Name = "lb_length";
            this.lb_length.Size = new System.Drawing.Size(0, 13);
            this.lb_length.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "File Length:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File name:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(77, 59);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(0, 13);
            this.lb_name.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::NAudioTests.Properties.Resources.LR;
            this.pictureBox1.Location = new System.Drawing.Point(186, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Volume";
            // 
            // vsb_volumeM
            // 
            this.vsb_volumeM.LargeChange = 1;
            this.vsb_volumeM.Location = new System.Drawing.Point(46, 97);
            this.vsb_volumeM.Name = "vsb_volumeM";
            this.vsb_volumeM.Size = new System.Drawing.Size(97, 17);
            this.vsb_volumeM.TabIndex = 22;
            this.vsb_volumeM.Value = 50;
            this.vsb_volumeM.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsb_volumeM_Scroll);
            // 
            // lb_volumeR
            // 
            this.lb_volumeR.AutoSize = true;
            this.lb_volumeR.Location = new System.Drawing.Point(155, 59);
            this.lb_volumeR.Name = "lb_volumeR";
            this.lb_volumeR.Size = new System.Drawing.Size(0, 13);
            this.lb_volumeR.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "L";
            // 
            // lb_volumeL
            // 
            this.lb_volumeL.AutoSize = true;
            this.lb_volumeL.Location = new System.Drawing.Point(155, 28);
            this.lb_volumeL.Name = "lb_volumeL";
            this.lb_volumeL.Size = new System.Drawing.Size(0, 13);
            this.lb_volumeL.TabIndex = 13;
            // 
            // cb_controle
            // 
            this.cb_controle.AutoSize = true;
            this.cb_controle.Location = new System.Drawing.Point(199, 114);
            this.cb_controle.Name = "cb_controle";
            this.cb_controle.Size = new System.Drawing.Size(131, 17);
            this.cb_controle.TabIndex = 11;
            this.cb_controle.Text = "Enable manual control";
            this.cb_controle.UseVisualStyleBackColor = true;
            this.cb_controle.CheckedChanged += new System.EventHandler(this.cb_controle_CheckedChanged);
            // 
            // lb_volumeM
            // 
            this.lb_volumeM.AutoSize = true;
            this.lb_volumeM.Location = new System.Drawing.Point(155, 91);
            this.lb_volumeM.Name = "lb_volumeM";
            this.lb_volumeM.Size = new System.Drawing.Size(0, 13);
            this.lb_volumeM.TabIndex = 19;
            // 
            // vsb_volumeR
            // 
            this.vsb_volumeR.LargeChange = 1;
            this.vsb_volumeR.Location = new System.Drawing.Point(46, 65);
            this.vsb_volumeR.Name = "vsb_volumeR";
            this.vsb_volumeR.Size = new System.Drawing.Size(97, 17);
            this.vsb_volumeR.TabIndex = 21;
            this.vsb_volumeR.Value = 50;
            this.vsb_volumeR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsb_volumeR_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "M";
            // 
            // vsb_volumeL
            // 
            this.vsb_volumeL.LargeChange = 1;
            this.vsb_volumeL.Location = new System.Drawing.Point(46, 38);
            this.vsb_volumeL.Name = "vsb_volumeL";
            this.vsb_volumeL.Size = new System.Drawing.Size(97, 17);
            this.vsb_volumeL.TabIndex = 10;
            this.vsb_volumeL.Value = 50;
            this.vsb_volumeL.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 273);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_pitch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trb_progress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.ProgressBar progressBar8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label lb_length;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_volumeL;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lb_decTime;
        private System.Windows.Forms.TrackBar trb_progress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_volumeR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_volumeM;
        private System.Windows.Forms.HScrollBar vsb_volumeM;
        private System.Windows.Forms.HScrollBar vsb_volumeR;
        private System.Windows.Forms.HScrollBar vsb_volumeL;
        private System.Windows.Forms.CheckBox cb_controle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trb_pitch;
        private System.Windows.Forms.Button btn_stopWave;
        private System.Windows.Forms.ComboBox cb_waves;
        private System.Windows.Forms.Button btn_playWave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

