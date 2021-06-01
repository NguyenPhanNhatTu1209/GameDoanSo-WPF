using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DoAn1.Controllers;
using DoAn1.Model;
namespace DoAn1
{
    /// <summary>
    /// Interaction logic for Score.xaml
    /// </summary>
    public partial class Score : Window
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool _IsBack;
        public bool IsBack
        {
            get => _IsBack;
            set
            {
                _IsBack = value;
                OnPropertyChanged();
            }
        }
        SoundPlayer sp_active;
        SoundPlayer sp_hover;
        SoundPlayer sp_megaman;
        SoundPlayer sp_congtac;
        SoundPlayer sp_hover1;
        public Score()
        {
            InitializeComponent();
            diem.Children.Clear();
            this.DataContext = this;
            LoadSound();
            List<Diem> listdiem = DiemController.danhsachdiemeasy();
            int dem = 1;
            foreach (var item in listdiem)
            {
                //top
                TextBlock top = new TextBlock();
                top.Text = "Top " + dem.ToString() + ".";
                top.FontSize = 25;
                top.Foreground = Brushes.Red;
                top.Margin = new Thickness(400, dem * 30, 0, 0);
                top.FontWeight = FontWeights.Bold ;
                diem.Children.Add(top);
                //người chơi
                TextBlock nguoichoi = new TextBlock();
                nguoichoi.Text = item.NameUser;
                nguoichoi.FontSize = 25;
                nguoichoi.Foreground = Brushes.Aqua;
                nguoichoi.Margin = new Thickness(500, dem * 30, 0, 0);
                nguoichoi.FontWeight = FontWeights.Bold;
                diem.Children.Add(nguoichoi);
                //Điểm
                TextBlock diemnguoichoi = new TextBlock();
                diemnguoichoi.Text = item.Score.ToString();
                diemnguoichoi.FontSize = 25;
                diemnguoichoi.Foreground = Brushes.White;
                diemnguoichoi.Margin = new Thickness(630, dem * 30, 0, 0);
                diemnguoichoi.FontWeight = FontWeights.Bold;
                diem.Children.Add(diemnguoichoi);
                dem++;
            }    
            
        }

        void LoadSound()
        {
            sp_active = new SoundPlayer(Properties.Resources.hover_2);
            sp_hover = new SoundPlayer(Properties.Resources.hover);
            sp_megaman = new SoundPlayer(Properties.Resources.megaman);
            sp_congtac = new SoundPlayer(Properties.Resources.congtac);
            sp_hover1 = new SoundPlayer(Properties.Resources.hover_3);


        }
        void PlaySoundCongTac()
        {
            sp_congtac.Play();
        }
        void PlaySoundActive()
        {
            sp_active.Play();
        }

        void PlaySoundHover()
        {
            sp_hover.Play();
        }
        void PlaySoundHover1()
        {
            sp_hover1.Play();
        }


        private void Image_MouseDown_Easy(object sender, MouseButtonEventArgs e)
        {
            PlaySoundActive();
            diem.Children.Clear();
            List<Diem> listdiem = DiemController.danhsachdiemeasy();
            int dem = 1;
            foreach (var item in listdiem)
            {
                //top
                TextBlock top = new TextBlock();
                top.Text = "Top " + dem.ToString() + ".";
                top.FontSize = 25;
                top.Foreground = Brushes.Red;
                top.Margin = new Thickness(400, dem * 30, 0, 0);
                top.FontWeight = FontWeights.Bold;
                diem.Children.Add(top);
                //người chơi
                TextBlock nguoichoi = new TextBlock();
                nguoichoi.Text = item.NameUser;
                nguoichoi.FontSize = 25;
                nguoichoi.Foreground = Brushes.Aqua;
                nguoichoi.Margin = new Thickness(500, dem * 30, 0, 0);
                nguoichoi.FontWeight = FontWeights.Bold;
                diem.Children.Add(nguoichoi);
                //Điểm
                TextBlock diemnguoichoi = new TextBlock();
                diemnguoichoi.Text = item.Score.ToString();
                diemnguoichoi.FontSize = 25;
                diemnguoichoi.Foreground = Brushes.White;
                diemnguoichoi.Margin = new Thickness(630, dem * 30, 0, 0);
                diemnguoichoi.FontWeight = FontWeights.Bold;
                diem.Children.Add(diemnguoichoi);
                dem++;
            }
        }
        private void Image_MouseDown_Hard(object sender, MouseButtonEventArgs e)
        {
            PlaySoundActive();
            diem.Children.Clear();
            List<Diem> listdiem = DiemController.danhsachdiemhard();
            int dem = 1;
            foreach (var item in listdiem)
            {
                //top
                TextBlock top = new TextBlock();
                top.Text = "Top " + dem.ToString() + ".";
                top.FontSize = 25;
                top.Foreground = Brushes.Red;
                top.Margin = new Thickness(400, dem * 30, 0, 0);
                top.FontWeight = FontWeights.Bold;
                diem.Children.Add(top);
                //người chơi
                TextBlock nguoichoi = new TextBlock();
                nguoichoi.Text = item.NameUser;
                nguoichoi.FontSize = 25;
                nguoichoi.Foreground = Brushes.Aqua;
                nguoichoi.Margin = new Thickness(500, dem * 30, 0, 0);
                nguoichoi.FontWeight = FontWeights.Bold;
                diem.Children.Add(nguoichoi);
                //Điểm
                TextBlock diemnguoichoi = new TextBlock();
                diemnguoichoi.Text = item.Score.ToString();
                diemnguoichoi.FontSize = 25;
                diemnguoichoi.Foreground = Brushes.White;
                diemnguoichoi.Margin = new Thickness(630, dem * 30, 0, 0);
                diemnguoichoi.FontWeight = FontWeights.Bold;
                diem.Children.Add(diemnguoichoi);
                dem++;
            }
        }

        private void Image_MouseDown_IsBack(object sender, MouseButtonEventArgs e)
        {
            IsBack = !IsBack;
            PlaySoundActive();
            //MainWindow mainwindow = new MainWindow();
            //mainwindow.Show();
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!IsBack)
                PlaySoundHover();
        }
    }
}
