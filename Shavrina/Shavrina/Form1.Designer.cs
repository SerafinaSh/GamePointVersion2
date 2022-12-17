
namespace Shavrina
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player1Name = new System.Windows.Forms.TextBox();
            this.Player2Name = new System.Windows.Forms.TextBox();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.SettingsBut = new System.Windows.Forms.Button();
            this.SoundCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Descript = new System.Windows.Forms.Button();
            this.TimerGame = new System.Windows.Forms.Label();
            this.GameXod = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Color1 = new System.Windows.Forms.Button();
            this.color2 = new System.Windows.Forms.Button();
            this.descript1 = new Shavrina.Descript();
            this.pole1 = new Shavrina.Pole();
            this.logo = new Shavrina.Logo();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player1Name
            // 
            this.Player1Name.Location = new System.Drawing.Point(100, 6);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(100, 20);
            this.Player1Name.TabIndex = 1;
            this.Player1Name.TextChanged += new System.EventHandler(this.Player1Name_TextChanged);
            // 
            // Player2Name
            // 
            this.Player2Name.Location = new System.Drawing.Point(100, 48);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(100, 20);
            this.Player2Name.TabIndex = 2;
            this.Player2Name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.BackColor = System.Drawing.Color.Tan;
            this.Player1Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Player1Label.Location = new System.Drawing.Point(12, 9);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(82, 13);
            this.Player1Label.TabIndex = 3;
            this.Player1Label.Text = "Игрок первый ";
            this.Player1Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.BackColor = System.Drawing.Color.Tan;
            this.Player2Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Player2Label.Location = new System.Drawing.Point(12, 51);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(76, 13);
            this.Player2Label.TabIndex = 4;
            this.Player2Label.Text = "Игрок второй";
            this.Player2Label.Click += new System.EventHandler(this.Player2Label_Click);
            // 
            // SettingsBut
            // 
            this.SettingsBut.BackColor = System.Drawing.Color.Tan;
            this.SettingsBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SettingsBut.Location = new System.Drawing.Point(14, 92);
            this.SettingsBut.Name = "SettingsBut";
            this.SettingsBut.Size = new System.Drawing.Size(186, 27);
            this.SettingsBut.TabIndex = 5;
            this.SettingsBut.Text = "Настройки";
            this.SettingsBut.UseVisualStyleBackColor = false;
            this.SettingsBut.Click += new System.EventHandler(this.SettingClick);
            // 
            // SoundCheck
            // 
            this.SoundCheck.AutoSize = true;
            this.SoundCheck.BackgroundImage = global::Shavrina.Properties.Resources._1;
            this.SoundCheck.Checked = true;
            this.SoundCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SoundCheck.Location = new System.Drawing.Point(49, 143);
            this.SoundCheck.Name = "SoundCheck";
            this.SoundCheck.Size = new System.Drawing.Size(15, 14);
            this.SoundCheck.TabIndex = 7;
            this.SoundCheck.UseVisualStyleBackColor = true;
            this.SoundCheck.Visible = false;
            this.SoundCheck.CheckedChanged += new System.EventHandler(this.SoundCheck_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Tan;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Звук";
            this.label5.Visible = false;
            // 
            // Descript
            // 
            this.Descript.BackColor = System.Drawing.Color.Tan;
            this.Descript.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Descript.Location = new System.Drawing.Point(12, 166);
            this.Descript.Name = "Descript";
            this.Descript.Size = new System.Drawing.Size(188, 26);
            this.Descript.TabIndex = 12;
            this.Descript.Text = "Правила";
            this.Descript.UseVisualStyleBackColor = false;
            this.Descript.Visible = false;
            this.Descript.Click += new System.EventHandler(this.Description);
            // 
            // TimerGame
            // 
            this.TimerGame.AutoSize = true;
            this.TimerGame.BackColor = System.Drawing.Color.Tan;
            this.TimerGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimerGame.Location = new System.Drawing.Point(339, 14);
            this.TimerGame.Name = "TimerGame";
            this.TimerGame.Size = new System.Drawing.Size(34, 13);
            this.TimerGame.TabIndex = 13;
            this.TimerGame.Text = "00:00";
            this.TimerGame.Click += new System.EventHandler(this.label6_Click);
            // 
            // GameXod
            // 
            this.GameXod.AutoSize = true;
            this.GameXod.BackColor = System.Drawing.Color.Tan;
            this.GameXod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GameXod.Location = new System.Drawing.Point(390, 14);
            this.GameXod.Name = "GameXod";
            this.GameXod.Size = new System.Drawing.Size(72, 13);
            this.GameXod.TabIndex = 14;
            this.GameXod.Text = "Ход: Игрок 1";
            this.GameXod.Click += new System.EventHandler(this.label7_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Tan;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 231);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.83117F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.05628F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.05628F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.05628F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 161);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Tan;
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(33, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Рейнинг\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Tan;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(3, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "1.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Tan;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(3, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "2.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Tan;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(3, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "3.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(33, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(33, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(33, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 6;
            // 
            // Color1
            // 
            this.Color1.Location = new System.Drawing.Point(223, 3);
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(23, 23);
            this.Color1.TabIndex = 6;
            this.Color1.UseVisualStyleBackColor = true;
            this.Color1.Click += new System.EventHandler(this.button2_Click);
            // 
            // color2
            // 
            this.color2.Location = new System.Drawing.Point(223, 47);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(23, 23);
            this.color2.TabIndex = 16;
            this.color2.UseVisualStyleBackColor = true;
            this.color2.Click += new System.EventHandler(this.color2_Click);
            // 
            // descript1
            // 
            this.descript1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descript1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("descript1.BackgroundImage")));
            this.descript1.Location = new System.Drawing.Point(252, 47);
            this.descript1.Name = "descript1";
            this.descript1.Size = new System.Drawing.Size(418, 354);
            this.descript1.TabIndex = 22;
            this.descript1.Visible = false;
            // 
            // pole1
            // 
            this.pole1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pole1.BackgroundImage = global::Shavrina.Properties.Resources._1;
            this.pole1.Location = new System.Drawing.Point(252, 47);
            this.pole1.Name = "pole1";
            this.pole1.Size = new System.Drawing.Size(501, 501);
            this.pole1.TabIndex = 21;
            this.pole1.Click += new System.EventHandler(this.ClickMouse);
            this.pole1.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPoints);
            this.pole1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickMouse);
            this.pole1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CoordMous);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(813, 580);
            this.logo.TabIndex = 23;
            this.logo.Load += new System.EventHandler(this.logo_Load_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(813, 580);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.descript1);
            this.Controls.Add(this.pole1);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.GameXod);
            this.Controls.Add(this.TimerGame);
            this.Controls.Add(this.Descript);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SoundCheck);
            this.Controls.Add(this.Color1);
            this.Controls.Add(this.SettingsBut);
            this.Controls.Add(this.Player2Label);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Player1Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Player1Name;
        private System.Windows.Forms.TextBox Player2Name;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.Button SettingsBut;
        private System.Windows.Forms.CheckBox SoundCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Descript;
        private System.Windows.Forms.Label TimerGame;
        private System.Windows.Forms.Label GameXod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Color1;
        private System.Windows.Forms.Button color2;
        private Pole pole1;
        private Descript descript1;
        private Logo logo;
    }
}

