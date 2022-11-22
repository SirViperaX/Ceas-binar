using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceas_binar
{
    public partial class Form1 : Form
    {
        PictureBox[] hourBits = new PictureBox[6];
        PictureBox[] minuteBits = new PictureBox[7];
        PictureBox[] secondBits = new PictureBox[7];
        public Form1()
        {
            InitializeComponent();
            hourBits[0] = HBit1; hourBits[1] = HBit2; hourBits[2] = HBit3; hourBits[3] = HBit4; hourBits[4] = HBit5; hourBits[5] = HBit6;
            minuteBits[0] = MBit1; minuteBits[1] = MBit2; minuteBits[2] = MBit3; minuteBits[3] = MBit4; minuteBits[4] = MBit5; minuteBits[5] = MBit6; minuteBits[6] = MBit7;
            secondBits[0] = SBit1; secondBits[1] = SBit2; secondBits[2] = SBit3; secondBits[3] = SBit4; secondBits[4] = SBit5; secondBits[5] = SBit6; secondBits[6] = SBit7;

        }
        private int[] toBinary(int time)
        {
            int[] binaryNumber = new int[4];
            int i = 3;
            while(time>0)
            {
                binaryNumber[i] = time % 2;
                time /= 2;
                i--;
            }
            return binaryNumber;
        }
        private void hour_Tick()
        {
            int hour = DateTime.Now.Hour;
            int[] binaryNumber1 = toBinary(hour % 10);
            int[] binaryNumber2 = toBinary(hour / 10);
            for(int i = 0; i < hourBits.Length; i++)
            {
                if(i<4)
                {
                    if (binaryNumber1[3 - i] == 1)
                    {
                        hourBits[i].Image = Ceas_binar.Properties.Resources.dsBuffer;

                    }
                    else
                    {
                        hourBits[i].Image = Ceas_binar.Properties.Resources.c9af8efe164f75b2d3aaebf5534892b0;
                    }
                }
                else
                {
                    if (binaryNumber2[7 - i] == 1)
                    {
                        hourBits[i].Image = Ceas_binar.Properties.Resources.dsBuffer;

                    }
                    else
                    {
                        hourBits[i].Image = Ceas_binar.Properties.Resources.c9af8efe164f75b2d3aaebf5534892b0;
                    }
                }
            }

        }

        private void minute_Tick()
        {
            int minute = DateTime.Now.Minute;
            int[] binaryNumber1 = toBinary(minute % 10);
            int[] binaryNumber2 = toBinary(minute / 10);
            for (int i = 0; i < minuteBits.Length; i++)
            {
                if (i < 4)
                {
                    if (binaryNumber1[3 - i] == 1)
                    {
                        minuteBits[i].Image = Ceas_binar.Properties.Resources.dsBuffer;

                    }
                    else
                    {
                        minuteBits[i].Image = Ceas_binar.Properties.Resources.c9af8efe164f75b2d3aaebf5534892b0;
                    }
                }
                else
                {
                    if (binaryNumber2[7 - i] == 1)
                    {
                        minuteBits[i].Image = Ceas_binar.Properties.Resources.dsBuffer;

                    }
                    else
                    {
                        minuteBits[i].Image = Ceas_binar.Properties.Resources.c9af8efe164f75b2d3aaebf5534892b0;
                    }
                }
            }

        }
        private void second_Tick()
        {
            int second = DateTime.Now.Second;
            int[] binaryNumber1 = toBinary(second % 10);
            int[] binaryNumber2 = toBinary(second / 10);
            for (int i = 0; i < secondBits.Length; i++)
            {
                if (i < 4)
                {
                    if (binaryNumber1[3 - i] == 1)
                    {
                        secondBits[i].Image = Ceas_binar.Properties.Resources.dsBuffer;

                    }
                    else
                    {
                        secondBits[i].Image = Ceas_binar.Properties.Resources.c9af8efe164f75b2d3aaebf5534892b0;
                    }
                }
                else
                {
                    if (binaryNumber2[7 - i] == 1)
                    {
                        secondBits[i].Image = Ceas_binar.Properties.Resources.dsBuffer;

                    }
                    else
                    {
                        secondBits[i].Image = Ceas_binar.Properties.Resources.c9af8efe164f75b2d3aaebf5534892b0;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            hour_Tick();
            minute_Tick();
            second_Tick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
