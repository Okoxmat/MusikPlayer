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


namespace MusikPlayer
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        string path1;
        string path2 = @"C:\Users\maste\Desktop\hello.wav";
        string path3;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Play_1_Click(object sender, System.EventArgs e)
        {
            path1 = '"' + Pfad_1.Text + '"';
            if (path1 != "")            
            {
                
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(path1);
                player1.Play();
                
            }
            else
            { return; }

        }

        private void Play_2_Click(object sender, System.EventArgs e)
        {
            System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(path2);
            player2.Play(); 
        }

        private void Play_3_Click(object sender, System.EventArgs e)
        {
            path3 = Pfad_3.Text;
            System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(path3);
            player3.Play();
        }

        private void Save(object sender, System.EventArgs e)
        {
            var x = 0;
        }

        private void Load(object sender, System.EventArgs e)
        {
            var x = 0;
        }

    }
}
