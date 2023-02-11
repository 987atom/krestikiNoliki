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

namespace Krestiki_Noliki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int pleer = 1;
        public static int step = 0;
        public static bool step_retur = true;
        public static bool whod_w_case = false;

        public MainWindow()
        {
            InitializeComponent();
            my_main();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Start.Visibility = Visibility.Hidden;

            if (step_retur == true)
            {
                step_retur = false;
            }
            Blok_1.Visibility = Visibility.Visible;
            Blok_2.Visibility = Visibility.Visible;
            Blok_3.Visibility = Visibility.Visible;
            Blok_4.Visibility = Visibility.Visible;
            Blok_5.Visibility = Visibility.Visible;
            Blok_6.Visibility = Visibility.Visible;
            Blok_7.Visibility = Visibility.Visible;
            Blok_8.Visibility = Visibility.Visible;
            Blok_9.Visibility = Visibility.Visible;

            Pleer_Wins.Visibility = Visibility.Hidden;
            Bot_Wins.Visibility = Visibility.Hidden;
            Now_One.Visibility = Visibility.Hidden;

            pleer++;
        }


        static void my_main()
        {
            if (step_retur == true)
            {
                step++;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Blok_1.Visibility = Visibility.Hidden;
            if (pleer % 2 == 0)
            {
                Text_X1.Visibility = Visibility.Visible;
            }
            else
            {
                Text_O1.Visibility = Visibility.Visible;
            }

            Random rnd = new Random();
            int value = rnd.Next(1, 9);

            int kletks = 1;

            while (value == kletks)
            {
                value = rnd.Next(1, 9);
            }

            bool end = false;

            int count = 0;
            Button[] b = new Button[] { Blok_1, Blok_2, Blok_3, Blok_4, Blok_5, Blok_6, Blok_7, Blok_8, Blok_9 };


            foreach (var item in b)
            {
                if (item.Visibility == Visibility.Hidden)
                {
                    count++;
                }
                if (count == 8)
                {
                    break;
                }
            }
            if (count != 8)
            {


                while (whod_w_case == false)
                {
                    if (pleer % 2 == 0)
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_O1.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (2):
                                if (Text_O2.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_O3.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_O4.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_O5.Visibility is Visibility.Visible || Text_X5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_O6.Visibility is Visibility.Visible || Text_X6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_O7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_O8.Visibility is Visibility.Visible || Text_X8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_O9.Visibility is Visibility.Visible || Text_X9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;

                        }
                    }
                    else
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_X1.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                }
                                whod_w_case = true;
                                break;
                            case (2):
                                if (Text_X2.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_X3.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_X4.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_X5.Visibility is Visibility.Visible || Text_O5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_X6.Visibility is Visibility.Visible || Text_O6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_X7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_X8.Visibility is Visibility.Visible || Text_O8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_X9.Visibility is Visibility.Visible || Text_O9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;
                        }
                    }
                }
            }
            else
            {
                if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
                {
                    Pleer_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
                {
                    Bot_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else
                {
                    Now_One.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
            }
            whod_w_case = false;




            if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
            {
                Pleer_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
            if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
            {
                Bot_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }


        }

        private void Blok_2_Click(object sender, RoutedEventArgs e)
        {
            Blok_2.Visibility = Visibility.Hidden;


            if (pleer % 2 == 0)
            {
                Text_X2.Visibility = Visibility.Visible;
            }
            else
            {
                Text_O2.Visibility = Visibility.Visible;
            }

            Random rnd = new Random();
            int value = rnd.Next(1, 9);

            int kletks = 2;

            while (value == kletks)
            {
                value = rnd.Next(1, 9);
            }

            bool end = false;

            int count = 0;
            Button[] b = new Button[] { Blok_1, Blok_2, Blok_3, Blok_4, Blok_5, Blok_6, Blok_7, Blok_8, Blok_9 };


            foreach (var item in b)
            {
                if (item.Visibility == Visibility.Hidden)
                {
                    count++;
                }
                if (count == 8)
                {
                    break;
                }
            }
            if (count != 8)
            {

                while (whod_w_case == false)
                {
                    if (pleer % 2 == 0)
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_O1.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (2):
                                if (Text_O2.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_O3.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_O4.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_O5.Visibility is Visibility.Visible || Text_X5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_O6.Visibility is Visibility.Visible || Text_X6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_O7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_O8.Visibility is Visibility.Visible || Text_X8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_O9.Visibility is Visibility.Visible || Text_X9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;

                        }
                    }
                    else
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_X1.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                }
                                whod_w_case = true;
                                break;
                            case (2):
                                if (Text_X2.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_X3.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_X4.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_X5.Visibility is Visibility.Visible || Text_O5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_X6.Visibility is Visibility.Visible || Text_O6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_X7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_X8.Visibility is Visibility.Visible || Text_O8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_X9.Visibility is Visibility.Visible || Text_O9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;
                        }
                    }
                }
            }
            else
            {
                if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
                {
                    Pleer_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
                {
                    Bot_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else
                {
                    Now_One.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
            }
            whod_w_case = false;
            if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
            {
                Pleer_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
            if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
            {
                Bot_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
        }

        private void Blok_3_Click(object sender, RoutedEventArgs e)
        {
            Blok_3.Visibility = Visibility.Hidden;
            if (pleer % 2 == 0)
            {
                Text_X3.Visibility = Visibility.Visible;
            }
            else
            {
                Text_O3.Visibility = Visibility.Visible;
            }

            Random rnd = new Random();
            int value = rnd.Next(1, 9);

            int kletks = 3;

            while (value == kletks)
            {
                value = rnd.Next(1, 9);
            }

            bool end = false;

            int count = 0;
            Button[] b = new Button[] { Blok_1, Blok_2, Blok_3, Blok_4, Blok_5, Blok_6, Blok_7, Blok_8, Blok_9 };


            foreach (var item in b)
            {
                if (item.Visibility == Visibility.Hidden)
                {
                    count++;
                }
                if (count == 8)
                {
                    break;
                }
            }
            if (count != 8)
            {
                while (whod_w_case == false)
                {
                    if (pleer % 2 == 0)
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_O1.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (2):
                                if (Text_O2.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_O3.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_O4.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_O5.Visibility is Visibility.Visible || Text_X5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_O6.Visibility is Visibility.Visible || Text_X6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_O7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_O8.Visibility is Visibility.Visible || Text_X8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_O9.Visibility is Visibility.Visible || Text_X9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;

                        }
                    }
                    else
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_X1.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                }
                                whod_w_case = true;
                                break;
                            case (2):
                                if (Text_X2.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_X3.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_X4.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_X5.Visibility is Visibility.Visible || Text_O5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_X6.Visibility is Visibility.Visible || Text_O6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_X7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_X8.Visibility is Visibility.Visible || Text_O8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_X9.Visibility is Visibility.Visible || Text_O9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;
                        }
                    }
                }
            }
            else
            {
                if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
                {
                    Pleer_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
                {
                    Bot_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else
                {
                    Now_One.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
            }
            whod_w_case = false;
            if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
            {
                Pleer_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
            if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
            {
                Bot_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
        }

        private void Blok_4_Click(object sender, RoutedEventArgs e)
        {
            Blok_4.Visibility = Visibility.Hidden;
            if (pleer % 2 == 0)
            {
                Text_X4.Visibility = Visibility.Visible;
            }
            else
            {
                Text_O4.Visibility = Visibility.Visible;
            }

            Random rnd = new Random();
            int value = rnd.Next(1, 9);

            int kletks = 4;

            while (value == kletks)
            {
                value = rnd.Next(1, 9);
            }

            bool end = false;

            int count = 0;
            Button[] b = new Button[] { Blok_1, Blok_2, Blok_3, Blok_4, Blok_5, Blok_6, Blok_7, Blok_8, Blok_9 };


            foreach (var item in b)
            {
                if (item.Visibility == Visibility.Hidden)
                {
                    count++;
                }
                if (count == 8)
                {
                    break;
                }
            }
            if (count != 8)
            {
                while (whod_w_case == false)
                {
                    if (pleer % 2 == 0)
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_O1.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (2):
                                if (Text_O2.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_O3.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_O4.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_O5.Visibility is Visibility.Visible || Text_X5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_O6.Visibility is Visibility.Visible || Text_X6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_O7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_O8.Visibility is Visibility.Visible || Text_X8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_O9.Visibility is Visibility.Visible || Text_X9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;

                        }
                    }
                    else
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_X1.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                }
                                whod_w_case = true;
                                break;
                            case (2):
                                if (Text_X2.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_X3.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_X4.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_X5.Visibility is Visibility.Visible || Text_O5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_X6.Visibility is Visibility.Visible || Text_O6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_X7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_X8.Visibility is Visibility.Visible || Text_O8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_X9.Visibility is Visibility.Visible || Text_O9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;
                        }
                    }
                }
            }
            else
            {
                if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
                {
                    Pleer_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
                {
                    Bot_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else
                {
                    Now_One.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
            }
            whod_w_case = false;
            if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
            {
                Pleer_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
            if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
            {
                Bot_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
        }

        private void Blok_5_Click(object sender, RoutedEventArgs e)
        {
            Blok_5.Visibility = Visibility.Hidden;
            if (pleer % 2 == 0)
            {
                Text_X5.Visibility = Visibility.Visible;
            }
            else
            {
                Text_O5.Visibility = Visibility.Visible;
            }

            Random rnd = new Random();
            int value = rnd.Next(1, 9);

            int kletks = 5;

            while (value == kletks)
            {
                value = rnd.Next(1, 9);
            }

            bool end = false;

            int count = 0;
            Button[] b = new Button[] { Blok_1, Blok_2, Blok_3, Blok_4, Blok_5, Blok_6, Blok_7, Blok_8, Blok_9 };


            foreach (var item in b)
            {
                if (item.Visibility == Visibility.Hidden)
                {
                    count++;
                }
                if (count == 8)
                {
                    break;
                }
            }
            if (count != 8)
            {
                while (whod_w_case == false)
                {
                    if (pleer % 2 == 0)
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_O1.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (2):
                                if (Text_O2.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_O3.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_O4.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_O5.Visibility is Visibility.Visible || Text_X5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_O6.Visibility is Visibility.Visible || Text_X6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_O7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_O8.Visibility is Visibility.Visible || Text_X8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_O9.Visibility is Visibility.Visible || Text_X9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;

                        }
                    }
                    else
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_X1.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                }
                                whod_w_case = true;
                                break;
                            case (2):
                                if (Text_X2.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_X3.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_X4.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_X5.Visibility is Visibility.Visible || Text_O5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_X6.Visibility is Visibility.Visible || Text_O6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_X7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_X8.Visibility is Visibility.Visible || Text_O8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_X9.Visibility is Visibility.Visible || Text_O9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;
                        }
                    }
                }
            }
            else
            {
                if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
                {
                    Pleer_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
                {
                    Bot_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else
                {
                    Now_One.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
            }
            whod_w_case = false;
            if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
            {
                Pleer_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
            if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
            {
                Bot_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
        }

        private void Blok_6_Click(object sender, RoutedEventArgs e)
        {
            Blok_6.Visibility = Visibility.Hidden;
            if (pleer % 2 == 0)
            {
                Text_X6.Visibility = Visibility.Visible;
            }
            else
            {
                Text_O6.Visibility = Visibility.Visible;
            }

            Random rnd = new Random();
            int value = rnd.Next(1, 9);

            int kletks = 6;

            while (value == kletks)
            {
                value = rnd.Next(1, 9);
            }

            bool end = false;

            int count = 0;
            Button[] b = new Button[] { Blok_1, Blok_2, Blok_3, Blok_4, Blok_5, Blok_6, Blok_7, Blok_8, Blok_9 };


            foreach (var item in b)
            {
                if (item.Visibility == Visibility.Hidden)
                {
                    count++;
                }
                if (count == 8)
                {
                    break;
                }
            }
            if (count != 8)
            {
                while (whod_w_case == false)
                {
                    if (pleer % 2 == 0)
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_O1.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (2):
                                if (Text_O2.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_O3.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_O4.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_O5.Visibility is Visibility.Visible || Text_X5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_O6.Visibility is Visibility.Visible || Text_X6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_O7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_O8.Visibility is Visibility.Visible || Text_X8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_O9.Visibility is Visibility.Visible || Text_X9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;

                        }
                    }
                    else
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_X1.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                }
                                whod_w_case = true;
                                break;
                            case (2):
                                if (Text_X2.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_X3.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_X4.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_X5.Visibility is Visibility.Visible || Text_O5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_X6.Visibility is Visibility.Visible || Text_O6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_X7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_X8.Visibility is Visibility.Visible || Text_O8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_X9.Visibility is Visibility.Visible || Text_O9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;
                        }
                    }
                }
            }
            else
            {
                if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
                {
                    Pleer_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
                {
                    Bot_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else
                {
                    Now_One.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
            }
            whod_w_case = false;
            if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
            {
                Pleer_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
            if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
            {
                Bot_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
        }

        private void Blok_7_Click(object sender, RoutedEventArgs e)
        {
            Blok_7.Visibility = Visibility.Hidden;
            if (pleer % 2 == 0)
            {
                Text_X7.Visibility = Visibility.Visible;
            }
            else
            {
                Text_O7.Visibility = Visibility.Visible;
            }

            Random rnd = new Random();
            int value = rnd.Next(1, 9);

            int kletks = 7;

            while (value == kletks)
            {
                value = rnd.Next(1, 9);
            }


            bool end = false;

            int count = 0;
            Button[] b = new Button[] { Blok_1, Blok_2, Blok_3, Blok_4, Blok_5, Blok_6, Blok_7, Blok_8, Blok_9 };


            foreach (var item in b)
            {
                if (item.Visibility == Visibility.Hidden)
                {
                    count++;
                }
                if (count == 8)
                {
                    break;
                }
            }
            if (count != 8)
            {
                while (whod_w_case == false)
                {
                    if (pleer % 2 == 0)
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_O1.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (2):
                                if (Text_O2.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_O3.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_O4.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_O5.Visibility is Visibility.Visible || Text_X5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_O6.Visibility is Visibility.Visible || Text_X6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_O7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_O8.Visibility is Visibility.Visible || Text_X8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_O9.Visibility is Visibility.Visible || Text_X9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;

                        }
                    }
                    else
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_X1.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                }
                                whod_w_case = true;
                                break;
                            case (2):
                                if (Text_X2.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_X3.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_X4.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_X5.Visibility is Visibility.Visible || Text_O5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_X6.Visibility is Visibility.Visible || Text_O6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_X7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_X8.Visibility is Visibility.Visible || Text_O8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_X9.Visibility is Visibility.Visible || Text_O9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;
                        }
                    }
                }
            }
            else
            {
                if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
                {
                    Pleer_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
                {
                    Bot_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else
                {
                    Now_One.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
            }
            whod_w_case = false;
            if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
            {
                Pleer_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
            if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
            {
                Bot_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
        }

        private void Blok_8_Click(object sender, RoutedEventArgs e)
        {
            Blok_8.Visibility = Visibility.Hidden;
            if (pleer % 2 == 0)
            {
                Text_X8.Visibility = Visibility.Visible;
            }
            else
            {
                Text_O8.Visibility = Visibility.Visible;
            }

            Random rnd = new Random();
            int value = rnd.Next(1, 9);

            int kletks = 8;

            while (value == kletks)
            {
                value = rnd.Next(1, 9);
            }

            bool end = false;

            int count = 0;
            Button[] b = new Button[] { Blok_1, Blok_2, Blok_3, Blok_4, Blok_5, Blok_6, Blok_7, Blok_8, Blok_9 };


            foreach (var item in b)
            {
                if (item.Visibility == Visibility.Hidden)
                {
                    count++;
                }
                if (count == 8)
                {
                    break;
                }
            }
            if (count != 8)
            {
                while (whod_w_case == false)
                {
                    if (pleer % 2 == 0)
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_O1.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (2):
                                if (Text_O2.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_O3.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_O4.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_O5.Visibility is Visibility.Visible || Text_X5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_O6.Visibility is Visibility.Visible || Text_X6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_O7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_O8.Visibility is Visibility.Visible || Text_X8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_O9.Visibility is Visibility.Visible || Text_X9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;

                        }
                    }
                    else
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_X1.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (2):
                                if (Text_X2.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_X3.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_X4.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_X5.Visibility is Visibility.Visible || Text_O5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_X6.Visibility is Visibility.Visible || Text_O6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_X7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_X8.Visibility is Visibility.Visible || Text_O8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_X9.Visibility is Visibility.Visible || Text_O9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;
                        }
                    }
                }
            }
            else
            {
                if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
                {
                    Pleer_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
                {
                    Bot_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else
                {
                    Now_One.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
            }
            whod_w_case = false;
            if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
            {
                Pleer_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
            if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
            {
                Bot_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
        }

        private void Blok_9_Click(object sender, RoutedEventArgs e)
        {
            Blok_9.Visibility = Visibility.Hidden;
            if (pleer % 2 == 0)
            {
                Text_X9.Visibility = Visibility.Visible;
            }
            else
            {
                Text_O9.Visibility = Visibility.Visible;
            }

            int kletks = 9;

            Random rnd = new Random();
            int value = rnd.Next(1, 9);

            while (value == 9)
            {
                value = rnd.Next(1, 9);
            }

            bool end = false;

            int count = 0;
            Button[] b = new Button[] { Blok_1, Blok_2, Blok_3, Blok_4, Blok_5, Blok_6, Blok_7, Blok_8, Blok_9 };


            foreach (var item in b)
            {
                if (item.Visibility == Visibility.Hidden)
                {
                    count++;
                }
                if (count == 8)
                {
                    break;
                }
            }
            if (count != 8)
            {
                while (whod_w_case == false)
                {
                    if (pleer % 2 == 0)
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_O1.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (2):
                                if (Text_O2.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_O3.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_O4.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_O5.Visibility is Visibility.Visible || Text_X5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_O6.Visibility is Visibility.Visible || Text_X6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_O7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_O8.Visibility is Visibility.Visible || Text_X8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_O9.Visibility is Visibility.Visible || Text_X9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_O9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;

                        }
                    }
                    else
                    {
                        switch (value)
                        {
                            case (1):
                                if (Text_X1.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 1)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X1.Visibility = Visibility.Visible;
                                    Blok_1.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (2):
                                if (Text_X2.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 2)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X2.Visibility = Visibility.Visible;
                                    Blok_2.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (3):
                                if (Text_X3.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 3)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X3.Visibility = Visibility.Visible;
                                    Blok_3.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (4):
                                if (Text_X4.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 4)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X4.Visibility = Visibility.Visible;
                                    Blok_4.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (5):
                                if (Text_X5.Visibility is Visibility.Visible || Text_O5.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 5)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X5.Visibility = Visibility.Visible;
                                    Blok_5.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (6):
                                if (Text_X6.Visibility is Visibility.Visible || Text_O6.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 6)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X6.Visibility = Visibility.Visible;
                                    Blok_6.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (7):
                                if (Text_X7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 7)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X7.Visibility = Visibility.Visible;
                                    Blok_7.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (8):
                                if (Text_X8.Visibility is Visibility.Visible || Text_O8.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 8)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X8.Visibility = Visibility.Visible;
                                    Blok_8.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            case (9):
                                if (Text_X9.Visibility is Visibility.Visible || Text_O9.Visibility is Visibility.Visible)
                                {
                                    value = rnd.Next(1, 9);
                                    while (value == kletks || value == 9)
                                    {
                                        value = rnd.Next(1, 9);
                                    }
                                }
                                else
                                {
                                    Text_X9.Visibility = Visibility.Visible;
                                    Blok_9.Visibility = Visibility.Hidden;
                                    whod_w_case = true;
                                }

                                break;
                            default:
                                value = rnd.Next(1, 9);
                                while (value == kletks)
                                {
                                    value = rnd.Next(1, 9);
                                }
                                break;
                        }
                    }
                }
                
            }
            else
            {
                if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
                {
                    Pleer_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
                {
                    Bot_Wins.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
                else
                {
                    Now_One.Visibility = Visibility.Visible;

                    Start.Visibility = Visibility.Visible;

                    Text_O1.Visibility = Visibility.Hidden;
                    Text_O2.Visibility = Visibility.Hidden;
                    Text_O3.Visibility = Visibility.Hidden;
                    Text_O4.Visibility = Visibility.Hidden;
                    Text_O5.Visibility = Visibility.Hidden;
                    Text_O6.Visibility = Visibility.Hidden;
                    Text_O7.Visibility = Visibility.Hidden;
                    Text_O8.Visibility = Visibility.Hidden;
                    Text_O9.Visibility = Visibility.Hidden;

                    Text_X1.Visibility = Visibility.Hidden;
                    Text_X2.Visibility = Visibility.Hidden;
                    Text_X3.Visibility = Visibility.Hidden;
                    Text_X4.Visibility = Visibility.Hidden;
                    Text_X5.Visibility = Visibility.Hidden;
                    Text_X6.Visibility = Visibility.Hidden;
                    Text_X7.Visibility = Visibility.Hidden;
                    Text_X8.Visibility = Visibility.Hidden;
                    Text_X9.Visibility = Visibility.Hidden;

                    Blok_1.Visibility = Visibility.Hidden;
                    Blok_2.Visibility = Visibility.Hidden;
                    Blok_3.Visibility = Visibility.Hidden;
                    Blok_4.Visibility = Visibility.Hidden;
                    Blok_5.Visibility = Visibility.Hidden;
                    Blok_6.Visibility = Visibility.Hidden;
                    Blok_7.Visibility = Visibility.Hidden;
                    Blok_8.Visibility = Visibility.Hidden;
                    Blok_9.Visibility = Visibility.Hidden;
                }
            }
            whod_w_case = false;
            if (Text_X1.Visibility is Visibility.Visible && Text_X2.Visibility is Visibility.Visible && Text_X3.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X4.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X1.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X2.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible || Text_X4.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X6.Visibility is Visibility.Visible || Text_X3.Visibility is Visibility.Visible && Text_X5.Visibility is Visibility.Visible && Text_X7.Visibility is Visibility.Visible || Text_X7.Visibility is Visibility.Visible && Text_X8.Visibility is Visibility.Visible && Text_X9.Visibility is Visibility.Visible)
            {
                Pleer_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
            if (Text_O1.Visibility is Visibility.Visible && Text_O2.Visibility is Visibility.Visible && Text_O3.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O4.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O1.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O2.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible || Text_O4.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O6.Visibility is Visibility.Visible || Text_O3.Visibility is Visibility.Visible && Text_O5.Visibility is Visibility.Visible && Text_O7.Visibility is Visibility.Visible || Text_O7.Visibility is Visibility.Visible && Text_O8.Visibility is Visibility.Visible && Text_O9.Visibility is Visibility.Visible)
            {
                Bot_Wins.Visibility = Visibility.Visible;

                Start.Visibility = Visibility.Visible;

                Text_O1.Visibility = Visibility.Hidden;
                Text_O2.Visibility = Visibility.Hidden;
                Text_O3.Visibility = Visibility.Hidden;
                Text_O4.Visibility = Visibility.Hidden;
                Text_O5.Visibility = Visibility.Hidden;
                Text_O6.Visibility = Visibility.Hidden;
                Text_O7.Visibility = Visibility.Hidden;
                Text_O8.Visibility = Visibility.Hidden;
                Text_O9.Visibility = Visibility.Hidden;

                Text_X1.Visibility = Visibility.Hidden;
                Text_X2.Visibility = Visibility.Hidden;
                Text_X3.Visibility = Visibility.Hidden;
                Text_X4.Visibility = Visibility.Hidden;
                Text_X5.Visibility = Visibility.Hidden;
                Text_X6.Visibility = Visibility.Hidden;
                Text_X7.Visibility = Visibility.Hidden;
                Text_X8.Visibility = Visibility.Hidden;
                Text_X9.Visibility = Visibility.Hidden;

                Blok_1.Visibility = Visibility.Hidden;
                Blok_2.Visibility = Visibility.Hidden;
                Blok_3.Visibility = Visibility.Hidden;
                Blok_4.Visibility = Visibility.Hidden;
                Blok_5.Visibility = Visibility.Hidden;
                Blok_6.Visibility = Visibility.Hidden;
                Blok_7.Visibility = Visibility.Hidden;
                Blok_8.Visibility = Visibility.Hidden;
                Blok_9.Visibility = Visibility.Hidden;
            }
        }
    }
}
