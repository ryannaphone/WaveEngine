using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Media;
using System.Reflection.Metadata.Ecma335;
using WaveEngine.Properties;

namespace WaveEngine
{
    public partial class WaveEngine : Form
    {
        System.Media.SoundPlayer audioPlayer;

        public Boolean inProgress;

        public Event[] events;
        public static int totalEvents = 10;

        public Event currentEvent;
        public Stage currentStage;
        public Option currentOption;
        public int eventIndex;
        public int stageIndex;
        public int optionIndex;

        public int currentBackgroundState;
        public int currentChatState;
        public int currentSongState;
        public int lastBackgroundState = -1;
        public int lastChatState = -1;
        public int lastSongState = -1;

        public Boolean musicStopped = false;

        public Boolean holdingProgram = false;
        public Boolean holdingMusic = false;

        public static Person player;
        public static Person baron = new Person("Baron Von Odorbotom", 4524, new Event[0], new Item[0]);
        public static Person guida = new Person("Antonio Guida", 9986, new Event[0], new Item[0]);
        public WaveEngine()
        {
            InitializeComponent();
        }

        private void WaveEngine_Load(object sender, EventArgs e)
        {

            Cursor.Position = new Point(0, 0);
            timer2.Start();
            timer1.Interval = 800;
            chatPanel.Show();
            audioPlayer = new System.Media.SoundPlayer(@"C:\Users\Cloon\source\repos\WaveEngine\WaveEngine\Resources\tutorialBeat.wav");
            audioPlayer.Play();
            events = generateEvents();
            player = new Person("Norman", 0, new Event[0], new Item[0]);
            loadEvent(events[0]);
        }



        public void startGame()
        {

        }

        static Event[] generateEvents()
        {
            Event[] events = new Event[totalEvents];
            events[0] = tutorial();
            events[1] = greenHorn();

            return events;
        }

        static Event greenHorn()
        {
            int greenHornStages = 1;
            Event greenHorn = new Event();
            Stage[] stages = new Stage[greenHornStages];
            Option[][] options = new Option[greenHornStages][];

            options[0] = new Option[2];
            options[0][0] = new Option("'Sure'", 0);
            options[0][1] = new Option("'No way.'", 0);

            stages[0] = new Stage("'Think you could help me out?'", options[0]);

            greenHorn = new Event("Greenhorn", stages);

            return greenHorn;
        }
        static Event tutorial()
        {
            int tutorialStages = 12;
            Event tutorial = new Event();
            Stage[] stages = new Stage[tutorialStages];
            Option[][] options = new Option[tutorialStages][];


            options[0] = new Option[1];
            options[0][0] = new Option("Click here.", "Yes! Click me!", 1, 1, -1, -1, 1, 1);

            stages[0] = new Stage("'Hey! It's me! " +
                "\n I'm on your screen!" +
                "\n You must be here for... " +
                "\n *that Tutorial,* right? " +
                "\n Just click that button for me, " +
                "\n then we can get started.'", options[0], 0, 0, 0);


            options[1] = new Option[2];
            options[1][0] = new Option("'My name is Norman'", 2, 2, -1, -1, 1, 1);
            options[1][1] = new Option("'My name is Sine'", 3, 3, -1, -1, 3, 3);

            stages[1] = new Stage("'Before we can go any further, " +
                "\n I need you to verify " +
                "\n ~your indicator.~ " +
                "\n Just seleect the correct option. " +
                "\n Shouldn't be too hard.'", options[1], 0, 0, 0);

            options[2] = new Option[3];
            options[2][0] = new Option("Myself.", "I'm an independent contractor.", 11, 11, -1, -1, 4, 4);
            options[2][1] = new Option("Olympia, Inc.", "'It's a job, ya know.'", 11, 11, -1, -1, 1, 1);
            options[2][2] = new Option("The Postal Service", "'I like my pension.'", 11, 11, -1, -1, 6, 6);

            stages[2] = new Stage("'It's nice to meet you Sine. " +
                "\n Who do you work for?.'", options[2], 0, 0, 0);

            options[3] = new Option[3];
            options[3][0] = new Option("Myself.", "I'm my own boss.", 11, 11, -1, -1, 4, 4);
            options[3][1] = new Option("Olympia, Inc.", "'They've always treated me well.'", 11, 11, -1, -1, 1, 1);
            options[3][2] = new Option("The Postal Service", "'I take pride in the uniform.'", 11, 11, -1, -1, 6, 6);

            stages[3] = new Stage("'It's nice to meet you Sine. " +
                "\n Who do you work for?.'", options[3], 0, 0, 0);

            options[4] = new Option[1];
            options[4][0] = new Option("Click if you want.", 1);

            stages[4] = new Stage("You drop the package.", options[4], 0, 0, 1);

            options[11] = new Option[1];
            options[11][0] = new Option("Restart.", 0);

            stages[11] = new Stage("The tutorial is incomplete, " +
                "\n please restart the game " +
                "\n and try a different path.", options[11], 0, 0, 1);

            tutorial = new Event("Tutorial", stages);

            return tutorial;

        }

