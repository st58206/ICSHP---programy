using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV04
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public Form1()
        {
            InitializeComponent();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameListBox.Items.Add((Keys)random.Next(65,90));
            if(gameListBox.Items.Count > 6)
            {
                gameListBox.Items.Clear();
                gameListBox.Items.Add("Game over!");
                timer1.Stop();
            }
        }

        private void gameListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameListBox.Items.Contains(e.KeyCode))
            {
                gameListBox.Items.Remove(e.KeyCode);
                gameListBox.Refresh();

                if(timer1.Interval > 400)
                {
                    timer1.Interval -= 60;
                }
                else if(timer1.Interval > 250)
                {
                    timer1.Interval -= 15;
                }
                else if(timer1.Interval > 150)
                {
                    timer1.Interval -= 8;
                }

                int obtiznost = 800 - timer1.Interval;
                if(obtiznost < 800 && obtiznost > 0)
                {
                    difficultProgressBar.Value = obtiznost;
                }

                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }
            correctLabel.Text = "Correct:" + stats.Correct;
            missedLabel.Text = "Missed:" + stats.Missed;
            accuracyLabel.Text = $"Accuracy: {stats.Accuracy}%";    
        }
    }

    public class Stats
    {
        public delegate void UpdatedStatsEventHandler(object sender, EventArgs e);

        public int Correct { get; private set; }
        public int Accuracy { get; private set; }
        public int Missed { get; private set; }

        public event UpdatedStatsEventHandler UpdatedStats;

        private void OnUpdatedStats()
        {
            UpdatedStatsEventHandler handler = UpdatedStats;
            if (handler != null)
                handler(this, new EventArgs());
        }

        public void Update(bool correctKey)
        {
            if(!correctKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }
            Accuracy = 100 * Correct / (Correct + Missed);

        }

    }
}
