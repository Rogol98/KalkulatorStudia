using System;
using System.Windows;
using System.Windows.Controls;

namespace Kalkulator
{
    public partial class MainWindow : Window
    {
        OperacjeMatematyczne op = new OperacjeMatematyczne();
        double wartosc = 0;
      
        string operacja = "";
        
        bool operacja_w = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            if (screenik.Text == "0" || operacja_w)
            {
                screenik.Clear();
                operacja_w = false;
            }
            Button butt = (Button)sender;

            if (butt.Content.ToString() == ",")
            {
                if (!screenik.Text.Contains(","))
                {
                    screenik.Text = screenik.Text + butt.Content.ToString();
                }
            }
            else
            {
                screenik.Text = screenik.Text + butt.Content.ToString();
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            screenik.Clear();
            wartosc = 0;
            pamiec.Content = string.Empty;
            screenik.Text = "0";
        }

        private void ZmianaZnakuLiczby(object sender, RoutedEventArgs e)
        {
            if (!Double.TryParse(screenik.Text, out wartosc))
            {
                wartosc = 0;
            }
            wartosc = wartosc * (-1);
            screenik.Text = wartosc.ToString();
        }

        private void Op_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            operacja = b.Content.ToString();
            if(!Double.TryParse(screenik.Text, out wartosc))
            {
                wartosc = 0;
            }

            operacja_w = true;

       
            pamiec.Content = wartosc + " " + operacja;
        }

   
        private void Wynik(object sender, RoutedEventArgs e)
        {
            pamiec.Content = "";

            switch (operacja)
            {
                case "+":
                    screenik.Text = op.Dodaj(wartosc, screenik.Text);
                    break;
                case "-":
                    screenik.Text = op.Odejmij(wartosc, screenik.Text);
                    break;
                case "*":
                    screenik.Text = op.Mnozenie(wartosc, screenik.Text);
                    break;
                case "/":
                    screenik.Text = op.Dzielenie(wartosc, screenik.Text);
                    break;
                case "^":
                    screenik.Text = op.Potega(wartosc, screenik.Text);
                    break;
                case "%":
                    screenik.Text = op.Procent(wartosc, screenik.Text);
                    break;
                case "√":
                    screenik.Text = op.Pierwiastek(wartosc);
                    break;
                case "mod":
                    screenik.Text = op.Modulo(wartosc, screenik.Text);
                    break;
                case "bin":
                    screenik.Text = op.Binary(screenik.Text);
                    break;
                case "!":
                    screenik.Text = op.Silnia(screenik.Text);
                    break;
                case "sin":
                    screenik.Text = op.Sinus(screenik.Text);
                    break;
                case "cos":
                    screenik.Text = op.Cosinus(screenik.Text);
                    break;
                case "tg":
                    screenik.Text = op.Tangens(screenik.Text);
                    break;
                case "ctg":
                    screenik.Text = op.Cotangens(screenik.Text);
                    break;
                case "sinh":
                    screenik.Text = op.SinusH(screenik.Text);
                    break;
                case "cosh":
                    screenik.Text = op.CosinusH(screenik.Text);
                    break;
                case "log":
                    screenik.Text = op.Log10(screenik.Text);
                    break;
                case "ln":
                    screenik.Text = op.Ln(screenik.Text);
                    break;
                default:
                    break;
            }

            operacja_w = false;
        }
    }

    public class OperacjeMatematyczne
    {
        public string Dodaj(double a, string b)
        {
            if (!Double.TryParse(b, out double c))
            {
                return a.ToString();
            }

            return (a + c).ToString();
        }

        public string Odejmij(double a, string b)
        {
            if (!Double.TryParse(b, out double c))
            {
                return a.ToString();
            }

            return (a - c).ToString();
        }

        public string Mnozenie(double a, string b)
        {
            if (!Double.TryParse(b, out double c))
            {
                return a.ToString();
            }

            return (a * c).ToString();
        }

        public string Dzielenie(double a, string b)
        {
            if (!Double.TryParse(b, out double c))
            {
                return a.ToString();
            }

            return (a/c).ToString();
        }

        public string Potega(double a, string b)
        {
            if (!Double.TryParse(b, out double c))
            {
                return a.ToString();
            }

            return Math.Pow(a, c).ToString();
        }

        public string Procent(double a, string b)
        {
            if (!Double.TryParse(b, out double c))
            {
                return a.ToString();
            }

            return (a / c).ToString("0.00%");
        }

        public string Pierwiastek(double a)
        {
            return Math.Sqrt(a).ToString();
        }

        public string Modulo(double a, string b)
        {
            if (!Double.TryParse(b, out double c))
            {
                return a.ToString();
            }

            return (a % c).ToString();
        }

        public string Binary(string a)
        {
            if (!int.TryParse(a, out int b))
            {
                b = 0;
            }

            return Convert.ToString(b, 2);
        }

        public string Silnia(string a)
        {
            if (!int.TryParse(a, out int b))
            {
                return "1";
            }

            int wynik = 1;

            for(int i = 1; i <= b; ++i)
            {
                wynik *= i;
            }

            return wynik.ToString();
        }

        public string Sinus(string a)
        {
            if (!Double.TryParse(a, out double b))
            {
                return a.ToString();
            }

            return Math.Sin(b).ToString();
        }

        public string Cosinus(string a)
        {
            if (!Double.TryParse(a, out double b))
            {
                return a.ToString();
            }

            return Math.Cos(b).ToString();
        }

        public string Tangens(string a)
        {
            if (!Double.TryParse(a, out double b))
            {
                return a.ToString();
            }

            return Math.Tan(b).ToString();
        }

        public string Cotangens(string a)
        {
            if (!Double.TryParse(a, out double b))
            {
                return a.ToString();
            }

            return (1 / Math.Tan(b)).ToString();
        }

        public string SinusH(string a)
        {
            if (!Double.TryParse(a, out double b))
            {
                return a.ToString();
            }

            return Math.Sinh(b).ToString();
        }

        public string CosinusH(string a)
        {
            if (!Double.TryParse(a, out double b))
            {
                return a.ToString();
            }

            return Math.Cosh(b).ToString();
        }

        public string Log10(string a)
        {
            if (!Double.TryParse(a, out double b))
            {
                return a.ToString();
            }

            return Math.Log10(b).ToString();
        }

        public string Ln(string a)
        {
            if (!Double.TryParse(a, out double b))
            {
                return a.ToString();
            }

            return Math.Log(b).ToString();
        }
    }
}