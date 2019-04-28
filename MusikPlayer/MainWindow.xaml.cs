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
using AudioSwitcher.AudioApi.CoreAudio;
using Vlc.DotNet.Core;

namespace MusikPlayer
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        //   C:\Users\maste\Desktop\hello.wav


        public MainWindow()
        {
            InitializeComponent();
            Volume_1.Value = 30;
            Volume_2.Value = 30;
            Volume_3.Value = 30;
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


        //PLAY

        private void Play_1_Click(object sender, System.EventArgs e)
        {
            string path = Pfad_1.Text;
            var volume = Volume_1.Value;
            string Fade = FadeTime_1.Text;

            int fc = 0;
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            try
            {
                defaultPlaybackDevice.Volume = volume;
                if (Checkbox_1.IsChecked == false)
                {
                    System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path);
                    soundPlayer.Play();
                }
                else
                {
                    System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path);
                    soundPlayer.PlayLooping();
                }
                if (Fade != "0")
                {
                    int time = (((Int16.Parse(Fade) / 100)));
                    while (fc <= 100)
                    {
                        defaultPlaybackDevice.Volume = ((volume / 100) * fc);
                        string a = Convert.ToString(defaultPlaybackDevice.VolumeChanged);
                        Debug.WriteLine(a);
                        System.Threading.Thread.Sleep(time);
                        fc++;
                    }
                }
            }
            catch (Exception err)
            { MessageBox.Show("Fehler: " + " " + err.ToString() + "\n\n " + err.Message);}
            }

        private void Play_2_Click(object sender, System.EventArgs e)
        {
            string path = Pfad_2.Text;
            var volume = Volume_2.Value;
            string Fade = FadeTime_2.Text;

            int fc = 0;
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            try
            {
                defaultPlaybackDevice.Volume = volume;
                if (Checkbox_2.IsChecked == false)
                {
                    System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path);
                    soundPlayer.Play();
                }
                else
                {
                    System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path);
                    soundPlayer.PlayLooping();
                }
                if (Fade != "0")
                {
                    int time = (((Int16.Parse(Fade) / 100)));
                    while (fc <= 100)
                    {
                        defaultPlaybackDevice.Volume = ((volume / 100) * fc);
                        string a = Convert.ToString(defaultPlaybackDevice.VolumeChanged);
                        Debug.WriteLine(a);
                        System.Threading.Thread.Sleep(time);
                        fc++;
                    }
                }
            }
            catch (Exception err)
            { MessageBox.Show("Fehler: " + " " + err.ToString() + "\n\n " + err.Message); }
        }

        private void Play_3_Click(object sender, System.EventArgs e)
        {
            string path = Pfad_3.Text;
            var volume = Volume_3.Value;
            string Fade = FadeTime_3.Text;

            int fc = 0;
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            try
            {
                defaultPlaybackDevice.Volume = volume;
                if (Checkbox_3.IsChecked == false)
                {
                    System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path);
                    soundPlayer.Play();
                }
                else
                {
                    System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path);
                    soundPlayer.PlayLooping();
                }
                if (Fade != "0")
                {
                    int time = (((Int16.Parse(Fade) / 100)));
                    while (fc <= 100)
                    {
                        defaultPlaybackDevice.Volume = ((volume / 100) * fc);
                        string a = Convert.ToString(defaultPlaybackDevice.VolumeChanged);
                        Debug.WriteLine(a);
                        System.Threading.Thread.Sleep(time);
                        fc++;
                    }
                }
            }
            catch (Exception err)
            { MessageBox.Show("Fehler: " + " " + err.ToString() + "\n\n " + err.Message); }
        }

        //PAUSE

        private void Pause_1_Click(object sender, EventArgs e)
        {
            var volume = Volume_1.Value;
            string Fade = FadeTime_1.Text;

            int fc = 0;
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

            if (Fade != "0")
            {
                try
                {
                    Int16.Parse(Fade);
                    int time = (((Int16.Parse(Fade) / 100)));
                    while (fc <= 100)
                    {
                        defaultPlaybackDevice.Volume = (volume - ((volume / 100) * fc));
                        System.Threading.Thread.Sleep(time);
                        fc++;
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Fehler: " + er.Message);
                }
            }
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
            soundPlayer.Stop();
        }

        private void Pause_2_Click(object sender, EventArgs e)
        {
            var volume = Volume_2.Value;
            string Fade = FadeTime_2.Text;

            int fc = 0;
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

            if (Fade != "0")
            {
                try
                {
                    Int16.Parse(Fade);
                    int time = (((Int16.Parse(Fade) / 100)));
                    while (fc <= 100)
                    {
                        defaultPlaybackDevice.Volume = (volume - ((volume / 100) * fc));
                        System.Threading.Thread.Sleep(time);
                        fc++;
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Fehler: " + er.Message);
                }
            }
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
            soundPlayer.Stop();
        }

        private void Pause_3_Click(object sender, EventArgs e)
        {
            double volume = Volume_3.Value;
            string Fade = FadeTime_3.Text;

            int fc = 0;
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

            if (Fade != "0")
            {
                try
                {
                    Int16.Parse(Fade);
                    int time = (((Convert.ToInt32(Fade) / 20)));
                    while (fc <= 20)
                    {
                        defaultPlaybackDevice.Volume = (volume - ((volume / 100) * fc));
                        fc++;
                        System.Threading.Thread.Sleep(time);
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Fehler: " + er.Message);
                }
            }
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
            soundPlayer.Stop();
        }

        //STOP

        private void Stop_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
            soundPlayer.Stop();
        }

        //SAVE

        private void Save_Click(object sender, EventArgs e)
        {
            string path1 = Pfad_1.Text;
            string path2 = Pfad_2.Text;
            string path3 = Pfad_3.Text;

            string re1;
            if (Checkbox_1.IsChecked == true)
            {re1 = "true";}
            else { re1 = "false"; };

            string re2;
            if (Checkbox_2.IsChecked == true)
            { re2 = "true"; }
            else { re2 = "false"; };

            string re3;
            if (Checkbox_3.IsChecked == true)
            { re3 = "true"; }
            else { re3 = "false"; };

            string vol1 = Convert.ToString(Volume_1.Value);
            string vol2 = Convert.ToString(Volume_2.Value);
            string vol3 = Convert.ToString(Volume_3.Value);

            string Fade1 = FadeTime_1.Text;
            string Fade2 = FadeTime_2.Text;
            string Fade3 = FadeTime_3.Text;


            string Speicherort = @"c:";
            SaveFileDialog openFileDialog = new SaveFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                    Speicherort = filename;
            }

            try
            {


                if (File.Exists(Speicherort) == false)
                {
                    File.Create(Speicherort);
                }

                string[] Save = { path1, path2, path3, re1, re2, re3, vol1, vol2, vol3, Fade1, Fade2, Fade3};
                System.IO.File.WriteAllLines(Speicherort, Save);
                

            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        //LOAD

        private void Load_Click(object sender, EventArgs e)
        {
            string Speicherort = @"c:";

            OpenFileDialog openFileDialog= new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                    Speicherort = filename;
            }

            int counter = 0;
            string line;
            bool error = false;

            string[] Load = {"","","", "", "", "", "", "", "", "", "", "" };
            try
            {
                System.IO.StreamReader file =
               new System.IO.StreamReader(Speicherort);
                while ((line = file.ReadLine()) != null)
                {
                    Load[counter] = line;
                    counter++;
                }
            }
            catch(Exception err)
            { MessageBox.Show("Fehler: " + err.Message); error = true; }


            if (error == false)
            {
                Pfad_1.Text = Load[0];
                Pfad_2.Text = Load[1];
                Pfad_3.Text = Load[2];

                if (Load[3] == "true")
                { Checkbox_1.IsChecked = true; }
                else { Checkbox_1.IsChecked = false; }
                if (Load[4] == "true")
                { Checkbox_2.IsChecked = true; }
                else { Checkbox_2.IsChecked = false; }
                if (Load[5] == "true")
                { Checkbox_3.IsChecked = true; }
                else { Checkbox_3.IsChecked = false; }

                Volume_1.Value = double.Parse(Load[6]);
                Volume_2.Value = double.Parse(Load[7]);
                Volume_3.Value = double.Parse(Load[8]);

                FadeTime_1.Text = Load[9];
                FadeTime_2.Text = Load[10];
                FadeTime_3.Text = Load[11];

            }
            //Convert.ToDouble(Load[6]) = Volume_1.Value;
        }
    }
}
