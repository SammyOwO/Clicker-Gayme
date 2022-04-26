using System;
using System.Windows.Forms;

namespace Clicker_Gayme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //All my variable in 1 place.
        double dosh = 0;
        double price2 = 100;
        double price4 = 1000;
        double price8 = 10000;
        double price16 = 50000;
        double price32 = 250000;
        double price64 = 2;
        double price128 = 8;
        double price256 = 16;
        double price512 = 64;
        double price1024 = 128;
        double price2048 = 2;
        double price4096 = 8;
        double price8192 = 32;
        double price_win = 128;
        Int16 ClickPlus2 = 0;
        Int16 ClickPlus4 = 0;
        Int16 ClickPlus8 = 0;
        Int16 ClickPlus16 = 0;
        Int16 ClickPlus32 = 0;
        Int16 ClickPlus64 = 0;
        Int16 ClickPlus128 = 0;
        Int16 ClickPlus256 = 0;
        Int16 ClickPlus512 = 0;
        Int16 ClickPlus1024 = 0;
        Int16 ClickPlus2048 = 0;
        Int16 ClickPlus4096 = 0;
        Int16 ClickPlus8192 = 0;
        Int16 awaited_coins = 0;
        Int16 awaited_super_coins = 0;
        int prestige_coins = 0;
        int super_coins = 0;
        byte wins = 0;

        //This is the code that adds the money when you click the button to get money.
        private void button_CashMoney_Click(object sender, EventArgs e)
        {
            textBox_CashMoney.Text = dosh.ToString();
            //This checks if you clicked the +2 Clicks button, if you haven't it adds one.
            //If you have clicked it, it checks if you clicked the +4 clicks button, if you haven't it adds 1 + the amount of times you purchased the +2 clicks.
            //This goes on for each button: +2 Clicks, +4 Clicks, +8 clicks etc.
            if (ClickPlus2 == 0)
            {
                dosh += 1;
            }
            else
            {
                if (ClickPlus4 == 0)
                {
                    dosh += 1 + (ClickPlus2 * 2);
                }
                else
                {
                    if (ClickPlus8 == 0)
                    {
                        dosh += 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4);
                    }
                    else
                    {
                        if (ClickPlus16 == 0)
                        {
                            dosh += 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8);
                        }
                        else
                        {
                            if (ClickPlus32 == 0)
                            {
                                dosh += 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16);
                            }
                            else
                            {
                                if (ClickPlus64 == 0)
                                {
                                    dosh += 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32);
                                }
                                else
                                {
                                    if (ClickPlus128 == 0)
                                    {
                                        dosh += 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64);
                                    }
                                    else
                                    {
                                        if (ClickPlus256 == 0)
                                        {
                                            dosh += 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128);
                                        }
                                        else
                                        {
                                            if (ClickPlus512 == 0)
                                            {
                                                dosh += 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256);
                                            }
                                            else
                                            {
                                                if (ClickPlus1024 == 0)
                                                {
                                                    dosh += 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512);
                                                }
                                                else
                                                {
                                                    if (ClickPlus2048 == 0)
                                                    {
                                                        dosh += 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024);
                                                    }
                                                    else
                                                    {
                                                        if (ClickPlus4096 == 0)
                                                        {
                                                            dosh += 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048);
                                                        }
                                                        else
                                                        {
                                                            if (ClickPlus8192 == 0)
                                                            {
                                                                dosh += 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048) + (ClickPlus4096 * 4096);
                                                            }
                                                            else
                                                            {
                                                                dosh += 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048) + (ClickPlus4096 * 4096) + (ClickPlus8192 * 8192);
                                                            };
                                                        };
                                                    };
                                                };
                                            };
                                        };
                                    };
                                };
                            };
                        };
                    };
                };
            };
            toolTip_price2.SetToolTip(control: button_plus2, Math.Truncate(price2).ToString());
            toolTip_price4.SetToolTip(control: button_plus4, Math.Truncate(price4).ToString());
            toolTip_price8.SetToolTip(control: button_plus8, Math.Truncate(price8).ToString());
            toolTip_price16.SetToolTip(control: button_plus16, Math.Truncate(price16).ToString());
            toolTip_price32.SetToolTip(control: button_plus32, Math.Truncate(price32).ToString());
            toolTip_price64.SetToolTip(control: button_plus64, Math.Truncate(price64).ToString());
            toolTip_price128.SetToolTip(control: button_plus128, Math.Truncate(price128).ToString());
            toolTip_price256.SetToolTip(control: button_plus256, Math.Truncate(price256).ToString());
            toolTip_price512.SetToolTip(control: button_plus512, Math.Truncate(price512).ToString());
            toolTip_price1024.SetToolTip(control: button_plus1024, Math.Truncate(price1024).ToString());
            toolTip_price2048.SetToolTip(control: button_plus2048, Math.Truncate(price2048).ToString());
            toolTip_price4096.SetToolTip(control: button_plus4096, Math.Truncate(price4096).ToString());
            toolTip_price8192.SetToolTip(control: button_plus8192, Math.Truncate(price8192).ToString());
            toolTip_price_win.SetToolTip(control: button_win, Math.Truncate(price_win).ToString());
        }
        private void button_multi_one_Click(object sender, EventArgs e)
        {
            //This check is for if the button is "max level" and if it is, it disables the button.
            if (ClickPlus2 == 512)
            {
                button_plus2.Enabled = false;
            }
            else
            {
                //This checks if your money is more than or equal to the price of the button, which is the price2 double variable.
                if (dosh == price2 || dosh >= price2)
                {
                    //If it is equal to or greater than price2 it will subtract price2 + however much you get per click currently.
                    //If you don't subract the added money per click, it will add it back.
                    //I need price2 to be a whole number so truncating it is the solution.
                    if (ClickPlus2 == 0)
                    {
                        dosh -= Math.Truncate(price2) + 1;
                    }
                    else
                    {
                        if (ClickPlus4 == 0)
                        {
                            dosh -= Math.Truncate(price2) + 1 + (ClickPlus2 * 2);
                        }
                        else
                        {
                            if (ClickPlus8 == 0)
                            {
                                dosh -= Math.Truncate(price2) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4);
                            }
                            else
                            {
                                if (ClickPlus16 == 0)
                                {
                                    dosh -= Math.Truncate(price2) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8);
                                }
                                else
                                {
                                    if (ClickPlus32 == 0)
                                    {
                                        dosh -= Math.Truncate(price2) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16);
                                    }
                                    else
                                    {
                                        if (ClickPlus64 == 0)
                                        {
                                            dosh -= Math.Truncate(price2) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32);
                                        }
                                        else
                                        {
                                            if (ClickPlus128 == 0)
                                            {
                                                dosh -= Math.Truncate(price2) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64);
                                            }
                                            else
                                            {
                                                if (ClickPlus256 == 0)
                                                {
                                                    dosh -= Math.Truncate(price2) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128);
                                                }
                                                else
                                                {
                                                    if (ClickPlus512 == 0)
                                                    {
                                                        dosh -= Math.Truncate(price2) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256);
                                                    }
                                                    else
                                                    {
                                                        if (ClickPlus1024 == 0)
                                                        {
                                                            dosh -= Math.Truncate(price2) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512);
                                                        }
                                                        else
                                                        {
                                                            if (ClickPlus2048 == 0)
                                                            {
                                                                dosh -= Math.Truncate(price2) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024);
                                                            }
                                                            else
                                                            {
                                                                if (ClickPlus4096 == 0)
                                                                {
                                                                    dosh -= Math.Truncate(price2) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048);
                                                                }
                                                                else
                                                                {
                                                                    if (ClickPlus8192 == 0)
                                                                    {
                                                                        dosh -= Math.Truncate(price2) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048) + (ClickPlus4096 * 4096);;
                                                                    }
                                                                    else
                                                                    {
                                                                        dosh -= Math.Truncate(price2) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048) + (ClickPlus4096 * 4096) + (ClickPlus8192 * 8192);
                                                                    };
                                                                };
                                                            };
                                                        };
                                                    };
                                                };
                                            };
                                        };
                                    };
                                };
                            };
                        };
                    };
                    ClickPlus2 += 1;
                    price2 = ((double)(price2 * 1.05));
                    if (button_plus4.Enabled == false)
                    {
                        button_plus4.Enabled = true;
                    };
                    textBox_CashMoney.Text = dosh.ToString();
                    toolTip_price2.SetToolTip(button_plus2, Math.Truncate(price2).ToString());
                };               
            };
        }
        private void button_multi_two_Click(object sender, EventArgs e)
        {
            //"Max level" check again. (You get the point, it's on every button.)
            if (ClickPlus4 == 512)
            {
                button_plus4.Enabled = false;
            }
            else
            {
                //Again, the check to see if you have enough money. (You get the point here too, it's also on every button.)
                if (dosh == price4 || dosh >= price4)
                {
                    //math to subtract the price properly, blah, blah, blah. (For a third time, you get the point, it's the same for every button)
                    if (ClickPlus2 == 0)
                    {
                        dosh -= Math.Truncate(price4) + 1;
                    }
                    else
                    {
                        if (ClickPlus4 == 0)
                        {
                            dosh -= Math.Truncate(price4) + 1 + (ClickPlus2 * 2);
                        }
                        else
                        {
                            if (ClickPlus8 == 0)
                            {
                                dosh -= Math.Truncate(price4) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4);
                            }
                            else
                            {
                                if (ClickPlus16 == 0)
                                {
                                    dosh -= Math.Truncate(price4) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8);
                                }
                                else
                                {
                                    if (ClickPlus32 == 0)
                                    {
                                        dosh -= Math.Truncate(price4) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16);
                                    }
                                    else
                                    {
                                        if (ClickPlus64 == 0)
                                        {
                                            dosh -= Math.Truncate(price4) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32);
                                        }
                                        else
                                        {
                                            if (ClickPlus128 == 0)
                                            {
                                                dosh -= Math.Truncate(price4) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64);
                                            }
                                            else
                                            {
                                                if (ClickPlus256 == 0)
                                                {
                                                    dosh -= Math.Truncate(price4) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128);
                                                }
                                                else
                                                {
                                                    if (ClickPlus512 == 0)
                                                    {
                                                        dosh -= Math.Truncate(price4) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256);
                                                    }
                                                    else
                                                    {
                                                        if (ClickPlus1024 == 0)
                                                        {
                                                            dosh -= Math.Truncate(price4) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512);
                                                        }
                                                        else
                                                        {
                                                            if (ClickPlus2048 == 0)
                                                            {
                                                                dosh -= Math.Truncate(price4) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024);
                                                            }
                                                            else
                                                            {
                                                                if (ClickPlus4096 == 0)
                                                                {
                                                                    dosh -= Math.Truncate(price4) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048);
                                                                }
                                                                else
                                                                {
                                                                    if (ClickPlus8192 == 0)
                                                                    {
                                                                        dosh -= Math.Truncate(price4) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048) + (ClickPlus4096 * 4096);
                                                                    }
                                                                    else
                                                                    {
                                                                        dosh -= Math.Truncate(price4) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048) + (ClickPlus4096 * 4096) + (ClickPlus8192 * 8192);
                                                                    };
                                                                };
                                                            };
                                                        };
                                                    };
                                                };
                                            };
                                        };
                                    };
                                };
                            };
                        };
                    };
                    ClickPlus4 += 1;
                    price4 = ((double)(price4 * 1.05));
                    if (button_plus8.Enabled == false)
                    {
                        button_plus8.Enabled = true;
                    };
                    textBox_CashMoney.Text = dosh.ToString();
                    toolTip_price4.SetToolTip(button_plus4, Math.Truncate(price4).ToString());
                };
            };
        }
        private void button_multi_three_Click(object sender, EventArgs e)
        {
            if (ClickPlus8 == 512)
            {
                button_plus8.Enabled = false;
            }
            else
            {
                if (dosh == price8 || dosh >= price8)
                {
                    if (ClickPlus2 == 0)
                    {
                        dosh -= Math.Truncate(price8) + 1;
                    }
                    else
                    {
                        if (ClickPlus4 == 0)
                        {
                            dosh -= Math.Truncate(price8) + 1 + (ClickPlus2 * 2);
                        }
                        else
                        {
                            if (ClickPlus8 == 0)
                            {
                                dosh -= Math.Truncate(price8) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4);
                            }
                            else
                            {
                                if (ClickPlus16 == 0)
                                {
                                    dosh -= Math.Truncate(price8) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8);
                                }
                                else
                                {
                                    if (ClickPlus32 == 0)
                                    {
                                        dosh -= Math.Truncate(price8) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16);
                                    }
                                    else
                                    {
                                        if (ClickPlus64 == 0)
                                        {
                                            dosh -= Math.Truncate(price8) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32);
                                        }
                                        else
                                        {
                                            if (ClickPlus128 == 0)
                                            {
                                                dosh -= Math.Truncate(price8) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64);
                                            }
                                            else
                                            {
                                                if (ClickPlus256 == 0)
                                                {
                                                    dosh -= Math.Truncate(price8) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128);
                                                }
                                                else
                                                {
                                                    if (ClickPlus512 == 0)
                                                    {
                                                        dosh -= Math.Truncate(price8) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256);
                                                    }
                                                    else
                                                    {
                                                        if (ClickPlus1024 == 0)
                                                        {
                                                            dosh -= Math.Truncate(price8) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512);
                                                        }
                                                        else
                                                        {
                                                            if (ClickPlus2048 == 0)
                                                            {
                                                                dosh -= Math.Truncate(price8) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024);
                                                            }
                                                            else
                                                            {
                                                                if (ClickPlus4096 == 0)
                                                                {
                                                                    dosh -= Math.Truncate(price8) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048);
                                                                }
                                                                else
                                                                {
                                                                    if (ClickPlus8192 == 0)
                                                                    {
                                                                        dosh -= Math.Truncate(price8) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048) + (ClickPlus4096 * 4096);
                                                                    }
                                                                    else
                                                                    {
                                                                        dosh -= Math.Truncate(price8) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048) + (ClickPlus4096 * 4096) + (ClickPlus8192 * 8192);
                                                                    };
                                                                };
                                                            };
                                                        };
                                                    };
                                                };
                                            };
                                        };
                                    };
                                };
                            };
                        };
                    };
                    ClickPlus8 += 1;
                    price8 = ((double)(price8 * 1.05));
                    if (button_plus16.Enabled == false)
                    {
                        button_plus16.Enabled = true;
                    };
                    textBox_CashMoney.Text = dosh.ToString();
                    toolTip_price8.SetToolTip(button_plus8, Math.Truncate(price8).ToString());
                };
            };
        }
        private void button_multi_four_Click(object sender, EventArgs e)
        {
            if (ClickPlus16 == 512)
            {
                button_plus16.Enabled = false;
            }
            else
            {
                if (dosh == price16 || dosh >= price16)
                {
                    if (ClickPlus2 == 0)
                    {
                        dosh -= Math.Truncate(price16) + 1;
                    }
                    else
                    {
                        if (ClickPlus4 == 0)
                        {
                            dosh -= Math.Truncate(price16) + 1 + (ClickPlus2 * 2);
                        }
                        else
                        {
                            if (ClickPlus8 == 0)
                            {
                                dosh -= Math.Truncate(price16) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4);
                            }
                            else
                            {
                                if (ClickPlus16 == 0)
                                {
                                    dosh -= Math.Truncate(price16) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8);
                                }
                                else
                                {
                                    if (ClickPlus32 == 0)
                                    {
                                        dosh -= Math.Truncate(price16) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16);
                                    }
                                    else
                                    {
                                        if (ClickPlus64 == 0)
                                        {
                                            dosh -= Math.Truncate(price16) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32);
                                        }
                                        else
                                        {
                                            if (ClickPlus128 == 0)
                                            {
                                                dosh -= Math.Truncate(price16) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64);
                                            }
                                            else
                                            {
                                                if (ClickPlus256 == 0)
                                                {
                                                    dosh -= Math.Truncate(price16) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128);
                                                }
                                                else
                                                {
                                                    if (ClickPlus512 == 0)
                                                    {
                                                        dosh -= Math.Truncate(price16) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256);
                                                    }
                                                    else
                                                    {
                                                        if (ClickPlus1024 == 0)
                                                        {
                                                            dosh -= Math.Truncate(price16) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512);
                                                        }
                                                        else
                                                        {
                                                            if (ClickPlus2048 == 0)
                                                            {
                                                                dosh -= Math.Truncate(price16) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024);
                                                            }
                                                            else
                                                            {
                                                                if (ClickPlus4096 == 0)
                                                                {
                                                                    dosh -= Math.Truncate(price16) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048);
                                                                }
                                                                else
                                                                {
                                                                    if (ClickPlus8192 == 0)
                                                                    {
                                                                        dosh -= Math.Truncate(price16) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048) + (ClickPlus4096 * 4096);
                                                                    }
                                                                    else
                                                                    {
                                                                        dosh -= Math.Truncate(price16) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048) + (ClickPlus4096 * 4096) + (ClickPlus8192 * 8192);
                                                                    };
                                                                };
                                                            };
                                                        };
                                                    };
                                                };
                                            };
                                        };
                                    };
                                };
                            };
                        };
                    };
                    ClickPlus16 += 1;
                    price16 = ((double)(price16 * 1.05));
                    if (button_plus32.Enabled == false)
                    {
                        button_plus32.Enabled = true;
                    };
                    textBox_CashMoney.Text = dosh.ToString();
                    toolTip_price16.SetToolTip(button_plus16, Math.Truncate(price16).ToString());
                };
            };
        }
        private void button_multi_five_Click(object sender, EventArgs e)
        {
            if (ClickPlus32 == 512)
            {
                button_plus32.Enabled = false;
            }
            else
            {
                if (dosh == price32 || dosh >= price32)
                {
                    if (ClickPlus32 == 0)
                    {
                        dosh -= Math.Truncate(price32) + 1;
                    }
                    else
                    {
                        if (ClickPlus4 == 0)
                        {
                            dosh -= Math.Truncate(price32) + 1 + (ClickPlus2 * 2); 
                        }
                        else
                        {
                            if (ClickPlus8 == 0)
                            {
                                dosh -= Math.Truncate(price32) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4);
                            }
                            else
                            {
                                if (ClickPlus16 == 0)
                                {
                                    dosh -= Math.Truncate(price32) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8);
                                }
                                else
                                {
                                    if (ClickPlus32 == 0)
                                    {
                                        dosh -= Math.Truncate(price32) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16);
                                    }
                                    else
                                    {
                                        if (ClickPlus64 == 0)
                                        {
                                            dosh -= Math.Truncate(price32) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32);
                                        }
                                        else
                                        {
                                            if (ClickPlus128 == 0)
                                            {
                                                dosh -= Math.Truncate(price32) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64);
                                            }
                                            else
                                            {
                                                if (ClickPlus256 == 0)
                                                {
                                                    dosh -= Math.Truncate(price32) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128);
                                                }
                                                else
                                                {
                                                    if (ClickPlus512 == 0)
                                                    {
                                                        dosh -= Math.Truncate(price32) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256);
                                                    }
                                                    else
                                                    {
                                                        if (ClickPlus1024 == 0)
                                                        {
                                                            dosh -= Math.Truncate(price32) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512);
                                                        }
                                                        else
                                                        {
                                                            if (ClickPlus2048 == 0)
                                                            {
                                                                dosh -= Math.Truncate(price32) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024);
                                                            }
                                                            else
                                                            {
                                                                if (ClickPlus4096 == 0)
                                                                {
                                                                    dosh -= Math.Truncate(price32) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048);
                                                                }
                                                                else
                                                                {
                                                                    if (ClickPlus8192 == 0)
                                                                    {
                                                                        dosh -= Math.Truncate(price32) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048) + (ClickPlus4096 * 4096);
                                                                    }
                                                                    else
                                                                    {
                                                                        dosh -= Math.Truncate(price32) + 1 + (ClickPlus2 * 2) + (ClickPlus4 * 4) + (ClickPlus8 * 8) + (ClickPlus16 * 16) + (ClickPlus32 * 32) + (ClickPlus64 * 64) + (ClickPlus128 * 128) + (ClickPlus256 * 256) + (ClickPlus512 * 512) + (ClickPlus1024 * 1024) + (ClickPlus2048 * 2048) + (ClickPlus4096 * 4096) + (ClickPlus8192 * 8192);
                                                                    };
                                                                };
                                                            };
                                                        };
                                                    };
                                                };
                                            };
                                        };
                                    };
                                };
                            };
                        };
                    };
                    ClickPlus32 += 1;
                    price32 = ((double)(price32 * 1.05));
                    progressBar_Rebirth.PerformStep();
                    //These are just check to see if they are visible or not and if they aren't then make them visible.
                    if (button_Rebirth.Visible == false)
                    {
                        button_Rebirth.Visible = true;
                    };
                    if (progressBar_Rebirth.Visible == false)
                    {
                        progressBar_Rebirth.Visible = true;
                    };
                    if (textBox_awaited_coins.Visible == false)
                    {
                        textBox_awaited_coins.Visible = true;
                    };
                    //Checks if the progress bar is at it's max and resets it and doubles the max value if it is at max.
                    //Also adds an awaited prestige coin for when you rebirth and updates the textbox to show how many prestiege coins you have waiting.
                    //Enables the button to allow you to prestiege so you don't prestiege with no coins awaited.
                    if (progressBar_Rebirth.Value == progressBar_Rebirth.Maximum)
                    {
                        progressBar_Rebirth.Value = 0;
                        progressBar_Rebirth.Maximum = progressBar_Rebirth.Maximum * 2;
                        if (super_coins == 0)
                        {
                            awaited_coins += 1;
                        }
                        else
                        {
                            if (wins == 0)
                            {
                                awaited_coins += (short)(1 * (super_coins * 1.35));
                            }
                            else
                            {
                                awaited_coins += (short)(1 * (super_coins * 1.35) * (wins * 4));
                            };
                        };
                        textBox_awaited_coins.Text = awaited_coins.ToString();
                        if (button_Rebirth.Enabled == false)
                        {
                            button_Rebirth.Enabled = true;
                        };
                    };
                    textBox_CashMoney.Text = dosh.ToString();
                    toolTip_price32.SetToolTip(button_plus32, Math.Truncate(price32).ToString());
                };
            };
        }

        private void button_Rebirth_Click(object sender, EventArgs e)
        {
            //Resets everything and adds the awaited coins to the prestige coins and updates text boxes.
            prestige_coins += awaited_coins;
            awaited_coins = 0;
            dosh = 0;
            price2 = 100;
            price4 = 10000;
            price8 = 100000;
            price16 = 500000;
            price32 = 2500000;
            price64 = 2;
            price128 = 8;
            price256 = 16;
            price512 = 64;
            price1024 = 128;
            price2048 = 2;
            price4096 = 8;
            price8192 = 32;
            ClickPlus2 = 0;
            ClickPlus4 = 0;
            ClickPlus8 = 0;
            ClickPlus16 = 0;
            ClickPlus32 = 0;
            ClickPlus64 = 0;
            ClickPlus128 = 0;
            ClickPlus256 = 0;
            ClickPlus512 = 0;
            ClickPlus1024 = 0;
            ClickPlus2048 = 0;
            ClickPlus4096 = 0;
            ClickPlus8192 = 0;
            progressBar_Rebirth.Value = 0;
            progressBar_Rebirth.Maximum = 2;
            button_Rebirth.Enabled = false;
            button_Rebirth.Visible = false;
            progressBar_Rebirth.Visible = false;
            textBox_awaited_coins.Visible = false;
            textBox_prestige_coins.Visible = true;
            textBox_CashMoney.Text = dosh.ToString();
            textBox_prestige_coins.Text = prestige_coins.ToString();
            toolTip_price2.SetToolTip(control: button_plus2, Math.Truncate(price2).ToString());
            toolTip_price4.SetToolTip(control: button_plus4, Math.Truncate(price4).ToString());
            toolTip_price8.SetToolTip(control: button_plus8, Math.Truncate(price8).ToString());
            toolTip_price16.SetToolTip(control: button_plus16, Math.Truncate(price16).ToString());
            toolTip_price32.SetToolTip(control: button_plus32, Math.Truncate(price32).ToString());
            toolTip_price64.SetToolTip(control: button_plus64, Math.Truncate(price64).ToString());
            toolTip_price128.SetToolTip(control: button_plus128, Math.Truncate(price128).ToString());
            toolTip_price256.SetToolTip(control: button_plus256, Math.Truncate(price256).ToString());
            toolTip_price512.SetToolTip(control: button_plus512, Math.Truncate(price512).ToString());
            toolTip_price1024.SetToolTip(control: button_plus1024, Math.Truncate(price1024).ToString());
            toolTip_price2048.SetToolTip(control: button_plus2048, Math.Truncate(price2048).ToString());
            toolTip_price4096.SetToolTip(control: button_plus4096, Math.Truncate(price4096).ToString());
            toolTip_price8192.SetToolTip(control: button_plus8192, Math.Truncate(price8192).ToString());
            toolTip_price_win.SetToolTip(control: button_win, Math.Truncate(price_win).ToString());
            label3.Visible = true;
            button_plus64.Visible = true;
            button_plus64.Enabled = true;
            button_plus128.Visible = true;
            button_plus256.Visible = true;
            button_plus512.Visible = true;
            button_plus1024.Visible = true;
        }

        private void button_plus64_Click(object sender, EventArgs e)
        {
            if(prestige_coins == price64 || prestige_coins >= price64)
            {
                if (ClickPlus64 == 512)
                {
                    button_plus64.Enabled = false;
                }
                else
                {
                    prestige_coins -= (int)price64;
                    price64 = ((int)(price64 * 1.25));
                    ClickPlus64 += 1;
                    textBox_prestige_coins.Text = prestige_coins.ToString();
                };
            };
        }

        private void button_plus128_Click(object sender, EventArgs e)
        {
            if (ClickPlus128 == 512)
            {
                button_plus128.Enabled = false;
            }
            else
            {
                if (prestige_coins == price128 || prestige_coins >= price128)
                {
                    prestige_coins -= (int)price128;
                    price128 = ((int)(price128 * 1.25));
                    ClickPlus128 += 1;
                    textBox_prestige_coins.Text = prestige_coins.ToString();
                };
            };            
        }

        private void button_plus256_Click(object sender, EventArgs e)
        {
            if (ClickPlus256 == 512)
            {
                button_plus256.Enabled = false;
            }
            else
            {
                if (prestige_coins == price256 || prestige_coins >= price256)
                {    
                    prestige_coins -= (int)price256;
                    price256 = ((int)(price256 * 1.25));
                    ClickPlus256 += 1;
                    textBox_prestige_coins.Text = prestige_coins.ToString();
                };
            };
        }

        private void button_plus512_Click(object sender, EventArgs e)
        {
            if (ClickPlus512 == 512)
            {
                button_plus512.Enabled = false;
            }
            else
            {
                if (prestige_coins == price512 || prestige_coins >= price512)
                {    
                    prestige_coins -= (int)price512;
                    price512 = ((int)(price512 * 1.25));
                    ClickPlus512 += 1;
                    textBox_prestige_coins.Text = prestige_coins.ToString();
                };
            };
        }

        private void button_plus1024_Click(object sender, EventArgs e)
        {
            if (ClickPlus1024 == 512)
            {
                button_plus1024.Enabled = false;
            }
            else
            {
                if (prestige_coins == price1024 || prestige_coins >= price1024)
                {
                    prestige_coins -= (int)price1024;
                    price1024 = ((int)(price1024 * 1.25));
                    ClickPlus1024 += 1;
                    textBox_prestige_coins.Text = prestige_coins.ToString();
                    progressBar_Super_Rebirth.PerformStep();
                    if (button_Super_Rebirth.Visible == false)
                    {
                        button_Super_Rebirth.Visible = true;
                    };
                    if (progressBar_Super_Rebirth.Visible == false)
                    {
                        progressBar_Super_Rebirth.Visible = true;
                    };
                    if (textBox_awaited_super_coins.Visible == false)
                    {
                        textBox_awaited_super_coins.Visible = true;
                    };
                    if (progressBar_Super_Rebirth.Value == progressBar_Super_Rebirth.Maximum)
                    {
                        progressBar_Super_Rebirth.Value = 1;
                        progressBar_Super_Rebirth.Maximum = (progressBar_Super_Rebirth.Maximum * 2);
                        if (wins == 0)
                        {
                            awaited_super_coins += 1;
                        }
                        else
                        {
                            awaited_super_coins += (short)(1 * (wins * 4));
                        }
                        textBox_awaited_super_coins.Text = awaited_super_coins.ToString();
                        if (button_Super_Rebirth.Enabled == false)
                        {
                            button_Super_Rebirth.Enabled = true;
                        };
                    };
                };
            };
        }

        private void button_Super_Rebirth_Click(object sender, EventArgs e)
        {
            super_coins -= awaited_super_coins;
            awaited_super_coins = 0;
            dosh = 0;
            price2 = 100;
            price4 = 10000;
            price8 = 100000;
            price16 = 500000;
            price32 = 2500000;
            price64 = 2;
            price128 = 8;
            price256 = 16;
            price512 = 64;
            price1024 = 128;
            price2048 = 2;
            price4096 = 8;
            price8192 = 32;
            ClickPlus2 = 0;
            ClickPlus4 = 0;
            ClickPlus8 = 0;
            ClickPlus16 = 0;
            ClickPlus32 = 0;
            ClickPlus64 = 0;
            ClickPlus128 = 0;
            ClickPlus256 = 0;
            ClickPlus512 = 0;
            ClickPlus1024 = 0;
            ClickPlus2048 = 0;
            ClickPlus4096 = 0;
            ClickPlus8192 = 0;
            progressBar_Rebirth.Value = 0;
            progressBar_Rebirth.Maximum = 2;
            button_Rebirth.Enabled = false;
            button_Rebirth.Visible = false;
            progressBar_Rebirth.Visible = false;
            textBox_awaited_coins.Visible = false;
            textBox_prestige_coins.Visible = true;
            button_Super_Rebirth.Enabled = false;
            button_Super_Rebirth.Visible = false;
            progressBar_Super_Rebirth.Visible = false;
            button_Spacer.Visible = true;
            textBox_awaited_super_coins.Visible = false;
            textBox_super_coins.Visible = true;
            textBox_CashMoney.Text = dosh.ToString();
            textBox_prestige_coins.Text = prestige_coins.ToString();
            textBox_super_coins.Text = super_coins.ToString();
            toolTip_price2.SetToolTip(control: button_plus2, Math.Truncate(price2).ToString());
            toolTip_price4.SetToolTip(control: button_plus4, Math.Truncate(price4).ToString());
            toolTip_price8.SetToolTip(control: button_plus8, Math.Truncate(price8).ToString());
            toolTip_price16.SetToolTip(control: button_plus16, Math.Truncate(price16).ToString());
            toolTip_price32.SetToolTip(control: button_plus32, Math.Truncate(price32).ToString());
            toolTip_price64.SetToolTip(control: button_plus64, Math.Truncate(price64).ToString());
            toolTip_price128.SetToolTip(control: button_plus128, Math.Truncate(price128).ToString());
            toolTip_price256.SetToolTip(control: button_plus256, Math.Truncate(price256).ToString());
            toolTip_price512.SetToolTip(control: button_plus512, Math.Truncate(price512).ToString());
            toolTip_price1024.SetToolTip(control: button_plus1024, Math.Truncate(price1024).ToString());
            toolTip_price2048.SetToolTip(control: button_plus2048, Math.Truncate(price2048).ToString());
            toolTip_price4096.SetToolTip(control: button_plus4096, Math.Truncate(price4096).ToString());
            toolTip_price8192.SetToolTip(control: button_plus8192, Math.Truncate(price8192).ToString());
            toolTip_price_win.SetToolTip(control: button_win, Math.Truncate(price_win).ToString()); 
            button_plus2048.Visible = true;
            button_plus2048.Enabled = true;
            button_plus4096.Visible = true;
            button_plus8192.Visible = true;
        }

        private void button_plus2048_Click(object sender, EventArgs e)
        {
            if (super_coins == price2048 || super_coins >= price2048)
            {
                if (ClickPlus2048 == 512)
                {
                    button_plus2048.Enabled = false;
                }
                else
                {
                    super_coins -= (int)price2048;
                    price2048 = ((int)(price2048 * 1.25));
                    ClickPlus2048 += 1;
                };
            };
        }

        private void button_plus4096_Click(object sender, EventArgs e)
        {
            if (super_coins == price4096 || super_coins >= price4096)
            {
                if (ClickPlus4096 == 512)
                {
                    button_plus4096.Enabled = false;
                }
                else
                {
                    super_coins -= (int)price4096;
                    price4096 = ((int)(price4096 * 1.25));
                    ClickPlus4096 += 1;
                };
            };
        }

        private void button_plus8192_Click(object sender, EventArgs e)
        {
            if (super_coins == price8192 || super_coins >= price8192)
            {
                if (ClickPlus8192 == 512)
                {
                    button_plus8192.Enabled = false;
                }
                else
                {
                    super_coins -= (int)price8192;
                    price8192 = ((int)(price8192 * 1.25));
                    ClickPlus8192 += 1;
                };
            };
        }

        private void button_win_Click(object sender, EventArgs e)
        {
            wins += 1;
            dosh = 0;
            price2 = 100;
            price4 = 10000;
            price8 = 100000;
            price16 = 500000;
            price32 = 2500000;
            price64 = 2;
            price128 = 8;
            price256 = 16;
            price512 = 64;
            price1024 = 128;
            price2048 = 2;
            price4096 = 8;
            price8192 = 32;
            ClickPlus2 = 0;
            ClickPlus4 = 0;
            ClickPlus8 = 0;
            ClickPlus16 = 0;
            ClickPlus32 = 0;
            ClickPlus64 = 0;
            ClickPlus128 = 0;
            ClickPlus256 = 0;
            ClickPlus512 = 0;
            ClickPlus1024 = 0;
            ClickPlus2048 = 0;
            ClickPlus4096 = 0;
            ClickPlus8192 = 0;
            prestige_coins = 0;
            super_coins = 0;
            progressBar_Rebirth.Value = 0;
            progressBar_Rebirth.Maximum = 2;
            button_Rebirth.Enabled = false;
            button_Rebirth.Visible = false;
            progressBar_Rebirth.Visible = false;
            textBox_awaited_coins.Visible = false;
            textBox_prestige_coins.Visible = false;
            button_Super_Rebirth.Enabled = false;
            button_Super_Rebirth.Visible = false;
            progressBar_Super_Rebirth.Visible = false;
            textBox_awaited_super_coins.Visible = false;
            textBox_super_coins.Visible = false;
            textBox_CashMoney.Text = dosh.ToString();
            toolTip_price2.SetToolTip(control: button_plus2, Math.Truncate(price2).ToString());
            toolTip_price4.SetToolTip(control: button_plus4, Math.Truncate(price4).ToString());
            toolTip_price8.SetToolTip(control: button_plus8, Math.Truncate(price8).ToString());
            toolTip_price16.SetToolTip(control: button_plus16, Math.Truncate(price16).ToString());
            toolTip_price32.SetToolTip(control: button_plus32, Math.Truncate(price32).ToString());
            toolTip_price64.SetToolTip(control: button_plus64, Math.Truncate(price64).ToString());
            toolTip_price128.SetToolTip(control: button_plus128, Math.Truncate(price128).ToString());
            toolTip_price256.SetToolTip(control: button_plus256, Math.Truncate(price256).ToString());
            toolTip_price512.SetToolTip(control: button_plus512, Math.Truncate(price512).ToString());
            toolTip_price1024.SetToolTip(control: button_plus1024, Math.Truncate(price1024).ToString());
            toolTip_price2048.SetToolTip(control: button_plus2048, Math.Truncate(price2048).ToString());
            toolTip_price4096.SetToolTip(control: button_plus4096, Math.Truncate(price4096).ToString());
            toolTip_price8192.SetToolTip(control: button_plus8192, Math.Truncate(price8192).ToString());
            toolTip_price_win.SetToolTip(control: button_win, Math.Truncate(price_win).ToString());
            label3.Visible = false;
            button_plus4.Enabled = false;
            button_plus8.Enabled = false;
            button_plus16.Enabled = false;
            button_plus32.Enabled = false;
            button_plus64.Visible = false;
            button_plus64.Enabled = false;
            button_plus128.Visible = false;
            button_plus256.Visible = false;
            button_plus512.Visible = false;
            button_plus1024.Visible = false;
            button_plus2048.Visible = false;
            button_plus2048.Enabled = false;
            button_plus4096.Visible = false;
            button_plus8192.Visible = false;
            this.BackgroundImage = Properties.Resources.diamond1;
        }
    }
}