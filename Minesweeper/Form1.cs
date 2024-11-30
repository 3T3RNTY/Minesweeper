using System.Windows.Forms;

namespace Minesweeper
{
    public partial class MainMenu : Form
    {
        // Creating necessary variables and objects
        int minecount;
        int flagCount = 0;
        bool flag = false;
        PictureBox pictureBox;

        Random random = new Random();
        int[,] list = new int[30, 30];
        PictureBox[,] boxList = new PictureBox[30, 30];
        bool[,] checkMap = new bool[30, 30];


        public MainMenu()
        {
            InitializeComponent();
        }

        // Start button event
        private void StartButton_click(object sender, EventArgs e)
        {
            try
            {
                // Checks if entry is between 0 and 900
                string text = mineNumText.Text;
                int number = Convert.ToInt32(text);
                // If entry is valid game starts
                if (number > 0 & number < 900)
                {
                    EntryLabel.Hide();
                    mineNumText.Hide();
                    startButton.Hide();

                    FlagButton.Show();
                    RestartButton.Hide();
                    MineCountLabel.Text = MineCountLabel.Text + number;
                    MineCountLabel.Show();
                    RemainigLabel.Text = RemainigLabel.Text + number;
                    RemainigLabel.Show();

                    minecount = number;
                    Create(number);
                }
            }
            catch
            {
                MessageBox.Show("Please enter number...");
            }

        }

        // Flag button event
        private void FlagButton_Click(object sender, EventArgs e)
        {
       
            var button = (Button)sender;
            // If button is active, makes it inactive
            if (flag)
            {
                flag = false;
                button.BackColor = Color.White;

            }
            // If button is inactive, makes it active
            else
            {
                flag = true;
                button.BackColor = Color.Silver;
            }



        }
        // When clicked the game cell
        private void PictureBox_Click(object sender, EventArgs e)
        {
      
            var pictureBox = (PictureBox)sender;    

            // If flag button is active place a flag
            if (flag & flagCount < minecount)
            {
                flagCount++;
                // If it already has a flag remove it -- Not working currently
                if (pictureBox.Image == Properties.Resources.Flag)
                {
                    pictureBox.Image = Properties.Resources.Mavi;
                    RemainigLabel.Text = "Remaining: " + (minecount - flagCount);
                }
                pictureBox.Image = Properties.Resources.Flag;
                RemainigLabel.Text = "Remaining: " + (minecount - flagCount);

            }
            // If flag button is inactive Check the cell
            else if (!flag)
            {

                string name = pictureBox.Name;
                int i = int.Parse(name.Substring(10, 2)) - 10;
                int j = int.Parse(name.Substring(12, 2)) - 10;

                bool[,] checkMap = new bool[30, 30];
                Check(i, j);
            }

            // If flag count equals to mine count ends the game -- Method is not working as intended
            if (flagCount == minecount)
            {
                MessageBox.Show("Congratulations!");
                //EndCheck();
            }



        }

        // Restarting action
        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void Create(int number)
        {
            // Creating and naming buttons with indexes
            int x = 50;
            int y = 50;
            for (int i = 10; i < 40; i++)
            {
                for (int j = 10; j < 40; j++)
                {
                    pictureBox = new PictureBox();
                    pictureBox.Name = "PictureBox" + i + j;
                    pictureBox.Size = new Size(20, 20);
                    pictureBox.Location = new Point(x, y);
                    pictureBox.Image = Properties.Resources.Mavi;
                    pictureBox.Click += PictureBox_Click;
                    Controls.Add(pictureBox);
                    list[i - 10, j - 10] = 0;
                    boxList[i - 10, j - 10] = pictureBox;
                    x += 25;
                }
                x = 50;
                y += 25;
            }
            // Placing mines
            for (int i = 0; i < number; i++)
            {
                int xMine = random.Next(0, 30);
                int yMine = random.Next(0, 30);
                if (list[xMine, yMine] == 0)
                {
                    list[xMine, yMine] = 1;
                }
                else
                {
                    i--;
                }
            }
        }
        
       // Check method
        public void Check(int x, int y)
        {
            checkMap[x, y] = true;
            int mineCount = 0;

            if (list[x, y] != 1)
            {
                for (int i = x - 1; i < x + 2; i++)
                {
                    for (int j = y - 1; j < y + 2; j++)
                    {
                        try
                        {
                            // If adjacent cell have mine, increase the mine count
                            if (list[i, j] == 1)
                                mineCount++;
                            // If adjacent cell have not mine, also check it
                            if (!checkMap[i, j] & list[i, j] == 0)
                                Check(i, j);

                        }
                        catch { }
                    }
                }
                // Change the picture using mine count
                switch (mineCount)
                {
                    case 0:
                        {
                            boxList[x, y].Image = Properties.Resources.Mavi;
                            break;
                        }
                    case 1:
                        {
                            boxList[x, y].Image = Properties.Resources.Mavi1;
                            break;
                        }
                    case 2:
                        {
                            boxList[x, y].Image = Properties.Resources.Mavi2;
                            break;
                        }
                    case 3:
                        {
                            boxList[x, y].Image = Properties.Resources.Mavi3;
                            break;
                        }
                    case 4:
                        {
                            boxList[x, y].Image = Properties.Resources.Mavi4;
                            break;
                        }
                    case 5:
                        {
                            boxList[x, y].Image = Properties.Resources.Mavi5;
                            break;
                        }
                    case 6:
                        {
                            boxList[x, y].Image = Properties.Resources.Mavi6;
                            break;
                        }
                    case 7:
                        {
                            boxList[x, y].Image = Properties.Resources.Mavi7;
                            break;
                        }
                    case 8:
                        {
                            boxList[x, y].Image = Properties.Resources.Mavi8;
                            break;
                        }
                }
            }

            // If pressed cell has a mine end the game
            else
            {
                MessageBox.Show("Game Over!");
                boxList[x, y].Image = Properties.Resources.Mavi9;
                Application.Restart();
            }

            // If the adjacent cells don't have mines, make the cell empty
            if (mineCount == 0 && list[x, y] != 1)
                boxList[x, y].Image = Properties.Resources.Mavi0;
        }
        // End game check
        public void EndCheck()
        {
            bool isEnd = false;           

            for (int i = 0; i < list.GetLength(0); i++)
            {
                for (int j = 0; j < list.GetLength(1); j++)
                {                   
                    if (list[i, j] != 1 && pictureBox.Image == Properties.Resources.Flag)                    
                    {
                        
                        isEnd = true;
                    }
                }
            }
            if (isEnd)
            {
                MessageBox.Show("Congratulations!");
            }
        }
    }
}