        public void loadEvent(Event e)
        {
            currentStage = e.stages[0];
            currentEvent = e;
            eventIndex = 0;
            stageIndex = 0;

            this.Text = "WaveEngine - " + e.text;
            loadStage(e.stages[0]);
        }

        public void loadEvent(Event e, int stageIndex)
        {
            loadStage(e.stages[stageIndex]);
        }

        public void loadStage(Stage s)
        {
            currentStage = s;
            stageLabel.Text = s.text;
            showPanel(s.options.Length);
            switch (s.options.Length)
            {
                case 1:
                    ONEoptionOne.Text = s.options[0].text;
                    break;

                case 2:
                    TWOoption1.Text = s.options[0].text;
                    TWOoption2.Text = s.options[1].text;
                    break;

                case 3:
                    THREEoption1.Text = s.options[0].text;
                    THREEoption2.Text = s.options[1].text;
                    THREEoption3.Text = s.options[2].text;
                    break;

                case 4:
                    FOURoption1.Text = s.options[0].text;
                    FOURoption2.Text = s.options[1].text;
                    FOURoption3.Text = s.options[2].text;
                    FOURoption4.Text = s.options[3].text;
                    break;
            }

            setScene(s.backgroundState, s.chatState, s.songState);
            timer1.Start();
        }

        public void updateLikes(int num)
        {
            player.likes += num;
            if (num != 0)
            {
                likesLabel.Text = "Likes : " + player.likes +
                    "\nYou received " +
                    "\n" + num + " likes!";
            }
            else
            {
                likesLabel.Text = "Likes : " + player.likes;
            }
        }



        private void setIndexes(int buttonNum)
        {
            optionIndex = buttonNum;
            currentOption = currentStage.options[optionIndex];
            if (currentOption.resultEventT != -1 || currentOption.resultEventF != -1)
            {
                if (checkConditions(eventIndex, stageIndex, optionIndex))
                {
                    eventIndex = currentOption.resultEventT;
                }
                else
                {
                    eventIndex = currentOption.resultEventF;
                }
            }

            if (checkConditions(eventIndex, stageIndex, optionIndex))
            {
                stageIndex = currentOption.resultStageT;
                updateLikes(currentOption.likesT);
            }
            else
            {
                stageIndex = currentOption.resultStageF;
                updateLikes(currentOption.likesF);
            }



        }

        public void setScene(int bState, int cState, int songIndex)
        {
            setChatImage(cState);
            setBackgroundImage(bState);
            setSong(songIndex);


        }

        private void setSong(int i)
        {
            if (i != lastSongState && !musicStopped)
            {
                switch (i)
                {
                    case -1:
                        songLabel.Text = "...";
                        audioPlayer.Stop();
                        currentSongState = -1;
                        break;
                    case 0:
                        audioPlayer = new System.Media.SoundPlayer(@"C:\Users\Cloon\source\repos\WaveEngine\WaveEngine\Resources\tutorialBeat.wav");
                        audioPlayer.Load();
                        audioPlayer.PlayLooping();
                        songLabel.Text = "tutorialBeat.wav - Watson";
                        currentSongState = 0;
                        break;
                    case 1:
                        audioPlayer = new System.Media.SoundPlayer(@"C:\Users\Cloon\source\repos\WaveEngine\WaveEngine\Resources\tutorialJaunt.wav");
                        audioPlayer.Load();
                        audioPlayer.PlayLooping();
                        songLabel.Text = "tutorialJaunt.wav - Watson";
                        currentSongState = 1;
                        break;

                }
                lastSongState = i;
            }
            else
            {

            }
        }



