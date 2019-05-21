using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathPractice
{
    public partial class Form1 : Form
    {
        private int cal1 = 0;
        private int cal2 = 0;
        private int result = 0;
        private int currentCnt = 0;
        private int rightCnt = 0;
        private int curTime = 0;
        private bool isOverTime = false;
        private bool isStartCal = false;
        private List<string> tickList = new List<string>();

        private const string TITLE = "丁逸澄的数学题";
        private const string MARK_RIGHT = "√";
        private const string MARK_WRONG = "×";
        private const int TOTAL_TICK_CNT = 20;
        private const int ANSER_TIME = 60;
        private const string TICK_FORMAT1 = "{0}{1}{2}={3}";
        private const string TICK_FORMAT2 = "{0} {1}    ";

        private Timer anserTimer = new Timer();
        private Timer waitTimer = new Timer();
        private MathHelper helper = new MathHelper();

        public Form1()
        {
            InitializeComponent();

            this.Text = TITLE;

            this.Init();
            this.InitTimer();
            this.GenerateTicks();
        }

        private void InitTimer()
        {
            this.anserTimer.Dispose();
            this.anserTimer = new Timer();
            this.anserTimer.Interval = 1000;
            this.anserTimer.Tick += CaculateTimer_Tick;

            this.waitTimer.Dispose();
            this.waitTimer = new Timer();
            this.waitTimer.Interval = 1000;
            this.waitTimer.Tick += WaitTimer_Tick;
        }

        private void Init()
        {
            this.lblPlus1.Text = string.Empty;
            this.lblPlus2.Text = string.Empty;
            this.tbxResult.Text = string.Empty;
            this.lblNote.Text = string.Empty;
            this.lblMark.Text = string.Empty;
            this.lblTime.Text = string.Empty;
            this.lblTicks.Text = string.Empty;
            this.button1.Visible = false;
            this.isOverTime = false;
            cal1 = 0;
            cal2 = 0;
            result = 0;
            curTime = 0;
        }
        private void Reset()
        {
            currentCnt = 0;
            rightCnt = 0;
            tickList.Clear();
        }

        private void GenerateTicks()
        {
            string calType = string.Empty;
            helper.GenerateCaculation(out cal1, out cal2, out calType, out result);
            this.lblCalType.Text = calType;
            this.lblPlus1.Text = cal1.ToString().PadLeft(2, ' ');
            this.lblPlus2.Text = cal2.ToString().PadRight(2, ' ');
            this.tbxResult.Enabled = true;
            this.tbxResult.Focus();
            this.currentCnt++;
            this.lblTime.Text = ANSER_TIME.ToString();
            this.anserTimer.Start();
            isStartCal = true;
        }

        private void CaculateTimer_Tick(object sender, EventArgs e)
        {
            curTime++;
            int restTime = ANSER_TIME - curTime;
            if (restTime >= 1)
            {
                this.lblTime.Text = restTime.ToString();
            }
            else
            {
                this.isOverTime = true;
                this.CheckResult();
            }
        }

        private void CheckResult()
        {
            int tmpResult = 0;
            int.TryParse(this.tbxResult.Text, out tmpResult);

            if (this.isOverTime == false
                && helper.IsNeedInputNextNum(this.result, tmpResult))
            {
                //需要继续输入
                return;
            }

            this.anserTimer.Stop();
            isStartCal = false;

            string tick = string.Format(
                TICK_FORMAT1, cal1, this.lblCalType.Text, cal2, result).PadRight(8, ' ');

            if (this.result == tmpResult)
            {
                this.lblMark.Text = MARK_RIGHT;
                tickList.Add(string.Format(TICK_FORMAT2, tick, MARK_RIGHT));
                this.lblMark.ForeColor = Color.Green;
                this.rightCnt++;
            }
            else
            {
                this.lblMark.Text = MARK_WRONG;
                tickList.Add(string.Format(TICK_FORMAT2, tick, MARK_WRONG));
                this.lblMark.ForeColor = Color.Red;
                this.lblNote.Text = string.Format("正确答案：{0}", this.result);
            }

            this.tbxResult.Enabled = false;

            if (currentCnt == TOTAL_TICK_CNT)
            {
                this.ShowResult();
            }
            else
            {
                this.waitTimer.Start();
            }
        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        {
            this.Init();
            this.GenerateTicks();
            this.waitTimer.Stop();
        }

        private void tbxResult_TextChanged(object sender, EventArgs e)
        {
            if (isStartCal == true)
            {
                this.CheckResult();
            }
        }

        private void ShowResult()
        {
            this.lblNote.Text = string.Format(
                "总共做了{0}道题，做对{1}道题，做错{2}道题！", 
                this.currentCnt,
                this.rightCnt,
                this.currentCnt - this.rightCnt);

            int tickCnt = 0;
            foreach (var item in this.tickList)
            {
                if (tickCnt > 0
                    && tickCnt % 5 == 0)
                {
                    this.lblTicks.Text += "\r\n";
                }
                this.lblTicks.Text += item;
                tickCnt++;
            }

            this.button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Init();
            this.InitTimer();
            this.Reset();
            this.GenerateTicks();
        }

        private void tbxResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            //这是允许输入退格键  
            if (e.KeyChar != '\b')
            {
                //这是允许输入0-9数字
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                {
                    e.Handled = true;
                }
            }
        }

    }
}
