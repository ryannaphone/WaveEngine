using Microsoft.VisualBasic.ApplicationServices;
using WaveEngine.Properties;

namespace WaveEngine
{
    partial class WaveEngine
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaveEngine));
            backgroundImage = new PictureBox();
            musicPlayerPanel = new Panel();
            moveMusicButton = new Button();
            closeMusicButton = new Button();
            label1 = new Label();
            musicControlPanel = new Panel();
            songLabel = new Label();
            nowPlayingLabel = new Label();
            stopMusicbutton = new Button();
            playMusicButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            programPanel = new Panel();
            moveProgramButton = new Button();
            closeChatButton = new Button();
            label3 = new Label();
            gamePanel = new Panel();
            terminalPanel = new Panel();
            stageLabel = new Label();
            chatPanel = new Panel();
            nameTagLabel = new Label();
            chatImage = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            inventoryBox = new ListBox();
            likesLabel = new Label();
            oneButtonPanel = new Panel();
            ONEoptionOne = new Button();
            fourButtonPanel = new Panel();
            FOURoption4 = new Button();
            FOURoption3 = new Button();
            FOURoption2 = new Button();
            FOURoption1 = new Button();
            twoButtonPanel = new Panel();
            TWOoption2 = new Button();
            TWOoption1 = new Button();
            threeButtonPanel = new Panel();
            THREEoption3 = new Button();
            THREEoption2 = new Button();
            THREEoption1 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)backgroundImage).BeginInit();
            musicPlayerPanel.SuspendLayout();
            musicControlPanel.SuspendLayout();
            programPanel.SuspendLayout();
            gamePanel.SuspendLayout();
            terminalPanel.SuspendLayout();
            chatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatImage).BeginInit();
            panel1.SuspendLayout();
            oneButtonPanel.SuspendLayout();
            fourButtonPanel.SuspendLayout();
            twoButtonPanel.SuspendLayout();
            threeButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundImage
            // 
            backgroundImage.Image = Resources.IMG_2046;
            backgroundImage.Location = new Point(11, 12);
            backgroundImage.Name = "backgroundImage";
            backgroundImage.Size = new Size(2328, 1397);
            backgroundImage.SizeMode = PictureBoxSizeMode.CenterImage;
            backgroundImage.TabIndex = 8;
            backgroundImage.TabStop = false;
            // 
            // musicPlayerPanel
            // 
            musicPlayerPanel.BackColor = SystemColors.ControlLight;
            musicPlayerPanel.BorderStyle = BorderStyle.FixedSingle;
            musicPlayerPanel.Controls.Add(moveMusicButton);
            musicPlayerPanel.Controls.Add(closeMusicButton);
            musicPlayerPanel.Controls.Add(label1);
            musicPlayerPanel.Controls.Add(musicControlPanel);
            musicPlayerPanel.Location = new Point(1844, 163);
            musicPlayerPanel.Name = "musicPlayerPanel";
            musicPlayerPanel.Size = new Size(393, 236);
            musicPlayerPanel.TabIndex = 11;
            // 
            // moveMusicButton
            // 
            moveMusicButton.BackColor = SystemColors.ActiveCaption;
            moveMusicButton.Font = new Font("Segoe UI", 7F);
            moveMusicButton.Location = new Point(3, 2);
            moveMusicButton.Name = "moveMusicButton";
            moveMusicButton.Size = new Size(66, 42);
            moveMusicButton.TabIndex = 17;
            moveMusicButton.Text = "🖐︎";
            moveMusicButton.UseVisualStyleBackColor = false;
            moveMusicButton.Click += moveMusicButton_Click;
            moveMusicButton.MouseDown += moveMusicButton_MouseDown;
            moveMusicButton.MouseUp += moveMusicButton_MouseUp;
            // 
            // closeMusicButton
            // 
            closeMusicButton.BackColor = Color.LightCoral;
            closeMusicButton.Font = new Font("Broadway", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeMusicButton.Location = new Point(331, 2);
            closeMusicButton.Name = "closeMusicButton";
            closeMusicButton.Size = new Size(57, 41);
            closeMusicButton.TabIndex = 16;
            closeMusicButton.Text = "X";
            closeMusicButton.UseVisualStyleBackColor = false;
            closeMusicButton.Click += closeMusicButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 3);
            label1.Name = "label1";
            label1.Size = new Size(192, 41);
            label1.TabIndex = 12;
            label1.Text = "Music Player";
            // 
            // musicControlPanel
            // 
            musicControlPanel.BackColor = SystemColors.Info;
            musicControlPanel.BorderStyle = BorderStyle.FixedSingle;
            musicControlPanel.Controls.Add(songLabel);
            musicControlPanel.Controls.Add(nowPlayingLabel);
            musicControlPanel.Controls.Add(stopMusicbutton);
            musicControlPanel.Controls.Add(playMusicButton);
            musicControlPanel.Location = new Point(4, 47);
            musicControlPanel.Name = "musicControlPanel";
            musicControlPanel.Size = new Size(384, 184);
            musicControlPanel.TabIndex = 11;
            // 
            // songLabel
            // 
            songLabel.AutoSize = true;
            songLabel.Location = new Point(3, 59);
            songLabel.Name = "songLabel";
            songLabel.Size = new Size(39, 41);
            songLabel.TabIndex = 4;
            songLabel.Text = "...";
            // 
            // nowPlayingLabel
            // 
            nowPlayingLabel.AutoSize = true;
            nowPlayingLabel.Font = new Font("Sitka Banner", 8.099999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            nowPlayingLabel.Location = new Point(3, 12);
            nowPlayingLabel.Name = "nowPlayingLabel";
            nowPlayingLabel.Size = new Size(155, 39);
            nowPlayingLabel.TabIndex = 3;
            nowPlayingLabel.Text = "Now playing:";
            // 
            // stopMusicbutton
            // 
            stopMusicbutton.Location = new Point(211, 115);
            stopMusicbutton.Name = "stopMusicbutton";
            stopMusicbutton.Size = new Size(168, 64);
            stopMusicbutton.TabIndex = 2;
            stopMusicbutton.Text = "Stop";
            stopMusicbutton.UseVisualStyleBackColor = true;
            stopMusicbutton.Click += stopMusicbutton_Click;
            // 
            // playMusicButton
            // 
            playMusicButton.Location = new Point(3, 115);
            playMusicButton.Name = "playMusicButton";
            playMusicButton.Size = new Size(170, 64);
            playMusicButton.TabIndex = 0;
            playMusicButton.Text = "Play";
            playMusicButton.UseVisualStyleBackColor = true;
            playMusicButton.Click += playMusicButton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // programPanel
            // 
            programPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            programPanel.AutoSize = true;
            programPanel.BorderStyle = BorderStyle.Fixed3D;
            programPanel.Controls.Add(moveProgramButton);
            programPanel.Controls.Add(closeChatButton);
            programPanel.Controls.Add(label3);
            programPanel.Controls.Add(gamePanel);
            programPanel.Location = new Point(439, 405);
            programPanel.Name = "programPanel";
            programPanel.Size = new Size(1534, 899);
            programPanel.TabIndex = 12;
            programPanel.MouseMove += programPanel_MouseMove;
            // 
            // moveProgramButton
            // 
            moveProgramButton.BackColor = SystemColors.ActiveCaption;
            moveProgramButton.Font = new Font("Segoe UI", 7F);
            moveProgramButton.Location = new Point(3, 3);
            moveProgramButton.Name = "moveProgramButton";
            moveProgramButton.Size = new Size(66, 42);
            moveProgramButton.TabIndex = 16;
            moveProgramButton.Text = "🖐︎";
            moveProgramButton.UseVisualStyleBackColor = false;
            moveProgramButton.Click += moveProgramButton_Click;
            moveProgramButton.MouseDown += moveProgramButton_MouseDown;
            moveProgramButton.MouseMove += moveProgramButton_MouseMove;
            moveProgramButton.MouseUp += moveProgramButton_MouseUp;
            // 
            // closeChatButton
            // 
            closeChatButton.BackColor = Color.LightCoral;
            closeChatButton.Font = new Font("Broadway", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeChatButton.Location = new Point(1466, 3);
            closeChatButton.Name = "closeChatButton";
            closeChatButton.Size = new Size(61, 42);
            closeChatButton.TabIndex = 15;
            closeChatButton.Text = "X";
            closeChatButton.UseVisualStyleBackColor = false;
            closeChatButton.Click += closeChatButton_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("ROG Fonts", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(592, 3);
            label3.Name = "label3";
            label3.Size = new Size(280, 42);
            label3.TabIndex = 14;
            label3.Text = "Live Chat";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // gamePanel
            // 
            gamePanel.BorderStyle = BorderStyle.FixedSingle;
            gamePanel.Controls.Add(terminalPanel);
            gamePanel.Controls.Add(chatPanel);
            gamePanel.Controls.Add(panel1);
            gamePanel.Controls.Add(twoButtonPanel);
            gamePanel.Controls.Add(threeButtonPanel);
            gamePanel.Controls.Add(oneButtonPanel);
            gamePanel.Controls.Add(fourButtonPanel);
            gamePanel.Location = new Point(3, 46);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(1524, 846);
            gamePanel.TabIndex = 10;
            // 
            // terminalPanel
            // 
            terminalPanel.BackgroundImage = Resources.terminalBackground2;
            terminalPanel.Controls.Add(stageLabel);
            terminalPanel.Location = new Point(13, 16);
            terminalPanel.Name = "terminalPanel";
            terminalPanel.Size = new Size(772, 374);
            terminalPanel.TabIndex = 14;
            // 
            // stageLabel
            // 
            stageLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            stageLabel.BackColor = Color.DarkSeaGreen;
            stageLabel.BorderStyle = BorderStyle.FixedSingle;
            stageLabel.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stageLabel.ForeColor = Color.Indigo;
            stageLabel.Location = new Point(21, 25);
            stageLabel.Name = "stageLabel";
            stageLabel.Padding = new Padding(25);
            stageLabel.Size = new Size(720, 331);
            stageLabel.TabIndex = 2;
            stageLabel.Text = "COLLOIDAL GOOP IS COMING, FRIEND";
            // 
            // chatPanel
            // 
            chatPanel.BorderStyle = BorderStyle.FixedSingle;
            chatPanel.Controls.Add(nameTagLabel);
            chatPanel.Controls.Add(chatImage);
            chatPanel.Location = new Point(791, 15);
            chatPanel.Name = "chatPanel";
            chatPanel.Size = new Size(384, 375);
            chatPanel.TabIndex = 13;
            // 
            // nameTagLabel
            // 
            nameTagLabel.BackColor = Color.Transparent;
            nameTagLabel.BorderStyle = BorderStyle.FixedSingle;
            nameTagLabel.Font = new Font("ROG Fonts", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTagLabel.Location = new Point(53, 25);
            nameTagLabel.Name = "nameTagLabel";
            nameTagLabel.Size = new Size(280, 42);
            nameTagLabel.TabIndex = 13;
            nameTagLabel.Text = "Antonio Guida";
            nameTagLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chatImage
            // 
            chatImage.BackColor = Color.Transparent;
            chatImage.BorderStyle = BorderStyle.FixedSingle;
            chatImage.Image = (Image)resources.GetObject("chatImage.Image");
            chatImage.Location = new Point(3, 3);
            chatImage.Name = "chatImage";
            chatImage.Size = new Size(378, 369);
            chatImage.SizeMode = PictureBoxSizeMode.Zoom;
            chatImage.TabIndex = 12;
            chatImage.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.BackgroundImage = Resources.terminalBackground3;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(inventoryBox);
            panel1.Controls.Add(likesLabel);
            panel1.Location = new Point(1182, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 816);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Eurostile ExtendedTwo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 176);
            label2.Name = "label2";
            label2.Size = new Size(280, 42);
            label2.TabIndex = 2;
            label2.Text = "Inventory:";
            // 
            // inventoryBox
            // 
            inventoryBox.BackColor = SystemColors.GradientInactiveCaption;
            inventoryBox.Font = new Font("Univers 55", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventoryBox.FormattingEnabled = true;
            inventoryBox.ItemHeight = 36;
            inventoryBox.Location = new Point(12, 219);
            inventoryBox.Name = "inventoryBox";
            inventoryBox.Size = new Size(300, 580);
            inventoryBox.TabIndex = 1;
            // 
            // likesLabel
            // 
            likesLabel.BackColor = Color.PowderBlue;
            likesLabel.Font = new Font("Monaco", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            likesLabel.Location = new Point(12, 14);
            likesLabel.Name = "likesLabel";
            likesLabel.Padding = new Padding(0, 10, 0, 0);
            likesLabel.Size = new Size(280, 162);
            likesLabel.TabIndex = 0;
            likesLabel.Text = "...";
            // 
            // oneButtonPanel
            // 
            oneButtonPanel.BackgroundImage = Resources.terminalBackground4;
            oneButtonPanel.BorderStyle = BorderStyle.FixedSingle;
            oneButtonPanel.Controls.Add(ONEoptionOne);
            oneButtonPanel.Location = new Point(14, 404);
            oneButtonPanel.Name = "oneButtonPanel";
            oneButtonPanel.Size = new Size(1161, 427);
            oneButtonPanel.TabIndex = 5;
            // 
            // ONEoptionOne
            // 
            ONEoptionOne.BackColor = Color.Moccasin;
            ONEoptionOne.Font = new Font("Univers Condensed", 12F);
            ONEoptionOne.Location = new Point(310, 106);
            ONEoptionOne.Name = "ONEoptionOne";
            ONEoptionOne.Size = new Size(542, 201);
            ONEoptionOne.TabIndex = 0;
            ONEoptionOne.Text = "Option 1";
            ONEoptionOne.UseVisualStyleBackColor = false;
            ONEoptionOne.Click += ONEoptionOne_Click;
            ONEoptionOne.MouseHover += ONEoptionOne_MouseHover;
            ONEoptionOne.MouseLeave += ONEoptionOne_MouseLeave;
            // 
            // fourButtonPanel
            // 
            fourButtonPanel.BackgroundImage = Resources.terminalBackground4;
            fourButtonPanel.BorderStyle = BorderStyle.FixedSingle;
            fourButtonPanel.Controls.Add(FOURoption4);
            fourButtonPanel.Controls.Add(FOURoption3);
            fourButtonPanel.Controls.Add(FOURoption2);
            fourButtonPanel.Controls.Add(FOURoption1);
            fourButtonPanel.Location = new Point(15, 404);
            fourButtonPanel.Name = "fourButtonPanel";
            fourButtonPanel.Size = new Size(1161, 427);
            fourButtonPanel.TabIndex = 7;
            // 
            // FOURoption4
            // 
            FOURoption4.BackColor = Color.Moccasin;
            FOURoption4.Font = new Font("Univers Condensed", 12F);
            FOURoption4.Location = new Point(602, 221);
            FOURoption4.Name = "FOURoption4";
            FOURoption4.Size = new Size(542, 201);
            FOURoption4.TabIndex = 3;
            FOURoption4.Text = "Option 3";
            FOURoption4.UseVisualStyleBackColor = false;
            FOURoption4.Click += FOURoption4_Click;
            FOURoption4.MouseHover += FOURoptionFour_MouseHover;
            FOURoption4.MouseLeave += FOURoptionFour_MouseLeave;
            // 
            // FOURoption3
            // 
            FOURoption3.BackColor = Color.Moccasin;
            FOURoption3.Font = new Font("Univers Condensed", 12F);
            FOURoption3.Location = new Point(19, 221);
            FOURoption3.Name = "FOURoption3";
            FOURoption3.Size = new Size(542, 201);
            FOURoption3.TabIndex = 2;
            FOURoption3.Text = "Option 3";
            FOURoption3.UseVisualStyleBackColor = false;
            FOURoption3.Click += FOURoption3_Click;
            FOURoption3.MouseHover += FOURoptionThree_MouseHover;
            FOURoption3.MouseLeave += FOURoptionThree_MouseLeave;
            // 
            // FOURoption2
            // 
            FOURoption2.BackColor = Color.Moccasin;
            FOURoption2.Font = new Font("Univers Condensed", 12F);
            FOURoption2.Location = new Point(602, 14);
            FOURoption2.Name = "FOURoption2";
            FOURoption2.Size = new Size(542, 201);
            FOURoption2.TabIndex = 1;
            FOURoption2.Text = "Option 2";
            FOURoption2.UseVisualStyleBackColor = false;
            FOURoption2.Click += FOURoption2_Click;
            FOURoption2.MouseHover += FOURoptionTwo_MouseHover;
            FOURoption2.MouseLeave += FOURoptionTwo_MouseLeave;
            // 
            // FOURoption1
            // 
            FOURoption1.BackColor = Color.Moccasin;
            FOURoption1.Font = new Font("Univers Condensed", 12F);
            FOURoption1.Location = new Point(19, 14);
            FOURoption1.Name = "FOURoption1";
            FOURoption1.Size = new Size(542, 201);
            FOURoption1.TabIndex = 0;
            FOURoption1.Text = "Option 1";
            FOURoption1.UseVisualStyleBackColor = false;
            FOURoption1.Click += FOURoption1_Click;
            FOURoption1.MouseHover += FOURoptionOne_MouseHover;
            FOURoption1.MouseLeave += FOURoptionOne_MouseLeave;
            // 
            // twoButtonPanel
            // 
            twoButtonPanel.BackgroundImage = Resources.terminalBackground4;
            twoButtonPanel.BorderStyle = BorderStyle.FixedSingle;
            twoButtonPanel.Controls.Add(TWOoption2);
            twoButtonPanel.Controls.Add(TWOoption1);
            twoButtonPanel.Location = new Point(15, 404);
            twoButtonPanel.Name = "twoButtonPanel";
            twoButtonPanel.Size = new Size(1161, 427);
            twoButtonPanel.TabIndex = 9;
            // 
            // TWOoption2
            // 
            TWOoption2.BackColor = Color.Moccasin;
            TWOoption2.Font = new Font("Univers Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TWOoption2.Location = new Point(587, 108);
            TWOoption2.Name = "TWOoption2";
            TWOoption2.Size = new Size(542, 201);
            TWOoption2.TabIndex = 1;
            TWOoption2.Text = "Option 2";
            TWOoption2.UseVisualStyleBackColor = false;
            TWOoption2.Click += TWOoption2_Click;
            TWOoption2.MouseHover += TWOoptionTWO_MouseHover;
            TWOoption2.MouseLeave += TWOoptionTWO_MouseLeave;
            // 
            // TWOoption1
            // 
            TWOoption1.BackColor = Color.Moccasin;
            TWOoption1.Font = new Font("Univers Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TWOoption1.Location = new Point(18, 108);
            TWOoption1.Name = "TWOoption1";
            TWOoption1.Size = new Size(542, 201);
            TWOoption1.TabIndex = 0;
            TWOoption1.Text = "Option 1";
            TWOoption1.UseVisualStyleBackColor = false;
            TWOoption1.Click += TWOoption1_Click;
            TWOoption1.MouseHover += TWOoptionOne_MouseHover;
            TWOoption1.MouseLeave += TWOoptionOne_MouseLeave;
            // 
            // threeButtonPanel
            // 
            threeButtonPanel.BackgroundImage = Resources.terminalBackground4;
            threeButtonPanel.BorderStyle = BorderStyle.FixedSingle;
            threeButtonPanel.Controls.Add(THREEoption3);
            threeButtonPanel.Controls.Add(THREEoption2);
            threeButtonPanel.Controls.Add(THREEoption1);
            threeButtonPanel.Location = new Point(14, 404);
            threeButtonPanel.Name = "threeButtonPanel";
            threeButtonPanel.Size = new Size(1161, 427);
            threeButtonPanel.TabIndex = 8;
            // 
            // THREEoption3
            // 
            THREEoption3.BackColor = Color.Moccasin;
            THREEoption3.Font = new Font("Univers Condensed", 12F);
            THREEoption3.Location = new Point(311, 221);
            THREEoption3.Name = "THREEoption3";
            THREEoption3.Size = new Size(542, 201);
            THREEoption3.TabIndex = 2;
            THREEoption3.Text = "Option 3";
            THREEoption3.UseVisualStyleBackColor = false;
            THREEoption3.Click += THREEoption3_Click;
            THREEoption3.MouseHover += THREEoptionThree_MouseHover;
            THREEoption3.MouseLeave += THREEoptionThree_MouseLeave;
            // 
            // THREEoption2
            // 
            THREEoption2.BackColor = Color.Moccasin;
            THREEoption2.Font = new Font("Univers Condensed", 12F);
            THREEoption2.Location = new Point(602, 14);
            THREEoption2.Name = "THREEoption2";
            THREEoption2.Size = new Size(542, 201);
            THREEoption2.TabIndex = 1;
            THREEoption2.Text = "Option 2";
            THREEoption2.UseVisualStyleBackColor = false;
            THREEoption2.Click += THREEoption2_Click;
            THREEoption2.MouseHover += THREEoptionTwo_MouseHover;
            THREEoption2.MouseLeave += THREEoptionTwo_MouseLeave;
            // 
            // THREEoption1
            // 
            THREEoption1.BackColor = Color.Moccasin;
            THREEoption1.Font = new Font("Univers Condensed", 12F);
            THREEoption1.Location = new Point(19, 14);
            THREEoption1.Name = "THREEoption1";
            THREEoption1.Size = new Size(542, 201);
            THREEoption1.TabIndex = 0;
            THREEoption1.Text = "Option 1";
            THREEoption1.UseVisualStyleBackColor = false;
            THREEoption1.Click += THREEoption1_Click;
            THREEoption1.MouseHover += THREEoptionOne_MouseHover;
            THREEoption1.MouseLeave += THREEoptionOne_MouseLeave;
            // 
            // timer2
            // 
            timer2.Interval = 25;
            timer2.Tick += timer2_Tick;
            // 
            // WaveEngine
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2351, 1421);
            Controls.Add(programPanel);
            Controls.Add(musicPlayerPanel);
            Controls.Add(backgroundImage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "WaveEngine";
            Text = "WaveEngine";
            Load += WaveEngine_Load;
            MouseMove += WaveEngine_MouseMove;
            ((System.ComponentModel.ISupportInitialize)backgroundImage).EndInit();
            musicPlayerPanel.ResumeLayout(false);
            musicPlayerPanel.PerformLayout();
            musicControlPanel.ResumeLayout(false);
            musicControlPanel.PerformLayout();
            programPanel.ResumeLayout(false);
            gamePanel.ResumeLayout(false);
            terminalPanel.ResumeLayout(false);
            chatPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chatImage).EndInit();
            panel1.ResumeLayout(false);
            oneButtonPanel.ResumeLayout(false);
            fourButtonPanel.ResumeLayout(false);
            twoButtonPanel.ResumeLayout(false);
            threeButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion
        private Button closeChatButton;
        private Button button2;
        private PictureBox backgroundImage;
        private Panel musicPlayerPanel;
        private Label label1;
        private Panel musicControlPanel;
        private Label songLabel;
        private Label nowPlayingLabel;
        private Button stopMusicbutton;
        private Button playMusicButton;
        private System.Windows.Forms.Timer timer1;
        private Panel programPanel;
        private Label label3;
        private Panel gamePanel;
        private Panel chatPanel;
        private Label nameTagLabel;
        private PictureBox chatImage;
        private Panel panel1;
        private Label label2;
        private ListBox inventoryBox;
        private Label likesLabel;
        public Panel threeButtonPanel;
        private Button THREEoption3;
        private Button THREEoption2;
        private Button THREEoption1;
        private Panel oneButtonPanel;
        private Button ONEoptionOne;
        public Panel fourButtonPanel;
        private Button FOURoption4;
        private Button FOURoption3;
        private Button FOURoption2;
        private Button FOURoption1;
        public Panel twoButtonPanel;
        private Button TWOoption2;
        private Button TWOoption1;
        private Button closeMusicButton;
        private Button moveProgramButton;
        private System.Windows.Forms.Timer timer2;
        private Button moveMusicButton;
        private Panel terminalPanel;
        public Label stageLabel;
    }
}
