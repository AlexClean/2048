using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2048
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[,] btn_s = new Button[4, 4];
        Random rand = new Random();
        Button New;
        int scores = 0;
        public MainWindow()
        {
            InitializeComponent();

            SizeToContent = SizeToContent.WidthAndHeight;
            Score_txt_block.Text = "Score\n" + scores.ToString();
            High_score_txt_block.Text = "High score\n345";
            for(int i = 0; i < 4; i++)
            {
                Grid_for_buttons.ColumnDefinitions.Add(new ColumnDefinition());
                Grid_for_buttons.RowDefinitions.Add(new RowDefinition());
            }
            MinWidth = 380;
            MinHeight = 425;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Make_Buttons();
            Random_number();
            Random_number();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Button btn = sender as Button;
            if(btn!=null)
            {
                int temp = 0;
                try
                {
                    temp = int.Parse(btn.Content.ToString());
                }
                catch (Exception) { temp = 0; }
                temp++;
                btn.Content = temp.ToString();
                if(btn.Content.ToString() =="23")
                {
                    MessageBox.Show("Here you go!", Title);
                }
            }
        }

        private void Grid_for_buttons_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Up)
            {
                Changing_numbers_for_Up();
                Random_number();
            }
            else if(e.Key == Key.Down)
            {
                Changing_for_Down();
                Random_number();
            }
            else if(e.Key == Key.Left)
            {
                Changing_numbers_for_left();
                Random_number();
            }
            else if(e.Key==Key.Right)
            {
                Changing_numbers_for_right();
                Random_number();
            }
        }
        private void Changing_numbers_for_right()
        {
            
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 2; j >= 0; j--)
                    {
                       
                        if (btn_s[i,j + 1].Content.ToString() != " " && (btn_s[i,j].Content.ToString() == btn_s[i,j + 1].Content.ToString()))
                        {
                            int temp = int.Parse(btn_s[i, j].Content.ToString()) * 2;
                            btn_s[i, j + 1].Content = temp.ToString();
                            btn_s[i, j].Content = " ";
                            scores += temp;
                            Score_txt_block.Text = "Scores\n" + scores.ToString();
                            High_score_txt_block.Text = "High scores\n" + scores.ToString();
                        }
                        if (btn_s[i, j + 1].Content.ToString() == " ")
                        {
                            btn_s[i, j + 1].Content = btn_s[i, j].Content.ToString();
                            btn_s[i, j].Content = " ";

                        }
                    }
                }
            }
            catch(IndexOutOfRangeException) { }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j >= 0; j--)
                {
                    if (btn_s[i, j + 1].Content.ToString() == " ")
                    {
                        btn_s[i, j + 1].Content = btn_s[i, j].Content.ToString();
                        btn_s[i, j].Content = " ";
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j >= 0; j--)
                {

                    if (btn_s[i, j + 1].Content.ToString() != " " && (btn_s[i, j].Content.ToString() == btn_s[i, j + 1].Content.ToString()))
                    {
                        int temp = int.Parse(btn_s[i, j].Content.ToString()) * 2;
                        btn_s[i, j + 1].Content = temp.ToString();
                        btn_s[i, j].Content = " ";
                        scores += temp;
                        Score_txt_block.Text = "Scores\n" + scores.ToString();
                        High_score_txt_block.Text = "High scores\n" + scores.ToString();
                    }
                    if (btn_s[i, j + 1].Content.ToString() == " ")
                    {
                        btn_s[i, j + 1].Content = btn_s[i, j].Content.ToString();
                        btn_s[i, j].Content = " ";

                    }
                }
            }
        }
        private void Changing_numbers_for_Up()
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 1; i < 4; i++)
                {

                    if (btn_s[i - 1, j].Content.ToString() != " " && (btn_s[i - 1, j].Content.ToString() == btn_s[i, j].Content.ToString()))
                    {
                        int temp = int.Parse(btn_s[i, j].Content.ToString()) * 2;
                        btn_s[i - 1, j].Content = temp.ToString();
                        btn_s[i, j].Content = " ";
                        scores += temp;
                        Score_txt_block.Text = "Scores\n" + scores.ToString();
                        High_score_txt_block.Text = "High scores\n" + scores.ToString();
                    }
                    if (btn_s[i - 1, j].Content.ToString() == " ")
                    {
                        btn_s[i - 1, j].Content = btn_s[i, j].Content.ToString();
                        btn_s[i, j].Content = " ";
                    }

                }
            }
            for (int j = 0; j < 4; j++)
            {
                for (int i = 3; i > 0; i--)
                {
                    if (btn_s[i - 1, j].Content.ToString() == " ")
                    {
                        btn_s[i - 1, j].Content = btn_s[i, j].Content.ToString();
                        btn_s[i, j].Content = " ";
                    }
                }
            }
            for (int j = 0; j < 4; j++)
            {
                for (int i = 1; i < 4; i++)
                {

                    if (btn_s[i - 1, j].Content.ToString() != " " && (btn_s[i - 1, j].Content.ToString() == btn_s[i, j].Content.ToString()))
                    {
                        int temp = int.Parse(btn_s[i, j].Content.ToString()) * 2;
                        btn_s[i - 1, j].Content = temp.ToString();
                        btn_s[i, j].Content = " ";
                        scores += temp;
                        Score_txt_block.Text = "Scores\n" + scores.ToString();
                        High_score_txt_block.Text = "High scores\n" + scores.ToString();
                    }
                    if (btn_s[i - 1, j].Content.ToString() == " ")
                    {
                        btn_s[i - 1, j].Content = btn_s[i, j].Content.ToString();
                        btn_s[i, j].Content = " ";
                    }

                }
            }

        }
        private void Changing_numbers_for_left()
        {
            for(int i = 0; i < 4; i++)
            {
                for(int j = 1; j < 4; j++)
                {
                    if (btn_s[i, j - 1].Content.ToString() != " " && (btn_s[i, j - 1].Content.ToString() == btn_s[i, j].Content.ToString()))
                    {
                        int temp = int.Parse(btn_s[i, j - 1].Content.ToString()) * 2;
                        btn_s[i, j].Content = temp.ToString();
                        btn_s[i, j - 1].Content = " ";
                        scores += temp;
                        Score_txt_block.Text = "Scores\n" + scores.ToString();
                        High_score_txt_block.Text = "High scores\n" + scores.ToString();
                    }
                    if (btn_s[i, j - 1].Content.ToString() == " ")
                    {
                        btn_s[i, j - 1].Content = btn_s[i, j].Content.ToString();
                        btn_s[i, j].Content = " ";
                    }

                }
            }
            for(int i = 0; i < 4; i++)
            {
                for(int j = 1; j < 4; j++)
                {
                    if (btn_s[i, j - 1].Content.ToString() == " ")
                    {
                        btn_s[i, j - 1].Content = btn_s[i, j].Content.ToString();
                        btn_s[i, j].Content = " ";
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    if (btn_s[i, j - 1].Content.ToString() != " " && (btn_s[i, j - 1].Content.ToString() == btn_s[i, j].Content.ToString()))
                    {
                        int temp = int.Parse(btn_s[i, j - 1].Content.ToString()) * 2;
                        btn_s[i, j].Content = temp.ToString();
                        btn_s[i, j - 1].Content = " ";
                        scores += temp;
                        Score_txt_block.Text = "Scores\n" + scores.ToString();
                        High_score_txt_block.Text = "High scores\n" + scores.ToString();
                    }
                    if (btn_s[i, j - 1].Content.ToString() == " ")
                    {
                        btn_s[i, j - 1].Content = btn_s[i, j].Content.ToString();
                        btn_s[i, j].Content = " ";
                    }

                }
            }
        }
        private void Changing_for_Down()
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 2; i >= 0; i--)
                {
                    if (btn_s[i + 1, j].Content.ToString() != " " && (btn_s[i + 1, j].Content.ToString() == btn_s[i, j].Content.ToString()))
                    {
                        int temp = int.Parse(btn_s[i, j].Content.ToString()) * 2;
                        btn_s[i + 1, j].Content = temp.ToString();
                        btn_s[i, j].Content = " ";
                        scores += temp;
                        Score_txt_block.Text = "Scores\n" + scores.ToString();
                        High_score_txt_block.Text = "High scores\n" + scores.ToString();
                    }
                    if ((btn_s[i + 1, j].Content.ToString() == " ") && (btn_s[i, j].Content.ToString() != " "))
                    {
                        btn_s[i + 1, j].Content = btn_s[i, j].Content.ToString();
                        btn_s[i, j].Content = " ";
                    }
                    
                }
            }
            for(int j = 0; j < 3; j++)
            {
                for(int i = 2; i >= 0; i--)
                {
                    if (btn_s[i + 1, j].Content.ToString() == " ")
                    {
                        btn_s[i + 1, j].Content = btn_s[i, j].Content.ToString();
                        btn_s[i, j].Content = " ";
                    }
                }
            }
            for (int j = 0; j < 4; j++)
            {
                for (int i = 2; i >= 0; i--)
                {
                    if (btn_s[i + 1, j].Content.ToString() != " " && (btn_s[i + 1, j].Content.ToString() == btn_s[i, j].Content.ToString()))
                    {
                        int temp = int.Parse(btn_s[i, j].Content.ToString()) * 2;
                        btn_s[i + 1, j].Content = temp.ToString();
                        btn_s[i, j].Content = " ";
                        scores += temp;
                        Score_txt_block.Text = "Scores\n" + scores.ToString();
                        High_score_txt_block.Text = "High scores\n" + scores.ToString();
                    }
                    if (btn_s[i + 1, j].Content.ToString() == " ")
                    {
                        btn_s[i + 1, j].Content = btn_s[i, j].Content.ToString();
                        btn_s[i, j].Content = " ";
                    }

                }
            }
        }
        private void Make_Buttons()
        {
           
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    
                    btn_s[i, j] = new Button();
                    btn_s[i, j].Content = " ";
                    btn_s[i, j].Click += Button_Click;
                    Grid_for_buttons.Children.Add(btn_s[i, j]);
                    Grid.SetRow(btn_s[i, j], i);
                    Grid.SetColumn(btn_s[i, j], j);
                    //cont++;
                }
            }
        }
        private void Random_number()
        {
            if (New != null) New.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            if (Check_for_All() == false)
            {
                MessageBox.Show("Game over!",Title);
                return;
            }
            while (true)
            {
                int x = rand.Next(0, 4);
                int y = rand.Next(0, 4);
                if ((btn_s[y, x].Content.ToString() == " "))
                {
                    btn_s[y, x].Content = "2";
                    New = btn_s[y, x];
                    New.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    return;
                }

            }
        }
        private bool Check_for_All()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (btn_s[i, j].Content.ToString() == " ")
                        return true;
                }
            }
            return false;
        }
    }
}
