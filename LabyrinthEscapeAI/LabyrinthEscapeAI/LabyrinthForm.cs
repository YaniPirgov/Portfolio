using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabyrinthEscapeAI
{
    public partial class LabyrinthForm : Form
    {
        public LabyrinthForm()
        {
            InitializeComponent();
            graphics = labyrinthPanel.CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            jamesBond = new Agent(startCoordinates[0], startCoordinates[1]);
            gridXWidth = labyrinthPattern[0].Length;
            finalState = GetState(finishCoordinates[0], finishCoordinates[1]);
            InitializeQTable();
            episodesCountLabel.Text = episodes.ToString();
        }

        private int[][] labyrinthPattern = new int[][] { new int [] {0, 1, 1, 1, 1, 0, 1, 0, 0, 1},
                                                         new int [] {0, 0, 1, 0, 0, 0, 0, 0, 0, 1},
                                                         new int [] {0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
                                                         new int [] {1, 1, 0, 0, 0, 1, 0, 1, 1, 0},
                                                         new int [] {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                                                         new int [] {1, 0, 0, 0, 0, 0, 0, 1, 0, 1},
                                                         new int [] {1, 1, 0, 1, 0, 1, 0, 0, 0, 0},
                                                         new int [] {0, 0, 0, 1, 0, 1, 0, 1, 0, 0},
                                                         new int [] {1, 0, 1, 1, 0, 1, 0, 0, 0, 1},
                                                         new int [] {0, 0, 1, 1, 1, 1, 0, 0, 1, 1}};

        private decimal[,] Qtable = new decimal[100, 4];

        private int[] startCoordinates = new int[] { 0, 9 };
        private int[] finishCoordinates = new int[] { 5, 0 };
        private int gridXWidth;

        Graphics graphics;
        Brush redBrush = new SolidBrush(Color.Red);
        Brush greenBrush = new SolidBrush(Color.Green);
        Brush pinkBrush = new SolidBrush(Color.Pink);
        Brush grayBrush = new SolidBrush(Color.DarkGray);
        Pen pen = new Pen(Color.DarkGray);
        Agent jamesBond;
        decimal discountFactor = 0.99M;
        decimal alpha = 0.1M;
        decimal epsilon = 0.1M;
        int episodes = 0;
        private int finalState;

        public void DrawGrid()
        {
            int labyrinthWidth = labyrinthPanel.Width;
            int labyrinthHeight = labyrinthPanel.Height;

            int horizontalGridLinesCount = labyrinthPattern.Length;
            int verticalGridLinesCount = labyrinthPattern[0].Length;
            int marginBetweenHorizontalLines = (labyrinthHeight - horizontalGridLinesCount) / horizontalGridLinesCount;
            int marginBetweenVerticalLines = (labyrinthWidth - verticalGridLinesCount) / verticalGridLinesCount;

            horizontalGridLinesCount += 1;
            verticalGridLinesCount += 1;

            int currentX = 0;
            int currentY = 0;
            int lastX = labyrinthWidth - 1;
            int lastY = labyrinthHeight - 1;

            Graphics graphics = labyrinthPanel.CreateGraphics();
            Brush redBrush = new SolidBrush(Color.Red);
            Brush greenBrush = new SolidBrush(Color.Green);
            Brush pinkBrush = new SolidBrush(Color.Pink);
            Brush grayBrush = new SolidBrush(Color.DarkGray);
            Pen pen = new Pen(Color.DarkGray);

            for (int i = 0; i < horizontalGridLinesCount; i++)
            {
                graphics.DrawLine(pen, 0, currentY, lastX, currentY);
                currentX = 0;

                for (int j = 0; j < verticalGridLinesCount; j++)
                {
                    graphics.DrawLine(pen, currentX, 0, currentX, lastY);

                    if (i < labyrinthPattern.Length && j < labyrinthPattern[i].Length && labyrinthPattern[i][j] == 1)
                    {
                        graphics.FillRectangle(grayBrush, currentX + 1, currentY + 1, marginBetweenVerticalLines, marginBetweenHorizontalLines);
                    }

                    if (j == startCoordinates[0] && i == startCoordinates[1])
                    {
                        graphics.FillRectangle(greenBrush, currentX + 1, currentY + 1, marginBetweenVerticalLines, marginBetweenHorizontalLines);
                    }

                    if (j == finishCoordinates[0] && i == finishCoordinates[1])
                    {
                        graphics.FillRectangle(pinkBrush, currentX + 1, currentY + 1, marginBetweenVerticalLines, marginBetweenHorizontalLines);
                    }

                    currentX += marginBetweenVerticalLines + 1;
                }

                currentY += marginBetweenHorizontalLines + 1;
            }
        }

        public void MoveAgent(int direction)
        {
            //0 - up, 1 - down, 2 - left, 3 - right

            switch (direction)
            {
                case 0:
                    {
                        if (jamesBond.AgentPosition.Y - 1 < 0 || labyrinthPattern[jamesBond.AgentPosition.Y - 1][jamesBond.AgentPosition.X] == 1)
                        {
                            break;
                        }

                        jamesBond.AgentPosition.Y -= 1;
                        break;
                    }
                case 1:
                    {
                        if (jamesBond.AgentPosition.Y + 1 > 9 || labyrinthPattern[jamesBond.AgentPosition.Y + 1][jamesBond.AgentPosition.X] == 1)
                        {
                            break;
                        }

                        jamesBond.AgentPosition.Y += 1;
                        break;
                    }
                case 2:
                    {
                        if (jamesBond.AgentPosition.X - 1 < 0 || labyrinthPattern[jamesBond.AgentPosition.Y][jamesBond.AgentPosition.X - 1] == 1)
                        {
                            break;
                        }

                        jamesBond.AgentPosition.X -= 1;
                        break;
                    }
                case 3:
                    {
                        if (jamesBond.AgentPosition.X + 1 > 9 || labyrinthPattern[jamesBond.AgentPosition.Y][jamesBond.AgentPosition.X + 1] == 1)
                        {
                            break;
                        }

                        jamesBond.AgentPosition.X += 1;
                        break;
                    }
            }
        }

        class Agent
        {
            public Agent(int x, int y)
            {
                AgentPosition = new Position(x, y);
            }

            public Position AgentPosition { get; set; }
        }

        class Position
        {
            public Position(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }
        }

        private void labyrinthPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid();
            graphics.FillEllipse(redBrush, jamesBond.AgentPosition.X * 50 + 1, jamesBond.AgentPosition.Y * 50 + 1, 49, 49);
        }

        private void LabyrinthForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 38: MoveAgent(0); break;
                case 40: MoveAgent(1); break;
                case 37: MoveAgent(2); break;
                case 39: MoveAgent(3); break;
            }

            labyrinthPanel.Refresh();
        }

        private int GetState(int x, int y)
        {
            return y * gridXWidth + x;
        }

        private Position GetPosition(int state)
        {
            return new Position(state % gridXWidth, state / gridXWidth);
        }

        private void InitializeQTable()
        {
            int finalState = finishCoordinates[1] * gridXWidth + finishCoordinates[0];

            for (int s = 0; s < 100; s++)
            {
                for (int a = 0; a < 4; a++)
                {
                    Qtable[s, a] = 1.1M;
                }
            }

            for (int a = 0; a < 4; a++)
            {
                Qtable[finalState, a] = 0;
            }
        }

        private int SelectAction(int currentState)
        {
            Random random = new Random();
            int rand = random.Next(0, 101);

            if (rand <= 10)
            {
                return random.Next(0, 4);
            }
            else
            {
                decimal maxQ = Qtable[currentState, 0];
                int maxA = 0;

                for (int a = 1; a < 4; a++)
                {
                    if (Qtable[currentState, a] > maxQ)
                    {
                        maxQ = Qtable[currentState, a];
                        maxA = a;
                    }
                }

                return maxA;
            }
        }

        private void TakeAction(int initialState, int action)
        {
            MoveAgent(action);
            int nextState = GetState(jamesBond.AgentPosition.X, jamesBond.AgentPosition.Y);
            int reward = 0;

            if (nextState == finalState)
            {
                reward = 1;
            }

            decimal v = Qtable[nextState, 0];

            for (int a = 1; a < 4; a++)
            {
                if (Qtable[nextState, a] > v)
                {
                    v = Qtable[nextState, a];
                }
            }

            // Update QTable

            Qtable[initialState, action] = (1 - alpha) * Qtable[initialState, action] + alpha * (reward + discountFactor * v);
        }

        private void ResetBoard()
        {
            jamesBond.AgentPosition.X = startCoordinates[0];
            jamesBond.AgentPosition.Y = startCoordinates[1];

            labyrinthPanel.Refresh();
        }

        private void LabyrinthForm_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(Learn);
            t.Start();
        }

        private void Learn()
        {
            while (episodes < 20000)
            {
                Application.DoEvents();
                Thread.Sleep(100);

                int initialState = GetState(jamesBond.AgentPosition.X, jamesBond.AgentPosition.Y);
                int action = SelectAction(initialState);
                TakeAction(initialState, action);
                int nextState = GetState(jamesBond.AgentPosition.X, jamesBond.AgentPosition.Y);

                if (nextState == finalState)
                {
                    episodes++;
                    episodesCountLabel.Text = episodes.ToString();
                    ResetBoard();
                }
            }
        }
    }
}
