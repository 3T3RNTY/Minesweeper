using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        PictureBox pictureBox;
        Random random = new Random();

        int[,] list = new int[30, 30];
        PictureBox[,] boxList = new PictureBox[30, 30];
        bool[,] checkMap = new bool[30, 30];


        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_click(object sender, EventArgs e)
        {
            try
            {
                string text = mineNumText.Text;
                int number = Convert.ToInt32(text);
                if (number > 0)
                {
                    EntryLabel.Hide();
                    mineNumText.Hide();
                    startButton.Hide();
                    Create(number);
                }
            }
            catch
            {
                MessageBox.Show("Please enter number...");
            }

        }
        private void PictureBox_Click(object sender, EventArgs e)
        {

            
            var pictureBox = (PictureBox)sender;
            string name = pictureBox.Name;
            int i = int.Parse(name.Substring(10, 2)) - 10;
            int j = int.Parse(name.Substring(12, 2)) - 10;

            bool[,] checkMap = new bool[30, 30];
            Check(i, j);



            //MessageBox.Show(i.ToString() + " " + j.ToString() + " " + list[i, j]);


        }
        public void Create(int number)
        {
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
        public void Write()
        {
            int i = 1;
            int j = 1;
            string name = "PictureBox" + i + j;
        }
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
                            if (list[i, j] == 1)
                                mineCount++;

                            if (!checkMap[i, j] & list[i, j] == 0)                                                            
                                Check(i, j);
                                
                        }
                        catch { }
                    }
                }
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
            
            else
            {
                //MessageBox.Show("Game Over!");
                boxList[x, y].Image = Properties.Resources.Mavi9;
            }

            if (mineCount == 0 && list[x,y] != 1)
                boxList[x, y].Image = Properties.Resources.Mavi0;
        }
    }
}
