namespace HomeWork_12
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
            this.picBoxAvatar = new System.Windows.Forms.PictureBox();
            this.lblMechanics = new System.Windows.Forms.Label();
            this.cmbMechanic = new System.Windows.Forms.ComboBox();
            this.btnAddMaster = new System.Windows.Forms.Button();
            this.tBAddMaster = new System.Windows.Forms.TextBox();
            this.lblAddMaster = new System.Windows.Forms.Label();
            this.lblNumberMaster = new System.Windows.Forms.Label();
            this.tBNumberMaster = new System.Windows.Forms.TextBox();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.gBAddMaster = new System.Windows.Forms.GroupBox();
            this.btnDeleteMaster = new System.Windows.Forms.Button();
            this.gBEditMaster = new System.Windows.Forms.GroupBox();
            this.tBEditMaster = new System.Windows.Forms.TextBox();
            this.btnEditMaster = new System.Windows.Forms.Button();
            this.lblEditMaster = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCoefficient = new System.Windows.Forms.Label();
            this.tBCoefficient = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).BeginInit();
            this.gBAddMaster.SuspendLayout();
            this.gBEditMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxAvatar
            // 
            this.picBoxAvatar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.picBoxAvatar.Location = new System.Drawing.Point(471, 65);
            this.picBoxAvatar.Name = "picBoxAvatar";
            this.picBoxAvatar.Size = new System.Drawing.Size(120, 120);
            this.picBoxAvatar.TabIndex = 5;
            this.picBoxAvatar.TabStop = false;
            this.picBoxAvatar.Click += new System.EventHandler(this.picBoxAvatar_Click);
            // 
            // lblMechanics
            // 
            this.lblMechanics.AutoSize = true;
            this.lblMechanics.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMechanics.Location = new System.Drawing.Point(20, 9);
            this.lblMechanics.Name = "lblMechanics";
            this.lblMechanics.Size = new System.Drawing.Size(105, 26);
            this.lblMechanics.TabIndex = 4;
            this.lblMechanics.Text = "Мастера:";
            // 
            // cmbMechanic
            // 
            this.cmbMechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbMechanic.FormattingEnabled = true;
            this.cmbMechanic.Location = new System.Drawing.Point(25, 65);
            this.cmbMechanic.Name = "cmbMechanic";
            this.cmbMechanic.Size = new System.Drawing.Size(225, 33);
            this.cmbMechanic.TabIndex = 3;
            this.cmbMechanic.SelectedIndexChanged += new System.EventHandler(this.cmbMechanic_SelectedValueChanged);
            // 
            // btnAddMaster
            // 
            this.btnAddMaster.Enabled = false;
            this.btnAddMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddMaster.Location = new System.Drawing.Point(15, 205);
            this.btnAddMaster.Name = "btnAddMaster";
            this.btnAddMaster.Size = new System.Drawing.Size(170, 35);
            this.btnAddMaster.TabIndex = 6;
            this.btnAddMaster.Text = "Добавить мастера";
            this.btnAddMaster.UseVisualStyleBackColor = true;
            this.btnAddMaster.Click += new System.EventHandler(this.btnAddMaster_Click);
            // 
            // tBAddMaster
            // 
            this.tBAddMaster.Enabled = false;
            this.tBAddMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBAddMaster.Location = new System.Drawing.Point(15, 53);
            this.tBAddMaster.Name = "tBAddMaster";
            this.tBAddMaster.Size = new System.Drawing.Size(258, 24);
            this.tBAddMaster.TabIndex = 7;
            this.tBAddMaster.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // lblAddMaster
            // 
            this.lblAddMaster.AutoSize = true;
            this.lblAddMaster.Enabled = false;
            this.lblAddMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddMaster.Location = new System.Drawing.Point(10, 32);
            this.lblAddMaster.Name = "lblAddMaster";
            this.lblAddMaster.Size = new System.Drawing.Size(278, 18);
            this.lblAddMaster.TabIndex = 8;
            this.lblAddMaster.Text = "1. Поле заполнения фамилии мастера";
            // 
            // lblNumberMaster
            // 
            this.lblNumberMaster.AutoSize = true;
            this.lblNumberMaster.Enabled = false;
            this.lblNumberMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumberMaster.Location = new System.Drawing.Point(8, 92);
            this.lblNumberMaster.Name = "lblNumberMaster";
            this.lblNumberMaster.Size = new System.Drawing.Size(265, 18);
            this.lblNumberMaster.TabIndex = 9;
            this.lblNumberMaster.Text = "2. Поле заполнения номера мастера";
            // 
            // tBNumberMaster
            // 
            this.tBNumberMaster.Enabled = false;
            this.tBNumberMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBNumberMaster.Location = new System.Drawing.Point(15, 113);
            this.tBNumberMaster.Name = "tBNumberMaster";
            this.tBNumberMaster.Size = new System.Drawing.Size(258, 24);
            this.tBNumberMaster.TabIndex = 10;
            this.tBNumberMaster.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Enabled = false;
            this.lblAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAvatar.Location = new System.Drawing.Point(468, 44);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(118, 18);
            this.lblAvatar.TabIndex = 11;
            this.lblAvatar.Text = "Аватар мастера";
            // 
            // gBAddMaster
            // 
            this.gBAddMaster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gBAddMaster.Controls.Add(this.tBAddMaster);
            this.gBAddMaster.Controls.Add(this.btnAddMaster);
            this.gBAddMaster.Controls.Add(this.tBNumberMaster);
            this.gBAddMaster.Controls.Add(this.lblAddMaster);
            this.gBAddMaster.Controls.Add(this.lblNumberMaster);
            this.gBAddMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBAddMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBAddMaster.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gBAddMaster.Location = new System.Drawing.Point(366, 214);
            this.gBAddMaster.Name = "gBAddMaster";
            this.gBAddMaster.Size = new System.Drawing.Size(291, 265);
            this.gBAddMaster.TabIndex = 12;
            this.gBAddMaster.TabStop = false;
            this.gBAddMaster.Text = "Добавление нового мастера";
            // 
            // btnDeleteMaster
            // 
            this.btnDeleteMaster.Enabled = false;
            this.btnDeleteMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteMaster.Location = new System.Drawing.Point(25, 129);
            this.btnDeleteMaster.Name = "btnDeleteMaster";
            this.btnDeleteMaster.Size = new System.Drawing.Size(170, 35);
            this.btnDeleteMaster.TabIndex = 11;
            this.btnDeleteMaster.Text = "Удалить мастера";
            this.btnDeleteMaster.UseVisualStyleBackColor = true;
            this.btnDeleteMaster.Click += new System.EventHandler(this.btnDeleteMaster_Click);
            // 
            // gBEditMaster
            // 
            this.gBEditMaster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gBEditMaster.Controls.Add(this.tBEditMaster);
            this.gBEditMaster.Controls.Add(this.btnEditMaster);
            this.gBEditMaster.Controls.Add(this.lblEditMaster);
            this.gBEditMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBEditMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBEditMaster.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gBEditMaster.Location = new System.Drawing.Point(25, 214);
            this.gBEditMaster.Name = "gBEditMaster";
            this.gBEditMaster.Size = new System.Drawing.Size(308, 191);
            this.gBEditMaster.TabIndex = 13;
            this.gBEditMaster.TabStop = false;
            this.gBEditMaster.Text = "Редактирование мастера";
            // 
            // tBEditMaster
            // 
            this.tBEditMaster.Enabled = false;
            this.tBEditMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBEditMaster.Location = new System.Drawing.Point(15, 53);
            this.tBEditMaster.Name = "tBEditMaster";
            this.tBEditMaster.Size = new System.Drawing.Size(284, 24);
            this.tBEditMaster.TabIndex = 7;
            // 
            // btnEditMaster
            // 
            this.btnEditMaster.Enabled = false;
            this.btnEditMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditMaster.Location = new System.Drawing.Point(15, 138);
            this.btnEditMaster.Name = "btnEditMaster";
            this.btnEditMaster.Size = new System.Drawing.Size(255, 35);
            this.btnEditMaster.TabIndex = 6;
            this.btnEditMaster.Text = "Редактировать мастера";
            this.btnEditMaster.UseVisualStyleBackColor = true;
            this.btnEditMaster.Click += new System.EventHandler(this.btnEditMaster_Click);
            // 
            // lblEditMaster
            // 
            this.lblEditMaster.AutoSize = true;
            this.lblEditMaster.Enabled = false;
            this.lblEditMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEditMaster.Location = new System.Drawing.Point(6, 26);
            this.lblEditMaster.Name = "lblEditMaster";
            this.lblEditMaster.Size = new System.Drawing.Size(293, 18);
            this.lblEditMaster.TabIndex = 8;
            this.lblEditMaster.Text = "Поле редактирования фамилии мастера";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(21, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 18);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "ФИО мастера";
            // 
            // lblCoefficient
            // 
            this.lblCoefficient.AutoSize = true;
            this.lblCoefficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCoefficient.Location = new System.Drawing.Point(265, 44);
            this.lblCoefficient.Name = "lblCoefficient";
            this.lblCoefficient.Size = new System.Drawing.Size(170, 18);
            this.lblCoefficient.TabIndex = 15;
            this.lblCoefficient.Text = "Коэффициент мастера";
            // 
            // tBCoefficient
            // 
            this.tBCoefficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBCoefficient.Location = new System.Drawing.Point(268, 65);
            this.tBCoefficient.Name = "tBCoefficient";
            this.tBCoefficient.Size = new System.Drawing.Size(167, 32);
            this.tBCoefficient.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.tBCoefficient);
            this.Controls.Add(this.lblCoefficient);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.gBEditMaster);
            this.Controls.Add(this.btnDeleteMaster);
            this.Controls.Add(this.gBAddMaster);
            this.Controls.Add(this.lblAvatar);
            this.Controls.Add(this.picBoxAvatar);
            this.Controls.Add(this.lblMechanics);
            this.Controls.Add(this.cmbMechanic);
            this.Name = "Form1";
            this.Text = "Автосервис";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).EndInit();
            this.gBAddMaster.ResumeLayout(false);
            this.gBAddMaster.PerformLayout();
            this.gBEditMaster.ResumeLayout(false);
            this.gBEditMaster.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxAvatar;
        private System.Windows.Forms.Label lblMechanics;
        private System.Windows.Forms.ComboBox cmbMechanic;
        private System.Windows.Forms.Button btnAddMaster;
        private System.Windows.Forms.TextBox tBAddMaster;
        private System.Windows.Forms.Label lblAddMaster;
        private System.Windows.Forms.Label lblNumberMaster;
        private System.Windows.Forms.TextBox tBNumberMaster;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.GroupBox gBAddMaster;
        private System.Windows.Forms.Button btnDeleteMaster;
        private System.Windows.Forms.GroupBox gBEditMaster;
        private System.Windows.Forms.TextBox tBEditMaster;
        private System.Windows.Forms.Button btnEditMaster;
        private System.Windows.Forms.Label lblEditMaster;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCoefficient;
        private System.Windows.Forms.TextBox tBCoefficient;
    }
}