        private void setChatImage(int i)
        {
            switch (i)
            {
                case -1:
                    chatImage.Hide();
                    nameTagLabel.Hide();
                    currentChatState = -1;
                    break;

                case 0:
                    chatImage.Show();
                    nameTagLabel.Show();
                    chatImage.Image = Image.FromFile(@"C:\Users\Cloon\source\repos\WaveEngine\WaveEngine\Resources\antonio.png");
                    nameTagLabel.Text = "Antonio Guida";
                    currentChatState = 0;
                    break;

                case 1:
                    chatImage.Show();
                    nameTagLabel.Show();
                    chatImage.Image = Image.FromFile(@"C:\Users\Cloon\source\repos\WaveEngine\WaveEngine\Resources\antonioOpenMouth.png");
                    nameTagLabel.Text = "Antonio Guida";
                    currentChatState = 1;
                    break;

                case 2:
                    chatImage.Show();
                    nameTagLabel.Show();
                    chatImage.Image = Image.FromFile(@"C:\Users\Cloon\source\repos\WaveEngine\WaveEngine\Resources\antonioMidOpen.png");
                    nameTagLabel.Text = "Antonio Guida";
                    currentChatState = 2;
                    break;
            }
        }

        private void setBackgroundImage(int i)
        {
            switch (i)
            {
                case -1:
                    backgroundImage.Hide();
                    currentBackgroundState = -1;
                    break;

                case 0:
                    backgroundImage.Image = Image.FromFile(@"C:\Users\Cloon\source\repos\WaveEngine\WaveEngine\Resources\IMG_2046.png");
                    backgroundImage.Show();
                    currentBackgroundState = 0;
                    break;
            }
        }

        private void optionSelected(int optionIndex)
        {
            triggerEffects(eventIndex, stageIndex, optionIndex);
            setIndexes(optionIndex);
            loadEvent(events[eventIndex], stageIndex);

        }

        private Boolean checkConditions(int eIndex, int sIndex, int oIndex)
        {
            switch (eIndex)
            {
                case 0:
                    switch (sIndex)
                    {

                    }
                    break;
            }
            return true;
        }

        private void triggerEffects(int eIndex, int sIndex, int oIndex)
        {
            switch (eIndex)
            {
                case 0:
                    switch (sIndex)
                    {
                        case 0:
                            switch (oIndex)
                            {
                                case 0:

                                    break;
                            }
                            break;

                        case 2:
                            switch (oIndex)
                            {
                                case 0:
                                    addItemToInventory(player, new Package("Tutorial", (float)10.0, baron));
                                    //removeItemFromInventory(player, new Package("Tutorial", (float)10.0, baron));
                                    break;
                            }
                            break;

                        case 3:
                            switch (oIndex)
                            {
                                case 0:
                                    removeItemFromInventory(player, new Package("Tutorial", (float)10.0, baron));
                                    //removeItemFromInventory(player, new Package("Tutorial", (float)10.0, baron));
                                    break;
                            }
                            break;

                    }
                    break;



            }
        }

        private void addItemToInventory(Person p, Item i)
        {
            if (findItem(p.items, i) == -1)
            {
                p.items = expandInventory(p.items);
                p.items[p.items.Length - 1] = i;

            }
            else if (i.stackable)
            {

                p.items[findItem(p.items, i)].quantity += i.quantity;

            }
            else
            {
                p.items = expandInventory(p.items);
                p.items[p.items.Length - 1] = i;
            }

            updateInventoryBox(p.items);

        }

        private void removeItemFromInventory(Person p, Item i)
        {
            p.items = shrinkInventory(p.items, findItem(p.items, i));


            updateInventoryBox(p.items);
        }

        private void removeItemFromInventory(Person p, Item i, int num)
        {
            updateInventoryBox(p.items);
        }

        private void updateInventoryBox(Item[] i)
        {
            inventoryBox.Items.Clear();
            for (int index = 0; index < i.Length; index++)
            {
                if (i[index] is Package)
                {
                    inventoryBox.Items.Add(i[index].name + " Package : " + i[index].quantity);
                }
                else
                {
                    inventoryBox.Items.Add(i[index].name + " : " + i[index].quantity);
                }

            }
        }

        private Item[] shrinkInventory(Item[] i, int index)
        {
            Item[] shrunk = new Item[i.Length - 1];

            for (int i2 = 0; i2 < index; i2++)
            {
                shrunk[i2] = i[i2];
            }

            for (int i2 = index; i2 < i.Length - 1; i2++)
            {
                shrunk[i2] = i[i2 + 1];
            }

            return shrunk;
        }

        private Item[] expandInventory(Item[] i)
        {
            Item[] expanded = new Item[i.Length + 1];

            for (int i2 = 0; i2 < i.Length; i2++)
            {
                expanded[i2] = i[i2];
            }

            return expanded;
        }

