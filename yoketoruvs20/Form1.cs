﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace yoketoruvs20
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;
        const int TimeMax = 100;
        const int TimeStart = 5;

        const string PlayerText = "(・ω・)";
        const string EnemyText = "◆";
        const string ItemText = "★";

        static Random rand = new Random();
        
        enum State
        {
            None = -1,  // 無効
            Title,      // タイトル
            Game,       // ゲーム
            Gameover,   // ゲームオーバー
            Clear       // クリア
        }
        State currentState = State.None;
        State nextState = State.Title;

        const int SpeedMax = 20;
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        int ItemCount = ItemMax;
        int Time = TimeMax;
        int Hiscore = 0;

        public Form1()
        {
            InitializeComponent();

            for(int i = 0; i < ChrMax; i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if(i == PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if (i < ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                chrs[i].Font = tempLabel.Font;
                Controls.Add(chrs[i]);

                chrs[i].Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState != State.None)
            {
                initProc();
            }

            /*if (isDebug)
            {
                if(GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                if(GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }
            }*/

            if(currentState == State.Game)
            {
                UpdateGame();
            }
        }

        void UpdateGame()
        {
            Point mp = PointToClient(MousePosition);

            chrs[PlayerIndex].Left = mp.X - chrs[PlayerIndex].Width / 2;
            chrs[PlayerIndex].Top = mp.Y - chrs[PlayerIndex].Height / 2;

            Time--;
            timeLabel.Text = "TIME " + Time;
            if(Time <= 0)
            {
                nextState = State.Gameover;
            }

            for(int i = EnemyIndex; i < ChrMax; i++)
            {
                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];

                if (chrs[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (chrs[i].Right > ClientSize.Width )
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (chrs[i].Bottom > ClientSize.Height )
                {
                    vy[i] = -Math.Abs(vy[i]);
                }

                //当たり判定
                if ((mp.X>= chrs[i].Left)&&
                    (mp.X< chrs[i].Right)&&
                    (mp.Y>=chrs[i].Top)&&
                    (mp.Y<chrs[i].Bottom))
                {
                    //if(chrs[i].text == EnemyText)
                    if (i<ItemIndex)
                    {
                        if(Time <= TimeMax - TimeStart)
                        {
                            nextState = State.Gameover;
                        }
                    }
                    else
                    {
                        if (chrs[i].Visible)
                        {
                            //アイテム処理
                            ItemCount = ItemCount - 1;
                            leftLabel.Text = "★:" + ItemCount;
                        }

                        chrs[i].Visible = false;

                        if (ItemCount <= 0)
                        {
                            nextState = State.Clear;
                        }
                    }
                }         
            }
        }

        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch (currentState)
            {
                case State.Title:
                    titleLabel.Visible = true;
                    startbutton.Visible = true;
                    copyLabel.Visible = true;
                    hiLabel.Visible = true;
                    gameOverLabel.Visible = false;
                    TitleButton.Visible = false;
                    clearLabel.Visible = false;
                    hiLabel.Text = "ハイスコア " + Hiscore;
                    break;

                case State.Game:
                    titleLabel.Visible = false;
                    startbutton.Visible = false;
                    copyLabel.Visible = false;
                    hiLabel.Visible = false;
                    Time = TimeMax;

                    chrs[PlayerIndex].Visible = true;
                    for(int i = EnemyIndex; i < ChrMax; i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);

                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);

                        chrs[i].Visible = true;
                        ItemCount = ItemMax;
                        leftLabel.Text = "★:" + ItemCount;
                    }
                    break;

                case State.Gameover:
                    gameOverLabel.Visible = true;
                    TitleButton.Visible = true;
                    break;

                case State.Clear:
                    clearLabel.Visible = true;
                    TitleButton.Visible = true;
                    hiLabel.Visible = true;

                    if(Hiscore <= Time)
                    {
                        Hiscore = Time;
                    }
                    hiLabel.Text = "ハイスコア " + Hiscore;
                    break;
            }
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void TitleButton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
