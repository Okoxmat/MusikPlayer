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
            while (true)
            {

                MessageBox.Show("Kek");
            }
        }

        //PLAY


        private void Play_1_Click(object sender, System.EventArgs e)
        {
            string path1 = Pfad_1.Text;
            var volume1 = Volume_1.Value;
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            defaultPlaybackDevice.Volume = volume1;

            bool error = false;
            while (true)
            {
            
                try
                {
                    System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path1);
                    soundPlayer.Play();
                }
                catch (Exception err)
                { MessageBox.Show("Fehler: " + err.Message); error = true; }
                finally {
                    if (error == false)
                    {
                        if (Checkbox_1.IsChecked == false)

                        {
                            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path1);
                            soundPlayer.Play();
                        }
                        else
                        {
                            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path1);
                            soundPlayer.PlayLooping();
                        }
                    }             }break;
            }
        }

        private void Play_2_Click(object sender, System.EventArgs e)
        {
            string path2 = Pfad_2.Text;
            bool error = false;
            while (true)
            {

                try
                {
                    System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path2);
                    soundPlayer.Play();
                }
                catch (Exception err)
                { MessageBox.Show("Fehler: " + err.Message); error = true; }
                finally
                {
                    if (error == false)
                    {
                        if (Checkbox_1.IsChecked == false)

                        {
                            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path2);
                            soundPlayer.Play();
                        }
                        else
                        {
                            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path2);
                            soundPlayer.PlayLooping();
                        }
                    }
                }
                break;
            }
        }

        private void Play_3_Click(object sender, System.EventArgs e)
        {
            string path3 = Pfad_3.Text;
            bool error = false;
            while (true)
            {

                try
                {
                    System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path3);
                    soundPlayer.Play();
                }
                catch (Exception err)
                { MessageBox.Show("Fehler: " + err.Message); error = true; }
                finally
                {
                    if (error == false)
                    {
                        if (Checkbox_1.IsChecked == false)

                        {
                            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path3);
                            soundPlayer.Play();
                        }
                        else
                        {
                            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(path3);
                            soundPlayer.PlayLooping();
                        }
                    }
                }
                break;
            }
        }

        //STOP

        private void Stop_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
            soundPlayer.Stop();
        }

        

    }
}
