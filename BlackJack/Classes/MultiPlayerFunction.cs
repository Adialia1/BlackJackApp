using System;
using System.Windows.Forms;

namespace BlackJack.Classes
{
    internal class MultiPlayerFunction
    {
        //[Both]
        public static void LoadNames()
        {
            int playersInRoom = MultiPlayerSetUp.tableSize;
            switch (playersInRoom)
            {
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        //[Both]
        public static void CreateTable()
        {
            int playersInRoom = MultiPlayerSetUp.tableSize;
            for (int i = 0; i < playersInRoom; i++)
            {
                Label sum = new Label();
                sum.AutoSize = true;
                sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                sum.ForeColor = System.Drawing.Color.White;
                sum.Location = new System.Drawing.Point(40 * (i + 1), 50 * (i + 1));
                sum.Name = $"sumPlayer{i}";
                sum.Tag = $"sumPlayer{i}";
                sum.Size = new System.Drawing.Size(29 * (i + 1), 13 * (i + 1));
                sum.Visible = true;
                Pages.MultiPlayer.Instance.Invoke(new Action(() =>
                {
                    Pages.MultiPlayer.Instance.Controls.Add(sum);
                    sum.BringToFront();
                }));
            }
        }

        /*
                     // 
            // sumPlayer0
            // 
            this.sumPlayer0.AutoSize = true;
            this.sumPlayer0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sumPlayer0.ForeColor = System.Drawing.Color.White;
            this.sumPlayer0.Location = new System.Drawing.Point(218, 396);
            this.sumPlayer0.Name = "sumPlayer0";
            this.sumPlayer0.Size = new System.Drawing.Size(29, 13);
            this.sumPlayer0.TabIndex = 97;
            this.sumPlayer0.Text = "sum";
            this.sumPlayer0.Visible = false;
            // 
            // username0
            // 
            this.username0.AutoSize = true;
            this.username0.Font = new System.Drawing.Font("Mont Heavy DEMO", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username0.ForeColor = System.Drawing.Color.White;
            this.username0.Location = new System.Drawing.Point(218, 412);
            this.username0.MaximumSize = new System.Drawing.Size(162, 37);
            this.username0.Name = "username0";
            this.username0.Size = new System.Drawing.Size(95, 37);
            this.username0.TabIndex = 96;
            this.username0.Text = "name";
            this.username0.Visible = false;
         * */
    }
}
