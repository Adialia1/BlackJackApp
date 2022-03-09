using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlackJack.Classes
{
    internal class MultiPlayerFunction
    {
        const int SUM_Y_MINUS = 16;
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
            CreateUsernameLables(MultiPlayerSetUp.usernames);
            CreateSumLables();
        }

        //[Both]
        private static void CreateUsernameLables(string[] usernames)
        {
            int playersInRoom = MultiPlayerSetUp.tableSize;
            for (int i = 0; i < playersInRoom; i++)
            {
                Pages.MultiPlayer.Instance.Invoke(new Action(() =>
                {
                    Label userLB = new Label();
                    userLB.AutoSize = true;
                    userLB.Font = new Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                    userLB.ForeColor = Color.White;
                    userLB.Location = CheckLocation(playersInRoom, i);
                    userLB.Name = $"username{i}";
                    userLB.Tag = $"username{i}";
                    userLB.Text = $"{usernames[i]}";
                    Pages.MultiPlayer.Instance.Controls.Add(userLB);
                    userLB.BringToFront();
                }));
            }
        }
        //[Both]
        private static void CreateSumLables()
        {
            int playersInRoom = MultiPlayerSetUp.tableSize;
            for (int i = 0; i < playersInRoom; i++)
            {
                Pages.MultiPlayer.Instance.Invoke(new Action(() =>
                {
                    Label userLB = new Label();
                    userLB.AutoSize = true;
                    userLB.Font = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                    userLB.ForeColor = Color.White;
                    userLB.Location = new Point(CheckLocation(playersInRoom, i).X, CheckLocation(playersInRoom,i).Y - SUM_Y_MINUS);
                    userLB.Name = $"sum{i}";
                    userLB.Tag = $"sum{i}";
                    userLB.Text = $"Sum: ";
                    Pages.MultiPlayer.Instance.Controls.Add(userLB);
                    userLB.BringToFront();
                }));
            }
        }
        private static Point CheckLocation(int tableSize, int index)
        {
            switch(tableSize)
            {
                case 2:
                    if(index == 0)
                        return new Point(218, 412);
                    else if(index == 1)
                        return new Point(654, 412);
                    else return Point.Empty;
                case 3:
                    if (index == 0)
                        return new Point(218, 412);
                    else if (index == 1)
                        return new Point(540, 412);
                    else if (index == 2)
                        return new Point(809, 412);
                    else return Point.Empty;
                case 4:
                    if (index == 0)
                        return new Point(218, 412);
                    else if (index == 1)
                        return new Point(491, 412);
                    else if (index == 2)
                        return new Point(704, 412);
                    else if (index == 3)
                        return new Point(906, 412);
                    else return Point.Empty;
            }
            return Point.Empty;
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
