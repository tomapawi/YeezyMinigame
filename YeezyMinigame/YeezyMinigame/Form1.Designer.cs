namespace YeezyMinigame
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
            this.playground = new System.Windows.Forms.Panel();
            this.przegrales_lbl = new System.Windows.Forms.Label();
            this.buty_lbl = new System.Windows.Forms.Label();
            this.zlapanychbutow = new System.Windows.Forms.Label();
            this.but = new System.Windows.Forms.PictureBox();
            this.koszyk = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.but)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koszyk)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.Color.White;
            this.playground.Controls.Add(this.przegrales_lbl);
            this.playground.Controls.Add(this.buty_lbl);
            this.playground.Controls.Add(this.zlapanychbutow);
            this.playground.Controls.Add(this.but);
            this.playground.Controls.Add(this.koszyk);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(652, 440);
            this.playground.TabIndex = 0;
            // 
            // przegrales
            // 
            this.przegrales_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.przegrales_lbl.AutoSize = true;
            this.przegrales_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przegrales_lbl.Location = new System.Drawing.Point(316, 109);
            this.przegrales_lbl.Name = "przegrales";
            this.przegrales_lbl.Size = new System.Drawing.Size(277, 220);
            this.przegrales_lbl.TabIndex = 4;
            this.przegrales_lbl.Text = "Przegrales\r\n\r\nF1 - Restart\r\nEsc - Exit";
            this.przegrales_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buty_lbl
            // 
            this.buty_lbl.AutoSize = true;
            this.buty_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buty_lbl.Location = new System.Drawing.Point(412, 9);
            this.buty_lbl.Name = "buty_lbl";
            this.buty_lbl.Size = new System.Drawing.Size(51, 55);
            this.buty_lbl.TabIndex = 3;
            this.buty_lbl.Text = "0";
            // 
            // zlapanychbutow
            // 
            this.zlapanychbutow.AutoSize = true;
            this.zlapanychbutow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zlapanychbutow.Location = new System.Drawing.Point(12, 9);
            this.zlapanychbutow.Name = "zlapanychbutow";
            this.zlapanychbutow.Size = new System.Drawing.Size(401, 55);
            this.zlapanychbutow.TabIndex = 2;
            this.zlapanychbutow.Text = "Zlapanych butow:";
            // 
            // but
            // 
            this.but.BackColor = System.Drawing.Color.White;
            this.but.Image = global::YeezyMinigame.Properties.Resources.but2;
            this.but.Location = new System.Drawing.Point(145, 138);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(45, 30);
            this.but.TabIndex = 1;
            this.but.TabStop = false;
            // 
            // koszyk
            // 
            this.koszyk.BackColor = System.Drawing.Color.White;
            this.koszyk.Image = global::YeezyMinigame.Properties.Resources.koszyk;
            this.koszyk.Location = new System.Drawing.Point(163, 378);
            this.koszyk.Name = "koszyk";
            this.koszyk.Size = new System.Drawing.Size(200, 50);
            this.koszyk.TabIndex = 0;
            this.koszyk.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 440);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Yeezy Minigame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.but)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koszyk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox but;
        private System.Windows.Forms.PictureBox koszyk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label buty_lbl;
        private System.Windows.Forms.Label zlapanychbutow;
        private System.Windows.Forms.Label przegrales_lbl;
    }
}

