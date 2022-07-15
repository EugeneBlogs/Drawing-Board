using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Ink;
using Microsoft.Win32;
using System.Drawing.Imaging;
using System.IO;


namespace Drawing_Board
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            a.Text = "255";
            r.Text = "0";
            g.Text = "0";
            b.Text = "0";
            sh.Text = "0";
            af.Text = "255";
            rf.Text = "173";
            gf.Text = "216";
            bf.Text = "230";
        }
        private void inkCanvas_Gesture(object sender, InkCanvasGestureEventArgs e)
        {
            String gestures = "";
            foreach (GestureRecognitionResult res in e.GetGestureRecognitionResults())
                gestures += res.ApplicationGesture.ToString() + "; ";
            gestureName.Text = gestures;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (InkCanvasEditingMode mode in Enum.GetValues(typeof(InkCanvasEditingMode)))
                lstEditingMode.Items.Add(mode);
            lstEditingMode.SelectedItem = inkCanvas.EditingMode;
        }

        private void a_TextChanged(object sender, TextChangedEventArgs e)
        {
            byte za = 0;
            byte zr = 0;
            byte zg = 0;
            byte zb = 0;
            try
            {
                za = Convert.ToByte(a.Text);
            }
            catch
            {
                za = 0;
            }
            try
            {
                zr = Convert.ToByte(r.Text);
            }
            catch
            {
                zr = 0;
            }
            try
            {
                zg = Convert.ToByte(g.Text);
            }
            catch
            {
                zg = 0;
            }
            try
            {
                zb = Convert.ToByte(b.Text);
            }
            catch
            {
                zb = 0;
            }
            inkCanvas.DefaultDrawingAttributes.Color = Color.FromArgb(za, zr, zg, zb);
        }

        private void sh_TextChanged(object sender, TextChangedEventArgs e)
        {
            int shirina = 0;
            try
            {
                shirina = Convert.ToInt32(sh.Text);
            }
            catch
            {
                shirina = 0;
            }
            try
            {
                foreach (Stroke s in inkCanvas.Strokes)
                    s.DrawingAttributes.Width = shirina;
            }
            catch
            {
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.Strokes.Clear();
            inkCanvas.Children.Clear();
        }

        private void af_TextChanged(object sender, TextChangedEventArgs e)
        {
            byte za = 0;
            byte zr = 0;
            byte zg = 0;
            byte zb = 0;
            try
            {
                za = Convert.ToByte(af.Text);
            }
            catch
            {
                za = 0;
            }
            try
            {
                zr = Convert.ToByte(rf.Text);
            }
            catch
            {
                zr = 0;
            }
            try
            {
                zg = Convert.ToByte(gf.Text);
            }
            catch
            {
                zg = 0;
            }
            try
            {
                zb = Convert.ToByte(bf.Text);
            }
            catch
            {
                zb = 0;
            }
            inkCanvas.Background = new SolidColorBrush(Color.FromArgb(za, zr, zg, zb));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Image t = new Image();
            t.Height = 100;
            t.Width = 100;
            string FilePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
            }
            try
            {
                t.Source = new BitmapImage(new Uri(FilePath));
            }
            catch
            {
                MessageBox.Show("При загрузки изображения произошла ошибка!");
            }
            inkCanvas.Children.Add(t);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Rectangle btn = new Rectangle();
            btn.Width = 100;
            btn.Height = 100;
            byte za = 0;
            byte zr = 0;
            byte zg = 0;
            byte zb = 0;
            try
            {
                za = Convert.ToByte(abo.Text);
            }
            catch
            {
                za = 0;
            }
            try
            {
                zr = Convert.ToByte(rbo.Text);
            }
            catch
            {
                zr = 0;
            }
            try
            {
                zg = Convert.ToByte(gbo.Text);
            }
            catch
            {
                zg = 0;
            }
            try
            {
                zb = Convert.ToByte(bbo.Text);
            }
            catch
            {
                zb = 0;
            }
            btn.Fill = new SolidColorBrush(Color.FromArgb(za, zr, zg, zb));
            inkCanvas.Children.Add(btn);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Ellipse btn = new Ellipse();
            btn.Width = 100;
            btn.Height = 100;
            byte za = 0;
            byte zr = 0;
            byte zg = 0;
            byte zb = 0;
            try
            {
                za = Convert.ToByte(ael.Text);
            }
            catch
            {
                za = 0;
            }
            try
            {
                zr = Convert.ToByte(rel.Text);
            }
            catch
            {
                zr = 0;
            }
            try
            {
                zg = Convert.ToByte(gel.Text);
            }
            catch
            {
                zg = 0;
            }
            try
            {
                zb = Convert.ToByte(bel.Text);
            }
            catch
            {
                zb = 0;
            }
            btn.Fill = new SolidColorBrush(Color.FromArgb(za, zr, zg, zb));
            inkCanvas.Children.Add(btn);
        }
    }
}
