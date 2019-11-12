namespace DSRHook
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.noDamage = new System.Windows.Forms.NumericUpDown();
            this.noGravity = new System.Windows.Forms.NumericUpDown();
            this.noMapHit = new System.Windows.Forms.NumericUpDown();
            this.ChrValue = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.Windows.Forms.Button();
            this.playerTeam = new System.Windows.Forms.NumericUpDown();
            this.enemyTeam = new System.Windows.Forms.NumericUpDown();
            this.teamTypeEnemy = new System.Windows.Forms.Button();
            this.teamTypePlayer = new System.Windows.Forms.Button();
            this.cancelWorker = new System.Windows.Forms.Button();
            this.teleport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cameraOvr = new System.Windows.Forms.NumericUpDown();
            this.cameraY = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noGravity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noMapHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraOvr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraY)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // noDamage
            // 
            this.noDamage.Location = new System.Drawing.Point(30, 27);
            this.noDamage.Name = "noDamage";
            this.noDamage.Size = new System.Drawing.Size(120, 20);
            this.noDamage.TabIndex = 2;
            // 
            // noGravity
            // 
            this.noGravity.Location = new System.Drawing.Point(30, 53);
            this.noGravity.Name = "noGravity";
            this.noGravity.Size = new System.Drawing.Size(120, 20);
            this.noGravity.TabIndex = 3;
            // 
            // noMapHit
            // 
            this.noMapHit.Location = new System.Drawing.Point(30, 79);
            this.noMapHit.Name = "noMapHit";
            this.noMapHit.Size = new System.Drawing.Size(120, 20);
            this.noMapHit.TabIndex = 4;
            // 
            // ChrValue
            // 
            this.ChrValue.Location = new System.Drawing.Point(50, 105);
            this.ChrValue.Name = "ChrValue";
            this.ChrValue.Size = new System.Drawing.Size(75, 23);
            this.ChrValue.TabIndex = 5;
            this.ChrValue.Text = "Modify";
            this.ChrValue.UseVisualStyleBackColor = true;
            this.ChrValue.Click += new System.EventHandler(this.ChrValue_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.Location = new System.Drawing.Point(313, 354);
            this.backgroundWorker.Name = "backgroundWorker";
            this.backgroundWorker.Size = new System.Drawing.Size(202, 23);
            this.backgroundWorker.TabIndex = 6;
            this.backgroundWorker.Text = "Background Worker";
            this.backgroundWorker.UseVisualStyleBackColor = true;
            this.backgroundWorker.Click += new System.EventHandler(this.backgroundWorker_Click);
            // 
            // playerTeam
            // 
            this.playerTeam.Location = new System.Drawing.Point(225, 27);
            this.playerTeam.Name = "playerTeam";
            this.playerTeam.Size = new System.Drawing.Size(120, 20);
            this.playerTeam.TabIndex = 8;
            // 
            // enemyTeam
            // 
            this.enemyTeam.Location = new System.Drawing.Point(225, 79);
            this.enemyTeam.Name = "enemyTeam";
            this.enemyTeam.Size = new System.Drawing.Size(120, 20);
            this.enemyTeam.TabIndex = 9;
            // 
            // teamTypeEnemy
            // 
            this.teamTypeEnemy.Location = new System.Drawing.Point(225, 105);
            this.teamTypeEnemy.Name = "teamTypeEnemy";
            this.teamTypeEnemy.Size = new System.Drawing.Size(120, 23);
            this.teamTypeEnemy.TabIndex = 10;
            this.teamTypeEnemy.Text = "Modify Team";
            this.teamTypeEnemy.UseVisualStyleBackColor = true;
            this.teamTypeEnemy.Click += new System.EventHandler(this.teamType_Click);
            // 
            // teamTypePlayer
            // 
            this.teamTypePlayer.Location = new System.Drawing.Point(225, 50);
            this.teamTypePlayer.Name = "teamTypePlayer";
            this.teamTypePlayer.Size = new System.Drawing.Size(120, 23);
            this.teamTypePlayer.TabIndex = 11;
            this.teamTypePlayer.Text = "Modify Team";
            this.teamTypePlayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.teamTypePlayer.UseVisualStyleBackColor = true;
            this.teamTypePlayer.Click += new System.EventHandler(this.teamTypePlayer_Click);
            // 
            // cancelWorker
            // 
            this.cancelWorker.Location = new System.Drawing.Point(313, 384);
            this.cancelWorker.Name = "cancelWorker";
            this.cancelWorker.Size = new System.Drawing.Size(202, 23);
            this.cancelWorker.TabIndex = 12;
            this.cancelWorker.Text = "Cancel Worker";
            this.cancelWorker.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelWorker.UseVisualStyleBackColor = true;
            this.cancelWorker.Click += new System.EventHandler(this.cancelWorker_Click);
            // 
            // teleport
            // 
            this.teleport.Location = new System.Drawing.Point(353, 292);
            this.teleport.Name = "teleport";
            this.teleport.Size = new System.Drawing.Size(138, 23);
            this.teleport.TabIndex = 13;
            this.teleport.Text = "Teleport";
            this.teleport.UseVisualStyleBackColor = true;
            this.teleport.Click += new System.EventHandler(this.teleport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "cameraOvrButton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cameraOvr
            // 
            this.cameraOvr.Location = new System.Drawing.Point(562, 79);
            this.cameraOvr.Name = "cameraOvr";
            this.cameraOvr.Size = new System.Drawing.Size(120, 20);
            this.cameraOvr.TabIndex = 15;
            // 
            // cameraY
            // 
            this.cameraY.Location = new System.Drawing.Point(562, 27);
            this.cameraY.Name = "cameraY";
            this.cameraY.Size = new System.Drawing.Size(120, 20);
            this.cameraY.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "cameraY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cameraY);
            this.Controls.Add(this.cameraOvr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teleport);
            this.Controls.Add(this.cancelWorker);
            this.Controls.Add(this.teamTypePlayer);
            this.Controls.Add(this.teamTypeEnemy);
            this.Controls.Add(this.enemyTeam);
            this.Controls.Add(this.playerTeam);
            this.Controls.Add(this.backgroundWorker);
            this.Controls.Add(this.ChrValue);
            this.Controls.Add(this.noMapHit);
            this.Controls.Add(this.noGravity);
            this.Controls.Add(this.noDamage);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.noDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noGravity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noMapHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraOvr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown noDamage;
        private System.Windows.Forms.NumericUpDown noGravity;
        private System.Windows.Forms.NumericUpDown noMapHit;
        private System.Windows.Forms.Button ChrValue;
        private System.Windows.Forms.Button backgroundWorker;
        private System.Windows.Forms.NumericUpDown playerTeam;
        private System.Windows.Forms.NumericUpDown enemyTeam;
        private System.Windows.Forms.Button teamTypeEnemy;
        private System.Windows.Forms.Button teamTypePlayer;
        private System.Windows.Forms.Button cancelWorker;
        private System.Windows.Forms.Button teleport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown cameraOvr;
        private System.Windows.Forms.NumericUpDown cameraY;
        private System.Windows.Forms.Button button2;
    }
}

