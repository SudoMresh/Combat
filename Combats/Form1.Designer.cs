namespace Combats
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.hpPlayer = new System.Windows.Forms.ProgressBar();
            this.hpEnemy = new System.Windows.Forms.ProgressBar();
            this.Player = new System.Windows.Forms.Label();
            this.Enemy = new System.Windows.Forms.Label();
            this.bntHitHead = new System.Windows.Forms.Button();
            this.btnHitBody = new System.Windows.Forms.Button();
            this.btnHitLegs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProtHead = new System.Windows.Forms.Button();
            this.btnProtBody = new System.Windows.Forms.Button();
            this.btnProtLeg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // hpPlayer
            // 
            this.hpPlayer.Location = new System.Drawing.Point(518, 35);
            this.hpPlayer.Name = "hpPlayer";
            this.hpPlayer.Size = new System.Drawing.Size(254, 23);
            this.hpPlayer.TabIndex = 1;
            // 
            // hpEnemy
            // 
            this.hpEnemy.Location = new System.Drawing.Point(12, 35);
            this.hpEnemy.Name = "hpEnemy";
            this.hpEnemy.Size = new System.Drawing.Size(230, 23);
            this.hpEnemy.TabIndex = 2;
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.Location = new System.Drawing.Point(647, 12);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(10, 13);
            this.Player.TabIndex = 3;
            this.Player.Text = " ";
            // 
            // Enemy
            // 
            this.Enemy.AutoSize = true;
            this.Enemy.Location = new System.Drawing.Point(96, 12);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(10, 13);
            this.Enemy.TabIndex = 4;
            this.Enemy.Text = " ";
            // 
            // bntHitHead
            // 
            this.bntHitHead.Location = new System.Drawing.Point(482, 148);
            this.bntHitHead.Name = "bntHitHead";
            this.bntHitHead.Size = new System.Drawing.Size(75, 23);
            this.bntHitHead.TabIndex = 5;
            this.bntHitHead.Text = "Head";
            this.bntHitHead.UseVisualStyleBackColor = true;
            // 
            // btnHitBody
            // 
            this.btnHitBody.Location = new System.Drawing.Point(582, 148);
            this.btnHitBody.Name = "btnHitBody";
            this.btnHitBody.Size = new System.Drawing.Size(75, 23);
            this.btnHitBody.TabIndex = 6;
            this.btnHitBody.Text = "Body";
            this.btnHitBody.UseVisualStyleBackColor = true;
            // 
            // btnHitLegs
            // 
            this.btnHitLegs.Location = new System.Drawing.Point(685, 148);
            this.btnHitLegs.Name = "btnHitLegs";
            this.btnHitLegs.Size = new System.Drawing.Size(75, 23);
            this.btnHitLegs.TabIndex = 7;
            this.btnHitLegs.Text = "Legs";
            this.btnHitLegs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chose your hit!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Protection!";
            // 
            // btnProtHead
            // 
            this.btnProtHead.Location = new System.Drawing.Point(482, 215);
            this.btnProtHead.Name = "btnProtHead";
            this.btnProtHead.Size = new System.Drawing.Size(75, 23);
            this.btnProtHead.TabIndex = 10;
            this.btnProtHead.Text = "Head";
            this.btnProtHead.UseVisualStyleBackColor = true;
            // 
            // btnProtBody
            // 
            this.btnProtBody.Location = new System.Drawing.Point(582, 215);
            this.btnProtBody.Name = "btnProtBody";
            this.btnProtBody.Size = new System.Drawing.Size(75, 23);
            this.btnProtBody.TabIndex = 11;
            this.btnProtBody.Text = "Body";
            this.btnProtBody.UseVisualStyleBackColor = true;
            // 
            // btnProtLeg
            // 
            this.btnProtLeg.Location = new System.Drawing.Point(685, 215);
            this.btnProtLeg.Name = "btnProtLeg";
            this.btnProtLeg.Size = new System.Drawing.Size(75, 23);
            this.btnProtLeg.TabIndex = 12;
            this.btnProtLeg.Text = "Legs";
            this.btnProtLeg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnProtLeg);
            this.Controls.Add(this.btnProtBody);
            this.Controls.Add(this.btnProtHead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHitLegs);
            this.Controls.Add(this.btnHitBody);
            this.Controls.Add(this.bntHitHead);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.hpEnemy);
            this.Controls.Add(this.hpPlayer);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Battle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar hpPlayer;
        private System.Windows.Forms.ProgressBar hpEnemy;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.Label Enemy;
        private System.Windows.Forms.Button bntHitHead;
        private System.Windows.Forms.Button btnHitBody;
        private System.Windows.Forms.Button btnHitLegs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProtHead;
        private System.Windows.Forms.Button btnProtBody;
        private System.Windows.Forms.Button btnProtLeg;
    }
}