        private int findItem(Item[] items, Item i)
        {
            int index = -1;

            for (int i2 = 0; i2 < items.Length; i2++)
            {
                if (items[i2].name.Equals(i.name)) return i2;
            }

            return index;
        }



        public void showPanel(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("One Option.");
                    oneButtonPanel.Show();
                    twoButtonPanel.Hide();
                    threeButtonPanel.Hide();
                    fourButtonPanel.Hide();
                    break;

                case 2:
                    Console.WriteLine("Two Options.");
                    oneButtonPanel.Hide();
                    twoButtonPanel.Show();
                    threeButtonPanel.Hide();
                    fourButtonPanel.Hide();
                    break;

                case 3:
                    Console.WriteLine("Three Options.");
                    oneButtonPanel.Hide();
                    twoButtonPanel.Hide();
                    threeButtonPanel.Show();
                    fourButtonPanel.Hide();
                    break;

                case 4:
                    Console.WriteLine("Four Options.");
                    oneButtonPanel.Hide();
                    twoButtonPanel.Hide();
                    threeButtonPanel.Hide();
                    fourButtonPanel.Show();
                    break;
            }
        }



        private void ONEoptionOne_Click(object sender, EventArgs e)
        {
            optionSelected(0);
        }

        private void ONEoptionOne_MouseHover(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            } else
            {
                ONEoptionOne.Text = currentStage.options[0].hoverText;
            }
            
        }

        private void ONEoptionOne_MouseLeave(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                ONEoptionOne.Text = currentStage.options[0].text;
            }

        }

        private void TWOoption2_Click(object sender, EventArgs e)
        {
            optionSelected(1);
        }

        private void TWOoption1_Click(object sender, EventArgs e)
        {
            optionSelected(0);
        }

        private void TWOoptionOne_MouseHover(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                TWOoption1.Text = currentStage.options[0].hoverText;
            }

        }
        private void TWOoptionOne_MouseLeave(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                TWOoption1.Text = currentStage.options[0].text;
            }

        }

        private void TWOoptionTWO_MouseHover(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                TWOoption2.Text = currentStage.options[1].hoverText;
            }

        }
        private void TWOoptionTWO_MouseLeave(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                TWOoption2.Text = currentStage.options[1].text;
            }

        }

        private void THREEoption1_Click(object sender, EventArgs e)
        {
            optionSelected(0);
        }

        private void THREEoption2_Click(object sender, EventArgs e)
        {
            optionSelected(1);
        }

        private void THREEoption3_Click(object sender, EventArgs e)
        {
            optionSelected(2);
        }

        private void THREEoptionOne_MouseHover(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                THREEoption1.Text = currentStage.options[0].hoverText;
            }

        }

        private void THREEoptionOne_MouseLeave(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                THREEoption1.Text = currentStage.options[0].text;
            }

        }

        private void THREEoptionTwo_MouseHover(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                THREEoption2.Text = currentStage.options[1].hoverText;
            }

        }

        private void THREEoptionTwo_MouseLeave(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                THREEoption2.Text = currentStage.options[1].text;
            }

        }

        private void THREEoptionThree_MouseHover(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                THREEoption3.Text = currentStage.options[2].hoverText;
            }

        }

        private void THREEoptionThree_MouseLeave(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                THREEoption3.Text = currentStage.options[2].text;
            }

        }

        private void FOURoption1_Click(object sender, EventArgs e)
        {
            optionSelected(0);
        }

        private void FOURoption2_Click(object sender, EventArgs e)
        {
            optionSelected(1);
        }

        private void FOURoption3_Click(object sender, EventArgs e)
        {
            optionSelected(2);
        }

        private void FOURoption4_Click(object sender, EventArgs e)
        {
            optionSelected(3);
        }

        private void FOURoptionOne_MouseHover(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                FOURoption1.Text = currentStage.options[0].hoverText;
            }

        }
        private void FOURoptionOne_MouseLeave(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                FOURoption1.Text = currentStage.options[0].text;
            }

        }

        private void FOURoptionTwo_MouseHover(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                FOURoption2.Text = currentStage.options[1].hoverText;
            }

        }
        private void FOURoptionTwo_MouseLeave(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                FOURoption2.Text = currentStage.options[1].text;
            }

        }

        private void FOURoptionThree_MouseHover(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                FOURoption3.Text = currentStage.options[2].hoverText;
            }

        }
        private void FOURoptionThree_MouseLeave(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                FOURoption3.Text = currentStage.options[2].text;
            }

        }

        private void FOURoptionFour_MouseHover(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                FOURoption4.Text = currentStage.options[3].hoverText;
            }

        }

        private void FOURoptionFour_MouseLeave(object sender, EventArgs e)
        {
            if (currentStage.options[0].hoverText.Equals(""))
            {

            }
            else
            {
                FOURoption4.Text = currentStage.options[3].text;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void stopMusicbutton_Click(object sender, EventArgs e)
        {
            if (musicStopped)
            {

            }
            else
            {
                setSong(-1);
                musicStopped = true;

            }
        }

        private void playMusicButton_Click(object sender, EventArgs e)
        {
            if (musicStopped)
            {
                musicStopped = false;
                setSong(currentStage.songState);

            }
            else
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (currentChatState)
            {
                case 0:
                    setChatImage(1);
                    break;
                case 1:
                    setChatImage(2);
                    break;
                case 2:
                    setChatImage(0);
                    break;
            }
        }

        async void PlaySoundAsync(int i)
        {
            switch (i)
            {
                case 0:
                    using (var player = new SoundPlayer(@"C:\Users\Cloon\source\repos\WaveEngine\WaveEngine\Resources\tutorialBeat.wav"))
                    {
                        player.Load();
                        await Task.Run(() => player.PlaySync()); // Play asynchronously without blocking UI
                        PlaySoundAsync(i);
                    }
                    Console.WriteLine("Playing again.");

                    break;
            }


            // This code will execute after the sound has finished playing,
            // and the UI thread remains responsive during playback.
            //MessageBox.Show("Sound playback complete!");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void closeChatButton_Click(object sender, EventArgs e)
        {
            programPanel.Hide();
        }

        private void closeMusicButton_Click(object sender, EventArgs e)
        {
            musicPlayerPanel.Hide();
            if (musicStopped)
            {

            }
            else
            {
                setSong(-1);
                musicStopped = true;

            }
        }

        private void moveProgramButton_Click(object sender, EventArgs e)
        {

        }
        private void moveProgramButton_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void moveProgramButton_MouseDown(object sender, MouseEventArgs e)
        {

            holdingProgram = true;

        }

        private void moveProgramButton_MouseUp(object sender, EventArgs e)
        {
            holdingProgram = false;
        }

        private void WaveEngine_MouseMove(object sender, MouseEventArgs e)
        {
            //programPanel.Hide();
            if (holdingProgram)
            {
                //programPanel.Hide();
                //programPanel.Location = e.Location;
            }
        }
        private void programPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //programPanel.Hide();
            if (holdingProgram)
            {
                //programPanel.Hide();
                //programPanel.Location = e.Location;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //programPanel.Hide();
            if (holdingProgram)
            {
                int xOffset = -50;
                int yOffset = -90;
                //programPanel.Hide();
                //programPanel.Location = WaveEngine.MousePosition;
                int x = WaveEngine.MousePosition.X - this.Left + xOffset;
                int y = WaveEngine.MousePosition.Y - this.Top + yOffset;
                if (x < 15) x = 15;
                if (y < 15) y = 15;
                if (x > this.Width - programPanel.Width + xOffset) x = this.Width - programPanel.Width + xOffset;
                if (y > this.Height - programPanel.Height + yOffset - 15) y = this.Height - programPanel.Height + yOffset - 15;
                programPanel.Location = new Point(x, y);

            }

            if (holdingMusic)
            {
                int xOffset = -50;
                int yOffset = -90;
                //programPanel.Hide();
                //programPanel.Location = WaveEngine.MousePosition;
                int x = WaveEngine.MousePosition.X - this.Left + xOffset;
                int y = WaveEngine.MousePosition.Y - this.Top + yOffset;
                if (x < 15) x = 15;
                if (y < 15) y = 15;
                if (x > this.Width - musicPlayerPanel.Width + xOffset) x = this.Width - musicPlayerPanel.Width + xOffset;
                if (y > this.Height - musicPlayerPanel.Height + yOffset - 15) y = this.Height - musicPlayerPanel.Height + yOffset - 15;
                musicPlayerPanel.Location = new Point(x, y);

            }
        }

        private void moveMusicButton_Click(object sender, EventArgs e)
        {

        }

        private void moveMusicButton_MouseDown(object sender, MouseEventArgs e)
        {

            holdingMusic = true;

        }

        private void moveMusicButton_MouseUp(object sender, EventArgs e)
        {
            holdingMusic = false;
        }

        
    }
}
