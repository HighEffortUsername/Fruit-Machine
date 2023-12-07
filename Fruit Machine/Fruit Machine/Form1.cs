using System.Security.Permissions;
using System.Timers;

namespace Fruit_Machine
{
    public partial class Form1 : Form
    {
        static Image Apple = Fruit_Machine.Resource1.Apple;
        static Image Banana = Fruit_Machine.Resource1.Banana;
        static Image Cherry = Fruit_Machine.Resource1.Cherry;
        static Image Kiwi = Fruit_Machine.Resource1.Kiwi;
        static Image Pineapple = Fruit_Machine.Resource1.Pineapple;

        Image[] Fruits = new Image[] { Apple, Banana, Cherry, Kiwi, Pineapple };
        int[] slotPos = { 0, 0, 0 };
        //Creates arrays to store the images and the image each slot is on.

        public Form1()
        {
            InitializeComponent();
            Slot1.Image = Fruits[slotPos[0]];
            Slot2.Image = Fruits[slotPos[1]];
            Slot3.Image = Fruits[slotPos[2]];
            Slot1Upper.Image = Fruits[4];
            Slot1Lower.Image = Fruits[1];
            Slot2Upper.Image = Fruits[4];
            Slot2Lower.Image = Fruits[1];
            Slot3Upper.Image = Fruits[4];
            Slot3Lower.Image = Fruits[1];
            //Sets each slot to the first image.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            Refresh();
            Update();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            new Random();
            int slot = new Random().Next(0, 3);
            switch (slot)
            {
                case 0:
                    {
                        slotPos[0] = slotPos[0] + 1;
                        if (slotPos[0] >= Fruits.Length)
                        {
                            slotPos[0] = 0;
                        }
                        Slot1.Image = Fruits[slotPos[0]];
                        if (slotPos[0] == 0)
                        {
                            Slot1Upper.Image = Fruits[4];
                        }
                        else
                        {
                            Slot1Upper.Image = Fruits[slotPos[0] - 1];
                        }
                        if (slotPos[0] == Fruits.Length - 1)
                        {
                            Slot1Lower.Image = Fruits[0];
                        }
                        else
                        {
                            Slot1Lower.Image = Fruits[slotPos[0] + 1];
                        }
                        break;
                    }
                case 1:
                    {
                        slotPos[1] = slotPos[1] + 1;
                        if (slotPos[1] >= Fruits.Length)
                        {
                            slotPos[1] = 0;
                        }
                        Slot2.Image = Fruits[slotPos[1]];
                        if (slotPos[1] == 0)
                        {
                            Slot2Upper.Image = Fruits[4];
                        }
                        else
                        {
                            Slot2Upper.Image = Fruits[slotPos[1] - 1];
                        }
                        if (slotPos[1] == Fruits.Length - 1)
                        {
                            Slot2Lower.Image = Fruits[0];
                        }
                        else
                        {
                            Slot2Lower.Image = Fruits[slotPos[1] + 1];
                        }
                        break;
                    }
                case 2:
                    {
                        slotPos[2] = slotPos[2] + 1;
                        if (slotPos[2] >= Fruits.Length)
                        {
                            slotPos[2] = 0;
                        }
                        Slot3.Image = Fruits[slotPos[2]];
                        if (slotPos[2] == 0)
                        {
                            Slot3Upper.Image = Fruits[4];
                        }
                        else
                        {
                            Slot3Upper.Image = Fruits[slotPos[2] - 1];
                        }
                        if (slotPos[2] == Fruits.Length - 1)
                        {
                            Slot3Lower.Image = Fruits[0];
                        }
                        else
                        {
                            Slot3Lower.Image = Fruits[slotPos[2] + 1];
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            Slot3.Image = Fruits[slotPos[2]];
            Refresh();
            Update();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }
    }
}