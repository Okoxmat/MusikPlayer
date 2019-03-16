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
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.IO;
using Microsoft.Win32;




namespace MusikPlayer
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        //   C:\Users\maste\Desktop\hello.wav
        string path1;
        string path2;
        string path3;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void ChooseFolder_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                    Pfad_1.Text = filename;
            }
        }

        public void ChooseFolder_2(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                    Pfad_2.Text = filename;
            }
        }

        public void ChooseFolder_3(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                    Pfad_3.Text = filename;
            }
        }


        private void Save(object sender, EventArgs e)
        {
            MessageBox.Show("Kek");
        }

        private void Load(object sender, EventArgs e)
        {
            MessageBox.Show("Kek");
        }

        //PLAY

        private void Play_1_Click(object sender, System.EventArgs e)
        {
            string path1 = Pfad_1.Text;
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path1);
            soundPlayer.Play();
        }

        private void Play_2_Click(object sender, System.EventArgs e)
        {
            string path2 = Pfad_2.Text;
            System.Media.SoundPlayer soundplayer = new System.Media.SoundPlayer(path2);
            soundplayer.Play();
        }

        private void Play_3_Click(object sender, System.EventArgs e)
        {
           string path3 = Pfad_3.Text;
           System.Media.SoundPlayer soundplayer = new System.Media.SoundPlayer(path3);
           soundplayer.Play();
        }

        //STOP

        private void Stop_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
            soundPlayer.Stop();
        }

        

    }
}
